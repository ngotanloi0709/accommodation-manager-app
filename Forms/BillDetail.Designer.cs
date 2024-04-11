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
            this.LabelTotalPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelVehicleTotalPrice = new System.Windows.Forms.Label();
            this.LabelVehiclePrice = new System.Windows.Forms.Label();
            this.lblQuanVehicle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelInternetTotalPrice = new System.Windows.Forms.Label();
            this.LabelInternetPrice = new System.Windows.Forms.Label();
            this.lblQuanInternet = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.LabelElectricityTotalPrice = new System.Windows.Forms.Label();
            this.LabelElectricityPrice = new System.Windows.Forms.Label();
            this.LabelElectricityQuantity = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.LabelWaterQuantity = new System.Windows.Forms.Label();
            this.LabelWaterPrice = new System.Windows.Forms.Label();
            this.LabelWaterTotalPrice = new System.Windows.Forms.Label();
            this.lblQuanRent = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbllls = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LabelRent = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LabelRoomId = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.btnWord);
            this.panel1.Controls.Add(this.btn_ExportPDF);
            this.panel1.Controls.Add(this.PanelHD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 947);
            this.panel1.TabIndex = 0;
            // 
            // btnWord
            // 
            this.btnWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWord.Location = new System.Drawing.Point(400, 886);
            this.btnWord.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(179, 46);
            this.btnWord.TabIndex = 2;
            this.btnWord.Text = "Xuất Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.ButtonExportWord_Click);
            // 
            // btn_ExportPDF
            // 
            this.btn_ExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportPDF.Location = new System.Drawing.Point(211, 886);
            this.btn_ExportPDF.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_ExportPDF.Name = "btn_ExportPDF";
            this.btn_ExportPDF.Size = new System.Drawing.Size(177, 46);
            this.btn_ExportPDF.TabIndex = 1;
            this.btn_ExportPDF.Text = "Xuất PDF";
            this.btn_ExportPDF.UseVisualStyleBackColor = true;
            this.btn_ExportPDF.Click += new System.EventHandler(this.ButtonExportPDF_Click);
            // 
            // PanelHD
            // 
            this.PanelHD.AutoScroll = true;
            this.PanelHD.BackColor = System.Drawing.Color.White;
            this.PanelHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHD.Controls.Add(this.LabelEmail);
            this.PanelHD.Controls.Add(this.label6);
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
            this.PanelHD.Controls.Add(this.LabelRoomId);
            this.PanelHD.Controls.Add(this.label12);
            this.PanelHD.Controls.Add(this.LabelDate);
            this.PanelHD.Controls.Add(this.label7);
            this.PanelHD.Controls.Add(this.lblName);
            this.PanelHD.Controls.Add(this.label1);
            this.PanelHD.Controls.Add(this.panel2);
            this.PanelHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHD.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelHD.Location = new System.Drawing.Point(0, 0);
            this.PanelHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelHD.Name = "PanelHD";
            this.PanelHD.Size = new System.Drawing.Size(771, 853);
            this.PanelHD.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AccommodationManagerApp.Properties.Resources.signature;
            this.pictureBox2.Location = new System.Drawing.Point(561, 736);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(603, 704);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(64, 22);
            this.label44.TabIndex = 25;
            this.label44.Text = "Chữ Ký";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(581, 676);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(101, 22);
            this.label43.TabIndex = 24;
            this.label43.Text = "Chủ Ký Tên";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(125, 704);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(64, 22);
            this.label42.TabIndex = 23;
            this.label42.Text = "Chữ Ký";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(83, 676);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(164, 22);
            this.label41.TabIndex = 22;
            this.label41.Text = "Người Thuê Ký Tên";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(83, 282);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(134, 22);
            this.label36.TabIndex = 17;
            this.label36.Text = "Direct Payment";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(80, 247);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(213, 23);
            this.label35.TabIndex = 16;
            this.label35.Text = "Phương thức thanh toán:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label33, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LabelTotalPrice, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(87, 582);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(616, 50);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(3, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(147, 50);
            this.label33.TabIndex = 16;
            this.label33.Text = "Tổng Tiền";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTotalPrice
            // 
            this.LabelTotalPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalPrice.Location = new System.Drawing.Point(465, 0);
            this.LabelTotalPrice.Name = "LabelTotalPrice";
            this.LabelTotalPrice.Size = new System.Drawing.Size(148, 50);
            this.LabelTotalPrice.TabIndex = 17;
            this.LabelTotalPrice.Text = "-1";
            this.LabelTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.LabelVehicleTotalPrice, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.LabelVehiclePrice, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblQuanVehicle, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.LabelInternetTotalPrice, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.LabelInternetPrice, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblQuanInternet, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label29, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LabelElectricityTotalPrice, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.LabelElectricityPrice, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.LabelElectricityQuantity, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label25, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.LabelWaterQuantity, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LabelWaterPrice, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LabelWaterTotalPrice, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblQuanRent, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbllls, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelRent, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(85, 369);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(616, 208);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // LabelVehicleTotalPrice
            // 
            this.LabelVehicleTotalPrice.AutoSize = true;
            this.LabelVehicleTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelVehicleTotalPrice.Location = new System.Drawing.Point(466, 164);
            this.LabelVehicleTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelVehicleTotalPrice.Name = "LabelVehicleTotalPrice";
            this.LabelVehicleTotalPrice.Size = new System.Drawing.Size(146, 44);
            this.LabelVehicleTotalPrice.TabIndex = 33;
            this.LabelVehicleTotalPrice.Text = "-1";
            this.LabelVehicleTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelVehiclePrice
            // 
            this.LabelVehiclePrice.AutoSize = true;
            this.LabelVehiclePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelVehiclePrice.Location = new System.Drawing.Point(312, 164);
            this.LabelVehiclePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelVehiclePrice.Name = "LabelVehiclePrice";
            this.LabelVehiclePrice.Size = new System.Drawing.Size(146, 44);
            this.LabelVehiclePrice.TabIndex = 32;
            // 
            // lblQuanVehicle
            // 
            this.lblQuanVehicle.AutoSize = true;
            this.lblQuanVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuanVehicle.Location = new System.Drawing.Point(158, 164);
            this.lblQuanVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuanVehicle.Name = "lblQuanVehicle";
            this.lblQuanVehicle.Size = new System.Drawing.Size(146, 44);
            this.lblQuanVehicle.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 44);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tiền xe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelInternetTotalPrice
            // 
            this.LabelInternetTotalPrice.AutoSize = true;
            this.LabelInternetTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelInternetTotalPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInternetTotalPrice.Location = new System.Drawing.Point(465, 123);
            this.LabelInternetTotalPrice.Name = "LabelInternetTotalPrice";
            this.LabelInternetTotalPrice.Size = new System.Drawing.Size(148, 41);
            this.LabelInternetTotalPrice.TabIndex = 30;
            this.LabelInternetTotalPrice.Text = "-1";
            this.LabelInternetTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelInternetPrice
            // 
            this.LabelInternetPrice.AutoSize = true;
            this.LabelInternetPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelInternetPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInternetPrice.Location = new System.Drawing.Point(311, 123);
            this.LabelInternetPrice.Name = "LabelInternetPrice";
            this.LabelInternetPrice.Size = new System.Drawing.Size(148, 41);
            this.LabelInternetPrice.TabIndex = 29;
            this.LabelInternetPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuanInternet
            // 
            this.lblQuanInternet.AutoSize = true;
            this.lblQuanInternet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuanInternet.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanInternet.Location = new System.Drawing.Point(157, 123);
            this.lblQuanInternet.Name = "lblQuanInternet";
            this.lblQuanInternet.Size = new System.Drawing.Size(148, 41);
            this.lblQuanInternet.TabIndex = 28;
            this.lblQuanInternet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(3, 123);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(148, 41);
            this.label29.TabIndex = 27;
            this.label29.Text = "Internet";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelElectricityTotalPrice
            // 
            this.LabelElectricityTotalPrice.AutoSize = true;
            this.LabelElectricityTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelElectricityTotalPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelElectricityTotalPrice.Location = new System.Drawing.Point(465, 82);
            this.LabelElectricityTotalPrice.Name = "LabelElectricityTotalPrice";
            this.LabelElectricityTotalPrice.Size = new System.Drawing.Size(148, 41);
            this.LabelElectricityTotalPrice.TabIndex = 26;
            this.LabelElectricityTotalPrice.Text = "-1";
            this.LabelElectricityTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelElectricityPrice
            // 
            this.LabelElectricityPrice.AutoSize = true;
            this.LabelElectricityPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelElectricityPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelElectricityPrice.Location = new System.Drawing.Point(311, 82);
            this.LabelElectricityPrice.Name = "LabelElectricityPrice";
            this.LabelElectricityPrice.Size = new System.Drawing.Size(148, 41);
            this.LabelElectricityPrice.TabIndex = 25;
            this.LabelElectricityPrice.Text = "-1";
            this.LabelElectricityPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelElectricityQuantity
            // 
            this.LabelElectricityQuantity.AutoSize = true;
            this.LabelElectricityQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelElectricityQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelElectricityQuantity.Location = new System.Drawing.Point(157, 82);
            this.LabelElectricityQuantity.Name = "LabelElectricityQuantity";
            this.LabelElectricityQuantity.Size = new System.Drawing.Size(148, 41);
            this.LabelElectricityQuantity.TabIndex = 24;
            this.LabelElectricityQuantity.Text = "-1";
            this.LabelElectricityQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 82);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(148, 41);
            this.label25.TabIndex = 15;
            this.label25.Text = "Điện";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelWaterQuantity
            // 
            this.LabelWaterQuantity.AutoSize = true;
            this.LabelWaterQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelWaterQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWaterQuantity.Location = new System.Drawing.Point(157, 41);
            this.LabelWaterQuantity.Name = "LabelWaterQuantity";
            this.LabelWaterQuantity.Size = new System.Drawing.Size(148, 41);
            this.LabelWaterQuantity.TabIndex = 23;
            this.LabelWaterQuantity.Text = "-1";
            this.LabelWaterQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelWaterPrice
            // 
            this.LabelWaterPrice.AutoSize = true;
            this.LabelWaterPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelWaterPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWaterPrice.Location = new System.Drawing.Point(311, 41);
            this.LabelWaterPrice.Name = "LabelWaterPrice";
            this.LabelWaterPrice.Size = new System.Drawing.Size(148, 41);
            this.LabelWaterPrice.TabIndex = 22;
            this.LabelWaterPrice.Text = "-1";
            this.LabelWaterPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelWaterTotalPrice
            // 
            this.LabelWaterTotalPrice.AutoSize = true;
            this.LabelWaterTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelWaterTotalPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWaterTotalPrice.Location = new System.Drawing.Point(465, 41);
            this.LabelWaterTotalPrice.Name = "LabelWaterTotalPrice";
            this.LabelWaterTotalPrice.Size = new System.Drawing.Size(148, 41);
            this.LabelWaterTotalPrice.TabIndex = 21;
            this.LabelWaterTotalPrice.Text = "-1";
            this.LabelWaterTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuanRent
            // 
            this.lblQuanRent.AutoSize = true;
            this.lblQuanRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuanRent.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanRent.Location = new System.Drawing.Point(157, 0);
            this.lblQuanRent.Name = "lblQuanRent";
            this.lblQuanRent.Size = new System.Drawing.Size(148, 41);
            this.lblQuanRent.TabIndex = 20;
            this.lblQuanRent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(148, 41);
            this.label21.TabIndex = 19;
            this.label21.Text = "Thuê";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbllls
            // 
            this.lbllls.AutoSize = true;
            this.lbllls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbllls.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllls.Location = new System.Drawing.Point(311, 0);
            this.lbllls.Name = "lbllls";
            this.lbllls.Size = new System.Drawing.Size(148, 41);
            this.lbllls.TabIndex = 18;
            this.lbllls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 41);
            this.label19.TabIndex = 17;
            this.label19.Text = "Nước";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRent
            // 
            this.LabelRent.AutoSize = true;
            this.LabelRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelRent.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRent.Location = new System.Drawing.Point(465, 0);
            this.LabelRent.Name = "LabelRent";
            this.LabelRent.Size = new System.Drawing.Size(148, 41);
            this.LabelRent.TabIndex = 16;
            this.LabelRent.Text = "-1";
            this.LabelRent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(85, 320);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 43);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(465, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 43);
            this.label16.TabIndex = 16;
            this.label16.Text = "Tổng";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(311, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 43);
            this.label15.TabIndex = 15;
            this.label15.Text = "đơn giá";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(157, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 43);
            this.label14.TabIndex = 14;
            this.label14.Text = "đơn vị";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 43);
            this.label13.TabIndex = 14;
            this.label13.Text = "Loại Phí";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRoomId
            // 
            this.LabelRoomId.AutoSize = true;
            this.LabelRoomId.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoomId.Location = new System.Drawing.Point(615, 216);
            this.LabelRoomId.Name = "LabelRoomId";
            this.LabelRoomId.Size = new System.Drawing.Size(55, 22);
            this.LabelRoomId.TabIndex = 12;
            this.LabelRoomId.Text = "Trống";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(500, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 22);
            this.label12.TabIndex = 11;
            this.label12.Text = "Phòng Số:";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(556, 183);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(96, 22);
            this.LabelDate.TabIndex = 8;
            this.LabelDate.Text = "15/08/2023";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(81, 212);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(170, 22);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Đỗ Trần Long Nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 149);
            this.panel2.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel1.Location = new System.Drawing.Point(72, 52);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(185, 58);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Hóa Đơn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccommodationManagerApp.Properties.Resources.icon_250;
            this.pictureBox1.Location = new System.Drawing.Point(504, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 132);
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
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(561, 248);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(55, 22);
            this.LabelEmail.TabIndex = 28;
            this.LabelEmail.Text = "Trống";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Email:";
            // 
            // BillDetail
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 979);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(778, 979);
            this.MinimumSize = new System.Drawing.Size(778, 979);
            this.Name = "BillDetail";
            this.Padding = new System.Windows.Forms.Padding(4, 30, 3, 2);
            this.Text = "BillDetail";
            this.panel1.ResumeLayout(false);
            this.PanelHD.ResumeLayout(false);
            this.PanelHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelInternetTotalPrice;
        private System.Windows.Forms.Label LabelInternetPrice;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label LabelElectricityTotalPrice;
        private System.Windows.Forms.Label LabelElectricityPrice;
        private System.Windows.Forms.Label LabelElectricityQuantity;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label LabelWaterQuantity;
        private System.Windows.Forms.Label LabelWaterPrice;
        private System.Windows.Forms.Label LabelWaterTotalPrice;
        private System.Windows.Forms.Label lblQuanRent;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label LabelRent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LabelRoomId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Label lblQuanInternet;
        private System.Windows.Forms.Label lbllls;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label LabelVehicleTotalPrice;
        private System.Windows.Forms.Label LabelVehiclePrice;
        private System.Windows.Forms.Label lblQuanVehicle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelTotalPrice;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label label6;
    }
}