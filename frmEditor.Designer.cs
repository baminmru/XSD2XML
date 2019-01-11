namespace XSD2XML
{
    partial class frmEditor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditor));
            this.cmdSelectXSD = new System.Windows.Forms.Button();
            this.txtXSD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.opf = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tv = new System.Windows.Forms.TreeView();
            this.il32 = new System.Windows.Forms.ImageList(this.components);
            this.cmdLoadMap = new System.Windows.Forms.Button();
            this.cmdSaveMap = new System.Windows.Forms.Button();
            this.numGenPrc = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.chkSkip = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtFixed = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.numPrc = new System.Windows.Forms.NumericUpDown();
            this.cmdSetPrc = new System.Windows.Forms.Button();
            this.cmdNoLoop = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdNextSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGenPrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrc)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSelectXSD
            // 
            this.cmdSelectXSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectXSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdSelectXSD.Location = new System.Drawing.Point(814, 9);
            this.cmdSelectXSD.Name = "cmdSelectXSD";
            this.cmdSelectXSD.Size = new System.Drawing.Size(49, 26);
            this.cmdSelectXSD.TabIndex = 49;
            this.cmdSelectXSD.Text = "...";
            this.cmdSelectXSD.UseVisualStyleBackColor = true;
            this.cmdSelectXSD.Click += new System.EventHandler(this.cmdSelectXSD_Click);
            // 
            // txtXSD
            // 
            this.txtXSD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtXSD.Location = new System.Drawing.Point(235, 9);
            this.txtXSD.Name = "txtXSD";
            this.txtXSD.ReadOnly = true;
            this.txtXSD.Size = new System.Drawing.Size(573, 26);
            this.txtXSD.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "XSD файл";
            // 
            // opf
            // 
            this.opf.Filter = "XML files|*.xml|All files|*.*";
            this.opf.InitialDirectory = ".";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(7, 179);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(300, 0);
            this.splitContainer1.Panel1.Controls.Add(this.tv);
            this.splitContainer1.Panel1.Controls.Add(this.cmdLoadMap);
            this.splitContainer1.Panel1.Controls.Add(this.cmdSaveMap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.AutoScrollMinSize = new System.Drawing.Size(300, 0);
            this.splitContainer1.Panel2.Controls.Add(this.numGenPrc);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.chkSkip);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtMax);
            this.splitContainer1.Panel2.Controls.Add(this.txtMin);
            this.splitContainer1.Panel2.Controls.Add(this.txtFixed);
            this.splitContainer1.Panel2.Controls.Add(this.txtType);
            this.splitContainer1.Panel2.Controls.Add(this.txtName);
            this.splitContainer1.Size = new System.Drawing.Size(869, 377);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 50;
            // 
            // tv
            // 
            this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv.ImageIndex = 0;
            this.tv.ImageList = this.il32;
            this.tv.Indent = 32;
            this.tv.Location = new System.Drawing.Point(5, 79);
            this.tv.Name = "tv";
            this.tv.SelectedImageIndex = 0;
            this.tv.ShowRootLines = false;
            this.tv.Size = new System.Drawing.Size(273, 278);
            this.tv.TabIndex = 0;
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            // 
            // il32
            // 
            this.il32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il32.ImageStream")));
            this.il32.TransparentColor = System.Drawing.Color.Transparent;
            this.il32.Images.SetKeyName(0, "current.png");
            this.il32.Images.SetKeyName(1, "child.png");
            this.il32.Images.SetKeyName(2, "choice.png");
            this.il32.Images.SetKeyName(3, "cross.png");
            this.il32.Images.SetKeyName(4, "root.png");
            this.il32.Images.SetKeyName(5, "codes.jpg");
            // 
            // cmdLoadMap
            // 
            this.cmdLoadMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdLoadMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdLoadMap.Location = new System.Drawing.Point(3, 4);
            this.cmdLoadMap.Name = "cmdLoadMap";
            this.cmdLoadMap.Size = new System.Drawing.Size(304, 35);
            this.cmdLoadMap.TabIndex = 55;
            this.cmdLoadMap.Text = "Загрузить настройки";
            this.cmdLoadMap.UseVisualStyleBackColor = true;
            this.cmdLoadMap.Click += new System.EventHandler(this.cmdLoadMap_Click);
            // 
            // cmdSaveMap
            // 
            this.cmdSaveMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSaveMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdSaveMap.Location = new System.Drawing.Point(3, 43);
            this.cmdSaveMap.Name = "cmdSaveMap";
            this.cmdSaveMap.Size = new System.Drawing.Size(304, 35);
            this.cmdSaveMap.TabIndex = 56;
            this.cmdSaveMap.Text = "Сохранить настройки ";
            this.cmdSaveMap.UseVisualStyleBackColor = true;
            this.cmdSaveMap.Click += new System.EventHandler(this.cmdSaveMap_Click);
            // 
            // numGenPrc
            // 
            this.numGenPrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numGenPrc.Location = new System.Drawing.Point(171, 216);
            this.numGenPrc.Name = "numGenPrc";
            this.numGenPrc.Size = new System.Drawing.Size(71, 26);
            this.numGenPrc.TabIndex = 62;
            this.numGenPrc.ValueChanged += new System.EventHandler(this.numGenPrc_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(22, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Исключить узел";
            // 
            // chkSkip
            // 
            this.chkSkip.AutoSize = true;
            this.chkSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSkip.Location = new System.Drawing.Point(173, 263);
            this.chkSkip.Name = "chkSkip";
            this.chkSkip.Size = new System.Drawing.Size(15, 14);
            this.chkSkip.TabIndex = 12;
            this.chkSkip.UseVisualStyleBackColor = true;
            this.chkSkip.CheckedChanged += new System.EventHandler(this.chkSkip_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(22, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "% пропуска";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(22, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Максимум";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(22, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Мин.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Значение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // txtMax
            // 
            this.txtMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMax.Location = new System.Drawing.Point(171, 171);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(388, 26);
            this.txtMax.TabIndex = 4;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // txtMin
            // 
            this.txtMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMin.Location = new System.Drawing.Point(171, 132);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(388, 26);
            this.txtMin.TabIndex = 3;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtFixed
            // 
            this.txtFixed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFixed.Location = new System.Drawing.Point(171, 88);
            this.txtFixed.Name = "txtFixed";
            this.txtFixed.ReadOnly = true;
            this.txtFixed.Size = new System.Drawing.Size(388, 26);
            this.txtFixed.TabIndex = 2;
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtType.Location = new System.Drawing.Point(171, 49);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(388, 26);
            this.txtType.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(171, 10);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(388, 26);
            this.txtName.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(814, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 26);
            this.button2.TabIndex = 59;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(235, 54);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(573, 26);
            this.txtOutput.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 26);
            this.label3.TabIndex = 57;
            this.label3.Text = " Папка для сохранения XML";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(10, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 35);
            this.button3.TabIndex = 60;
            this.button3.Text = "Создать XML файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fbd
            // 
            this.fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "xml";
            // 
            // numPrc
            // 
            this.numPrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPrc.Location = new System.Drawing.Point(805, 107);
            this.numPrc.Name = "numPrc";
            this.numPrc.Size = new System.Drawing.Size(71, 26);
            this.numPrc.TabIndex = 61;
            // 
            // cmdSetPrc
            // 
            this.cmdSetPrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSetPrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdSetPrc.Location = new System.Drawing.Point(596, 102);
            this.cmdSetPrc.Name = "cmdSetPrc";
            this.cmdSetPrc.Size = new System.Drawing.Size(203, 35);
            this.cmdSetPrc.TabIndex = 62;
            this.cmdSetPrc.Text = "Установить % пропуска";
            this.cmdSetPrc.UseVisualStyleBackColor = true;
            this.cmdSetPrc.Click += new System.EventHandler(this.cmdSetPrc_Click);
            // 
            // cmdNoLoop
            // 
            this.cmdNoLoop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNoLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdNoLoop.Location = new System.Drawing.Point(395, 102);
            this.cmdNoLoop.Name = "cmdNoLoop";
            this.cmdNoLoop.Size = new System.Drawing.Size(196, 35);
            this.cmdNoLoop.TabIndex = 63;
            this.cmdNoLoop.Text = "Цикл из 1 экземпляра";
            this.cmdNoLoop.UseVisualStyleBackColor = true;
            this.cmdNoLoop.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(112, 143);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(629, 26);
            this.txtSearch.TabIndex = 64;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdSearch.Location = new System.Drawing.Point(12, 143);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(89, 30);
            this.cmdSearch.TabIndex = 65;
            this.cmdSearch.Text = "Найти";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cmdNextSearch
            // 
            this.cmdNextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNextSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdNextSearch.Location = new System.Drawing.Point(747, 143);
            this.cmdNextSearch.Name = "cmdNextSearch";
            this.cmdNextSearch.Size = new System.Drawing.Size(128, 29);
            this.cmdNextSearch.TabIndex = 66;
            this.cmdNextSearch.Text = "далее";
            this.cmdNextSearch.UseVisualStyleBackColor = true;
            this.cmdNextSearch.Click += new System.EventHandler(this.cmdNextSearch_Click);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 561);
            this.Controls.Add(this.cmdNextSearch);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmdNoLoop);
            this.Controls.Add(this.cmdSetPrc);
            this.Controls.Add(this.numPrc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cmdSelectXSD);
            this.Controls.Add(this.txtXSD);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 480);
            this.Name = "frmEditor";
            this.Text = " Генератор  XML примеров";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGenPrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSelectXSD;
        private System.Windows.Forms.TextBox txtXSD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog opf;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.Button cmdLoadMap;
        private System.Windows.Forms.Button cmdSaveMap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.NumericUpDown numPrc;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtFixed;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkSkip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSetPrc;
        private System.Windows.Forms.NumericUpDown numGenPrc;
        private System.Windows.Forms.Button cmdNoLoop;
        private System.Windows.Forms.ImageList il32;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdNextSearch;
    }
}

