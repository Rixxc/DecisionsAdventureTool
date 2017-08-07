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

namespace DescisionsAdventureTool
{
    public partial class frmMain : Form
    {
        string path;
        string[] files;
        public frmMain()
        {
            InitializeComponent();
            #region Init
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\DecisionsTool\Adventures\";
            UpdateListView();
            #endregion
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
    }
}
