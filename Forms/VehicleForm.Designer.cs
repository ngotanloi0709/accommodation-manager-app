namespace AccommodationManagerApp.Forms
{
    partial class VehicleForm
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonSave = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxRoom = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.buttonMinus = new MaterialSkin.Controls.MaterialButton();
            this.buttonPlus = new MaterialSkin.Controls.MaterialButton();
            this.textBoxPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.comboBoxVehiclePrice = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(34, 172);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(156, 24);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Loại phương tiện:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(38, 99);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(152, 24);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Tên phương tiện:";
            // 
            // textBoxName
            // 
            this.textBoxName.AnimateReadOnly = false;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Depth = 0;
            this.textBoxName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxName.Hint = "Nhập tên/loại/miêu tả cho phương tiện";
            this.textBoxName.LeadingIcon = null;
            this.textBoxName.Location = new System.Drawing.Point(262, 90);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(296, 50);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.Text = "";
            this.textBoxName.TrailingIcon = null;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = false;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSave.Depth = 0;
            this.buttonSave.HighEmphasis = true;
            this.buttonSave.Icon = null;
            this.buttonSave.Location = new System.Drawing.Point(471, 514);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSave.Size = new System.Drawing.Size(87, 36);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSave.UseAccentColor = false;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(34, 248);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(184, 24);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Biển số phương tiện:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.AnimateReadOnly = false;
            this.textBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumber.Depth = 0;
            this.textBoxNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxNumber.Hint = "Nhập biển số xe";
            this.textBoxNumber.LeadingIcon = null;
            this.textBoxNumber.Location = new System.Drawing.Point(262, 237);
            this.textBoxNumber.MaxLength = 50;
            this.textBoxNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxNumber.Multiline = false;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(296, 50);
            this.textBoxNumber.TabIndex = 10;
            this.textBoxNumber.Text = "";
            this.textBoxNumber.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(34, 450);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(260, 24);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Phương tiện thuộc căn hộ số:";
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
            this.comboBoxRoom.Location = new System.Drawing.Point(327, 438);
            this.comboBoxRoom.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRoom.MaxDropDownItems = 4;
            this.comboBoxRoom.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(231, 49);
            this.comboBoxRoom.StartIndex = 0;
            this.comboBoxRoom.TabIndex = 14;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.AutoResize = false;
            this.comboBoxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxCategory.Depth = 0;
            this.comboBoxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCategory.DropDownHeight = 174;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.DropDownWidth = 121;
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.IntegralHeight = false;
            this.comboBoxCategory.ItemHeight = 43;
            this.comboBoxCategory.Location = new System.Drawing.Point(262, 162);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategory.MaxDropDownItems = 4;
            this.comboBoxCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(298, 49);
            this.comboBoxCategory.StartIndex = 0;
            this.comboBoxCategory.TabIndex = 15;
            // 
            // buttonMinus
            // 
            this.buttonMinus.AutoSize = false;
            this.buttonMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMinus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonMinus.Depth = 0;
            this.buttonMinus.HighEmphasis = true;
            this.buttonMinus.Icon = global::AccommodationManagerApp.Properties.Resources.minus;
            this.buttonMinus.Location = new System.Drawing.Point(358, 372);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonMinus.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonMinus.Size = new System.Drawing.Size(96, 40);
            this.buttonMinus.TabIndex = 33;
            this.buttonMinus.Text = "25";
            this.buttonMinus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonMinus.UseAccentColor = false;
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.AutoSize = false;
            this.buttonPlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonPlus.Depth = 0;
            this.buttonPlus.HighEmphasis = true;
            this.buttonPlus.Icon = global::AccommodationManagerApp.Properties.Resources.plus;
            this.buttonPlus.Location = new System.Drawing.Point(462, 372);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPlus.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonPlus.Size = new System.Drawing.Size(96, 40);
            this.buttonPlus.TabIndex = 32;
            this.buttonPlus.Text = "25";
            this.buttonPlus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonPlus.UseAccentColor = false;
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.AnimateReadOnly = false;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Depth = 0;
            this.textBoxPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPrice.Hint = "Số tiền phí (vnd)";
            this.textBoxPrice.LeadingIcon = null;
            this.textBoxPrice.Location = new System.Drawing.Point(358, 313);
            this.textBoxPrice.MaxLength = 50;
            this.textBoxPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPrice.Multiline = false;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 50);
            this.textBoxPrice.TabIndex = 31;
            this.textBoxPrice.Text = "";
            this.textBoxPrice.TrailingIcon = null;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // comboBoxVehiclePrice
            // 
            this.comboBoxVehiclePrice.AutoResize = false;
            this.comboBoxVehiclePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxVehiclePrice.Depth = 0;
            this.comboBoxVehiclePrice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxVehiclePrice.DropDownHeight = 174;
            this.comboBoxVehiclePrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVehiclePrice.DropDownWidth = 121;
            this.comboBoxVehiclePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxVehiclePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxVehiclePrice.FormattingEnabled = true;
            this.comboBoxVehiclePrice.IntegralHeight = false;
            this.comboBoxVehiclePrice.ItemHeight = 43;
            this.comboBoxVehiclePrice.Location = new System.Drawing.Point(262, 312);
            this.comboBoxVehiclePrice.MaxDropDownItems = 4;
            this.comboBoxVehiclePrice.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxVehiclePrice.Name = "comboBoxVehiclePrice";
            this.comboBoxVehiclePrice.Size = new System.Drawing.Size(82, 49);
            this.comboBoxVehiclePrice.StartIndex = 0;
            this.comboBoxVehiclePrice.TabIndex = 30;
            this.comboBoxVehiclePrice.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehiclePrice_SelectedIndexChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(34, 323);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(179, 24);
            this.materialLabel5.TabIndex = 29;
            this.materialLabel5.Text = "Đơn giá hằng tháng:";
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 784);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxVehiclePrice);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSave);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VehicleForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Thêm thông tin phương tiện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VehicleForm_FormClosing);
            this.Controls.SetChildIndex(this.buttonSave, 0);
            this.Controls.SetChildIndex(this.textBoxName, 0);
            this.Controls.SetChildIndex(this.materialLabel3, 0);
            this.Controls.SetChildIndex(this.materialLabel2, 0);
            this.Controls.SetChildIndex(this.textBoxNumber, 0);
            this.Controls.SetChildIndex(this.materialLabel1, 0);
            this.Controls.SetChildIndex(this.materialLabel4, 0);
            this.Controls.SetChildIndex(this.comboBoxRoom, 0);
            this.Controls.SetChildIndex(this.comboBoxCategory, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.materialLabel5, 0);
            this.Controls.SetChildIndex(this.comboBoxVehiclePrice, 0);
            this.Controls.SetChildIndex(this.textBoxPrice, 0);
            this.Controls.SetChildIndex(this.buttonPlus, 0);
            this.Controls.SetChildIndex(this.buttonMinus, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox textBoxName;
        private MaterialSkin.Controls.MaterialButton buttonSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox textBoxNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox comboBoxRoom;
        private MaterialSkin.Controls.MaterialComboBox comboBoxCategory;
        private MaterialSkin.Controls.MaterialButton buttonMinus;
        private MaterialSkin.Controls.MaterialButton buttonPlus;
        private MaterialSkin.Controls.MaterialTextBox textBoxPrice;
        private MaterialSkin.Controls.MaterialComboBox comboBoxVehiclePrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}