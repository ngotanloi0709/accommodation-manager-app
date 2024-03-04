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
            this.tabPageUnits = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.ListViewUnit = new MaterialSkin.Controls.MaterialListView();
            this.IdColumnDashboard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumnDashboard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BuildingColumnDashboard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreatedAtColumnDashboard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageDash = new System.Windows.Forms.TabPage();
            this.tabPageTenants = new System.Windows.Forms.TabPage();
            this.tabPageInvoices = new System.Windows.Forms.TabPage();
            this.tabPageSystemUsers = new System.Windows.Forms.TabPage();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.tabPageUnits.SuspendLayout();
            this.materialTabControl.SuspendLayout();
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
            // tabPageUnits
            // 
            this.tabPageUnits.BackColor = System.Drawing.Color.White;
            this.tabPageUnits.Controls.Add(this.materialButton2);
            this.tabPageUnits.Controls.Add(this.materialButton1);
            this.tabPageUnits.Controls.Add(this.materialTextBox1);
            this.tabPageUnits.Controls.Add(this.ListViewUnit);
            this.tabPageUnits.ForeColor = System.Drawing.Color.Transparent;
            this.tabPageUnits.ImageKey = "home.png";
            this.tabPageUnits.Location = new System.Drawing.Point(4, 39);
            this.tabPageUnits.Name = "tabPageUnits";
            this.tabPageUnits.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUnits.Size = new System.Drawing.Size(986, 673);
            this.tabPageUnits.TabIndex = 0;
            this.tabPageUnits.Text = "Units";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.ForeColor = System.Drawing.Color.Transparent;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(591, 23);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(207, 36);
            this.materialButton2.TabIndex = 3;
            this.materialButton2.Text = "Manage House Feature";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.ForeColor = System.Drawing.Color.Transparent;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(835, 23);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(75, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Add";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.materialTextBox1.Hint = "Search";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(24, 23);
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
            this.ListViewUnit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumnDashboard,
            this.NameColumnDashboard,
            this.BuildingColumnDashboard,
            this.CreatedAtColumnDashboard});
            this.ListViewUnit.Depth = 0;
            this.ListViewUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ListViewUnit.FullRowSelect = true;
            this.ListViewUnit.GridLines = true;
            this.ListViewUnit.HideSelection = false;
            this.ListViewUnit.Location = new System.Drawing.Point(1, 102);
            this.ListViewUnit.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewUnit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewUnit.Name = "ListViewUnit";
            this.ListViewUnit.OwnerDraw = true;
            this.ListViewUnit.Size = new System.Drawing.Size(985, 572);
            this.ListViewUnit.TabIndex = 0;
            this.ListViewUnit.UseCompatibleStateImageBehavior = false;
            this.ListViewUnit.View = System.Windows.Forms.View.Details;
            this.ListViewUnit.ItemActivate += new System.EventHandler(this.UnitListView_ItemActivate);
            // 
            // IdColumnDashboard
            // 
            this.IdColumnDashboard.Text = "Id";
            this.IdColumnDashboard.Width = 90;
            // 
            // NameColumnDashboard
            // 
            this.NameColumnDashboard.Text = "Name";
            this.NameColumnDashboard.Width = 307;
            // 
            // BuildingColumnDashboard
            // 
            this.BuildingColumnDashboard.Text = "Building";
            this.BuildingColumnDashboard.Width = 257;
            // 
            // CreatedAtColumnDashboard
            // 
            this.CreatedAtColumnDashboard.Text = "Date Created";
            this.CreatedAtColumnDashboard.Width = 324;
            // 
            // materialTabControl
            // 
            this.materialTabControl.Controls.Add(this.tabPageDash);
            this.materialTabControl.Controls.Add(this.tabPageUnits);
            this.materialTabControl.Controls.Add(this.tabPageTenants);
            this.materialTabControl.Controls.Add(this.tabPageInvoices);
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
            // tabPageDash
            // 
            this.tabPageDash.ImageKey = "dashboard.png";
            this.tabPageDash.Location = new System.Drawing.Point(4, 39);
            this.tabPageDash.Name = "tabPageDash";
            this.tabPageDash.Size = new System.Drawing.Size(986, 673);
            this.tabPageDash.TabIndex = 1;
            this.tabPageDash.Text = "Dashboard";
            this.tabPageDash.UseVisualStyleBackColor = true;
            // 
            // tabPageTenants
            // 
            this.tabPageTenants.BackColor = System.Drawing.Color.White;
            this.tabPageTenants.ImageKey = "house-owner.png";
            this.tabPageTenants.Location = new System.Drawing.Point(4, 39);
            this.tabPageTenants.Name = "tabPageTenants";
            this.tabPageTenants.Size = new System.Drawing.Size(986, 673);
            this.tabPageTenants.TabIndex = 2;
            this.tabPageTenants.Text = "Tenants";
            // 
            // tabPageInvoices
            // 
            this.tabPageInvoices.BackColor = System.Drawing.Color.White;
            this.tabPageInvoices.ImageKey = "invoice.png";
            this.tabPageInvoices.Location = new System.Drawing.Point(4, 39);
            this.tabPageInvoices.Name = "tabPageInvoices";
            this.tabPageInvoices.Size = new System.Drawing.Size(986, 673);
            this.tabPageInvoices.TabIndex = 3;
            this.tabPageInvoices.Text = "Invoices";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.materialTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 80, 3, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.tabPageUnits.ResumeLayout(false);
            this.materialTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList drawerImageList;
        private System.Windows.Forms.TabPage tabPageUnits;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tabPageDash;
        private System.Windows.Forms.TabPage tabPageTenants;
        private System.Windows.Forms.TabPage tabPageInvoices;
        private System.Windows.Forms.TabPage tabPageSystemUsers;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private MaterialSkin.Controls.MaterialListView ListViewUnit;
        private System.Windows.Forms.ColumnHeader IdColumnDashboard;
        private System.Windows.Forms.ColumnHeader NameColumnDashboard;
        private System.Windows.Forms.ColumnHeader BuildingColumnDashboard;
        private System.Windows.Forms.ColumnHeader CreatedAtColumnDashboard;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}