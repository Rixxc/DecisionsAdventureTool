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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Öffnet die Form mit der neue Abenteuer erstellt werden können.
        /// </summary>
        public void OpenNewAdventureForm()
        {
            frmNewAdventure form = new frmNewAdventure();
            form.ShowDialog();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewAdventureForm();
        }

        private void btnNewAdventure_Click(object sender, EventArgs e)
        {
            OpenNewAdventureForm();
        }
    }
}
