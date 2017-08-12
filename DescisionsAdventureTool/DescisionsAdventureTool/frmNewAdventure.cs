using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

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
        public static bool flag;
        public static bool BackTrack;
        int[,] FollowingNode;
        private int MaxPathCount;
        string path;
        #region XML
        XmlDocument doc;
        XmlDeclaration dec;
        XmlNode NodeDecision;
        XmlNode NodeSetting;
        XmlNode NodeSex;
        XmlNode NodeSection;
        XmlNode NodeID;
        XmlNode NodeStatReq;
        XmlNode NodeItemReq;
        XmlNode NodeTitle;
        XmlNode NodeText;
        XmlNode NodeItems;
        XmlNode NodeButtons;
        XmlNode NodePath;
        XmlNode NodePathID;
        XmlNode NodeReq;
        XmlNode NodeNextStatReq;
        XmlNode NodeNextItemReq;
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

            MaxPathCount = 5000;
            PathCounter = 1;
            Actions = new int[MaxPathCount,6];
            ActionTitles = new string[MaxPathCount];
            strText = new string[MaxPathCount];
            treeChoices.Nodes.Add("Anfang");
            ActionTitles[0] = "Anfang";
            txtSectionID.Text = "1";
            Actions[0, 0] = 1;
            flag = false;
            BackTrack = false;
            FollowingNode = new int[MaxPathCount, 3];

            #region XML
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\DecisionsTool\";
            Directory.CreateDirectory(path + @"Adventures\");
            doc = new XmlDocument();
            dec = doc.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            doc.InsertBefore(dec, doc.DocumentElement);
            #endregion

            #endregion
        }
        
        public frmNewAdventure(string name)
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

            MaxPathCount = 5000;
            PathCounter = 0;
            Actions = new int[MaxPathCount, 6];
            ActionTitles = new string[MaxPathCount];
            strText = new string[MaxPathCount];
            BackTrack = false;
            FollowingNode = new int[MaxPathCount, 3];

            #region XML
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\DecisionsTool\";
            Directory.CreateDirectory(path + @"Adventures\");
            doc = new XmlDocument();
            dec = doc.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            doc.InsertBefore(dec, doc.DocumentElement);
            #endregion

            #endregion

            #region Deserialize

            LoadAdventure(name);

            #endregion
        }

        public void LoadAdventure(string Target)
        {
            bool flag = false;
            string name = "";
            XmlDocument document = new XmlDocument();
            doc.Load(path + @"Adventures\" + Target + ".xml");
            foreach (XmlNode item in doc.LastChild.SelectNodes("Abschnitt"))
            {
                flag = false;
                foreach (XmlNode list in doc.LastChild.SelectNodes("Abschnitt"))
                {
                    if (list.LastChild.SelectSingleNode("IDS").InnerText.Contains(item.FirstChild.InnerText))
                    {
                        name = list.SelectSingleNode("Titel").InnerText;
                        foreach (TreeNode Node in treeChoices.Nodes)
                        {
                            if (Node.Text == name)
                            {
                                Node.Nodes.Add(item.SelectSingleNode("Titel").InnerText);
                            }
                            else
                            {
                                Search(name, Node, item.SelectSingleNode("Titel").InnerText);
                            }
                        }
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    treeChoices.Nodes.Add(item.SelectSingleNode("Titel").InnerText);
                }
                ActionTitles[PathCounter] = item.SelectSingleNode("Titel").InnerText;
                strText[PathCounter] = item.SelectSingleNode("Text").InnerText;
                Actions[PathCounter, 0] = Convert.ToInt32(item.SelectSingleNode("ID").InnerText);
                for (int i = 1; i < 6; i++)
                {
                    Actions[PathCounter, i] = Convert.ToInt32(item.SelectSingleNode("Attributvorraussetzungen").InnerText.Split(',')[i - 1]);
                }
                PathCounter++;
            }
            cmbSex.Text = doc.LastChild.SelectSingleNode("Geschlecht").InnerText;
            txtAdventureName.Text = Target;
        }
        private void Search(string name, TreeNode Nodes, string Target)
        {
            foreach (TreeNode Node in Nodes.Nodes)
            {
                if (Node.Text == name)
                {
                    Node.Nodes.Add(Target);
                }
                else
                {
                    Search(name, Node, Target);
                }
            }
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
            for (int i = 0; i < MaxPathCount; i++)
            {
                if (Actions[i, 0] != 0)
                {
                    #region Elemente erstellen
                    NodeSection = doc.CreateElement("Abschnitt");
                    NodeID = doc.CreateElement("ID");
                    NodeStatReq = doc.CreateElement("Attributvorraussetzungen");
                    NodeItemReq = doc.CreateElement("Itemvorraussetzungen");
                    NodeTitle = doc.CreateElement("Titel");
                    NodeText = doc.CreateElement("Text");
                    NodeItems = doc.CreateElement("Itembelohnungen");
                    NodeButtons = doc.CreateElement("Buttons");
                    NodePath = doc.CreateElement("Weiter");
                    NodePathID = doc.CreateElement("IDS");
                    NodeReq = doc.CreateElement("Vorraussetzungen");
                    NodeNextItemReq = doc.CreateElement("Items");
                    NodeNextStatReq = doc.CreateElement("Attribute");
                    #endregion

                    #region Inner Text festlegen
                    NodeID.InnerText = Convert.ToString(Actions[i, 0]);

                    for (int j = 1; j < 6; j++)
                    {
                        buff = buff + Convert.ToString(Actions[i,j] + ",");
                    }
                    buff = buff.Remove(buff.Length - 1);
                    NodeStatReq.InnerText = buff;
                    buff = "";

                    NodeItemReq.InnerText = "";

                    NodeTitle.InnerText = ActionTitles[i];

                    NodeText.InnerText = strText[i];

                    NodeItems.InnerText = "";

                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < MaxPathCount; k++)
                        {
                            if (FollowingNode[i, j] == Actions[k, 0] && FollowingNode[i, j] != 0)
                            {
                                buff = buff + ActionTitles[k] + ";";
                            }
                        }
                    }
                    try
                    {
                        buff = buff.Remove(buff.Length - 1);
                    }
                    catch
                    {

                    }
                    NodeButtons.InnerText = buff;
                    buff = "";

                    for (int j = 0; j < 3; j++)
                    {
                        buff = buff + Convert.ToString(FollowingNode[i, j]) + ";";
                    }
                    buff = buff.Remove(buff.Length - 1);
                    NodePathID.InnerText = buff;
                    buff = "";

                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < MaxPathCount; k++)
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
                    try
                    {
                        buff = buff.Remove(buff.Length - 1);
                    }
                    catch
                    {

                    }
                    NodeNextStatReq.InnerText = buff;
                    buff = "";
                    NodeNextItemReq.InnerText = " ";
                    #endregion

                    #region Ordnen
                    NodeReq.AppendChild(NodeNextStatReq);
                    NodeReq.AppendChild(NodeNextItemReq);
                    NodePath.AppendChild(NodePathID);
                    NodePath.AppendChild(NodeReq);
                    NodeSection.AppendChild(NodeID);
                    NodeSection.AppendChild(NodeStatReq);
                    NodeSection.AppendChild(NodeItemReq);
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
                if (flag == true)
                {
                    AddTreeNode();
                    if (BackTrack == true)
                    {
                        for (int i = 0; i < MaxPathCount; i++)
                        {
                            if (treeChoices.SelectedNode.Text == ActionTitles[i])
                            {
                                FollowingNode[PathCounter, 0] = Actions[i, 0];
                            }
                        }
                    }
                    PathCounter++;
                    if (PathCounter >= MaxPathCount)
                    {
                        MessageBox.Show("Mehr Wege Können nicht erstellt werden.");
                    }
                }
                flag = false;
                BackTrack = false;
            }
        }

        private void AddTreeNode()
        {
            if (treeChoices.SelectedNode == null)
            {
                treeChoices.SelectedNode = treeChoices.Nodes[0];
            }
            for (int i = 0; i < MaxPathCount; i++)
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
            for (int i = 0; i < MaxPathCount; i++)
            {
                if (txtSectionID.Text == Convert.ToString(Actions[i, 0]))
                {
                    ActionTitles[i] = txtSectionTitel.Text;
                }
            }
        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < MaxPathCount; i++)
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
            for (int i = 0; i < MaxPathCount; i++)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
