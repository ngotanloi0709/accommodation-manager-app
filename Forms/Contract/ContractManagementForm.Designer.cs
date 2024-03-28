using System.ComponentModel;

namespace AccommodationManagerApp.Forms {
    partial class ContractManagementForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonAddContract = new MaterialSkin.Controls.MaterialButton();
            this.labelTenantName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.labelEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.labelStartDate = new MaterialSkin.Controls.MaterialLabel();
            this.labelPrice = new MaterialSkin.Controls.MaterialLabel();
            this.labelRoomNumber = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonEditContract = new MaterialSkin.Controls.MaterialButton();
            this.buttonExtendContract = new MaterialSkin.Controls.MaterialButton();
            this.buttonTerminateContract = new MaterialSkin.Controls.MaterialButton();
            this.ListViewContract = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelIsTerminated = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonDelete = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // buttonAddContract
            // 
            this.buttonAddContract.AutoSize = false;
            this.buttonAddContract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddContract.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddContract.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAddContract.Depth = 0;
            this.buttonAddContract.HighEmphasis = true;
            this.buttonAddContract.Icon = global::AccommodationManagerApp.Properties.Resources.plus;
            this.buttonAddContract.Location = new System.Drawing.Point(771, 359);
            this.buttonAddContract.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAddContract.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddContract.Name = "buttonAddContract";
            this.buttonAddContract.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAddContract.Size = new System.Drawing.Size(213, 36);
            this.buttonAddContract.TabIndex = 1;
            this.buttonAddContract.Text = "Thêm hợp đồng";
            this.buttonAddContract.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAddContract.UseAccentColor = false;
            this.buttonAddContract.UseVisualStyleBackColor = false;
            this.buttonAddContract.Click += new System.EventHandler(this.buttonAddContract_Click);
            // 
            // labelTenantName
            // 
            this.labelTenantName.AutoSize = true;
            this.labelTenantName.BackColor = System.Drawing.Color.Transparent;
            this.labelTenantName.Depth = 0;
            this.labelTenantName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTenantName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelTenantName.Location = new System.Drawing.Point(767, 86);
            this.labelTenantName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTenantName.Name = "labelTenantName";
            this.labelTenantName.Size = new System.Drawing.Size(217, 24);
            this.labelTenantName.TabIndex = 23;
            this.labelTenantName.Text = "________________________";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel16.Location = new System.Drawing.Point(620, 86);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(141, 24);
            this.materialLabel16.TabIndex = 22;
            this.materialLabel16.Text = "Tên người thuê:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.BackColor = System.Drawing.Color.Transparent;
            this.labelEndDate.Depth = 0;
            this.labelEndDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelEndDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelEndDate.Location = new System.Drawing.Point(767, 257);
            this.labelEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(217, 24);
            this.labelEndDate.TabIndex = 21;
            this.labelEndDate.Text = "________________________";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.BackColor = System.Drawing.Color.Transparent;
            this.labelStartDate.Depth = 0;
            this.labelStartDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelStartDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelStartDate.Location = new System.Drawing.Point(767, 213);
            this.labelStartDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(217, 24);
            this.labelStartDate.TabIndex = 20;
            this.labelStartDate.Text = "________________________";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Depth = 0;
            this.labelPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelPrice.Location = new System.Drawing.Point(767, 168);
            this.labelPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(217, 24);
            this.labelPrice.TabIndex = 19;
            this.labelPrice.Text = "________________________";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelRoomNumber.Depth = 0;
            this.labelRoomNumber.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRoomNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelRoomNumber.Location = new System.Drawing.Point(767, 127);
            this.labelRoomNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(217, 24);
            this.labelRoomNumber.TabIndex = 18;
            this.labelRoomNumber.Text = "________________________";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(619, 213);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(125, 24);
            this.materialLabel8.TabIndex = 17;
            this.materialLabel8.Text = "Ngày bắt đầu:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(619, 257);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(129, 24);
            this.materialLabel7.TabIndex = 16;
            this.materialLabel7.Text = "Ngày kết thúc:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(620, 168);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(74, 24);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Đơn giá:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(620, 127);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 24);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Số phòng:";
            // 
            // buttonEditContract
            // 
            this.buttonEditContract.AutoSize = false;
            this.buttonEditContract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditContract.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditContract.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEditContract.Depth = 0;
            this.buttonEditContract.HighEmphasis = true;
            this.buttonEditContract.Icon = global::AccommodationManagerApp.Properties.Resources.edit;
            this.buttonEditContract.Location = new System.Drawing.Point(771, 407);
            this.buttonEditContract.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEditContract.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEditContract.Name = "buttonEditContract";
            this.buttonEditContract.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEditContract.Size = new System.Drawing.Size(213, 36);
            this.buttonEditContract.TabIndex = 24;
            this.buttonEditContract.Text = "Sửa hợp đồng";
            this.buttonEditContract.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEditContract.UseAccentColor = false;
            this.buttonEditContract.UseVisualStyleBackColor = false;
            this.buttonEditContract.Click += new System.EventHandler(this.buttonEditContract_Click);
            // 
            // buttonExtendContract
            // 
            this.buttonExtendContract.AutoSize = false;
            this.buttonExtendContract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExtendContract.BackColor = System.Drawing.Color.Transparent;
            this.buttonExtendContract.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonExtendContract.Depth = 0;
            this.buttonExtendContract.HighEmphasis = true;
            this.buttonExtendContract.Icon = global::AccommodationManagerApp.Properties.Resources.contract;
            this.buttonExtendContract.Location = new System.Drawing.Point(771, 551);
            this.buttonExtendContract.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonExtendContract.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonExtendContract.Name = "buttonExtendContract";
            this.buttonExtendContract.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonExtendContract.Size = new System.Drawing.Size(213, 36);
            this.buttonExtendContract.TabIndex = 25;
            this.buttonExtendContract.Text = "Gia hạn hợp đồng";
            this.buttonExtendContract.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonExtendContract.UseAccentColor = false;
            this.buttonExtendContract.UseVisualStyleBackColor = false;
            this.buttonExtendContract.Click += new System.EventHandler(this.buttonExtendContract_Click);
            // 
            // buttonTerminateContract
            // 
            this.buttonTerminateContract.AutoSize = false;
            this.buttonTerminateContract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTerminateContract.BackColor = System.Drawing.Color.Transparent;
            this.buttonTerminateContract.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonTerminateContract.Depth = 0;
            this.buttonTerminateContract.HighEmphasis = true;
            this.buttonTerminateContract.Icon = global::AccommodationManagerApp.Properties.Resources.close;
            this.buttonTerminateContract.Location = new System.Drawing.Point(771, 455);
            this.buttonTerminateContract.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonTerminateContract.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonTerminateContract.Name = "buttonTerminateContract";
            this.buttonTerminateContract.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonTerminateContract.Size = new System.Drawing.Size(213, 36);
            this.buttonTerminateContract.TabIndex = 26;
            this.buttonTerminateContract.Text = "Kết thúc hợp đồng";
            this.buttonTerminateContract.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonTerminateContract.UseAccentColor = false;
            this.buttonTerminateContract.UseVisualStyleBackColor = false;
            this.buttonTerminateContract.Click += new System.EventHandler(this.buttonTerminateContract_Click);
            // 
            // ListViewContract
            // 
            this.ListViewContract.AutoSizeTable = false;
            this.ListViewContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewContract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewContract.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.ListViewContract.Depth = 0;
            this.ListViewContract.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListViewContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ListViewContract.FullRowSelect = true;
            this.ListViewContract.HideSelection = false;
            this.ListViewContract.Location = new System.Drawing.Point(3, 64);
            this.ListViewContract.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewContract.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewContract.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewContract.Name = "ListViewContract";
            this.ListViewContract.OwnerDraw = true;
            this.ListViewContract.Size = new System.Drawing.Size(597, 569);
            this.ListViewContract.TabIndex = 27;
            this.ListViewContract.UseCompatibleStateImageBehavior = false;
            this.ListViewContract.View = System.Windows.Forms.View.Details;
            this.ListViewContract.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewContract_ItemSelectionChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên người thuê";
            this.columnHeader5.Width = 144;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số phòng";
            this.columnHeader7.Width = 105;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Đơn giá";
            this.columnHeader8.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ngày bắt đầu";
            this.columnHeader9.Width = 153;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Hiệu lực";
            this.columnHeader10.Width = 98;
            // 
            // labelIsTerminated
            // 
            this.labelIsTerminated.AutoSize = true;
            this.labelIsTerminated.BackColor = System.Drawing.Color.Transparent;
            this.labelIsTerminated.Depth = 0;
            this.labelIsTerminated.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelIsTerminated.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelIsTerminated.Location = new System.Drawing.Point(767, 302);
            this.labelIsTerminated.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelIsTerminated.Name = "labelIsTerminated";
            this.labelIsTerminated.Size = new System.Drawing.Size(217, 24);
            this.labelIsTerminated.TabIndex = 29;
            this.labelIsTerminated.Text = "________________________";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(619, 302);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 24);
            this.materialLabel3.TabIndex = 28;
            this.materialLabel3.Text = "Hiệu lực:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = false;
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonDelete.Depth = 0;
            this.buttonDelete.HighEmphasis = true;
            this.buttonDelete.Icon = global::AccommodationManagerApp.Properties.Resources.delete;
            this.buttonDelete.Location = new System.Drawing.Point(771, 503);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonDelete.Size = new System.Drawing.Size(213, 36);
            this.buttonDelete.TabIndex = 30;
            this.buttonDelete.Text = "Xoá hợp đồng";
            this.buttonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonDelete.UseAccentColor = false;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ContractManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1052, 636);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelIsTerminated);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.ListViewContract);
            this.Controls.Add(this.buttonTerminateContract);
            this.Controls.Add(this.buttonExtendContract);
            this.Controls.Add(this.buttonEditContract);
            this.Controls.Add(this.labelTenantName);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelRoomNumber);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonAddContract);
            this.MinimumSize = new System.Drawing.Size(959, 546);
            this.Name = "ContractManagementForm";
            this.Sizable = false;
            this.Text = "Quản lý hợp đồng thuê nhà";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton buttonAddContract;
        private MaterialSkin.Controls.MaterialLabel labelTenantName;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel labelEndDate;
        private MaterialSkin.Controls.MaterialLabel labelStartDate;
        private MaterialSkin.Controls.MaterialLabel labelPrice;
        private MaterialSkin.Controls.MaterialLabel labelRoomNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton buttonEditContract;
        private MaterialSkin.Controls.MaterialButton buttonExtendContract;
        private MaterialSkin.Controls.MaterialButton buttonTerminateContract;
        private MaterialSkin.Controls.MaterialListView ListViewContract;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private MaterialSkin.Controls.MaterialLabel labelIsTerminated;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton buttonDelete;
    }
}