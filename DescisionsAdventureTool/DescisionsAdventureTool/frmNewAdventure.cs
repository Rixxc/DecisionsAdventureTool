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
            toolTip.SetToolTip(label1, "Bestimmt den angezeigten Namen in der Wege Ansicht.\nFalls leer werden die ersten Wörter angezeigt.");
            toolTip.SetToolTip(label2, "Bestimmt die einzigartige ID über die die Wege verknüpft werden. Diese kann im Nachhinein nicht mehr verändert werden.");
        }
    }
}
