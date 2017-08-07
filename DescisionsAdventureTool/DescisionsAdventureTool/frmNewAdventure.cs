using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DescisionsAdventureTool
{
    public partial class frmNewAdventure : Form
    {
        frmActions form;
        public static int PathCounter;
        public static int ActionCounter;
        public static int[,] Actions;
        public static string[] ActionTitles;
        public string[] strText;
        public string[] strItems;
        int[,] FollowingNode;
        string path;
        #region XML
        XmlDocument doc;
        XmlDeclaration dec;
        XmlNode NodeDecision;
        XmlNode NodeSetting;
        XmlNode NodeSex;
        XmlNode NodeSection;
        XmlNode NodeID;
        XmlNode NodeTitle;
        XmlNode NodeText;
        XmlNode NodeItems;
        XmlNode NodeButtons;
        XmlNode NodePath;
        XmlNode NodePathID;
        XmlNode NodeReq;
        XmlNode NodeStatReq;
        XmlNode NodeItemReq;
        #endregion
        public frmNewAdventure()
        {
            InitializeComponent();

            #region Tooltips
            toolTip.SetToolTip(label1, "Bestimmt den angezeigten Namen in der Wege Ansicht.\nFalls leer werden die ersten Wörter angezeigt.");
            toolTip.SetToolTip(label2, "Bestimmt die einzigartige ID über die die Wege verknüpft werden." +
                "\nMögliche Auswahl aus den Optionen des vorangegeganen Pfades.");
            toolTip.SetToolTip(label3, "Das Geschlecht für das dieser Text geeignet ist." +
                "\nFür das andere Geschlecht kann der Text im im Verlauf neu geschrieben werden.");
            toolTip.SetToolTip(label4, "Das Setting in dem die Geschichte spielt.");
            toolTip.SetToolTip(label5, "Der Name unter dem das Abenteuer gespeichert und später angezeigt werden soll.");
            #endregion

            #region Init

            PathCounter = 1;
            Actions = new int[1000,6];
            ActionTitles = new string[1000];
            strText = new string[1000];
            treeChoices.Nodes.Add("Anfang");
            ActionTitles[0] = "Anfang";
            txtSectionID.Text = "1";
            Actions[0, 0] = 1;
            FollowingNode = new int[1000, 3];

            #region XML
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\DecisionsTool\";
            Directory.CreateDirectory(path + @"Adventures\");
            doc = new XmlDocument();
            dec = doc.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            doc.InsertBefore(dec, doc.DocumentElement);
            #endregion

            #endregion
        }
        public void SaveAdventure()
        {
            string buff = "";
            NodeDecision = doc.CreateElement("Decisions");
            NodeSetting = doc.CreateElement("Setting");
            NodeSex = doc.CreateElement("Geschlecht");
            NodeSetting.InnerText = cmbSetting.Text;
            NodeSex.InnerText = cmbSex.Text;
            doc.AppendChild(NodeDecision);
            NodeDecision.AppendChild(NodeSetting);
            NodeDecision.AppendChild(NodeSex);
            for (int i = 0; i < 1000; i++)
            {
                if (Actions[i, 0] != 0)
                {
                    #region Elemente erstellen
                    NodeSection = doc.CreateElement("Abschnitt");
                    NodeID = doc.CreateElement("ID");
                    NodeTitle = doc.CreateElement("Titel");
                    NodeText = doc.CreateElement("Text");
                    NodeItems = doc.CreateElement("Items");
                    NodeButtons = doc.CreateElement("Buttons");
                    NodePath = doc.CreateElement("Weiter");
                    NodePathID = doc.CreateElement("ID");
                    NodeReq = doc.CreateElement("Vorraussetzungen");
                    NodeItemReq = doc.CreateElement("Items");
                    NodeStatReq = doc.CreateElement("Attribute");
                    #endregion

                    #region Inner Text festlegen
                    NodeID.InnerText = Convert.ToString(Actions[i, 0]);
                    NodeTitle.InnerText = ActionTitles[i];
                    NodeText.InnerText = strText[i];

                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 1000; k++)
                        {
                            if (FollowingNode[i, j] == Actions[k, 0] && FollowingNode[i, j] != 0)
                            {
                                buff = buff + ActionTitles[k] + ";";
                            }
                        }
                    }
                    NodeButtons.InnerText = buff;
                    buff = "";

                    for (int j = 0; j < 3; j++)
                    {
                        buff = buff + Convert.ToString(FollowingNode[i, j]) + ";";
                    }
                    NodePathID.InnerText = buff;
                    buff = "";

                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 1000; k++)
                        {
                            if (FollowingNode[i, j] == Actions[k, 0] && FollowingNode[i, j] != 0)
                            {
                                for (int l = 1; l < 6; l++)
                                {
                                    if (l < 5)
                                    {
                                        buff = buff + Actions[k, l] + ",";
                                    }
                                    else
                                    {
                                        buff = buff + Actions[k, l] + ";";
                                    }
                                }
                            }
                        }
                    }
                    NodeStatReq.InnerText = buff;
                    buff = "";
                    NodeItemReq.InnerText = " ";
                    #endregion

                    #region Ordnen
                    NodeReq.AppendChild(NodeStatReq);
                    NodeReq.AppendChild(NodeItemReq);
                    NodePath.AppendChild(NodePathID);
                    NodePath.AppendChild(NodeReq);
                    NodeSection.AppendChild(NodeID);
                    NodeSection.AppendChild(NodeTitle);
                    NodeSection.AppendChild(NodeText);
                    NodeSection.AppendChild(NodeItems);
                    NodeSection.AppendChild(NodeButtons);
                    NodeSection.AppendChild(NodePath);
                    NodeDecision.AppendChild(NodeSection);
                    #endregion
                }
            }
            doc.Save(path + @"Adventures\" + txtAdventureName.Text + ".xml");
        }
        public void AddOption()
        {
            if (treeChoices.SelectedNode == null)
            {
                treeChoices.SelectedNode = treeChoices.Nodes[0];
            }
            if (treeChoices.SelectedNode.Nodes.Count >= 3)
            {
                MessageBox.Show("Es wurden bereits 3 Wege für diesen Weg angelegt.\nMehr sind zum aktuellem Zeitpunkt nicht möglich.");
            }
            else
            {
                form = new frmActions(ActionCounter);
                form.ShowDialog();
                AddTreeNode();
                PathCounter++;
                if (PathCounter >= 1000)
                {
                    MessageBox.Show("Mehr Wege Können nicht erstellt werden.");
                }
            }
        }

        private void AddTreeNode()
        {
            if (treeChoices.SelectedNode == null)
            {
                treeChoices.SelectedNode = treeChoices.Nodes[0];
            }
            for (int i = 0; i < 1000; i++)
            {
                if (treeChoices.SelectedNode.Text == ActionTitles[i])
                {
                    FollowingNode[i, treeChoices.SelectedNode.GetNodeCount(false)] = Actions[PathCounter, 0];
                }
            }
            treeChoices.SelectedNode.Nodes.Add(ActionTitles[PathCounter]);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ActionCounter > 2)
            {
                MessageBox.Show("Nur 3 Actionen pro Weg Möglich");
            }
            else
            {
                AddOption();
            }
        }

        private void txtSectionTitel_TextChanged(object sender, EventArgs e)
        {
            if (treeChoices.SelectedNode == null)
            {
                treeChoices.SelectedNode = treeChoices.Nodes[0];
            }
            treeChoices.SelectedNode.Text = txtSectionTitel.Text;
            for (int i = 0; i < 1000; i++)
            {
                if (txtSectionID.Text == Convert.ToString(Actions[i, 0]))
                {
                    ActionTitles[i] = txtSectionTitel.Text;
                }
            }
        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (txtSectionID.Text == Convert.ToString(Actions[i, 0]))
                {
                    strText[i] = txtEditor.Text;
                }
            }
        }

        private void treeChoices_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeChoices.SelectedNode == null)
            {
                treeChoices.SelectedNode = treeChoices.Nodes[0];
            }
            for (int i = 0; i < 1000; i++)
            {
                if (ActionTitles[i] == treeChoices.SelectedNode.Text)
                {
                    txtSectionID.Text = Convert.ToString(Actions[i, 0]);
                    txtEditor.Text = strText[i];
                    txtSectionTitel.Text = ActionTitles[i];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeChoices.SelectedNode.Remove();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAdventureName.Text == "")
            {
                MessageBox.Show("Der Name des Adventures darf nicht leer sein.");
            }
            else
            {
                SaveAdventure();
                this.Close();
            }
        }
    }
}
