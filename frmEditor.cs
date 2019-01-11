using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XSD2XML
{
    public partial class frmEditor : Form
    {
        private XMLBuilder xb = null;
        public frmEditor()
        {
            InitializeComponent();
        }

        private void cmdSelectXSD_Click(object sender, EventArgs e)
        {
            opf.Filter = "XSD files|*.xsd|All files|*.*";
            opf.Title = "XSD";
            opf.InitialDirectory = Properties.Settings.Default.XSDFolder;
            opf.CheckFileExists = true;
            opf.FileName = "";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                txtXSD.Text = opf.FileName;
                xb = new XMLBuilder();
                xb.LoadXSD(txtXSD.Text);
                LoadTree();

            }
        }


        private string NodeName(xsdItem t)
        {
            String Flags = "";
            {
                Flags += "[";
                if (t.oMin != null && t.oMin != "")
                    Flags += t.oMin;
                else
                    Flags += "0";
                Flags += "..";
                if (t.oMax != null && t.oMax != "")
                {
                    Flags += t.oMax.Replace("unbounded", "*");
                }
                else
                {
                    Flags += "1";
                }

                Flags += "]";
            }
            string sName = t.Name + " " + Flags;
            if(t.Type != null   && t.Type !="" )
                sName += "  (" + t.Type + ")";
            if(t.Fixed != "")
            {
                sName += " ='" + t.Fixed +"'";
            }
            return sName;
        }

        private void LoadTree()
        {
            tv.Nodes.Clear();
            xsdItem t = xb.root;

                TreeNode n = new TreeNode();
                n.Text = NodeName(t) ;
                n.Tag = t;
                n.ImageIndex = 4;
                tv.Nodes.Add(n);
                AddChildren(n, t);

        }

        private void AddChildren(TreeNode parent, xsdItem x)
        {
            
            foreach (xsdItem t in x.Children)
            {

                TreeNode n = new TreeNode();
                n.Text = NodeName(t); 
                if(t.Name== "defining_code")
                    n.ImageIndex = 5;
                else if (t.Skip)
                    n.ImageIndex = 3;
                else
                    n.ImageIndex = 1;
                n.Tag = t;
                parent.Nodes.Add(n);
                AddChildren(n, t);
            }

            foreach (xsdItem t in x.Choice)
            {

                TreeNode n = new TreeNode();
                n.Text = NodeName(t);
                if (t.Name == "defining_code")
                    n.ImageIndex = 5;
                else if (t.Skip)
                    n.ImageIndex = 3;
                else
                    n.ImageIndex = 2;
                n.Tag = t;
                parent.Nodes.Add(n);
                AddChildren(n, t);
            }
        }


        private void UpdateNode(TreeNode n )
        {
            xsdItem t;
            t = (xsdItem)n.Tag;
            n.Text = NodeName(t);
            if (t.Name == "defining_code")
                n.ImageIndex = 5;
            else if (t.Skip)
                n.ImageIndex = 3;
            else
                n.ImageIndex = 2;

        }

        private void cmdLoadMap_Click(object sender, EventArgs e)
        {
            opf.Filter = "XML files|*.xml|All files|*.*";
            opf.Title = "Настройки генерации (XML)";
            opf.InitialDirectory = Properties.Settings.Default.MAPFolder;
            opf.CheckFileExists = true;
            opf.FileName = "";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                xb = new XMLBuilder();
                using (var stream = System.IO.File.OpenRead(opf.FileName ))
                {
                    var serializer = new XmlSerializer(typeof(xsdItem ));
                    xb.root = serializer.Deserialize(stream) as xsdItem;
                }

                xb.root.RestoreParent();
                LoadTree();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = fbd.SelectedPath;
                Properties.Settings.Default.OutputFolder = txtOutput.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "")
            {
                MessageBox.Show("Не задана папка для  сохранения");
                return;
            }

            if (xb == null || xb.root == null)
            {
                MessageBox.Show("Не загружена  информация для генерации");
                return;
            }

            if (txtOutput.Text !="" && xb !=null && xb.root != null)
            {
                xb.OutFolder = txtOutput.Text;
                xb.BuildXML(xb.root,"");
            }
        }

        private bool InAfterSelect = false;
        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            InAfterSelect = true;
            xsdItem x = (xsdItem)e.Node.Tag;
            txtName.Text = x.Name;
            txtType.Text = x.Type;
            txtFixed.Text  = x.Fixed + x.Restrictions;
            txtMin.Text = x.oMin;
            txtMax.Text = x.oMax;
            numGenPrc.Value = x.GenPercent;
            if (x.Skip)
                chkSkip.Checked = true;
            else
                chkSkip.Checked = false;
            InAfterSelect = false;
        }

        private void cmdSetPrc_Click(object sender, EventArgs e)
        {
            if (xb == null || xb.root == null)
            {
                MessageBox.Show("Не загружена  информация для установки %");
                return;
            }
            if (xb != null && xb.root != null)
            {
                xb.root.SetGenPercent((short)numPrc.Value);
                LoadTree();
            }
            
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            if (InAfterSelect) return;
            if (tv.SelectedNode == null) return;
            xsdItem x = (xsdItem)tv.SelectedNode.Tag;

            if( IsNumeric(txtMin.Text)  || txtMin.Text == "")
            {
                x.oMin = txtMin.Text;
                UpdateNode(tv.SelectedNode);
            }
        }


        public static  bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            if (InAfterSelect) return;
            if (tv.SelectedNode == null) return;
            xsdItem x = (xsdItem)tv.SelectedNode.Tag;

            if (txtMax.Text == "*") txtMax.Text = "unbounded";

            if (IsNumeric(txtMax.Text) || txtMax.Text == "" || txtMax.Text == "unbounded" )
            {
                x.oMax = txtMax.Text;
                UpdateNode(tv.SelectedNode);
            }
        }

        private void numGenPrc_ValueChanged(object sender, EventArgs e)
        {
            if (InAfterSelect) return;
            if (tv.SelectedNode == null) return;
            xsdItem x = (xsdItem)tv.SelectedNode.Tag;

            x.GenPercent = (short)numGenPrc.Value;
            UpdateNode(tv.SelectedNode);
        }

        private void chkSkip_CheckedChanged(object sender, EventArgs e)
        {
            if (InAfterSelect) return;
            if (tv.SelectedNode == null) return;
            xsdItem x = (xsdItem)tv.SelectedNode.Tag;
            x.Skip = chkSkip.Checked;
            UpdateNode(tv.SelectedNode);
        }

        private void cmdSaveMap_Click(object sender, EventArgs e)
        {

            if (xb == null || xb.root == null)
            {
                MessageBox.Show("Не загружена  информация для сохранения");
                return;
            }
            sfd.Filter = "XML files|*.xml|All files|*.*";
            sfd.Title = "Настройки (XML)";
            sfd.InitialDirectory = Properties.Settings.Default.MAPFolder;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
               
                using (var writer = new System.IO.StreamWriter(sfd.FileName))
                {
                    var serializer = new XmlSerializer(xb.root.GetType());
                    serializer.Serialize(writer, xb.root);
                    writer.Flush();
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtOutput.Text = Properties.Settings.Default.OutputFolder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (xb == null || xb.root == null)
            {
                MessageBox.Show("Не загружена  информация для установки %");
                return;
            }
            if (xb != null && xb.root != null)
            {
                xb.root.SetMax(1);
                LoadTree();
            }
            
        }


        private List<TreeNode> prevSearch = null;
        private int searchIdx;

        private void SearchChild(List<TreeNode> listN, TreeNode pN)
        {
            foreach (TreeNode n in pN.Nodes )
            {
                if (n.Text.ToLower().StartsWith(txtSearch.Text.ToLower()))
                {
                    listN.Add(n);
                }
                SearchChild(listN, n);
            }
        }


        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                List<TreeNode> nodes = new List<TreeNode>();
                foreach(TreeNode n  in tv.Nodes)
                {
                    if (n.Text.ToLower().StartsWith(txtSearch.Text.ToLower()))
                    {
                        nodes.Add(n);
                    }
                    SearchChild(nodes, n);
                }
                    
                 
                if (prevSearch != null)
                {
                    foreach (TreeNode n in prevSearch)
                    {
                        n.BackColor = Color.White ;
                    }
                    prevSearch = null;
                }
                foreach (TreeNode n in nodes)
                {
                    n.BackColor = Color.Cyan;
                }
                prevSearch = nodes;
                if(nodes.Count > 0)
                {
                    searchIdx = 0;
                    tv.SelectedNode = prevSearch[searchIdx];
                }
            }
            else
            {
                if (prevSearch != null)
                {
                    foreach (TreeNode n in prevSearch)
                    {
                        n.BackColor = Color.White;
                    }
                    prevSearch = null;
                }
            }

        }

        private void cmdNextSearch_Click(object sender, EventArgs e)
        {
            if (prevSearch.Count > 0)
            {
                if(searchIdx< prevSearch.Count - 1) {
                    searchIdx ++;
                }
                else
                {
                    searchIdx = 0;
                }
                
                tv.SelectedNode = prevSearch[searchIdx];
            }
        }
    }
}
