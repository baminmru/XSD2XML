namespace XSD2XML
{
    partial class frmTester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTester));
            this.wb = new System.Windows.Forms.WebBrowser();
            this.cmdSelectFile = new System.Windows.Forms.Button();
            this.txtXSD = new System.Windows.Forms.TextBox();
            this.txtXSLT = new System.Windows.Forms.TextBox();
            this.opf = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtGenPaths = new System.Windows.Forms.TextBox();
            this.cmdCLR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdXML = new System.Windows.Forms.Button();
            this.cmdRun = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdPatchXSLT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupXML = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGen1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGen2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMap = new System.Windows.Forms.TextBox();
            this.cmdMap = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtErrPath = new System.Windows.Forms.TextBox();
            this.txtHtmlPath = new System.Windows.Forms.TextBox();
            this.groupXML.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb
            // 
            this.wb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wb.Location = new System.Drawing.Point(14, 408);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(988, 238);
            this.wb.TabIndex = 0;
            // 
            // cmdSelectFile
            // 
            this.cmdSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdSelectFile.Location = new System.Drawing.Point(643, 21);
            this.cmdSelectFile.Name = "cmdSelectFile";
            this.cmdSelectFile.Size = new System.Drawing.Size(39, 26);
            this.cmdSelectFile.TabIndex = 46;
            this.cmdSelectFile.Text = "...";
            this.cmdSelectFile.UseVisualStyleBackColor = true;
            this.cmdSelectFile.Click += new System.EventHandler(this.cmdSelectFile_Click);
            // 
            // txtXSD
            // 
            this.txtXSD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtXSD.Location = new System.Drawing.Point(113, 21);
            this.txtXSD.Name = "txtXSD";
            this.txtXSD.ReadOnly = true;
            this.txtXSD.Size = new System.Drawing.Size(524, 26);
            this.txtXSD.TabIndex = 45;
            this.txtXSD.TextChanged += new System.EventHandler(this.txtXSD_TextChanged);
            // 
            // txtXSLT
            // 
            this.txtXSLT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXSLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtXSLT.Location = new System.Drawing.Point(123, 6);
            this.txtXSLT.Name = "txtXSLT";
            this.txtXSLT.ReadOnly = true;
            this.txtXSLT.Size = new System.Drawing.Size(541, 26);
            this.txtXSLT.TabIndex = 43;
            // 
            // opf
            // 
            this.opf.Filter = "XML files|*.xml|All files|*.*";
            this.opf.InitialDirectory = ".";
            this.opf.FileOk += new System.ComponentModel.CancelEventHandler(this.opf_FileOk);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // txtGenPaths
            // 
            this.txtGenPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenPaths.Location = new System.Drawing.Point(7, 3);
            this.txtGenPaths.MaxLength = 2000000;
            this.txtGenPaths.Multiline = true;
            this.txtGenPaths.Name = "txtGenPaths";
            this.txtGenPaths.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGenPaths.Size = new System.Drawing.Size(935, 106);
            this.txtGenPaths.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtGenPaths, "Пути для генерации полей");
            // 
            // cmdCLR
            // 
            this.cmdCLR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCLR.Location = new System.Drawing.Point(960, 3);
            this.cmdCLR.Name = "cmdCLR";
            this.cmdCLR.Size = new System.Drawing.Size(25, 106);
            this.cmdCLR.TabIndex = 1;
            this.cmdCLR.Text = "CLR";
            this.toolTip1.SetToolTip(this.cmdCLR, "Очистить пути для генерации");
            this.cmdCLR.UseVisualStyleBackColor = true;
            this.cmdCLR.Click += new System.EventHandler(this.cmdCLR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "XSD файл";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "XSLT файл";
            // 
            // cmdXML
            // 
            this.cmdXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdXML.Location = new System.Drawing.Point(670, 3);
            this.cmdXML.Name = "cmdXML";
            this.cmdXML.Size = new System.Drawing.Size(39, 32);
            this.cmdXML.TabIndex = 41;
            this.cmdXML.Text = "...";
            this.cmdXML.UseVisualStyleBackColor = true;
            this.cmdXML.Click += new System.EventHandler(this.cmdXML_Click);
            // 
            // cmdRun
            // 
            this.cmdRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdRun.Location = new System.Drawing.Point(688, 21);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(278, 26);
            this.cmdRun.TabIndex = 47;
            this.cmdRun.Text = "Генерация XML и тестирование";
            this.cmdRun.UseVisualStyleBackColor = true;
            this.cmdRun.Click += new System.EventHandler(this.cmdRun_Click);
            // 
            // txtError
            // 
            this.txtError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtError.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtError.Location = new System.Drawing.Point(12, 266);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtError.Size = new System.Drawing.Size(990, 91);
            this.txtError.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(584, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 26);
            this.button1.TabIndex = 53;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtXML
            // 
            this.txtXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtXML.Location = new System.Drawing.Point(112, 25);
            this.txtXML.Name = "txtXML";
            this.txtXML.ReadOnly = true;
            this.txtXML.Size = new System.Drawing.Size(466, 26);
            this.txtXML.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "XML файл";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(629, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(337, 29);
            this.button2.TabIndex = 54;
            this.button2.Text = "Тестирование с готовым XML  файлом";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdPatchXSLT
            // 
            this.cmdPatchXSLT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPatchXSLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdPatchXSLT.Location = new System.Drawing.Point(729, 3);
            this.cmdPatchXSLT.Name = "cmdPatchXSLT";
            this.cmdPatchXSLT.Size = new System.Drawing.Size(256, 32);
            this.cmdPatchXSLT.TabIndex = 55;
            this.cmdPatchXSLT.Text = "Исправление /rm: -> /*:";
            this.cmdPatchXSLT.UseVisualStyleBackColor = true;
            this.cmdPatchXSLT.Click += new System.EventHandler(this.cmdPatchXSLT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Список ошибок";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Результат преобразования";
            // 
            // groupXML
            // 
            this.groupXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupXML.Controls.Add(this.button2);
            this.groupXML.Controls.Add(this.txtXML);
            this.groupXML.Controls.Add(this.button1);
            this.groupXML.Controls.Add(this.label4);
            this.groupXML.Location = new System.Drawing.Point(6, 0);
            this.groupXML.Name = "groupXML";
            this.groupXML.Size = new System.Drawing.Size(972, 109);
            this.groupXML.TabIndex = 58;
            this.groupXML.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtGen1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtXSD);
            this.groupBox2.Controls.Add(this.cmdSelectFile);
            this.groupBox2.Controls.Add(this.cmdRun);
            this.groupBox2.Location = new System.Drawing.Point(6, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 106);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            // 
            // txtGen1
            // 
            this.txtGen1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGen1.Location = new System.Drawing.Point(21, 69);
            this.txtGen1.Name = "txtGen1";
            this.txtGen1.ReadOnly = true;
            this.txtGen1.Size = new System.Drawing.Size(942, 26);
            this.txtGen1.TabIndex = 48;
            this.txtGen1.TextChanged += new System.EventHandler(this.txtGen1_TextChanged);
            this.txtGen1.DoubleClick += new System.EventHandler(this.txtGen1_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(994, 145);
            this.tabControl1.TabIndex = 60;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 112);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "XSD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(986, 112);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки генератора";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtGen2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtMap);
            this.groupBox1.Controls.Add(this.cmdMap);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 114);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // txtGen2
            // 
            this.txtGen2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGen2.Location = new System.Drawing.Point(19, 75);
            this.txtGen2.Name = "txtGen2";
            this.txtGen2.ReadOnly = true;
            this.txtGen2.Size = new System.Drawing.Size(947, 26);
            this.txtGen2.TabIndex = 55;
            this.txtGen2.TextChanged += new System.EventHandler(this.txtGen2_TextChanged);
            this.txtGen2.DoubleClick += new System.EventHandler(this.txtGen2_DoubleClick);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(706, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 29);
            this.button3.TabIndex = 54;
            this.button3.Text = "Генерация XML и тестирование";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtMap
            // 
            this.txtMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMap.Location = new System.Drawing.Point(241, 25);
            this.txtMap.Name = "txtMap";
            this.txtMap.ReadOnly = true;
            this.txtMap.Size = new System.Drawing.Size(414, 26);
            this.txtMap.TabIndex = 52;
            // 
            // cmdMap
            // 
            this.cmdMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdMap.Location = new System.Drawing.Point(661, 23);
            this.cmdMap.Name = "cmdMap";
            this.cmdMap.Size = new System.Drawing.Size(39, 26);
            this.cmdMap.TabIndex = 53;
            this.cmdMap.Text = "...";
            this.cmdMap.UseVisualStyleBackColor = true;
            this.cmdMap.Click += new System.EventHandler(this.cmdMap_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Файл настроек генератора";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupXML);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(986, 112);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Готовый XML";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmdCLR);
            this.tabPage4.Controls.Add(this.txtGenPaths);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(986, 112);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Пути для генерации";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Источник данных";
            // 
            // txtErrPath
            // 
            this.txtErrPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtErrPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtErrPath.Location = new System.Drawing.Point(264, 232);
            this.txtErrPath.Name = "txtErrPath";
            this.txtErrPath.ReadOnly = true;
            this.txtErrPath.Size = new System.Drawing.Size(738, 26);
            this.txtErrPath.TabIndex = 62;
            this.txtErrPath.TextChanged += new System.EventHandler(this.txtErrPath_TextChanged);
            this.txtErrPath.DoubleClick += new System.EventHandler(this.txtErrPath_DoubleClick);
            // 
            // txtHtmlPath
            // 
            this.txtHtmlPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHtmlPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHtmlPath.Location = new System.Drawing.Point(264, 373);
            this.txtHtmlPath.Name = "txtHtmlPath";
            this.txtHtmlPath.ReadOnly = true;
            this.txtHtmlPath.Size = new System.Drawing.Size(738, 26);
            this.txtHtmlPath.TabIndex = 63;
            this.txtHtmlPath.DoubleClick += new System.EventHandler(this.txtHtmlPath_DoubleClick);
            // 
            // frmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 663);
            this.Controls.Add(this.txtHtmlPath);
            this.Controls.Add(this.txtErrPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdPatchXSLT);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtXSLT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdXML);
            this.Controls.Add(this.wb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 480);
            this.Name = "frmTester";
            this.Text = "Тестирование преобразования XSLT";
            this.groupXML.ResumeLayout(false);
            this.groupXML.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Button cmdSelectFile;
        private System.Windows.Forms.TextBox txtXSD;
        private System.Windows.Forms.TextBox txtXSLT;
        private System.Windows.Forms.OpenFileDialog opf;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdXML;
        private System.Windows.Forms.Button cmdRun;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdPatchXSLT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupXML;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtMap;
        private System.Windows.Forms.Button cmdMap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGen1;
        private System.Windows.Forms.TextBox txtGen2;
        private System.Windows.Forms.TextBox txtErrPath;
        private System.Windows.Forms.TextBox txtHtmlPath;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtGenPaths;
        private System.Windows.Forms.Button cmdCLR;
    }
}