﻿namespace AccommodationManagerApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.drawerImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.tabPageSystemUsers = new System.Windows.Forms.TabPage();
            this.tabPageInvoices = new System.Windows.Forms.TabPage();
            this.exportPdfButton = new System.Windows.Forms.Button();
            this.tabPageTenants = new System.Windows.Forms.TabPage();
            this.tabPageRoom = new System.Windows.Forms.TabPage();
            this.buttonDeleteRoom = new MaterialSkin.Controls.MaterialButton();
            this.buttonEditRoom = new MaterialSkin.Controls.MaterialButton();
            this.buttonAddRoom = new MaterialSkin.Controls.MaterialButton();
            this.labelRoomId = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.labelRoomStatus = new MaterialSkin.Controls.MaterialLabel();
            this.labelRoomTenant = new MaterialSkin.Controls.MaterialLabel();
            this.labelRoomBuilding = new MaterialSkin.Controls.MaterialLabel();
            this.labelRoomNumber = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonReloadRoom = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.ListViewRoom = new MaterialSkin.Controls.MaterialListView();
            this.colRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRomBuilding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomTenant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageBuilding = new System.Windows.Forms.TabPage();
            this.buttonReloadBuilding = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonDeleteBuilding = new MaterialSkin.Controls.MaterialButton();
            this.labelBuilldingCreatedAt = new MaterialSkin.Controls.MaterialLabel();
            this.buttonEditBuilding = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.labelBuildingAddress = new MaterialSkin.Controls.MaterialLabel();
            this.labelBuildingName = new MaterialSkin.Controls.MaterialLabel();
            this.labelBuildingId = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonAddBuilding = new MaterialSkin.Controls.MaterialButton();
            this.ListViewBuilding = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageVehicle = new System.Windows.Forms.TabPage();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.labelVehicleRoom = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonDeleteVehicle = new MaterialSkin.Controls.MaterialButton();
            this.buttonEditVehicle = new MaterialSkin.Controls.MaterialButton();
            this.buttonAddVehicle = new MaterialSkin.Controls.MaterialButton();
            this.labelVehicleId = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.labelVehicleName = new MaterialSkin.Controls.MaterialLabel();
            this.labelVehicleType = new MaterialSkin.Controls.MaterialLabel();
            this.labelVehicleNumber = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.ListViewVehicle = new MaterialSkin.Controls.MaterialListView();
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogOut = new MaterialSkin.Controls.MaterialButton();
            this.tabPageInvoices.SuspendLayout();
            this.tabPageRoom.SuspendLayout();
            this.tabPageBuilding.SuspendLayout();
            this.materialTabControl.SuspendLayout();
            this.tabPageVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawerImageList
            // 
            this.drawerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("drawerImageList.ImageStream")));
            this.drawerImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.drawerImageList.Images.SetKeyName(0, "home.png");
            this.drawerImageList.Images.SetKeyName(1, "customer.png");
            this.drawerImageList.Images.SetKeyName(2, "dashboard.png");
            this.drawerImageList.Images.SetKeyName(3, "house-owner.png");
            this.drawerImageList.Images.SetKeyName(4, "invoice.png");
            this.drawerImageList.Images.SetKeyName(5, "setting.png");
            this.drawerImageList.Images.SetKeyName(6, "vehicle2.png");
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.BackColor = System.Drawing.Color.White;
            this.tabPageConfiguration.ImageKey = "setting.png";
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 39);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Size = new System.Drawing.Size(986, 673);
            this.tabPageConfiguration.TabIndex = 5;
            this.tabPageConfiguration.Text = "Configuration";
            // 
            // tabPageSystemUsers
            // 
            this.tabPageSystemUsers.BackColor = System.Drawing.Color.White;
            this.tabPageSystemUsers.ImageKey = "customer.png";
            this.tabPageSystemUsers.Location = new System.Drawing.Point(4, 39);
            this.tabPageSystemUsers.Name = "tabPageSystemUsers";
            this.tabPageSystemUsers.Size = new System.Drawing.Size(986, 673);
            this.tabPageSystemUsers.TabIndex = 4;
            this.tabPageSystemUsers.Text = "System Users";
            // 
            // tabPageInvoices
            // 
            this.tabPageInvoices.BackColor = System.Drawing.Color.White;
            this.tabPageInvoices.Controls.Add(this.exportPdfButton);
            this.tabPageInvoices.ImageKey = "invoice.png";
            this.tabPageInvoices.Location = new System.Drawing.Point(4, 39);
            this.tabPageInvoices.Name = "tabPageInvoices";
            this.tabPageInvoices.Size = new System.Drawing.Size(986, 673);
            this.tabPageInvoices.TabIndex = 3;
            this.tabPageInvoices.Text = "Invoices";
            // 
            // exportPdfButton
            // 
            this.exportPdfButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportPdfButton.Location = new System.Drawing.Point(414, 280);
            this.exportPdfButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportPdfButton.Name = "exportPdfButton";
            this.exportPdfButton.Size = new System.Drawing.Size(138, 34);
            this.exportPdfButton.TabIndex = 0;
            this.exportPdfButton.Text = "PDF";
            this.exportPdfButton.UseVisualStyleBackColor = true;
            this.exportPdfButton.Click += new System.EventHandler(this.exportPdfButton_Click);
            // 
            // tabPageTenants
            // 
            this.tabPageTenants.BackColor = System.Drawing.Color.White;
            this.tabPageTenants.ImageKey = "house-owner.png";
            this.tabPageTenants.Location = new System.Drawing.Point(4, 39);
            this.tabPageTenants.Name = "tabPageTenants";
            this.tabPageTenants.Size = new System.Drawing.Size(986, 673);
            this.tabPageTenants.TabIndex = 2;
            this.tabPageTenants.Text = "Quản lý người thuê";
            // 
            // tabPageRoom
            // 
            this.tabPageRoom.BackColor = System.Drawing.Color.White;
            this.tabPageRoom.Controls.Add(this.buttonDeleteRoom);
            this.tabPageRoom.Controls.Add(this.buttonEditRoom);
            this.tabPageRoom.Controls.Add(this.buttonAddRoom);
            this.tabPageRoom.Controls.Add(this.labelRoomId);
            this.tabPageRoom.Controls.Add(this.materialLabel16);
            this.tabPageRoom.Controls.Add(this.labelRoomStatus);
            this.tabPageRoom.Controls.Add(this.labelRoomTenant);
            this.tabPageRoom.Controls.Add(this.labelRoomBuilding);
            this.tabPageRoom.Controls.Add(this.labelRoomNumber);
            this.tabPageRoom.Controls.Add(this.materialLabel9);
            this.tabPageRoom.Controls.Add(this.materialLabel8);
            this.tabPageRoom.Controls.Add(this.materialLabel7);
            this.tabPageRoom.Controls.Add(this.materialLabel5);
            this.tabPageRoom.Controls.Add(this.materialLabel1);
            this.tabPageRoom.Controls.Add(this.materialTextBox1);
            this.tabPageRoom.Controls.Add(this.buttonReloadRoom);
            this.tabPageRoom.Controls.Add(this.ListViewRoom);
            this.tabPageRoom.ForeColor = System.Drawing.Color.Transparent;
            this.tabPageRoom.ImageKey = "home.png";
            this.tabPageRoom.Location = new System.Drawing.Point(4, 39);
            this.tabPageRoom.Name = "tabPageRoom";
            this.tabPageRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoom.Size = new System.Drawing.Size(986, 673);
            this.tabPageRoom.TabIndex = 0;
            this.tabPageRoom.Text = "Quản lý căn hộ";
            // 
            // buttonDeleteRoom
            // 
            this.buttonDeleteRoom.AutoSize = false;
            this.buttonDeleteRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeleteRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonDeleteRoom.Depth = 0;
            this.buttonDeleteRoom.HighEmphasis = true;
            this.buttonDeleteRoom.Icon = global::AccommodationManagerApp.Properties.Resources.delete;
            this.buttonDeleteRoom.Location = new System.Drawing.Point(548, 449);
            this.buttonDeleteRoom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDeleteRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDeleteRoom.Name = "buttonDeleteRoom";
            this.buttonDeleteRoom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonDeleteRoom.Size = new System.Drawing.Size(361, 36);
            this.buttonDeleteRoom.TabIndex = 16;
            this.buttonDeleteRoom.Text = "Xoá thông tin căn hộ đã chọn";
            this.buttonDeleteRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonDeleteRoom.UseAccentColor = false;
            this.buttonDeleteRoom.UseVisualStyleBackColor = true;
            this.buttonDeleteRoom.Click += new System.EventHandler(this.buttonDeleteRoom_Click);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.AutoSize = false;
            this.buttonEditRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEditRoom.Depth = 0;
            this.buttonEditRoom.HighEmphasis = true;
            this.buttonEditRoom.Icon = global::AccommodationManagerApp.Properties.Resources.edit;
            this.buttonEditRoom.Location = new System.Drawing.Point(548, 401);
            this.buttonEditRoom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEditRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEditRoom.Size = new System.Drawing.Size(361, 36);
            this.buttonEditRoom.TabIndex = 15;
            this.buttonEditRoom.Text = "Chỉnh sửa thông tin căn hộ đã chọn";
            this.buttonEditRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEditRoom.UseAccentColor = false;
            this.buttonEditRoom.UseVisualStyleBackColor = true;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.AutoSize = false;
            this.buttonAddRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAddRoom.Depth = 0;
            this.buttonAddRoom.HighEmphasis = true;
            this.buttonAddRoom.Icon = global::AccommodationManagerApp.Properties.Resources.plus;
            this.buttonAddRoom.Location = new System.Drawing.Point(548, 353);
            this.buttonAddRoom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAddRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAddRoom.Size = new System.Drawing.Size(361, 36);
            this.buttonAddRoom.TabIndex = 14;
            this.buttonAddRoom.Text = "Thêm căn hộ mới vào danh sách quản lý";
            this.buttonAddRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAddRoom.UseAccentColor = false;
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // labelRoomId
            // 
            this.labelRoomId.AutoSize = true;
            this.labelRoomId.Depth = 0;
            this.labelRoomId.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRoomId.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelRoomId.Location = new System.Drawing.Point(674, 127);
            this.labelRoomId.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoomId.Name = "labelRoomId";
            this.labelRoomId.Size = new System.Drawing.Size(217, 24);
            this.labelRoomId.TabIndex = 13;
            this.labelRoomId.Text = "________________________";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel16.Location = new System.Drawing.Point(564, 127);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(23, 24);
            this.materialLabel16.TabIndex = 12;
            this.materialLabel16.Text = "Id:";
            // 
            // labelRoomStatus
            // 
            this.labelRoomStatus.AutoSize = true;
            this.labelRoomStatus.Depth = 0;
            this.labelRoomStatus.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRoomStatus.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelRoomStatus.Location = new System.Drawing.Point(674, 298);
            this.labelRoomStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoomStatus.Name = "labelRoomStatus";
            this.labelRoomStatus.Size = new System.Drawing.Size(217, 24);
            this.labelRoomStatus.TabIndex = 11;
            this.labelRoomStatus.Text = "________________________";
            // 
            // labelRoomTenant
            // 
            this.labelRoomTenant.AutoSize = true;
            this.labelRoomTenant.Depth = 0;
            this.labelRoomTenant.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRoomTenant.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelRoomTenant.Location = new System.Drawing.Point(674, 254);
            this.labelRoomTenant.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoomTenant.Name = "labelRoomTenant";
            this.labelRoomTenant.Size = new System.Drawing.Size(217, 24);
            this.labelRoomTenant.TabIndex = 10;
            this.labelRoomTenant.Text = "________________________";
            // 
            // labelRoomBuilding
            // 
            this.labelRoomBuilding.AutoSize = true;
            this.labelRoomBuilding.Depth = 0;
            this.labelRoomBuilding.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRoomBuilding.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelRoomBuilding.Location = new System.Drawing.Point(674, 209);
            this.labelRoomBuilding.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoomBuilding.Name = "labelRoomBuilding";
            this.labelRoomBuilding.Size = new System.Drawing.Size(217, 24);
            this.labelRoomBuilding.TabIndex = 9;
            this.labelRoomBuilding.Text = "________________________";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Depth = 0;
            this.labelRoomNumber.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRoomNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelRoomNumber.Location = new System.Drawing.Point(674, 168);
            this.labelRoomNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(217, 24);
            this.labelRoomNumber.TabIndex = 8;
            this.labelRoomNumber.Text = "________________________";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel9.Location = new System.Drawing.Point(6, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(390, 72);
            this.materialLabel9.TabIndex = 7;
            this.materialLabel9.Text = "Quản lý căn hộ";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(563, 254);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(105, 24);
            this.materialLabel8.TabIndex = 6;
            this.materialLabel8.Text = "Người thuê:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(563, 298);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(97, 24);
            this.materialLabel7.TabIndex = 5;
            this.materialLabel7.Text = "Trạng thái:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(564, 209);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(78, 24);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Toà nhà:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(564, 168);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Số nhà:";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.materialTextBox1.Hint = "Tìm kiếm";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(548, 22);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(361, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // buttonReloadRoom
            // 
            this.buttonReloadRoom.Depth = 0;
            this.buttonReloadRoom.Icon = global::AccommodationManagerApp.Properties.Resources.reload;
            this.buttonReloadRoom.Location = new System.Drawing.Point(433, 590);
            this.buttonReloadRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonReloadRoom.Name = "buttonReloadRoom";
            this.buttonReloadRoom.Size = new System.Drawing.Size(56, 56);
            this.buttonReloadRoom.TabIndex = 2;
            this.buttonReloadRoom.Text = "materialFloatingActionButton1";
            this.buttonReloadRoom.UseVisualStyleBackColor = true;
            this.buttonReloadRoom.Click += new System.EventHandler(this.buttonReloadRoom_Click);
            // 
            // ListViewRoom
            // 
            this.ListViewRoom.AutoArrange = false;
            this.ListViewRoom.AutoSizeTable = false;
            this.ListViewRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoomNumber,
            this.colRomBuilding,
            this.colRoomTenant,
            this.colRoomStatus});
            this.ListViewRoom.Depth = 0;
            this.ListViewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ListViewRoom.FullRowSelect = true;
            this.ListViewRoom.HideSelection = false;
            this.ListViewRoom.Location = new System.Drawing.Point(3, 85);
            this.ListViewRoom.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewRoom.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewRoom.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewRoom.Name = "ListViewRoom";
            this.ListViewRoom.OwnerDraw = true;
            this.ListViewRoom.Size = new System.Drawing.Size(522, 585);
            this.ListViewRoom.TabIndex = 0;
            this.ListViewRoom.UseCompatibleStateImageBehavior = false;
            this.ListViewRoom.View = System.Windows.Forms.View.Details;
            this.ListViewRoom.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewRoom_ItemSelectionChanged);
            // 
            // colRoomNumber
            // 
            this.colRoomNumber.Text = "Số nhà";
            this.colRoomNumber.Width = 139;
            // 
            // colRomBuilding
            // 
            this.colRomBuilding.Text = "Toà nhà";
            this.colRomBuilding.Width = 112;
            // 
            // colRoomTenant
            // 
            this.colRoomTenant.Text = "Người thuê";
            this.colRoomTenant.Width = 137;
            // 
            // colRoomStatus
            // 
            this.colRoomStatus.Text = "Trạng thái";
            this.colRoomStatus.Width = 116;
            // 
            // tabPageBuilding
            // 
            this.tabPageBuilding.BackColor = System.Drawing.Color.White;
            this.tabPageBuilding.Controls.Add(this.buttonReloadBuilding);
            this.tabPageBuilding.Controls.Add(this.materialTextBox2);
            this.tabPageBuilding.Controls.Add(this.materialLabel10);
            this.tabPageBuilding.Controls.Add(this.buttonDeleteBuilding);
            this.tabPageBuilding.Controls.Add(this.labelBuilldingCreatedAt);
            this.tabPageBuilding.Controls.Add(this.buttonEditBuilding);
            this.tabPageBuilding.Controls.Add(this.materialLabel6);
            this.tabPageBuilding.Controls.Add(this.labelBuildingAddress);
            this.tabPageBuilding.Controls.Add(this.labelBuildingName);
            this.tabPageBuilding.Controls.Add(this.labelBuildingId);
            this.tabPageBuilding.Controls.Add(this.materialLabel4);
            this.tabPageBuilding.Controls.Add(this.materialLabel3);
            this.tabPageBuilding.Controls.Add(this.materialLabel2);
            this.tabPageBuilding.Controls.Add(this.buttonAddBuilding);
            this.tabPageBuilding.Controls.Add(this.ListViewBuilding);
            this.tabPageBuilding.ImageKey = "dashboard.png";
            this.tabPageBuilding.Location = new System.Drawing.Point(4, 39);
            this.tabPageBuilding.Name = "tabPageBuilding";
            this.tabPageBuilding.Size = new System.Drawing.Size(986, 673);
            this.tabPageBuilding.TabIndex = 1;
            this.tabPageBuilding.Text = "Quản lý toà nhà";
            // 
            // buttonReloadBuilding
            // 
            this.buttonReloadBuilding.Depth = 0;
            this.buttonReloadBuilding.Icon = global::AccommodationManagerApp.Properties.Resources.reload;
            this.buttonReloadBuilding.Location = new System.Drawing.Point(348, 572);
            this.buttonReloadBuilding.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonReloadBuilding.Name = "buttonReloadBuilding";
            this.buttonReloadBuilding.Size = new System.Drawing.Size(56, 56);
            this.buttonReloadBuilding.TabIndex = 16;
            this.buttonReloadBuilding.Text = "materialFloatingActionButton1";
            this.buttonReloadBuilding.UseVisualStyleBackColor = true;
            this.buttonReloadBuilding.Click += new System.EventHandler(this.buttonReloadBuilding_Click);
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.ForeColor = System.Drawing.Color.Transparent;
            this.materialTextBox2.Hint = "Tìm kiếm";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(490, 22);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(409, 50);
            this.materialTextBox2.TabIndex = 15;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel10.Location = new System.Drawing.Point(3, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(410, 72);
            this.materialLabel10.TabIndex = 14;
            this.materialLabel10.Text = "Quản lý toà nhà";
            // 
            // buttonDeleteBuilding
            // 
            this.buttonDeleteBuilding.AutoSize = false;
            this.buttonDeleteBuilding.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeleteBuilding.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonDeleteBuilding.Depth = 0;
            this.buttonDeleteBuilding.HighEmphasis = true;
            this.buttonDeleteBuilding.Icon = global::AccommodationManagerApp.Properties.Resources.delete;
            this.buttonDeleteBuilding.Location = new System.Drawing.Point(490, 374);
            this.buttonDeleteBuilding.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDeleteBuilding.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDeleteBuilding.Name = "buttonDeleteBuilding";
            this.buttonDeleteBuilding.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonDeleteBuilding.Size = new System.Drawing.Size(409, 36);
            this.buttonDeleteBuilding.TabIndex = 13;
            this.buttonDeleteBuilding.Text = "Xoá thông tin toà chung cư đã chọn";
            this.buttonDeleteBuilding.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonDeleteBuilding.UseAccentColor = false;
            this.buttonDeleteBuilding.UseVisualStyleBackColor = true;
            this.buttonDeleteBuilding.Click += new System.EventHandler(this.buttonDeleteBuilding_Click);
            // 
            // labelBuilldingCreatedAt
            // 
            this.labelBuilldingCreatedAt.AutoSize = true;
            this.labelBuilldingCreatedAt.Depth = 0;
            this.labelBuilldingCreatedAt.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelBuilldingCreatedAt.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelBuilldingCreatedAt.Location = new System.Drawing.Point(578, 205);
            this.labelBuilldingCreatedAt.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBuilldingCreatedAt.Name = "labelBuilldingCreatedAt";
            this.labelBuilldingCreatedAt.Size = new System.Drawing.Size(289, 24);
            this.labelBuilldingCreatedAt.TabIndex = 11;
            this.labelBuilldingCreatedAt.Text = "________________________________";
            // 
            // buttonEditBuilding
            // 
            this.buttonEditBuilding.AutoSize = false;
            this.buttonEditBuilding.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditBuilding.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEditBuilding.Depth = 0;
            this.buttonEditBuilding.HighEmphasis = true;
            this.buttonEditBuilding.Icon = global::AccommodationManagerApp.Properties.Resources.edit;
            this.buttonEditBuilding.Location = new System.Drawing.Point(490, 326);
            this.buttonEditBuilding.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEditBuilding.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEditBuilding.Name = "buttonEditBuilding";
            this.buttonEditBuilding.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEditBuilding.Size = new System.Drawing.Size(409, 36);
            this.buttonEditBuilding.TabIndex = 10;
            this.buttonEditBuilding.Text = "Chỉnh sửa thông tin toà chung cư đã chọn";
            this.buttonEditBuilding.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEditBuilding.UseAccentColor = false;
            this.buttonEditBuilding.UseVisualStyleBackColor = true;
            this.buttonEditBuilding.Click += new System.EventHandler(this.buttonEditBuilding_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(486, 205);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(86, 24);
            this.materialLabel6.TabIndex = 8;
            this.materialLabel6.Text = "Ngày tạo:";
            // 
            // labelBuildingAddress
            // 
            this.labelBuildingAddress.AutoSize = true;
            this.labelBuildingAddress.Depth = 0;
            this.labelBuildingAddress.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelBuildingAddress.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelBuildingAddress.Location = new System.Drawing.Point(578, 165);
            this.labelBuildingAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBuildingAddress.Name = "labelBuildingAddress";
            this.labelBuildingAddress.Size = new System.Drawing.Size(289, 24);
            this.labelBuildingAddress.TabIndex = 7;
            this.labelBuildingAddress.Text = "________________________________";
            // 
            // labelBuildingName
            // 
            this.labelBuildingName.AutoSize = true;
            this.labelBuildingName.Depth = 0;
            this.labelBuildingName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelBuildingName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelBuildingName.Location = new System.Drawing.Point(704, 122);
            this.labelBuildingName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBuildingName.Name = "labelBuildingName";
            this.labelBuildingName.Size = new System.Drawing.Size(163, 24);
            this.labelBuildingName.TabIndex = 6;
            this.labelBuildingName.Text = "__________________";
            // 
            // labelBuildingId
            // 
            this.labelBuildingId.AutoSize = true;
            this.labelBuildingId.Depth = 0;
            this.labelBuildingId.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelBuildingId.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelBuildingId.Location = new System.Drawing.Point(510, 122);
            this.labelBuildingId.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBuildingId.Name = "labelBuildingId";
            this.labelBuildingId.Size = new System.Drawing.Size(55, 24);
            this.labelBuildingId.TabIndex = 5;
            this.labelBuildingId.Text = "______";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(586, 122);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(112, 24);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Tên toà nhà:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(486, 165);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(66, 24);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Địa chỉ:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(486, 122);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(23, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Id:";
            // 
            // buttonAddBuilding
            // 
            this.buttonAddBuilding.AutoSize = false;
            this.buttonAddBuilding.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddBuilding.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAddBuilding.Depth = 0;
            this.buttonAddBuilding.HighEmphasis = true;
            this.buttonAddBuilding.Icon = global::AccommodationManagerApp.Properties.Resources.plus;
            this.buttonAddBuilding.Location = new System.Drawing.Point(490, 278);
            this.buttonAddBuilding.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAddBuilding.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddBuilding.Name = "buttonAddBuilding";
            this.buttonAddBuilding.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAddBuilding.Size = new System.Drawing.Size(409, 36);
            this.buttonAddBuilding.TabIndex = 1;
            this.buttonAddBuilding.Text = "Thêm toà chung cư mới vào danh sách quản lý";
            this.buttonAddBuilding.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAddBuilding.UseAccentColor = false;
            this.buttonAddBuilding.UseVisualStyleBackColor = true;
            this.buttonAddBuilding.Click += new System.EventHandler(this.buttonAddBuilding_Click);
            // 
            // ListViewBuilding
            // 
            this.ListViewBuilding.AutoSizeTable = false;
            this.ListViewBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewBuilding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewBuilding.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListViewBuilding.Depth = 0;
            this.ListViewBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ListViewBuilding.FullRowSelect = true;
            this.ListViewBuilding.HideSelection = false;
            this.ListViewBuilding.Location = new System.Drawing.Point(0, 75);
            this.ListViewBuilding.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewBuilding.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewBuilding.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewBuilding.Name = "ListViewBuilding";
            this.ListViewBuilding.OwnerDraw = true;
            this.ListViewBuilding.Size = new System.Drawing.Size(438, 599);
            this.ListViewBuilding.TabIndex = 0;
            this.ListViewBuilding.UseCompatibleStateImageBehavior = false;
            this.ListViewBuilding.View = System.Windows.Forms.View.Details;
            this.ListViewBuilding.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewBuilding_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên toà nhà";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày tạo";
            this.columnHeader3.Width = 178;
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.tabPageBuilding);
            this.materialTabControl.Controls.Add(this.tabPageRoom);
            this.materialTabControl.Controls.Add(this.tabPageTenants);
            this.materialTabControl.Controls.Add(this.tabPageInvoices);
            this.materialTabControl.Controls.Add(this.tabPageVehicle);
            this.materialTabControl.Controls.Add(this.tabPageSystemUsers);
            this.materialTabControl.Controls.Add(this.tabPageConfiguration);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl.ImageList = this.drawerImageList;
            this.materialTabControl.Location = new System.Drawing.Point(3, 80);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(994, 716);
            this.materialTabControl.TabIndex = 0;
            // 
            // tabPageVehicle
            // 
            this.tabPageVehicle.BackColor = System.Drawing.Color.White;
            this.tabPageVehicle.Controls.Add(this.materialFloatingActionButton1);
            this.tabPageVehicle.Controls.Add(this.labelVehicleRoom);
            this.tabPageVehicle.Controls.Add(this.materialLabel14);
            this.tabPageVehicle.Controls.Add(this.buttonDeleteVehicle);
            this.tabPageVehicle.Controls.Add(this.buttonEditVehicle);
            this.tabPageVehicle.Controls.Add(this.buttonAddVehicle);
            this.tabPageVehicle.Controls.Add(this.labelVehicleId);
            this.tabPageVehicle.Controls.Add(this.materialLabel13);
            this.tabPageVehicle.Controls.Add(this.labelVehicleName);
            this.tabPageVehicle.Controls.Add(this.labelVehicleType);
            this.tabPageVehicle.Controls.Add(this.labelVehicleNumber);
            this.tabPageVehicle.Controls.Add(this.materialLabel19);
            this.tabPageVehicle.Controls.Add(this.materialLabel21);
            this.tabPageVehicle.Controls.Add(this.materialLabel22);
            this.tabPageVehicle.Controls.Add(this.materialMaskedTextBox1);
            this.tabPageVehicle.Controls.Add(this.ListViewVehicle);
            this.tabPageVehicle.Controls.Add(this.materialLabel11);
            this.tabPageVehicle.ImageKey = "vehicle.png";
            this.tabPageVehicle.Location = new System.Drawing.Point(4, 39);
            this.tabPageVehicle.Name = "tabPageVehicle";
            this.tabPageVehicle.Size = new System.Drawing.Size(986, 673);
            this.tabPageVehicle.TabIndex = 6;
            this.tabPageVehicle.Text = "Vehicle";
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = global::AccommodationManagerApp.Properties.Resources.reload;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(388, 580);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 29;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            this.materialFloatingActionButton1.Click += new System.EventHandler(this.materialFloatingActionButton1_Click);
            // 
            // labelVehicleRoom
            // 
            this.labelVehicleRoom.AutoSize = true;
            this.labelVehicleRoom.Depth = 0;
            this.labelVehicleRoom.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelVehicleRoom.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelVehicleRoom.Location = new System.Drawing.Point(715, 269);
            this.labelVehicleRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelVehicleRoom.Name = "labelVehicleRoom";
            this.labelVehicleRoom.Size = new System.Drawing.Size(217, 24);
            this.labelVehicleRoom.TabIndex = 28;
            this.labelVehicleRoom.Text = "________________________";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel14.Location = new System.Drawing.Point(544, 269);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(63, 24);
            this.materialLabel14.TabIndex = 27;
            this.materialLabel14.Text = "Phòng:";
            // 
            // buttonDeleteVehicle
            // 
            this.buttonDeleteVehicle.AutoSize = false;
            this.buttonDeleteVehicle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeleteVehicle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonDeleteVehicle.Depth = 0;
            this.buttonDeleteVehicle.HighEmphasis = true;
            this.buttonDeleteVehicle.Icon = global::AccommodationManagerApp.Properties.Resources.delete;
            this.buttonDeleteVehicle.Location = new System.Drawing.Point(550, 452);
            this.buttonDeleteVehicle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDeleteVehicle.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDeleteVehicle.Name = "buttonDeleteVehicle";
            this.buttonDeleteVehicle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonDeleteVehicle.Size = new System.Drawing.Size(383, 36);
            this.buttonDeleteVehicle.TabIndex = 26;
            this.buttonDeleteVehicle.Text = "XÓA THÔNG TIN PHUONG TIỆN ĐÃ CHỌN";
            this.buttonDeleteVehicle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonDeleteVehicle.UseAccentColor = false;
            this.buttonDeleteVehicle.UseVisualStyleBackColor = true;
            this.buttonDeleteVehicle.Click += new System.EventHandler(this.buttonDeleteVehicle_Click);
            // 
            // buttonEditVehicle
            // 
            this.buttonEditVehicle.AutoSize = false;
            this.buttonEditVehicle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditVehicle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEditVehicle.Depth = 0;
            this.buttonEditVehicle.HighEmphasis = true;
            this.buttonEditVehicle.Icon = global::AccommodationManagerApp.Properties.Resources.edit;
            this.buttonEditVehicle.Location = new System.Drawing.Point(550, 404);
            this.buttonEditVehicle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEditVehicle.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEditVehicle.Name = "buttonEditVehicle";
            this.buttonEditVehicle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEditVehicle.Size = new System.Drawing.Size(383, 36);
            this.buttonEditVehicle.TabIndex = 25;
            this.buttonEditVehicle.Text = "CHỈNH SỬA THÔNG TIN PHƯƠNG TIỆN ĐÃ CHỌN";
            this.buttonEditVehicle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEditVehicle.UseAccentColor = false;
            this.buttonEditVehicle.UseVisualStyleBackColor = true;
            this.buttonEditVehicle.Click += new System.EventHandler(this.buttonEditVehicle_Click);
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.AutoSize = false;
            this.buttonAddVehicle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddVehicle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAddVehicle.Depth = 0;
            this.buttonAddVehicle.HighEmphasis = true;
            this.buttonAddVehicle.Icon = global::AccommodationManagerApp.Properties.Resources.plus;
            this.buttonAddVehicle.Location = new System.Drawing.Point(549, 356);
            this.buttonAddVehicle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAddVehicle.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAddVehicle.Size = new System.Drawing.Size(384, 36);
            this.buttonAddVehicle.TabIndex = 24;
            this.buttonAddVehicle.Text = "THÊM PHƯƠNG TIỆN MỚI VÀO DANH SÁCH QUẢN LÝ";
            this.buttonAddVehicle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAddVehicle.UseAccentColor = false;
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // labelVehicleId
            // 
            this.labelVehicleId.AutoSize = true;
            this.labelVehicleId.Depth = 0;
            this.labelVehicleId.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelVehicleId.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelVehicleId.Location = new System.Drawing.Point(715, 102);
            this.labelVehicleId.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelVehicleId.Name = "labelVehicleId";
            this.labelVehicleId.Size = new System.Drawing.Size(217, 24);
            this.labelVehicleId.TabIndex = 23;
            this.labelVehicleId.Text = "________________________";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel13.Location = new System.Drawing.Point(545, 102);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(23, 24);
            this.materialLabel13.TabIndex = 22;
            this.materialLabel13.Text = "Id:";
            // 
            // labelVehicleName
            // 
            this.labelVehicleName.AutoSize = true;
            this.labelVehicleName.Depth = 0;
            this.labelVehicleName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelVehicleName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelVehicleName.Location = new System.Drawing.Point(715, 229);
            this.labelVehicleName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelVehicleName.Name = "labelVehicleName";
            this.labelVehicleName.Size = new System.Drawing.Size(217, 24);
            this.labelVehicleName.TabIndex = 20;
            this.labelVehicleName.Text = "________________________";
            // 
            // labelVehicleType
            // 
            this.labelVehicleType.AutoSize = true;
            this.labelVehicleType.Depth = 0;
            this.labelVehicleType.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelVehicleType.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelVehicleType.Location = new System.Drawing.Point(715, 184);
            this.labelVehicleType.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelVehicleType.Name = "labelVehicleType";
            this.labelVehicleType.Size = new System.Drawing.Size(217, 24);
            this.labelVehicleType.TabIndex = 19;
            this.labelVehicleType.Text = "________________________";
            // 
            // labelVehicleNumber
            // 
            this.labelVehicleNumber.AutoSize = true;
            this.labelVehicleNumber.Depth = 0;
            this.labelVehicleNumber.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelVehicleNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelVehicleNumber.Location = new System.Drawing.Point(715, 143);
            this.labelVehicleNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelVehicleNumber.Name = "labelVehicleNumber";
            this.labelVehicleNumber.Size = new System.Drawing.Size(217, 24);
            this.labelVehicleNumber.TabIndex = 18;
            this.labelVehicleNumber.Text = "________________________";
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel19.Location = new System.Drawing.Point(544, 229);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(152, 24);
            this.materialLabel19.TabIndex = 17;
            this.materialLabel19.Text = "Tên phương tiện:";
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel21.Location = new System.Drawing.Point(545, 184);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(156, 24);
            this.materialLabel21.TabIndex = 15;
            this.materialLabel21.Text = "Loại phương tiện:";
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel22.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel22.Location = new System.Drawing.Point(545, 143);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(98, 24);
            this.materialLabel22.TabIndex = 14;
            this.materialLabel22.Text = "Biển số xe:";
            // 
            // materialMaskedTextBox1
            // 
            this.materialMaskedTextBox1.AllowPromptAsInput = true;
            this.materialMaskedTextBox1.AnimateReadOnly = false;
            this.materialMaskedTextBox1.AsciiOnly = false;
            this.materialMaskedTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox1.BeepOnError = false;
            this.materialMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.Depth = 0;
            this.materialMaskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox1.HidePromptOnLeave = false;
            this.materialMaskedTextBox1.HideSelection = true;
            this.materialMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox1.LeadingIcon = null;
            this.materialMaskedTextBox1.Location = new System.Drawing.Point(549, 24);
            this.materialMaskedTextBox1.Mask = "";
            this.materialMaskedTextBox1.MaxLength = 32767;
            this.materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            this.materialMaskedTextBox1.PasswordChar = '\0';
            this.materialMaskedTextBox1.PrefixSuffixText = null;
            this.materialMaskedTextBox1.PromptChar = '_';
            this.materialMaskedTextBox1.ReadOnly = false;
            this.materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox1.ResetOnPrompt = true;
            this.materialMaskedTextBox1.ResetOnSpace = true;
            this.materialMaskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox1.SelectedText = "";
            this.materialMaskedTextBox1.SelectionLength = 0;
            this.materialMaskedTextBox1.SelectionStart = 0;
            this.materialMaskedTextBox1.ShortcutsEnabled = true;
            this.materialMaskedTextBox1.Size = new System.Drawing.Size(382, 48);
            this.materialMaskedTextBox1.SkipLiterals = true;
            this.materialMaskedTextBox1.TabIndex = 2;
            this.materialMaskedTextBox1.TabStop = false;
            this.materialMaskedTextBox1.Text = "Tìm kiếm";
            this.materialMaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.TrailingIcon = null;
            this.materialMaskedTextBox1.UseSystemPasswordChar = false;
            this.materialMaskedTextBox1.ValidatingType = null;
            // 
            // ListViewVehicle
            // 
            this.ListViewVehicle.AutoSizeTable = false;
            this.ListViewVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewVehicle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumber,
            this.columnName,
            this.columnType,
            this.columnRoom});
            this.ListViewVehicle.Depth = 0;
            this.ListViewVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewVehicle.FullRowSelect = true;
            this.ListViewVehicle.HideSelection = false;
            this.ListViewVehicle.Location = new System.Drawing.Point(3, 89);
            this.ListViewVehicle.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewVehicle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewVehicle.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewVehicle.Name = "ListViewVehicle";
            this.ListViewVehicle.OwnerDraw = true;
            this.ListViewVehicle.Size = new System.Drawing.Size(524, 581);
            this.ListViewVehicle.TabIndex = 1;
            this.ListViewVehicle.UseCompatibleStateImageBehavior = false;
            this.ListViewVehicle.View = System.Windows.Forms.View.Details;
            this.ListViewVehicle.SelectedIndexChanged += new System.EventHandler(this.ListViewVehicle_SelectedIndexChanged);
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "Number";
            this.columnNumber.Width = 120;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 120;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnType.Width = 120;
            // 
            // columnRoom
            // 
            this.columnRoom.Text = "Room";
            this.columnRoom.Width = 150;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel11.Location = new System.Drawing.Point(3, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(524, 72);
            this.materialLabel11.TabIndex = 0;
            this.materialLabel11.Text = "Quản lý phương tiện";
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogOut.Depth = 0;
            this.btnLogOut.HighEmphasis = true;
            this.btnLogOut.Icon = null;
            this.btnLogOut.Location = new System.Drawing.Point(834, 25);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogOut.Size = new System.Drawing.Size(82, 36);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogOut.UseAccentColor = true;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.materialTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 3, 4);
            this.Sizable = false;
            this.Text = "MainForm";
            this.tabPageInvoices.ResumeLayout(false);
            this.tabPageRoom.ResumeLayout(false);
            this.tabPageRoom.PerformLayout();
            this.tabPageBuilding.ResumeLayout(false);
            this.tabPageBuilding.PerformLayout();
            this.materialTabControl.ResumeLayout(false);
            this.tabPageVehicle.ResumeLayout(false);
            this.tabPageVehicle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList drawerImageList;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.TabPage tabPageSystemUsers;
        private System.Windows.Forms.TabPage tabPageInvoices;
        private System.Windows.Forms.Button exportPdfButton;
        private System.Windows.Forms.TabPage tabPageTenants;
        private System.Windows.Forms.TabPage tabPageRoom;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialFloatingActionButton buttonReloadRoom;
        private MaterialSkin.Controls.MaterialListView ListViewRoom;
        private System.Windows.Forms.ColumnHeader colRoomNumber;
        private System.Windows.Forms.ColumnHeader colRomBuilding;
        private System.Windows.Forms.ColumnHeader colRoomTenant;
        private System.Windows.Forms.ColumnHeader colRoomStatus;
        private System.Windows.Forms.TabPage tabPageBuilding;
        private MaterialSkin.Controls.MaterialButton buttonDeleteBuilding;
        private MaterialSkin.Controls.MaterialLabel labelBuilldingCreatedAt;
        private MaterialSkin.Controls.MaterialButton buttonEditBuilding;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel labelBuildingAddress;
        private MaterialSkin.Controls.MaterialLabel labelBuildingName;
        private MaterialSkin.Controls.MaterialLabel labelBuildingId;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton buttonAddBuilding;
        private MaterialSkin.Controls.MaterialListView ListViewBuilding;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel labelRoomId;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel labelRoomStatus;
        private MaterialSkin.Controls.MaterialLabel labelRoomTenant;
        private MaterialSkin.Controls.MaterialLabel labelRoomBuilding;
        private MaterialSkin.Controls.MaterialLabel labelRoomNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialButton buttonDeleteRoom;
        private MaterialSkin.Controls.MaterialButton buttonEditRoom;
        private MaterialSkin.Controls.MaterialButton buttonAddRoom;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialFloatingActionButton buttonReloadBuilding;
        private MaterialSkin.Controls.MaterialButton btnLogOut;
        private System.Windows.Forms.TabPage tabPageVehicle;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialListView ListViewVehicle;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnType;
        private MaterialSkin.Controls.MaterialLabel labelVehicleId;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel labelVehicleName;
        private MaterialSkin.Controls.MaterialLabel labelVehicleType;
        private MaterialSkin.Controls.MaterialLabel labelVehicleNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialButton buttonDeleteVehicle;
        private MaterialSkin.Controls.MaterialButton buttonEditVehicle;
        private MaterialSkin.Controls.MaterialButton buttonAddVehicle;
        private System.Windows.Forms.ColumnHeader columnRoom;
        private MaterialSkin.Controls.MaterialLabel labelVehicleRoom;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
    }
}