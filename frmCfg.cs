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
    public partial class frmCfg : Form
    {
        public frmCfg()
        {
            InitializeComponent();
        }

        private void frmCfg_Load(object sender, EventArgs e)
        {
            txtXML.Text = Properties.Settings.Default.OutputFolder;
            txtXSD.Text = Properties.Settings.Default.XSDFolder;
            txtXSLT.Text = Properties.Settings.Default.XSLTFolder;
            txtMap.Text = Properties.Settings.Default.MAPFolder;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtXML.Text = fbd.SelectedPath;
                Properties.Settings.Default.OutputFolder = txtXML.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtXSD.Text = fbd.SelectedPath;
                Properties.Settings.Default.XSDFolder = txtXSD.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtXSLT.Text = fbd.SelectedPath;
                Properties.Settings.Default.XSLTFolder = txtXSLT.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtMap.Text = fbd.SelectedPath;
                Properties.Settings.Default.MAPFolder = txtMap.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
