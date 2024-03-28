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
            this.comboBoxEndDate = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxPrice = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxRoom = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxTenant = new MaterialSkin.Controls.MaterialComboBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.buttonPlus = new MaterialSkin.Controls.MaterialButton();
            this.buttonMinus = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // comboBoxEndDate
            // 
            this.comboBoxEndDate.AutoResize = false;
            this.comboBoxEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxEndDate.Depth = 0;
            this.comboBoxEndDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEndDate.DropDownHeight = 174;
            this.comboBoxEndDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndDate.DropDownWidth = 121;
            this.comboBoxEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxEndDate.FormattingEnabled = true;
            this.comboBoxEndDate.IntegralHeight = false;
            this.comboBoxEndDate.ItemHeight = 43;
            this.comboBoxEndDate.Location = new System.Drawing.Point(165, 476);
            this.comboBoxEndDate.MaxDropDownItems = 4;
            this.comboBoxEndDate.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxEndDate.Name = "comboBoxEndDate";
            this.comboBoxEndDate.Size = new System.Drawing.Size(284, 49);
            this.comboBoxEndDate.StartIndex = 0;
            this.comboBoxEndDate.TabIndex = 20;
            this.comboBoxEndDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndDate_SelectedIndexChanged);
            // 
            // comboBoxPrice
            // 
            this.comboBoxPrice.AutoResize = false;
            this.comboBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxPrice.Depth = 0;
            this.comboBoxPrice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxPrice.DropDownHeight = 174;
            this.comboBoxPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrice.DropDownWidth = 121;
            this.comboBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxPrice.FormattingEnabled = true;
            this.comboBoxPrice.IntegralHeight = false;
            this.comboBoxPrice.ItemHeight = 43;
            this.comboBoxPrice.Location = new System.Drawing.Point(40, 292);
            this.comboBoxPrice.MaxDropDownItems = 4;
            this.comboBoxPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxPrice.Name = "comboBoxPrice";
            this.comboBoxPrice.Size = new System.Drawing.Size(196, 49);
            this.comboBoxPrice.StartIndex = 0;
            this.comboBoxPrice.TabIndex = 19;
            this.comboBoxPrice.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrice_SelectedIndexChanged);
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
            this.comboBoxRoom.Location = new System.Drawing.Point(166, 165);
            this.comboBoxRoom.MaxDropDownItems = 4;
            this.comboBoxRoom.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(284, 49);
            this.comboBoxRoom.StartIndex = 0;
            this.comboBoxRoom.TabIndex = 18;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(35, 489);
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
            this.materialLabel3.Location = new System.Drawing.Point(36, 248);
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
            this.ButtonSave.Location = new System.Drawing.Point(354, 605);
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
            this.materialLabel2.Location = new System.Drawing.Point(36, 176);
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
            // comboBoxTenant
            // 
            this.comboBoxTenant.AutoResize = false;
            this.comboBoxTenant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxTenant.Depth = 0;
            this.comboBoxTenant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxTenant.DropDownHeight = 174;
            this.comboBoxTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTenant.DropDownWidth = 121;
            this.comboBoxTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTenant.FormattingEnabled = true;
            this.comboBoxTenant.IntegralHeight = false;
            this.comboBoxTenant.ItemHeight = 43;
            this.comboBoxTenant.Location = new System.Drawing.Point(166, 95);
            this.comboBoxTenant.MaxDropDownItems = 4;
            this.comboBoxTenant.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTenant.Name = "comboBoxTenant";
            this.comboBoxTenant.Size = new System.Drawing.Size(284, 49);
            this.comboBoxTenant.StartIndex = 0;
            this.comboBoxTenant.TabIndex = 21;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(165, 417);
            this.dateTimePickerStartDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(284, 26);
            this.dateTimePickerStartDate.TabIndex = 22;
            this.dateTimePickerStartDate.Value = new System.DateTime(2024, 3, 28, 0, 0, 0, 0);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(35, 417);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(85, 24);
            this.materialLabel5.TabIndex = 23;
            this.materialLabel5.Text = "Số tháng:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.AnimateReadOnly = false;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrice.Depth = 0;
            this.textBoxPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPrice.Hint = "Số tiền thuê (vnd)";
            this.textBoxPrice.LeadingIcon = null;
            this.textBoxPrice.Location = new System.Drawing.Point(250, 293);
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
            this.materialLabel6.Location = new System.Drawing.Point(35, 556);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(129, 24);
            this.materialLabel6.TabIndex = 25;
            this.materialLabel6.Text = "Ngày kết thúc:";
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.AutoSize = true;
            this.textBoxEndDate.Depth = 0;
            this.textBoxEndDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxEndDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.textBoxEndDate.Location = new System.Drawing.Point(170, 556);
            this.textBoxEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(280, 24);
            this.textBoxEndDate.TabIndex = 26;
            this.textBoxEndDate.Text = "_______________________________";
            // 
            // buttonPlus
            // 
            this.buttonPlus.AutoSize = false;
            this.buttonPlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonPlus.Depth = 0;
            this.buttonPlus.HighEmphasis = true;
            this.buttonPlus.Icon = global::AccommodationManagerApp.Properties.Resources.plus;
            this.buttonPlus.Location = new System.Drawing.Point(354, 352);
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
            this.buttonMinus.Location = new System.Drawing.Point(250, 352);
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
            this.materialLabel7.Location = new System.Drawing.Point(156, 217);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(294, 14);
            this.materialLabel7.TabIndex = 29;
            this.materialLabel7.Text = "Chỉ hiện thị những phòng trống và không có hợp đồng";
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 677);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxEndDate);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.comboBoxTenant);
            this.Controls.Add(this.comboBoxEndDate);
            this.Controls.Add(this.comboBoxPrice);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximumSize = new System.Drawing.Size(481, 677);
            this.MinimumSize = new System.Drawing.Size(481, 677);
            this.Name = "ContractForm";
            this.Sizable = false;
            this.Text = "Thêm hợp đồng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContractForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox comboBoxEndDate;
        private MaterialSkin.Controls.MaterialComboBox comboBoxPrice;
        private MaterialSkin.Controls.MaterialComboBox comboBoxRoom;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton ButtonSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox comboBoxTenant;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox textBoxPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel textBoxEndDate;
        private MaterialSkin.Controls.MaterialButton buttonPlus;
        private MaterialSkin.Controls.MaterialButton buttonMinus;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}