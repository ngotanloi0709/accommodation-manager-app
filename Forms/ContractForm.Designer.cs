using System.ComponentModel;

namespace AccommodationManagerApp.Forms {
    partial class ContractForm {
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
            this.comboBoxContractEndDate = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxContractPrice = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxContractRoom = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxContractTenant = new MaterialSkin.Controls.MaterialComboBox();
            this.dateTimePickerContractStartDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.labelContractEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.buttonPlus = new MaterialSkin.Controls.MaterialButton();
            this.buttonMinus = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxContractTenantEmail = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // comboBoxContractEndDate
            // 
            this.comboBoxContractEndDate.AutoResize = false;
            this.comboBoxContractEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxContractEndDate.Depth = 0;
            this.comboBoxContractEndDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxContractEndDate.DropDownHeight = 174;
            this.comboBoxContractEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContractEndDate.DropDownWidth = 121;
            this.comboBoxContractEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxContractEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxContractEndDate.FormattingEnabled = true;
            this.comboBoxContractEndDate.IntegralHeight = false;
            this.comboBoxContractEndDate.ItemHeight = 43;
            this.comboBoxContractEndDate.Location = new System.Drawing.Point(164, 552);
            this.comboBoxContractEndDate.MaxDropDownItems = 4;
            this.comboBoxContractEndDate.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxContractEndDate.Name = "comboBoxContractEndDate";
            this.comboBoxContractEndDate.Size = new System.Drawing.Size(284, 49);
            this.comboBoxContractEndDate.StartIndex = 0;
            this.comboBoxContractEndDate.TabIndex = 20;
            this.comboBoxContractEndDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndDate_SelectedIndexChanged);
            // 
            // comboBoxContractPrice
            // 
            this.comboBoxContractPrice.AutoResize = false;
            this.comboBoxContractPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxContractPrice.Depth = 0;
            this.comboBoxContractPrice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxContractPrice.DropDownHeight = 174;
            this.comboBoxContractPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContractPrice.DropDownWidth = 121;
            this.comboBoxContractPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxContractPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxContractPrice.FormattingEnabled = true;
            this.comboBoxContractPrice.IntegralHeight = false;
            this.comboBoxContractPrice.ItemHeight = 43;
            this.comboBoxContractPrice.Location = new System.Drawing.Point(39, 368);
            this.comboBoxContractPrice.MaxDropDownItems = 4;
            this.comboBoxContractPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxContractPrice.Name = "comboBoxContractPrice";
            this.comboBoxContractPrice.Size = new System.Drawing.Size(196, 49);
            this.comboBoxContractPrice.StartIndex = 0;
            this.comboBoxContractPrice.TabIndex = 19;
            this.comboBoxContractPrice.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrice_SelectedIndexChanged);
            // 
            // comboBoxContractRoom
            // 
            this.comboBoxContractRoom.AutoResize = false;
            this.comboBoxContractRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxContractRoom.Depth = 0;
            this.comboBoxContractRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxContractRoom.DropDownHeight = 174;
            this.comboBoxContractRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContractRoom.DropDownWidth = 121;
            this.comboBoxContractRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxContractRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxContractRoom.FormattingEnabled = true;
            this.comboBoxContractRoom.IntegralHeight = false;
            this.comboBoxContractRoom.ItemHeight = 43;
            this.comboBoxContractRoom.Location = new System.Drawing.Point(165, 241);
            this.comboBoxContractRoom.MaxDropDownItems = 4;
            this.comboBoxContractRoom.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxContractRoom.Name = "comboBoxContractRoom";
            this.comboBoxContractRoom.Size = new System.Drawing.Size(284, 49);
            this.comboBoxContractRoom.StartIndex = 0;
            this.comboBoxContractRoom.TabIndex = 18;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(34, 565);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(85, 24);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Số tháng:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(35, 324);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(179, 24);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Đơn giá hằng tháng:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = false;
            this.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonSave.Depth = 0;
            this.ButtonSave.HighEmphasis = true;
            this.ButtonSave.Icon = global::AccommodationManagerApp.Properties.Resources.save;
            this.ButtonSave.Location = new System.Drawing.Point(353, 681);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonSave.Size = new System.Drawing.Size(96, 40);
            this.ButtonSave.TabIndex = 15;
            this.ButtonSave.Text = "Lưu";
            this.ButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonSave.UseAccentColor = false;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(35, 252);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 24);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Số phòng:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(36, 105);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 24);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Người thuê:";
            // 
            // comboBoxContractTenant
            // 
            this.comboBoxContractTenant.AutoResize = false;
            this.comboBoxContractTenant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxContractTenant.Depth = 0;
            this.comboBoxContractTenant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxContractTenant.DropDownHeight = 174;
            this.comboBoxContractTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContractTenant.DropDownWidth = 121;
            this.comboBoxContractTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxContractTenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxContractTenant.FormattingEnabled = true;
            this.comboBoxContractTenant.IntegralHeight = false;
            this.comboBoxContractTenant.ItemHeight = 43;
            this.comboBoxContractTenant.Location = new System.Drawing.Point(166, 95);
            this.comboBoxContractTenant.MaxDropDownItems = 4;
            this.comboBoxContractTenant.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxContractTenant.Name = "comboBoxContractTenant";
            this.comboBoxContractTenant.Size = new System.Drawing.Size(284, 49);
            this.comboBoxContractTenant.StartIndex = 0;
            this.comboBoxContractTenant.TabIndex = 21;
            this.comboBoxContractTenant.SelectedIndexChanged += new System.EventHandler(this.comboBoxContractTenant_SelectedIndexChanged);
            // 
            // dateTimePickerContractStartDate
            // 
            this.dateTimePickerContractStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerContractStartDate.Location = new System.Drawing.Point(164, 493);
            this.dateTimePickerContractStartDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerContractStartDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerContractStartDate.Name = "dateTimePickerContractStartDate";
            this.dateTimePickerContractStartDate.Size = new System.Drawing.Size(284, 26);
            this.dateTimePickerContractStartDate.TabIndex = 22;
            this.dateTimePickerContractStartDate.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(34, 493);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(125, 24);
            this.materialLabel5.TabIndex = 23;
            this.materialLabel5.Text = "Ngày bắt đầu:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.AnimateReadOnly = false;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Depth = 0;
            this.textBoxPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPrice.Hint = "Số tiền thuê (vnd)";
            this.textBoxPrice.LeadingIcon = null;
            this.textBoxPrice.Location = new System.Drawing.Point(249, 369);
            this.textBoxPrice.MaxLength = 50;
            this.textBoxPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPrice.Multiline = false;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 50);
            this.textBoxPrice.TabIndex = 24;
            this.textBoxPrice.Text = "";
            this.textBoxPrice.TrailingIcon = null;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberInput);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(34, 632);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(129, 24);
            this.materialLabel6.TabIndex = 25;
            this.materialLabel6.Text = "Ngày kết thúc:";
            // 
            // labelContractEndDate
            // 
            this.labelContractEndDate.AutoSize = true;
            this.labelContractEndDate.Depth = 0;
            this.labelContractEndDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelContractEndDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelContractEndDate.Location = new System.Drawing.Point(169, 632);
            this.labelContractEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelContractEndDate.Name = "labelContractEndDate";
            this.labelContractEndDate.Size = new System.Drawing.Size(280, 24);
            this.labelContractEndDate.TabIndex = 26;
            this.labelContractEndDate.Text = "_______________________________";
            // 
            // buttonPlus
            // 
            this.buttonPlus.AutoSize = false;
            this.buttonPlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonPlus.Depth = 0;
            this.buttonPlus.HighEmphasis = true;
            this.buttonPlus.Icon = global::AccommodationManagerApp.Properties.Resources.plus;
            this.buttonPlus.Location = new System.Drawing.Point(353, 428);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPlus.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonPlus.Size = new System.Drawing.Size(96, 40);
            this.buttonPlus.TabIndex = 27;
            this.buttonPlus.Text = "500";
            this.buttonPlus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonPlus.UseAccentColor = false;
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.AutoSize = false;
            this.buttonMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMinus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonMinus.Depth = 0;
            this.buttonMinus.HighEmphasis = true;
            this.buttonMinus.Icon = global::AccommodationManagerApp.Properties.Resources.minus;
            this.buttonMinus.Location = new System.Drawing.Point(249, 428);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonMinus.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonMinus.Size = new System.Drawing.Size(96, 40);
            this.buttonMinus.TabIndex = 28;
            this.buttonMinus.Text = "500";
            this.buttonMinus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonMinus.UseAccentColor = false;
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel7.Location = new System.Drawing.Point(155, 293);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(294, 14);
            this.materialLabel7.TabIndex = 29;
            this.materialLabel7.Text = "Chỉ hiện thị những phòng trống và không có hợp đồng";
            // 
            // comboBoxContractTenantEmail
            // 
            this.comboBoxContractTenantEmail.AutoResize = false;
            this.comboBoxContractTenantEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxContractTenantEmail.Depth = 0;
            this.comboBoxContractTenantEmail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxContractTenantEmail.DropDownHeight = 174;
            this.comboBoxContractTenantEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContractTenantEmail.DropDownWidth = 121;
            this.comboBoxContractTenantEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxContractTenantEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxContractTenantEmail.FormattingEnabled = true;
            this.comboBoxContractTenantEmail.IntegralHeight = false;
            this.comboBoxContractTenantEmail.ItemHeight = 43;
            this.comboBoxContractTenantEmail.Location = new System.Drawing.Point(165, 166);
            this.comboBoxContractTenantEmail.MaxDropDownItems = 4;
            this.comboBoxContractTenantEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxContractTenantEmail.Name = "comboBoxContractTenantEmail";
            this.comboBoxContractTenantEmail.Size = new System.Drawing.Size(284, 49);
            this.comboBoxContractTenantEmail.StartIndex = 0;
            this.comboBoxContractTenantEmail.TabIndex = 31;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(35, 176);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(55, 24);
            this.materialLabel8.TabIndex = 30;
            this.materialLabel8.Text = "Email:";
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 744);
            this.Controls.Add(this.comboBoxContractTenantEmail);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.labelContractEndDate);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.dateTimePickerContractStartDate);
            this.Controls.Add(this.comboBoxContractTenant);
            this.Controls.Add(this.comboBoxContractEndDate);
            this.Controls.Add(this.comboBoxContractPrice);
            this.Controls.Add(this.comboBoxContractRoom);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximumSize = new System.Drawing.Size(481, 744);
            this.MinimumSize = new System.Drawing.Size(481, 677);
            this.Name = "ContractForm";
            this.Sizable = false;
            this.Text = "Thêm hợp đồng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContractForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox comboBoxContractEndDate;
        private MaterialSkin.Controls.MaterialComboBox comboBoxContractPrice;
        private MaterialSkin.Controls.MaterialComboBox comboBoxContractRoom;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton ButtonSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox comboBoxContractTenant;
        private System.Windows.Forms.DateTimePicker dateTimePickerContractStartDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox textBoxPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel labelContractEndDate;
        private MaterialSkin.Controls.MaterialButton buttonPlus;
        private MaterialSkin.Controls.MaterialButton buttonMinus;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox comboBoxContractTenantEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
    }
}