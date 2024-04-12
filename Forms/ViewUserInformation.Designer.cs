namespace AccommodationManagerApp.Forms
{
    partial class ViewUserInformation
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
            this.btnRoomInfor = new MaterialSkin.Controls.MaterialButton();
            this.btnTransactionHistory = new MaterialSkin.Controls.MaterialButton();
            this.btnCheckVehicles = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnRoomInfor
            // 
            this.btnRoomInfor.AutoSize = false;
            this.btnRoomInfor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRoomInfor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRoomInfor.Depth = 0;
            this.btnRoomInfor.HighEmphasis = true;
            this.btnRoomInfor.Icon = global::AccommodationManagerApp.Properties.Resources.search;
            this.btnRoomInfor.Location = new System.Drawing.Point(27, 238);
            this.btnRoomInfor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRoomInfor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRoomInfor.Name = "btnRoomInfor";
            this.btnRoomInfor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRoomInfor.Size = new System.Drawing.Size(337, 35);
            this.btnRoomInfor.TabIndex = 40;
            this.btnRoomInfor.Text = "Truy xuất thông tin phòng";
            this.btnRoomInfor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRoomInfor.UseAccentColor = false;
            this.btnRoomInfor.UseVisualStyleBackColor = true;
            this.btnRoomInfor.Click += new System.EventHandler(this.btnRoomInfor_Click);
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.AutoSize = false;
            this.btnTransactionHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTransactionHistory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTransactionHistory.Depth = 0;
            this.btnTransactionHistory.HighEmphasis = true;
            this.btnTransactionHistory.Icon = global::AccommodationManagerApp.Properties.Resources.invoice;
            this.btnTransactionHistory.Location = new System.Drawing.Point(27, 193);
            this.btnTransactionHistory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTransactionHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTransactionHistory.Size = new System.Drawing.Size(337, 35);
            this.btnTransactionHistory.TabIndex = 39;
            this.btnTransactionHistory.Text = "Truy xuất lịch sử thanh toán";
            this.btnTransactionHistory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTransactionHistory.UseAccentColor = false;
            this.btnTransactionHistory.UseVisualStyleBackColor = true;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // btnCheckVehicles
            // 
            this.btnCheckVehicles.AutoSize = false;
            this.btnCheckVehicles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckVehicles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCheckVehicles.Depth = 0;
            this.btnCheckVehicles.HighEmphasis = true;
            this.btnCheckVehicles.Icon = global::AccommodationManagerApp.Properties.Resources.view;
            this.btnCheckVehicles.Location = new System.Drawing.Point(27, 147);
            this.btnCheckVehicles.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCheckVehicles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckVehicles.Name = "btnCheckVehicles";
            this.btnCheckVehicles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCheckVehicles.Size = new System.Drawing.Size(337, 36);
            this.btnCheckVehicles.TabIndex = 38;
            this.btnCheckVehicles.Text = "Truy xuất thông tin phương tiện";
            this.btnCheckVehicles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCheckVehicles.UseAccentColor = false;
            this.btnCheckVehicles.UseVisualStyleBackColor = true;
            this.btnCheckVehicles.Click += new System.EventHandler(this.btnCheckVehicles_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel10.Location = new System.Drawing.Point(18, 70);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(245, 72);
            this.materialLabel10.TabIndex = 41;
            this.materialLabel10.Text = "Tùy chọn";
            // 
            // ViewUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 298);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.btnRoomInfor);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.btnCheckVehicles);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(389, 298);
            this.MinimumSize = new System.Drawing.Size(389, 298);
            this.Name = "ViewUserInformation";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "ViewUserInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnRoomInfor;
        private MaterialSkin.Controls.MaterialButton btnTransactionHistory;
        private MaterialSkin.Controls.MaterialButton btnCheckVehicles;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
    }
}