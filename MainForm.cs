using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XSD2XML
{
    public partial class MainForm : Form
    {
       

        public MainForm()
        {
            InitializeComponent();
        }

     

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mnuXSD_Click(object sender, EventArgs e)
        {
            frmEditor f = new frmEditor();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuTest_Click(object sender, EventArgs e)
        {
            frmTester f = new frmTester();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuConfig_Click(object sender, EventArgs e)
        {
            frmCfg f = new frmCfg();
            f.ShowDialog();
        }
    }
}
