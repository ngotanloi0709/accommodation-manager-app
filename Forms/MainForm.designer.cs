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
            this.tabPageRoom = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.ListViewUnit = new MaterialSkin.Controls.MaterialListView();
            this.colRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomTenant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageDash = new System.Windows.Forms.TabPage();
            this.tabPageTenants = new System.Windows.Forms.TabPage();
            this.tabPageInvoices = new System.Windows.Forms.TabPage();
            this.exportPdfButton = new System.Windows.Forms.Button();
            this.tabPageSystemUsers = new System.Windows.Forms.TabPage();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.ListViewBuilding = new MaterialSkin.Controls.MaterialListView();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageRoom.SuspendLayout();
            this.materialTabControl.SuspendLayout();
            this.tabPageDash.SuspendLayout();
            this.tabPageInvoices.SuspendLayout();
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
            // tabPageRoom
            // 
            this.tabPageRoom.BackColor = System.Drawing.Color.White;
            this.tabPageRoom.Controls.Add(this.materialLabel1);
            this.tabPageRoom.Controls.Add(this.materialTextBox1);
            this.tabPageRoom.Controls.Add(this.materialFloatingActionButton1);
            this.tabPageRoom.Controls.Add(this.ListViewUnit);
            this.tabPageRoom.ForeColor = System.Drawing.Color.Transparent;
            this.tabPageRoom.ImageKey = "home.png";
            this.tabPageRoom.Location = new System.Drawing.Point(4, 39);
            this.tabPageRoom.Name = "tabPageRoom";
            this.tabPageRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoom.Size = new System.Drawing.Size(873, 673);
            this.tabPageRoom.TabIndex = 0;
            this.tabPageRoom.Text = "Quản lý căn hộ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(589, 110);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Số nhà";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.materialTextBox1.Hint = "Tìm kiếm";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(605, 30);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(244, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // ListViewUnit
            // 
            this.ListViewUnit.AutoArrange = false;
            this.ListViewUnit.AutoSizeTable = false;
            this.ListViewUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewUnit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoomNumber,
            this.colRoomTenant,
            this.colRoomStatus});
            this.ListViewUnit.Depth = 0;
            this.ListViewUnit.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListViewUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ListViewUnit.FullRowSelect = true;
            this.ListViewUnit.HideSelection = false;
            this.ListViewUnit.Location = new System.Drawing.Point(3, 3);
            this.ListViewUnit.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewUnit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewUnit.Name = "ListViewUnit";
            this.ListViewUnit.OwnerDraw = true;
            this.ListViewUnit.Size = new System.Drawing.Size(552, 667);
            this.ListViewUnit.TabIndex = 0;
            this.ListViewUnit.UseCompatibleStateImageBehavior = false;
            this.ListViewUnit.View = System.Windows.Forms.View.Details;
            this.ListViewUnit.ItemActivate += new System.EventHandler(this.UnitListView_ItemActivate);
            // 
            // colRoomNumber
            // 
            this.colRoomNumber.Text = "Số nhà";
            this.colRoomNumber.Width = 139;
            // 
            // colRoomTenant
            // 
            this.colRoomTenant.Text = "Người thuê";
            this.colRoomTenant.Width = 121;
            // 
            // colRoomStatus
            // 
            this.colRoomStatus.Text = "Trạng thái";
            this.colRoomStatus.Width = 138;
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.tabPageDash);
            this.materialTabControl.Controls.Add(this.tabPageRoom);
            this.materialTabControl.Controls.Add(this.tabPageTenants);
            this.materialTabControl.Controls.Add(this.tabPageInvoices);
            this.materialTabControl.Controls.Add(this.tabPageSystemUsers);
            this.materialTabControl.Controls.Add(this.tabPageConfiguration);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialTabControl.ImageList = this.drawerImageList;
            this.materialTabControl.Location = new System.Drawing.Point(3, 80);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(881, 716);
            this.materialTabControl.TabIndex = 0;
            // 
            // tabPageDash
            // 
            this.tabPageDash.BackColor = System.Drawing.Color.White;
            this.tabPageDash.Controls.Add(this.materialButton1);
            this.tabPageDash.Controls.Add(this.ListViewBuilding);
            this.tabPageDash.ImageKey = "dashboard.png";
            this.tabPageDash.Location = new System.Drawing.Point(4, 39);
            this.tabPageDash.Name = "tabPageDash";
            this.tabPageDash.Size = new System.Drawing.Size(873, 673);
            this.tabPageDash.TabIndex = 1;
            this.tabPageDash.Text = "Dashboard";
            // 
            // tabPageTenants
            // 
            this.tabPageTenants.BackColor = System.Drawing.Color.White;
            this.tabPageTenants.ImageKey = "house-owner.png";
            this.tabPageTenants.Location = new System.Drawing.Point(4, 39);
            this.tabPageTenants.Name = "tabPageTenants";
            this.tabPageTenants.Size = new System.Drawing.Size(873, 673);
            this.tabPageTenants.TabIndex = 2;
            this.tabPageTenants.Text = "Tenants";
            // 
            // tabPageInvoices
            // 
            this.tabPageInvoices.BackColor = System.Drawing.Color.White;
            this.tabPageInvoices.Controls.Add(this.exportPdfButton);
            this.tabPageInvoices.ImageKey = "invoice.png";
            this.tabPageInvoices.Location = new System.Drawing.Point(4, 39);
            this.tabPageInvoices.Name = "tabPageInvoices";
            this.tabPageInvoices.Size = new System.Drawing.Size(873, 673);
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
            // tabPageSystemUsers
            // 
            this.tabPageSystemUsers.BackColor = System.Drawing.Color.White;
            this.tabPageSystemUsers.ImageKey = "customer.png";
            this.tabPageSystemUsers.Location = new System.Drawing.Point(4, 39);
            this.tabPageSystemUsers.Name = "tabPageSystemUsers";
            this.tabPageSystemUsers.Size = new System.Drawing.Size(873, 673);
            this.tabPageSystemUsers.TabIndex = 4;
            this.tabPageSystemUsers.Text = "System Users";
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.BackColor = System.Drawing.Color.White;
            this.tabPageConfiguration.ImageKey = "setting.png";
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 39);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Size = new System.Drawing.Size(873, 673);
            this.tabPageConfiguration.TabIndex = 5;
            this.tabPageConfiguration.Text = "Configuration";
            // 
            // ListViewBuilding
            // 
            this.ListViewBuilding.AutoSizeTable = false;
            this.ListViewBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewBuilding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewBuilding.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListViewBuilding.Depth = 0;
            this.ListViewBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ListViewBuilding.FullRowSelect = true;
            this.ListViewBuilding.GridLines = true;
            this.ListViewBuilding.HideSelection = false;
            this.ListViewBuilding.Location = new System.Drawing.Point(-1, 0);
            this.ListViewBuilding.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewBuilding.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewBuilding.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewBuilding.Name = "ListViewBuilding";
            this.ListViewBuilding.OwnerDraw = true;
            this.ListViewBuilding.Size = new System.Drawing.Size(345, 100);
            this.ListViewBuilding.TabIndex = 0;
            this.ListViewBuilding.UseCompatibleStateImageBehavior = false;
            this.ListViewBuilding.View = System.Windows.Forms.View.Details;
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = global::AccommodationManagerApp.Properties.Resources.plus;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(448, 582);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 2;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 71;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(409, 24);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(380, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Thêm toà chung cư mới vào danh sách quản lý";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên toà nhà";
            this.columnHeader2.Width = 250;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.materialTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 3, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.tabPageRoom.ResumeLayout(false);
            this.tabPageRoom.PerformLayout();
            this.materialTabControl.ResumeLayout(false);
            this.tabPageDash.ResumeLayout(false);
            this.tabPageInvoices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList drawerImageList;
        private System.Windows.Forms.TabPage tabPageRoom;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageDash;
        private System.Windows.Forms.TabPage tabPageTenants;
        private System.Windows.Forms.TabPage tabPageInvoices;
        private System.Windows.Forms.TabPage tabPageSystemUsers;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private MaterialSkin.Controls.MaterialListView ListViewUnit;
        private System.Windows.Forms.ColumnHeader colRoomNumber;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.Button exportPdfButton;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ColumnHeader colRoomTenant;
        private System.Windows.Forms.ColumnHeader colRoomStatus;
        private MaterialSkin.Controls.MaterialListView ListViewBuilding;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}