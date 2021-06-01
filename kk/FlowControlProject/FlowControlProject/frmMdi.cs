using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowControlProject
{
    public partial class frmMdi : Form
    {
        public frmMdi()
        {
            InitializeComponent();
        }

        private void ActivoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlActivoFijo frm = new PnlActivoFijo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMdi_Load(object sender, EventArgs e)
        {

        }
    }
}
