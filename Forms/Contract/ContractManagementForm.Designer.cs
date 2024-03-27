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
            this.ListViewContract = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddContract = new MaterialSkin.Controls.MaterialButton();
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.labelDateEnd = new MaterialSkin.Controls.MaterialLabel();
            this.labelDateStart = new MaterialSkin.Controls.MaterialLabel();
            this.labelPrice = new MaterialSkin.Controls.MaterialLabel();
            this.labelRoomNumber = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonEditContract = new MaterialSkin.Controls.MaterialButton();
            this.buttonExtendContract = new MaterialSkin.Controls.MaterialButton();
            this.buttonTerminateContract = new MaterialSkin.Controls.MaterialButton();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListViewContract
            // 
            this.ListViewContract.AutoSizeTable = false;
            this.ListViewContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewContract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewContract.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader4});
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
            this.ListViewContract.Size = new System.Drawing.Size(538, 479);
            this.ListViewContract.TabIndex = 0;
            this.ListViewContract.UseCompatibleStateImageBehavior = false;
            this.ListViewContract.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên người thuê";
            this.columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Đơn giá";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "Ngày bắt đầu";
            this.columnHeader3.Width = 120;
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
            this.buttonAddContract.Location = new System.Drawing.Point(699, 308);
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
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Depth = 0;
            this.labelName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelName.Location = new System.Drawing.Point(695, 88);
            this.labelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(217, 24);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "________________________";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel16.Location = new System.Drawing.Point(548, 88);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(141, 24);
            this.materialLabel16.TabIndex = 22;
            this.materialLabel16.Text = "Tên người thuê:";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.BackColor = System.Drawing.Color.Transparent;
            this.labelDateEnd.Depth = 0;
            this.labelDateEnd.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelDateEnd.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelDateEnd.Location = new System.Drawing.Point(695, 259);
            this.labelDateEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(217, 24);
            this.labelDateEnd.TabIndex = 21;
            this.labelDateEnd.Text = "________________________";
            // 
            // labelDateStart
            // 
            this.labelDateStart.AutoSize = true;
            this.labelDateStart.BackColor = System.Drawing.Color.Transparent;
            this.labelDateStart.Depth = 0;
            this.labelDateStart.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelDateStart.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelDateStart.Location = new System.Drawing.Point(695, 215);
            this.labelDateStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(217, 24);
            this.labelDateStart.TabIndex = 20;
            this.labelDateStart.Text = "________________________";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Depth = 0;
            this.labelPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelPrice.Location = new System.Drawing.Point(695, 170);
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
            this.labelRoomNumber.Location = new System.Drawing.Point(695, 129);
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
            this.materialLabel8.Location = new System.Drawing.Point(547, 215);
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
            this.materialLabel7.Location = new System.Drawing.Point(547, 259);
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
            this.materialLabel5.Location = new System.Drawing.Point(548, 170);
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
            this.materialLabel1.Location = new System.Drawing.Point(548, 129);
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
            this.buttonEditContract.Location = new System.Drawing.Point(699, 356);
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
            this.buttonExtendContract.Location = new System.Drawing.Point(699, 452);
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
            this.buttonTerminateContract.Location = new System.Drawing.Point(699, 404);
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
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 4;
            this.columnHeader6.Text = "Hiệu lực";
            this.columnHeader6.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 1;
            this.columnHeader4.Text = "Số phòng";
            this.columnHeader4.Width = 100;
            // 
            // ContractManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(959, 546);
            this.Controls.Add(this.buttonTerminateContract);
            this.Controls.Add(this.buttonExtendContract);
            this.Controls.Add(this.buttonEditContract);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.labelDateStart);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelRoomNumber);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonAddContract);
            this.Controls.Add(this.ListViewContract);
            this.MaximumSize = new System.Drawing.Size(959, 546);
            this.MinimumSize = new System.Drawing.Size(959, 546);
            this.Name = "ContractManagementForm";
            this.Sizable = false;
            this.Text = "Quản lý hợp đồng thuê nhà";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView ListViewContract;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialButton buttonAddContract;
        private MaterialSkin.Controls.MaterialLabel labelName;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel labelDateEnd;
        private MaterialSkin.Controls.MaterialLabel labelDateStart;
        private MaterialSkin.Controls.MaterialLabel labelPrice;
        private MaterialSkin.Controls.MaterialLabel labelRoomNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton buttonEditContract;
        private MaterialSkin.Controls.MaterialButton buttonExtendContract;
        private MaterialSkin.Controls.MaterialButton buttonTerminateContract;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}