using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescisionsAdventureTool
{
    public partial class frmNewAdventure : Form
    {
        frmActions form;
        public static int PathCounter;
        public static int ActionCounter;
        public static int[,] Actions;
        public static string[] ActionTitles;
        public string[] Text;
        public frmNewAdventure()
        {
            InitializeComponent();
            #region Tooltips
            toolTip.SetToolTip(label1, "Bestimmt den angezeigten Namen in der Wege Ansicht.\nFalls leer werden die ersten Wörter angezeigt.");
            toolTip.SetToolTip(label2, "Bestimmt die einzigartige ID über die die Wege verknüpft werden." +
                "\nMögliche Auswahl aus den Optionen des vorangegeganen Pfades.");
            toolTip.SetToolTip(label3, "Das Geschlecht für das dieser Text geeignet ist." +
                "\nFür das andere Geschlecht kann der Text im im Verlauf neu geschrieben werden.");
            #endregion
            #region Init
            PathCounter = 1;
            Actions = new int[1000,6];
            ActionTitles = new string[1000];
            Text = new string[1000];
            treeChoices.Nodes.Add("Anfang");
            ActionTitles[0] = "Anfang";
            txtSectionID.Text = "1";
            Actions[0, 0] = 1;
            #endregion
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
                    Text[i] = txtEditor.Text;
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
                    txtEditor.Text = Text[i];
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

        }
    }
}
