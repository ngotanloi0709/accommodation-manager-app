namespace AccommodationManagerApp.Forms
{
    partial class BillDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWord = new System.Windows.Forms.Button();
            this.btn_ExportPDF = new System.Windows.Forms.Button();
            this.PanelHD = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label33 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelInternet = new System.Windows.Forms.Label();
            this.lalslasl = new System.Windows.Forms.Label();
            this.lblQuanOther = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.labelElec = new System.Windows.Forms.Label();
            this.labelPriceElec = new System.Windows.Forms.Label();
            this.labelQtyElec = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.labelQtyWater = new System.Windows.Forms.Label();
            this.labelPriceWater = new System.Windows.Forms.Label();
            this.labelWater = new System.Windows.Forms.Label();
            this.lblQuanRent = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbllls = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelRent = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1.SuspendLayout();
            this.PanelHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnWord);
            this.panel1.Controls.Add(this.btn_ExportPDF);
            this.panel1.Controls.Add(this.PanelHD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 769);
            this.panel1.TabIndex = 0;
            // 
            // btnWord
            // 
            this.btnWord.AutoSize = true;
            this.btnWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWord.Location = new System.Drawing.Point(324, 714);
            this.btnWord.Margin = new System.Windows.Forms.Padding(2);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(100, 30);
            this.btnWord.TabIndex = 2;
            this.btnWord.Text = "Xuất Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btn_ExportPDF
            // 
            this.btn_ExportPDF.AutoSize = true;
            this.btn_ExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportPDF.Location = new System.Drawing.Point(156, 714);
            this.btn_ExportPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ExportPDF.Name = "btn_ExportPDF";
            this.btn_ExportPDF.Size = new System.Drawing.Size(100, 30);
            this.btn_ExportPDF.TabIndex = 1;
            this.btn_ExportPDF.Text = "Xuất PDF";
            this.btn_ExportPDF.UseVisualStyleBackColor = true;
            this.btn_ExportPDF.Click += new System.EventHandler(this.btn_ExportPDF_Click_1);
            // 
            // PanelHD
            // 
            this.PanelHD.AutoScroll = true;
            this.PanelHD.BackColor = System.Drawing.Color.White;
            this.PanelHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHD.Controls.Add(this.pictureBox2);
            this.PanelHD.Controls.Add(this.label44);
            this.PanelHD.Controls.Add(this.label43);
            this.PanelHD.Controls.Add(this.label42);
            this.PanelHD.Controls.Add(this.label41);
            this.PanelHD.Controls.Add(this.label36);
            this.PanelHD.Controls.Add(this.label35);
            this.PanelHD.Controls.Add(this.tableLayoutPanel3);
            this.PanelHD.Controls.Add(this.tableLayoutPanel2);
            this.PanelHD.Controls.Add(this.tableLayoutPanel1);
            this.PanelHD.Controls.Add(this.lblRoomId);
            this.PanelHD.Controls.Add(this.label12);
            this.PanelHD.Controls.Add(this.lblDate);
            this.PanelHD.Controls.Add(this.label7);
            this.PanelHD.Controls.Add(this.lblName);
            this.PanelHD.Controls.Add(this.label1);
            this.PanelHD.Controls.Add(this.panel2);
            this.PanelHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHD.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelHD.Location = new System.Drawing.Point(0, 0);
            this.PanelHD.Margin = new System.Windows.Forms.Padding(2);
            this.PanelHD.Name = "PanelHD";
            this.PanelHD.Size = new System.Drawing.Size(595, 693);
            this.PanelHD.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AccommodationManagerApp.Properties.Resources.signature;
            this.pictureBox2.Location = new System.Drawing.Point(420, 579);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(451, 553);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(52, 18);
            this.label44.TabIndex = 25;
            this.label44.Text = "Chữ Ký";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(435, 530);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(83, 18);
            this.label43.TabIndex = 24;
            this.label43.Text = "Chủ Ký Tên";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(93, 553);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(52, 18);
            this.label42.TabIndex = 23;
            this.label42.Text = "Chữ Ký";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(61, 530);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(135, 18);
            this.label41.TabIndex = 22;
            this.label41.Text = "Người Thuê Ký Tên";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(61, 225);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(102, 16);
            this.label36.TabIndex = 17;
            this.label36.Text = "Direct Payment";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(60, 201);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(169, 19);
            this.label35.TabIndex = 16;
            this.label35.Text = "Phương thức thanh toán:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.59916F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.40084F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel3.Controls.Add(this.label33, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelTotal, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(64, 452);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(462, 41);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(2, 0);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(161, 41);
            this.label33.TabIndex = 16;
            this.label33.Text = "Tổng Tiền";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(348, 0);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(112, 41);
            this.labelTotal.TabIndex = 17;
            this.labelTotal.Text = "-1";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.47231F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.5277F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.Controls.Add(this.labelInternet, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lalslasl, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblQuanOther, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label29, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelElec, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelPriceElec, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelQtyElec, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label25, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelQtyWater, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelPriceWater, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelWater, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblQuanRent, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbllls, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelRent, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(64, 300);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(462, 148);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // labelInternet
            // 
            this.labelInternet.AutoSize = true;
            this.labelInternet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInternet.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInternet.Location = new System.Drawing.Point(349, 107);
            this.labelInternet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInternet.Name = "labelInternet";
            this.labelInternet.Size = new System.Drawing.Size(111, 41);
            this.labelInternet.TabIndex = 30;
            this.labelInternet.Text = "-1";
            this.labelInternet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lalslasl
            // 
            this.lalslasl.AutoSize = true;
            this.lalslasl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lalslasl.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalslasl.Location = new System.Drawing.Point(245, 107);
            this.lalslasl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lalslasl.Name = "lalslasl";
            this.lalslasl.Size = new System.Drawing.Size(100, 41);
            this.lalslasl.TabIndex = 29;
            this.lalslasl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuanOther
            // 
            this.lblQuanOther.AutoSize = true;
            this.lblQuanOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuanOther.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanOther.Location = new System.Drawing.Point(164, 107);
            this.lblQuanOther.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuanOther.Name = "lblQuanOther";
            this.lblQuanOther.Size = new System.Drawing.Size(77, 41);
            this.lblQuanOther.TabIndex = 28;
            this.lblQuanOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(2, 107);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(158, 41);
            this.label29.TabIndex = 27;
            this.label29.Text = "Internet";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelElec
            // 
            this.labelElec.AutoSize = true;
            this.labelElec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelElec.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElec.Location = new System.Drawing.Point(349, 69);
            this.labelElec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelElec.Name = "labelElec";
            this.labelElec.Size = new System.Drawing.Size(111, 38);
            this.labelElec.TabIndex = 26;
            this.labelElec.Text = "-1";
            this.labelElec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPriceElec
            // 
            this.labelPriceElec.AutoSize = true;
            this.labelPriceElec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPriceElec.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceElec.Location = new System.Drawing.Point(245, 69);
            this.labelPriceElec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceElec.Name = "labelPriceElec";
            this.labelPriceElec.Size = new System.Drawing.Size(100, 38);
            this.labelPriceElec.TabIndex = 25;
            this.labelPriceElec.Text = "-1";
            this.labelPriceElec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQtyElec
            // 
            this.labelQtyElec.AutoSize = true;
            this.labelQtyElec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQtyElec.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtyElec.Location = new System.Drawing.Point(164, 69);
            this.labelQtyElec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQtyElec.Name = "labelQtyElec";
            this.labelQtyElec.Size = new System.Drawing.Size(77, 38);
            this.labelQtyElec.TabIndex = 24;
            this.labelQtyElec.Text = "-1";
            this.labelQtyElec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(2, 69);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(158, 38);
            this.label25.TabIndex = 15;
            this.label25.Text = "Điện";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQtyWater
            // 
            this.labelQtyWater.AutoSize = true;
            this.labelQtyWater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQtyWater.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtyWater.Location = new System.Drawing.Point(164, 32);
            this.labelQtyWater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQtyWater.Name = "labelQtyWater";
            this.labelQtyWater.Size = new System.Drawing.Size(77, 37);
            this.labelQtyWater.TabIndex = 23;
            this.labelQtyWater.Text = "-1";
            this.labelQtyWater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPriceWater
            // 
            this.labelPriceWater.AutoSize = true;
            this.labelPriceWater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPriceWater.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceWater.Location = new System.Drawing.Point(245, 32);
            this.labelPriceWater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceWater.Name = "labelPriceWater";
            this.labelPriceWater.Size = new System.Drawing.Size(100, 37);
            this.labelPriceWater.TabIndex = 22;
            this.labelPriceWater.Text = "-1";
            this.labelPriceWater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWater
            // 
            this.labelWater.AutoSize = true;
            this.labelWater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWater.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWater.Location = new System.Drawing.Point(349, 32);
            this.labelWater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWater.Name = "labelWater";
            this.labelWater.Size = new System.Drawing.Size(111, 37);
            this.labelWater.TabIndex = 21;
            this.labelWater.Text = "-1";
            this.labelWater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuanRent
            // 
            this.lblQuanRent.AutoSize = true;
            this.lblQuanRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuanRent.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanRent.Location = new System.Drawing.Point(164, 0);
            this.lblQuanRent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuanRent.Name = "lblQuanRent";
            this.lblQuanRent.Size = new System.Drawing.Size(77, 32);
            this.lblQuanRent.TabIndex = 20;
            this.lblQuanRent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(2, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(158, 32);
            this.label21.TabIndex = 19;
            this.label21.Text = "Thuê";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbllls
            // 
            this.lbllls.AutoSize = true;
            this.lbllls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbllls.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllls.Location = new System.Drawing.Point(245, 0);
            this.lbllls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllls.Name = "lbllls";
            this.lbllls.Size = new System.Drawing.Size(100, 32);
            this.lbllls.TabIndex = 18;
            this.lbllls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(2, 32);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 37);
            this.label19.TabIndex = 17;
            this.label19.Text = "Nước";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRent
            // 
            this.labelRent.AutoSize = true;
            this.labelRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRent.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRent.Location = new System.Drawing.Point(349, 0);
            this.labelRent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(111, 32);
            this.labelRent.TabIndex = 16;
            this.labelRent.Text = "-1";
            this.labelRent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(64, 260);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 35);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(364, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 35);
            this.label16.TabIndex = 16;
            this.label16.Text = "Tổng";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(260, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 35);
            this.label15.TabIndex = 15;
            this.label15.Text = "đơn giá";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(172, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 35);
            this.label14.TabIndex = 14;
            this.label14.Text = "đơn vị";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 35);
            this.label13.TabIndex = 14;
            this.label13.Text = "Loại Phí";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomId.Location = new System.Drawing.Point(486, 210);
            this.lblRoomId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(44, 18);
            this.lblRoomId.TabIndex = 12;
            this.lblRoomId.Text = "Trống";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(418, 211);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Phòng Số:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(442, 183);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 18);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "15/08/2023";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(61, 172);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Đỗ Trần Long Nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gửi Từ:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 121);
            this.panel2.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel1.Location = new System.Drawing.Point(54, 42);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(185, 58);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Hóa Đơn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccommodationManagerApp.Properties.Resources.icon_250;
            this.pictureBox1.Location = new System.Drawing.Point(392, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // BillDetail
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 795);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(600, 900);
            this.Name = "BillDetail";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 2, 2);
            this.Text = "BillDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelHD.ResumeLayout(false);
            this.PanelHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ExportPDF;
        private System.Windows.Forms.Panel PanelHD;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelInternet;
        private System.Windows.Forms.Label lalslasl;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label labelElec;
        private System.Windows.Forms.Label labelPriceElec;
        private System.Windows.Forms.Label labelQtyElec;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labelQtyWater;
        private System.Windows.Forms.Label labelPriceWater;
        private System.Windows.Forms.Label labelWater;
        private System.Windows.Forms.Label lblQuanRent;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelRent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Label lblQuanOther;
        private System.Windows.Forms.Label lbllls;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}