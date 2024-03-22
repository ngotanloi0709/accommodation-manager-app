namespace AccommodationManagerApp.Forms
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
            this.tabPageBills = new System.Windows.Forms.TabPage();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbboxCatg = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnPDF = new MaterialSkin.Controls.MaterialButton();
            this.lstViewBill = new MaterialSkin.Controls.MaterialListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.water = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.electricity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLogOut = new MaterialSkin.Controls.MaterialButton();
            this.mySqlConnection1 = new MySqlConnector.MySqlConnection();
            this.tabPageRoom.SuspendLayout();
            this.tabPageBuilding.SuspendLayout();
            this.materialTabControl.SuspendLayout();
            this.tabPageBills.SuspendLayout();
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
            this.buttonDeleteBuilding.Location = new System.Drawing.Point(490, 356);
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
            this.buttonEditBuilding.Location = new System.Drawing.Point(490, 308);
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
            this.buttonAddBuilding.Location = new System.Drawing.Point(490, 260);
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
            this.materialTabControl.Controls.Add(this.tabPageSystemUsers);
            this.materialTabControl.Controls.Add(this.tabPageConfiguration);
            this.materialTabControl.Controls.Add(this.tabPageBills);
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
            // tabPageBills
            // 
            this.tabPageBills.BackColor = System.Drawing.Color.White;
            this.tabPageBills.Controls.Add(this.materialComboBox2);
            this.tabPageBills.Controls.Add(this.cmbboxCatg);
            this.tabPageBills.Controls.Add(this.materialLabel12);
            this.tabPageBills.Controls.Add(this.btnSearch);
            this.tabPageBills.Controls.Add(this.txtBoxSearch);
            this.tabPageBills.Controls.Add(this.materialButton2);
            this.tabPageBills.Controls.Add(this.btnDelete);
            this.tabPageBills.Controls.Add(this.btnAdd);
            this.tabPageBills.Controls.Add(this.btnPDF);
            this.tabPageBills.Controls.Add(this.lstViewBill);
            this.tabPageBills.ImageKey = "invoice.png";
            this.tabPageBills.Location = new System.Drawing.Point(4, 39);
            this.tabPageBills.Name = "tabPageBills";
            this.tabPageBills.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBills.Size = new System.Drawing.Size(986, 673);
            this.tabPageBills.TabIndex = 6;
            this.tabPageBills.Text = "Bill Managements";
            this.tabPageBills.UseVisualStyleBackColor = true;
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Items.AddRange(new object[] {
            "Asc",
            "Des"});
            this.materialComboBox2.Location = new System.Drawing.Point(59, 27);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(87, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 19;
            // 
            // cmbboxCatg
            // 
            this.cmbboxCatg.AutoResize = false;
            this.cmbboxCatg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbboxCatg.Depth = 0;
            this.cmbboxCatg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbboxCatg.DropDownHeight = 174;
            this.cmbboxCatg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxCatg.DropDownWidth = 121;
            this.cmbboxCatg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbboxCatg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbboxCatg.FormattingEnabled = true;
            this.cmbboxCatg.IntegralHeight = false;
            this.cmbboxCatg.ItemHeight = 43;
            this.cmbboxCatg.Items.AddRange(new object[] {
            "Date",
            "Room Id",
            "User",
            "Price",
            "Electric",
            "Water",
            "Rent"});
            this.cmbboxCatg.Location = new System.Drawing.Point(152, 27);
            this.cmbboxCatg.MaxDropDownItems = 4;
            this.cmbboxCatg.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbboxCatg.Name = "cmbboxCatg";
            this.cmbboxCatg.Size = new System.Drawing.Size(87, 49);
            this.cmbboxCatg.StartIndex = 0;
            this.cmbboxCatg.TabIndex = 18;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel12.Location = new System.Drawing.Point(669, 600);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(196, 41);
            this.materialLabel12.TabIndex = 17;
            this.materialLabel12.Text = "Bills Manage";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = global::AccommodationManagerApp.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(823, 34);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(106, 36);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseCompatibleTextRendering = true;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.AnimateReadOnly = false;
            this.txtBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSearch.Depth = 0;
            this.txtBoxSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Transparent;
            this.txtBoxSearch.Hint = "Search";
            this.txtBoxSearch.LeadingIcon = null;
            this.txtBoxSearch.Location = new System.Drawing.Point(246, 26);
            this.txtBoxSearch.MaxLength = 50;
            this.txtBoxSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxSearch.Multiline = false;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(562, 50);
            this.txtBoxSearch.TabIndex = 15;
            this.txtBoxSearch.Text = "";
            this.txtBoxSearch.TrailingIcon = null;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = global::AccommodationManagerApp.Properties.Resources.edit;
            this.materialButton2.Location = new System.Drawing.Point(223, 605);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(78, 36);
            this.materialButton2.TabIndex = 4;
            this.materialButton2.Text = "UPD";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = global::AccommodationManagerApp.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(140, 605);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DEL";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = global::AccommodationManagerApp.Properties.Resources.plus1;
            this.btnAdd.Location = new System.Drawing.Point(54, 605);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(78, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPDF
            // 
            this.btnPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPDF.Depth = 0;
            this.btnPDF.HighEmphasis = true;
            this.btnPDF.Icon = global::AccommodationManagerApp.Properties.Resources.pdf;
            this.btnPDF.Location = new System.Drawing.Point(309, 605);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPDF.Size = new System.Drawing.Size(77, 36);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.Text = "PDF";
            this.btnPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPDF.UseAccentColor = false;
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // lstViewBill
            // 
            this.lstViewBill.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstViewBill.AutoSizeTable = false;
            this.lstViewBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstViewBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.rent,
            this.water,
            this.electricity,
            this.total,
            this.room,
            this.date});
            this.lstViewBill.Depth = 0;
            this.lstViewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lstViewBill.FullRowSelect = true;
            this.lstViewBill.HideSelection = false;
            this.lstViewBill.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstViewBill.Location = new System.Drawing.Point(3, 100);
            this.lstViewBill.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstViewBill.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstViewBill.MouseState = MaterialSkin.MouseState.OUT;
            this.lstViewBill.Name = "lstViewBill";
            this.lstViewBill.OwnerDraw = true;
            this.lstViewBill.ShowGroups = false;
            this.lstViewBill.Size = new System.Drawing.Size(983, 474);
            this.lstViewBill.TabIndex = 0;
            this.lstViewBill.UseCompatibleStateImageBehavior = false;
            this.lstViewBill.View = System.Windows.Forms.View.Details;
            this.lstViewBill.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LstViewBill_ItemSelectionChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 50;
            // 
            // rent
            // 
            this.rent.Text = "Rent";
            this.rent.Width = 150;
            // 
            // water
            // 
            this.water.Text = "Water";
            this.water.Width = 150;
            // 
            // electricity
            // 
            this.electricity.Text = "Electricity";
            this.electricity.Width = 150;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 150;
            // 
            // room
            // 
            this.room.Text = "Room ID";
            this.room.Width = 150;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 100;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogOut.Depth = 0;
            this.btnLogOut.HighEmphasis = true;
            this.btnLogOut.Icon = global::AccommodationManagerApp.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(798, 25);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogOut.Size = new System.Drawing.Size(110, 36);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogOut.UseAccentColor = false;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // mySqlConnection1
            // 
            this.mySqlConnection1.ProvideClientCertificatesCallback = null;
            this.mySqlConnection1.ProvidePasswordCallback = null;
            this.mySqlConnection1.RemoteCertificateValidationCallback = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
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
            this.tabPageRoom.ResumeLayout(false);
            this.tabPageRoom.PerformLayout();
            this.tabPageBuilding.ResumeLayout(false);
            this.tabPageBuilding.PerformLayout();
            this.materialTabControl.ResumeLayout(false);
            this.tabPageBills.ResumeLayout(false);
            this.tabPageBills.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList drawerImageList;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.TabPage tabPageSystemUsers;
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
        private System.Windows.Forms.TabPage tabPageBills;
        private MaterialSkin.Controls.MaterialListView lstViewBill;
        private MySqlConnector.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader rent;
        private System.Windows.Forms.ColumnHeader water;
        private System.Windows.Forms.ColumnHeader electricity;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader room;
        private System.Windows.Forms.ColumnHeader date;
        private MaterialSkin.Controls.MaterialButton btnPDF;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialTextBox txtBoxSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private MaterialSkin.Controls.MaterialComboBox cmbboxCatg;
    }
}