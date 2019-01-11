using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using Saxon.Api;
using System.Text.RegularExpressions;

namespace XSD2XML
{
    public partial class frmTester : Form
    {
        public frmTester()
        {
            InitializeComponent();
        }

        private void cmdSelectFile_Click(object sender, EventArgs e)
        {
            opf.Filter = "XSD files|*.xsd|All files|*.*";
            opf.Title = "XSD  схема";
            opf.InitialDirectory = Properties.Settings.Default.XSDFolder;
            opf.CheckFileExists = true;
            opf.FileName = "";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                txtXSD.Text = opf.FileName;
            }
        }

        private void cmdXML_Click(object sender, EventArgs e)
        {
            opf.Filter = "XSLT files|*.xslt|All files|*.*";
            opf.Title = "Файл преобразования";
            opf.InitialDirectory = Properties.Settings.Default.XSLTFolder;
            opf.CheckFileExists = true;
            if (opf.ShowDialog() == DialogResult.OK)
            {
                txtXSLT.Text = opf.FileName;
            }
        }

        private XMLBuilder xb;

        private void cmdRun_Click(object sender, EventArgs e)
        {
            if (txtXSLT.Text == "")
            {
                MessageBox.Show("Надо задать путь к XSLT файлу");
                return;
            }

            if (txtXSD.Text == "")
            {
                MessageBox.Show("Надо задать путь к XSD файлу");
                return;
            }
            xb = new XMLBuilder();
            FileInfo fi = new FileInfo(txtXSD.Text);
           
            string OutputFolder= fi.DirectoryName;

            if (Properties.Settings.Default.OutputFolder != "")
            {
                if(Directory.Exists(Properties.Settings.Default.OutputFolder))
                {
                    OutputFolder = Properties.Settings.Default.OutputFolder;
                }
            }

            xb.XSDPath = txtXSD.Text;
            xb.OutFolder = OutputFolder;
            
            string xmlPath = xb.BuildXML( txtGenPaths.Text.Trim());
            txtGen1.Text = xmlPath;
            
            string htmlPath = OutputFolder + "\\"+xb.root.Name +"_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".html";
            string errPath = OutputFolder + "\\" + xb.root.Name + "_ERROR_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            var input = new FileInfo(xmlPath);
            var output = new FileInfo(htmlPath);

            try
            {


                // Compile stylesheet
                var processor = new Processor();
                var compiler = processor.NewXsltCompiler();
                var executable = compiler.Compile(new Uri(txtXSLT.Text));

                // Do transformation to a destination
                var destination = new DomDestination();
                using (var inputStream = input.OpenRead())
                {
                    var transformer = executable.Load();
                    transformer.SetInputStream(inputStream, new Uri(input.FullName));
                    transformer.Run(destination);
                }
                destination.XmlDocument.Save(output.FullName);

                CheckHTML(output.FullName, errPath);
            }catch(System.Exception ex)
            {
                txtError.Text = ex.Message;
            }

        }


        private void CheckHTML(string htmlPath, string errPath)
        {
            StringBuilder sError = new StringBuilder();
            string sHtml = File.ReadAllText(htmlPath);
            sHtml = sHtml.Replace(" ", " "); // alt+0160
            sHtml = sHtml.Replace("&nbsp;", " ");
            sHtml = sHtml.Replace('\t', ' ');
            sHtml = sHtml.Replace("\r", "");
            sHtml = sHtml.Replace("\n", "");
            sHtml = sHtml.Replace("<br/>", " ");
            sHtml = sHtml.Replace("<br />", " ");

            int sLen;
            int eStart;
            int eStop;
            int pos;
            int bodyPos;
            int gap = 110;

            txtError.Text = "";
            sLen = sHtml.Length + 1;
            while (sLen != sHtml.Length)
            {
                sLen = sHtml.Length;
                sHtml = sHtml.Replace("  ", " ");
            }

            sHtml = sHtml.Replace("<span>", "");
            sHtml = sHtml.Replace("</span>", "");
            sHtml = sHtml.Replace("<span />", "");
            sHtml = sHtml.Replace("<strong>", "");
            sHtml = sHtml.Replace("</strong>", "");

            bodyPos = sHtml.IndexOf("<body");
            if (bodyPos < 0) bodyPos = 0;




            foreach (string seek in XMLBuilder.SeekExpressions)
            {
                if (sHtml.Contains(seek))
                {

                    pos = sHtml.IndexOf(". .", bodyPos);
                    do
                    {
                        if (pos >= 0)
                        {
                            eStart = pos - gap;
                            eStop = pos + gap;
                            if (eStart < 0) eStart = 0;
                            if (eStop >= sHtml.Length) eStop = sHtml.Length - 1;
                            sError.AppendLine("{"+ seek +"}  ..." + sHtml.Substring(eStart, eStop - eStart + 1) +"...");
                            pos = sHtml.IndexOf(seek, pos + 1);
                        }
                    } while (pos >= 0);
                }
            }


            /*
            if (sHtml.Contains(", ,"))
            {

                pos = sHtml.IndexOf(", ,", bodyPos);
                do
                {
                    if (pos >= 0)
                    {
                        eStart = pos - gap;
                        eStop = pos + gap;
                        if (eStart < 0) eStart = 0;
                        if (eStop >= sHtml.Length) eStop = sHtml.Length - 1;
                        sError.AppendLine("{, ,}  ..." + sHtml.Substring(eStart, eStop - eStart + 1));
                        pos = sHtml.IndexOf(", ,", pos + 1);
                    }
                } while (pos >= 0);
            }


            if (sHtml.Contains(", ."))
            {

                pos = sHtml.IndexOf(", .", bodyPos);
                do
                {
                    if (pos >= 0)
                    {
                        eStart = pos - gap;
                        eStop = pos + gap;
                        if (eStart < 0) eStart = 0;
                        if (eStop >= sHtml.Length) eStop = sHtml.Length - 1;
                        sError.AppendLine("{, .}  ..." + sHtml.Substring(eStart, eStop - eStart + 1));
                        pos = sHtml.IndexOf(", .", pos + 1);
                    }
                } while (pos >= 0);
            }


            if (sHtml.Contains(". ,"))
            {

                pos = sHtml.IndexOf(". ,", bodyPos);
                do
                {
                    if (pos >= 0)
                    {
                        eStart = pos - gap;
                        eStop = pos + gap;
                        if (eStart < 0) eStart = 0;
                        if (eStop >= sHtml.Length) eStop = sHtml.Length - 1;
                        sError.AppendLine("{. ,}  ..." + sHtml.Substring(eStart, eStop - eStart + 1));
                        pos = sHtml.IndexOf(". ,", pos + 1);
                    }
                } while (pos >= 0);
            }


            if (sHtml.Contains(" ."))
            {


                pos = sHtml.IndexOf(" .", bodyPos);
                do
                {
                    if (pos >= 0)
                    {
                        eStart = pos - gap;
                        eStop = pos + gap;
                        if (eStart < 0) eStart = 0;
                        if (eStop >= sHtml.Length) eStop = sHtml.Length - 1;
                        sError.AppendLine("{ .}  ..." + sHtml.Substring(eStart, eStop - eStart + 1));
                        pos = sHtml.IndexOf(" .", pos + 1);
                    }
                } while (pos >= 0);
            }

            if (sHtml.Contains(" .<"))
            {

                pos = sHtml.IndexOf(" .<", bodyPos);
                do
                {
                    if (pos >= 0)
                    {
                        eStart = pos - gap;
                        eStop = pos + gap;
                        if (eStart < 0) eStart = 0;
                        if (eStop >= sHtml.Length) eStop = sHtml.Length - 1;
                        sError.AppendLine("{ .< }  ..." + sHtml.Substring(eStart, eStop - eStart + 1));
                        pos = sHtml.IndexOf(" .<", pos + 1);
                    }
                } while (pos >= 0);
            }

            if (sHtml.Contains("<td>,"))
            {

                pos = sHtml.IndexOf("<td>,", bodyPos);
                do
                {
                    if (pos >= 0)
                    {
                        eStart = pos - gap;
                        eStop = pos + gap;
                        if (eStart < 0) eStart = 0;
                        if (eStop >= sHtml.Length) eStop = sHtml.Length - 1;
                        sError.AppendLine("{<td>,}  ..." + sHtml.Substring(eStart, eStop - eStart + 1));
                        pos = sHtml.IndexOf("<td>,", pos + 1);
                    }
                } while (pos >= 0);
            }

           

            if (sHtml.Contains(": ,"))
            {
                pos = sHtml.IndexOf(": ,", bodyPos);
                do
                {

                    eStart = pos - gap;
                    eStop = pos + gap;
                    if (eStart < 0) eStart = 0;
                    if (eStop >= sHtml.Length) eStop = sHtml.Length - 1;
                    sError.AppendLine("{: ,}  ..." + sHtml.Substring(eStart, eStop - eStart + 1));
                    pos = sHtml.IndexOf(": ,", pos + 1);

                } while (pos >= 0);
            }
            */


            foreach (string re in XMLBuilder.RegularExpressions )
            {
                Regex regex = new Regex(re);
                MatchCollection matches = regex.Matches(sHtml, bodyPos);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {

                        eStart = match.Index - gap;
                        eStop = match.Index + gap;
                        if (eStart < 0) eStart = 0;
                        if (eStop >= sHtml.Length) eStop = sHtml.Length - 1;
                        sError.AppendLine("{" + match.Value + "} ..." + sHtml.Substring(eStart, eStop - eStart + 1));

                    }

                }
            }

            /*
                {
                Regex regex = new Regex(@"\.\s*[а-я]");
                MatchCollection matches = regex.Matches(sHtml, bodyPos);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {

                        eStart = match.Index - gap;
                        eStop = match.Index + gap;
                        if (eStart < 0) eStart = 0;
                        if (eStop >= sHtml.Length) eStop = sHtml.Length - 1;
                        sError.AppendLine("{" + match.Value + "} ..." + sHtml.Substring(eStart, eStop - eStart + 1));

                    }

                }
            }
            {
                Regex regex = new Regex(@"\][^.,:<]");
                MatchCollection matches = regex.Matches(sHtml, bodyPos);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {

                        eStart = match.Index - gap;
                        eStop = match.Index + gap;
                        if (eStart < 0) eStart = 0;
                        if (eStop >= sHtml.Length) eStop = sHtml.Length - 1;
                        sError.AppendLine("{" + match.Value + "} ..." + sHtml.Substring(eStart, eStop - eStart + 1));

                    }

                }
            }
            {
                Regex regex = new Regex(@":\s*[А-Я]");
                MatchCollection matches = regex.Matches(sHtml, bodyPos);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        if (match.Index > bodyPos)
                        {
                            eStart = match.Index - gap;
                            eStop = match.Index + gap;
                            if (eStart < 0) eStart = 0;
                            if (eStop >= sHtml.Length) eStop = sHtml.Length - 1;
                            sError.AppendLine("{" + match.Value + "} ..." + sHtml.Substring(eStart, eStop - eStart + 1));
                        }
                    }

                }
            }
            */


            if (sError.ToString() != "")
            {
                File.WriteAllText(errPath, sError.ToString());
                txtError.Text = sError.ToString();
                txtErrPath.Text = errPath;
            }
            else
            {
                txtErrPath.Text = "";
            }
            wb.Navigate(htmlPath);
            txtHtmlPath.Text = htmlPath;
            
        }


        private void txtXSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void opf_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            opf.Filter = "XML files|*.xml|All files|*.*";
            opf.Title = "Готовый XML пример";
            opf.CheckFileExists = true;
            opf.FileName = "";
            opf.InitialDirectory = Properties.Settings.Default.OutputFolder;
            

            if (opf.ShowDialog() == DialogResult.OK)
            {
                txtXML.Text = opf.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtXSLT.Text == "")
            {
                MessageBox.Show("Надо задать путь к XSLT файлу");
                return;
            }

            if (txtXML.Text == "")
            {
                MessageBox.Show("Надо задать путь к XML файлу");
                return;
            }

            xb = new XMLBuilder();
            FileInfo fi = new FileInfo(txtXML.Text);

            string OutputFolder = fi.DirectoryName;

            if (Properties.Settings.Default.OutputFolder != "")
            {
                if (Directory.Exists(Properties.Settings.Default.OutputFolder))
                {
                    OutputFolder = Properties.Settings.Default.OutputFolder;
                }
            }

            string xmlPath = txtXML.Text;
            string Name = fi.Name.Replace(fi.Extension, "");

            string htmlPath = OutputFolder + "\\" + Name + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".html";
            string errPath = OutputFolder + "\\" + Name + "_ERROR_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            var input = new FileInfo(xmlPath);
            var output = new FileInfo(htmlPath);

            try
            {
                // Compile stylesheet
                var processor = new Processor();
                var compiler = processor.NewXsltCompiler();
                var executable = compiler.Compile(new Uri(txtXSLT.Text));

                // Do transformation to a destination
                var destination = new DomDestination();
                using (var inputStream = input.OpenRead())
                {
                    var transformer = executable.Load();
                    transformer.SetInputStream(inputStream, new Uri(input.DirectoryName));
                    transformer.Run(destination);
                }
                destination.XmlDocument.Save(output.FullName);

                CheckHTML(output.FullName, errPath);
            }catch(System.Exception ex)
            {
                txtError.Text = ex.Message;
            }
        }

        private void cmdPatchXSLT_Click(object sender, EventArgs e)
        {
            if (txtXSLT.Text == "")
            {
                MessageBox.Show("Надо задать путь к XSLT файлу");
                return;
            }
            string xslt;
            xslt = File.ReadAllText(txtXSLT.Text);
            xslt = xslt.Replace("/rm:", "/*:");
            File.WriteAllText(txtXSLT.Text,xslt);
        }

        private void cmdMap_Click(object sender, EventArgs e)
        {
            opf.Filter = "XML files|*.xml|All files|*.*";
            opf.Title = "Настройка генератора";
            opf.InitialDirectory = Properties.Settings.Default.MAPFolder;
            opf.CheckFileExists = true;
            opf.FileName = "";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                txtMap.Text = opf.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtXSLT.Text == "")
            {
                MessageBox.Show("Надо задать путь к XSLT файлу");
                return;
            }
            if (txtMap.Text == "")
            {
                MessageBox.Show("Надо задать путь к файлу настроек");
                return;
            }
            xb = new XMLBuilder();
            FileInfo fi = new FileInfo(txtMap.Text);

            string OutputFolder = fi.DirectoryName;

            if (Properties.Settings.Default.OutputFolder != "")
            {
                if (Directory.Exists(Properties.Settings.Default.OutputFolder))
                {
                    OutputFolder = Properties.Settings.Default.OutputFolder;
                }
            }

            xb.OutFolder = OutputFolder;
            
            using (var stream = System.IO.File.OpenRead(txtMap.Text))
            {
                var serializer = new XmlSerializer(typeof(xsdItem));
                xb.root = serializer.Deserialize(stream) as xsdItem;
            }

            xb.root.RestoreParent();

            string xmlPath = xb.BuildXML(xb.root,txtGenPaths.Text.Trim());
            txtGen2.Text = xmlPath;
            string htmlPath = OutputFolder + "\\" + xb.root.Name + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".html";
            string errPath = OutputFolder + "\\" + xb.root.Name + "_ERROR_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            var input = new FileInfo(xmlPath);
            var output = new FileInfo(htmlPath);

            try
            {


                // Compile stylesheet
                var processor = new Processor();
                var compiler = processor.NewXsltCompiler();
                var executable = compiler.Compile(new Uri(txtXSLT.Text));

                // Do transformation to a destination
                var destination = new DomDestination();
                using (var inputStream = input.OpenRead())
                {
                    var transformer = executable.Load();
                    transformer.SetInputStream(inputStream, new Uri(input.FullName));
                    transformer.Run(destination);
                }
                destination.XmlDocument.Save(output.FullName);

                CheckHTML(output.FullName, errPath);
            }
            catch (Saxon.Api.DynamicError sad)
            {
                //txtError.Text = ex.Message + "(" + ex.LineNumber.ToString() + ")";
                txtError.Text = sad.Message + "(" + sad.LineNumber + ")";




            }
            catch(System.Exception ex)
            {
                txtError.Text = ex.Message;
            }
            
        }

        private void cmdCLR_Click(object sender, EventArgs e)
        {
            txtGenPaths.Text = "";
        }

        private void txtGen2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGen2_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtGen2.Text);
        }

        private void txtGen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGen1_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtGen1.Text);
        }

        private void txtErrPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtErrPath_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtErrPath.Text);
        }

        private void txtHtmlPath_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtHtmlPath.Text);
        }
    }
}
