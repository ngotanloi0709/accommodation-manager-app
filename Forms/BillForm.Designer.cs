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
            this.txtbxWater = new MaterialSkin.Controls.MaterialTextBox();
            this.txtbxElectric = new MaterialSkin.Controls.MaterialTextBox();
            this.lblElectric = new MaterialSkin.Controls.MaterialLabel();
            this.lblWater = new MaterialSkin.Controls.MaterialLabel();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxRoom = new MaterialSkin.Controls.MaterialComboBox();
            this.buttonSave = new MaterialSkin.Controls.MaterialButton();
            this.labelRent = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
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
            // txtbxWater
            // 
            this.txtbxWater.AnimateReadOnly = false;
            this.txtbxWater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxWater.Depth = 0;
            this.txtbxWater.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbxWater.LeadingIcon = null;
            this.txtbxWater.Location = new System.Drawing.Point(134, 276);
            this.txtbxWater.MaxLength = 50;
            this.txtbxWater.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbxWater.Multiline = false;
            this.txtbxWater.Name = "txtbxWater";
            this.txtbxWater.Size = new System.Drawing.Size(207, 50);
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
            this.txtbxElectric.Location = new System.Drawing.Point(134, 348);
            this.txtbxElectric.MaxLength = 50;
            this.txtbxElectric.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbxElectric.Multiline = false;
            this.txtbxElectric.Name = "txtbxElectric";
            this.txtbxElectric.Size = new System.Drawing.Size(207, 50);
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
            this.lblElectric.Size = new System.Drawing.Size(69, 24);
            this.lblElectric.TabIndex = 8;
            this.lblElectric.Text = "Số Điện";
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
            this.lblWater.Size = new System.Drawing.Size(77, 24);
            this.lblWater.TabIndex = 9;
            this.lblWater.Text = "Số Nước";
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
            // comboBoxRoom
            // 
            this.comboBoxRoom.AutoResize = false;
            this.comboBoxRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxRoom.Depth = 0;
            this.comboBoxRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxRoom.DropDownHeight = 174;
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.DropDownWidth = 121;
            this.comboBoxRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.IntegralHeight = false;
            this.comboBoxRoom.ItemHeight = 43;
            this.comboBoxRoom.Location = new System.Drawing.Point(54, 212);
            this.comboBoxRoom.MaxDropDownItems = 4;
            this.comboBoxRoom.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(222, 49);
            this.comboBoxRoom.StartIndex = 0;
            this.comboBoxRoom.TabIndex = 12;
            this.comboBoxRoom.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoom_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = false;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSave.Depth = 0;
            this.buttonSave.HighEmphasis = true;
            this.buttonSave.Icon = global::AccommodationManagerApp.Properties.Resources.plus1;
            this.buttonSave.Location = new System.Drawing.Point(271, 434);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSave.Size = new System.Drawing.Size(95, 36);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Thêm";
            this.buttonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSave.UseAccentColor = false;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelRent
            // 
            this.labelRent.AutoSize = true;
            this.labelRent.Depth = 0;
            this.labelRent.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRent.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.labelRent.Location = new System.Drawing.Point(294, 222);
            this.labelRent.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(141, 29);
            this.labelRent.TabIndex = 26;
            this.labelRent.Text = "--------------------";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(349, 287);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 24);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "kWh/ Tháng";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(360, 357);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 24);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "m3/ Tháng";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 578);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.labelRent);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.lblElectric);
            this.Controls.Add(this.txtbxElectric);
            this.Controls.Add(this.txtbxWater);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "BillForm";
            this.Text = "Nhập Thông Tin Hóa Đơn";
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txtbxWater, 0);
            this.Controls.SetChildIndex(this.txtbxElectric, 0);
            this.Controls.SetChildIndex(this.lblElectric, 0);
            this.Controls.SetChildIndex(this.lblWater, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.comboBoxRoom, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.buttonSave, 0);
            this.Controls.SetChildIndex(this.labelRent, 0);
            this.Controls.SetChildIndex(this.materialLabel1, 0);
            this.Controls.SetChildIndex(this.materialLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected MaterialSkin.Controls.MaterialButton btnClose;
        protected MaterialSkin.Controls.MaterialTextBox txtbxWater;
        protected MaterialSkin.Controls.MaterialTextBox txtbxElectric;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        protected MaterialSkin.Controls.MaterialLabel lblDate;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected MaterialSkin.Controls.MaterialLabel lblElectric;
        protected MaterialSkin.Controls.MaterialLabel lblWater;
        protected MaterialSkin.Controls.MaterialComboBox comboBoxRoom;
        protected MaterialSkin.Controls.MaterialButton buttonSave;
        protected MaterialSkin.Controls.MaterialLabel labelRent;
        protected MaterialSkin.Controls.MaterialLabel materialLabel1;
        protected MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}