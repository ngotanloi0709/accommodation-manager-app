namespace AccommodationManagerApp.Forms.Bill
{
    partial class BillForm
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
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbboxRent = new MaterialSkin.Controls.MaterialComboBox();
            this.txtbxWater = new MaterialSkin.Controls.MaterialTextBox();
            this.txtbxElectric = new MaterialSkin.Controls.MaterialTextBox();
            this.lblElectric = new MaterialSkin.Controls.MaterialLabel();
            this.lblWater = new MaterialSkin.Controls.MaterialLabel();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.cmbboxRoom = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = global::AccommodationManagerApp.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(374, 434);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(95, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccommodationManagerApp.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(54, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmbboxRent
            // 
            this.cmbboxRent.AutoResize = false;
            this.cmbboxRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbboxRent.Depth = 0;
            this.cmbboxRent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbboxRent.DropDownHeight = 174;
            this.cmbboxRent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxRent.DropDownWidth = 121;
            this.cmbboxRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbboxRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbboxRent.FormattingEnabled = true;
            this.cmbboxRent.IntegralHeight = false;
            this.cmbboxRent.ItemHeight = 43;
            this.cmbboxRent.Items.AddRange(new object[] {
            "Phí Thuê Nhà",
            "1.000.000 vnd",
            "1.200.000 vnd",
            "1.500.000 vnd",
            "1.800.000 vnd",
            "2.000.000 vnd"});
            this.cmbboxRent.Location = new System.Drawing.Point(54, 210);
            this.cmbboxRent.MaxDropDownItems = 4;
            this.cmbboxRent.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbboxRent.Name = "cmbboxRent";
            this.cmbboxRent.Size = new System.Drawing.Size(196, 49);
            this.cmbboxRent.StartIndex = 0;
            this.cmbboxRent.TabIndex = 4;
            // 
            // txtbxWater
            // 
            this.txtbxWater.AnimateReadOnly = false;
            this.txtbxWater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxWater.Depth = 0;
            this.txtbxWater.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbxWater.LeadingIcon = null;
            this.txtbxWater.Location = new System.Drawing.Point(153, 276);
            this.txtbxWater.MaxLength = 50;
            this.txtbxWater.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbxWater.Multiline = false;
            this.txtbxWater.Name = "txtbxWater";
            this.txtbxWater.Size = new System.Drawing.Size(316, 50);
            this.txtbxWater.TabIndex = 6;
            this.txtbxWater.Text = "";
            this.txtbxWater.TrailingIcon = null;
            this.txtbxWater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxWater_KeyPress);
            // 
            // txtbxElectric
            // 
            this.txtbxElectric.AnimateReadOnly = false;
            this.txtbxElectric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxElectric.Depth = 0;
            this.txtbxElectric.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbxElectric.LeadingIcon = null;
            this.txtbxElectric.Location = new System.Drawing.Point(153, 343);
            this.txtbxElectric.MaxLength = 50;
            this.txtbxElectric.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbxElectric.Multiline = false;
            this.txtbxElectric.Name = "txtbxElectric";
            this.txtbxElectric.Size = new System.Drawing.Size(316, 50);
            this.txtbxElectric.TabIndex = 7;
            this.txtbxElectric.Text = "";
            this.txtbxElectric.TrailingIcon = null;
            this.txtbxElectric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxWater_KeyPress);
            // 
            // lblElectric
            // 
            this.lblElectric.AutoSize = true;
            this.lblElectric.Depth = 0;
            this.lblElectric.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblElectric.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblElectric.Location = new System.Drawing.Point(50, 287);
            this.lblElectric.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblElectric.Name = "lblElectric";
            this.lblElectric.Size = new System.Drawing.Size(85, 24);
            this.lblElectric.TabIndex = 8;
            this.lblElectric.Text = "Tiền Điện";
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Depth = 0;
            this.lblWater.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWater.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblWater.Location = new System.Drawing.Point(50, 357);
            this.lblWater.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(93, 24);
            this.lblWater.TabIndex = 9;
            this.lblWater.Text = "Tiền Nước";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblDate.Location = new System.Drawing.Point(160, 153);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 24);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Ngày Tạo: ";
            // 
            // cmbboxRoom
            // 
            this.cmbboxRoom.AutoResize = false;
            this.cmbboxRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbboxRoom.Depth = 0;
            this.cmbboxRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbboxRoom.DropDownHeight = 174;
            this.cmbboxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxRoom.DropDownWidth = 121;
            this.cmbboxRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbboxRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbboxRoom.FormattingEnabled = true;
            this.cmbboxRoom.IntegralHeight = false;
            this.cmbboxRoom.ItemHeight = 43;
            this.cmbboxRoom.Items.AddRange(new object[] {
            "Mã Phòng",
            "01",
            "02",
            "03"});
            this.cmbboxRoom.Location = new System.Drawing.Point(256, 210);
            this.cmbboxRoom.MaxDropDownItems = 4;
            this.cmbboxRoom.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbboxRoom.Name = "cmbboxRoom";
            this.cmbboxRoom.Size = new System.Drawing.Size(201, 49);
            this.cmbboxRoom.StartIndex = 0;
            this.cmbboxRoom.TabIndex = 12;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.cmbboxRoom);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.lblElectric);
            this.Controls.Add(this.txtbxElectric);
            this.Controls.Add(this.txtbxWater);
            this.Controls.Add(this.cmbboxRent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "BillForm";
            this.Text = "Nhập Thông Tin Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected MaterialSkin.Controls.MaterialButton btnClose;
        protected MaterialSkin.Controls.MaterialComboBox cmbboxRent;
        protected MaterialSkin.Controls.MaterialTextBox txtbxWater;
        protected MaterialSkin.Controls.MaterialTextBox txtbxElectric;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        protected MaterialSkin.Controls.MaterialLabel lblDate;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected MaterialSkin.Controls.MaterialLabel lblElectric;
        protected MaterialSkin.Controls.MaterialLabel lblWater;
        protected MaterialSkin.Controls.MaterialComboBox cmbboxRoom;
    }
}