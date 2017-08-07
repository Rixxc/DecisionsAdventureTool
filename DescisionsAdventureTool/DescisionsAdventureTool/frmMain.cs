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
    public partial class frmMain : Form
    {
        bool found;
        string path;
        string[] files;
        public frmMain()
        {
            InitializeComponent();
            #region Init
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\DecisionsTool\Adventures\";
            UpdateListView();
            found = false;
            #endregion
        }
        private void Deserialize()
        {
            bool flag = false;
            string name = "";
            XmlDocument doc = new XmlDocument();
            doc.Load(path + lvwAdventures.SelectedItems[0].Text + ".xml");
            foreach (XmlNode item in doc.LastChild.SelectNodes("Abschnitt"))
            {
                found = false;
                flag = false;
                foreach (XmlNode list in doc.LastChild.SelectNodes("Abschnitt"))
                {
                    if (list.LastChild.FirstChild.InnerText.Contains(item.FirstChild.InnerText))
                    {
                        name = list.FirstChild.NextSibling.InnerText;
                        foreach (TreeNode Node in treeDetail.Nodes)
                        {
                            if (Node.Text == name)
                            {
                                Node.Nodes.Add(item.FirstChild.NextSibling.InnerText);
                            }
                            else
                            {
                                Search(name, Node, item.FirstChild.NextSibling.InnerText);
                            }
                        }
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    treeDetail.Nodes.Add(item.FirstChild.NextSibling.InnerText);
                }
            }
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
        /// <summary>
        /// Öffnet die Form mit der neue Abenteuer erstellt werden können.
        /// </summary>
        public void OpenNewAdventureForm()
        {
            frmNewAdventure form = new frmNewAdventure();
            form.ShowDialog();
            UpdateListView();
        }
        private void UpdateListView()
        {
            lvwAdventures.Clear();
            files = Directory.GetFiles(path, "*.xml",SearchOption.TopDirectoryOnly);
            for (int  i = 0;  i < files.Length;  i++)
            {
                files[i] = files[i].Remove(0, 57);
                files[i] = files[i].Remove(files[i].Length - 4);
                lvwAdventures.Items.Add(files[i]);
            }
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewAdventureForm();
        }

        private void btnNewAdventure_Click(object sender, EventArgs e)
        {
            OpenNewAdventureForm();
        }

        private void lvwAdventures_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string buff = lvwAdventures.SelectedItems[0].Text;
                treeDetail.Nodes.Clear();
                Deserialize();
            }
            catch (ArgumentOutOfRangeException)
            {

            }

        }

        private void exportierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string buff = lvwAdventures.SelectedItems[0].Text;
                SaveFileDialog Dialog = new SaveFileDialog();
                Dialog.FileName = buff;
                Dialog.AddExtension = true;
                Dialog.CreatePrompt = false;
                Dialog.Filter = "XML-Dateine (*.xml)|*.xml|Alle Dateien (*.*)|*.*";
                Dialog.OverwritePrompt = true;
                Dialog.ShowDialog();
                buff = Path.GetFullPath(Dialog.FileName);
                File.Copy(path + lvwAdventures.SelectedItems[0].Text + ".xml", buff);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Kein Abenteuer ausgewählt. Bitte ein Abenteuer aus der Liste auswählen.");
            }
        }

        private void kopierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string buff = lvwAdventures.SelectedItems[0].Text;
                File.Copy(path + buff + ".xml", path + buff + "-Kopie.xml");
                lvwAdventures.Items.Add(buff + "-Kopie");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Kein Abenteuer ausgewählt. Bitte ein Abenteuer aus der Liste auswählen.");
            }
        }
    }

    public static class SOExtension
    {
        public static IEnumerable<TreeNode> FlattenTree(this TreeView tv)
        {
            return FlattenTree(tv.Nodes);
        }

        public static IEnumerable<TreeNode> FlattenTree(this TreeNodeCollection coll)
        {
            return coll.Cast<TreeNode>()
                        .Concat(coll.Cast<TreeNode>()
                                    .SelectMany(x => FlattenTree(x.Nodes)));
        }
    }
}
