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
        }
        public void AddOption()
        {
            frmOptions form = new frmOptions();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOption();
        }
    }
}
