using System.ComponentModel;

namespace AccommodationManagerApp.Forms {
    partial class UserForm {
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
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.switchSex = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxIdentityNumber = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonSave = new MaterialSkin.Controls.MaterialButton();
            this.ComboBoxRole = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(43, 379);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(81, 24);
            this.materialLabel6.TabIndex = 17;
            this.materialLabel6.Text = "Giới tính:";
            // 
            // switchSex
            // 
            this.switchSex.AutoSize = true;
            this.switchSex.Depth = 0;
            this.switchSex.Location = new System.Drawing.Point(167, 376);
            this.switchSex.Margin = new System.Windows.Forms.Padding(0);
            this.switchSex.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchSex.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchSex.Name = "switchSex";
            this.switchSex.Ripple = true;
            this.switchSex.Size = new System.Drawing.Size(79, 37);
            this.switchSex.TabIndex = 16;
            this.switchSex.Text = "Nữ";
            this.switchSex.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(43, 263);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(94, 24);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Ngày sinh:";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(179, 263);
            this.dateTimePickerDateOfBirth.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(330, 26);
            this.dateTimePickerDateOfBirth.TabIndex = 14;
            this.dateTimePickerDateOfBirth.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(43, 322);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(55, 24);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AnimateReadOnly = false;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Depth = 0;
            this.textBoxEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxEmail.Hint = "Nhập Email";
            this.textBoxEmail.LeadingIcon = null;
            this.textBoxEmail.Location = new System.Drawing.Point(179, 304);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxEmail.Multiline = false;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(330, 50);
            this.textBoxEmail.TabIndex = 12;
            this.textBoxEmail.Text = "";
            this.textBoxEmail.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(43, 208);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(115, 24);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Số căn cước:";
            // 
            // textBoxIdentityNumber
            // 
            this.textBoxIdentityNumber.AnimateReadOnly = false;
            this.textBoxIdentityNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIdentityNumber.Depth = 0;
            this.textBoxIdentityNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxIdentityNumber.Hint = "Nhập số căn cước";
            this.textBoxIdentityNumber.LeadingIcon = null;
            this.textBoxIdentityNumber.Location = new System.Drawing.Point(179, 193);
            this.textBoxIdentityNumber.MaxLength = 50;
            this.textBoxIdentityNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxIdentityNumber.Multiline = false;
            this.textBoxIdentityNumber.Name = "textBoxIdentityNumber";
            this.textBoxIdentityNumber.Size = new System.Drawing.Size(330, 50);
            this.textBoxIdentityNumber.TabIndex = 10;
            this.textBoxIdentityNumber.Text = "";
            this.textBoxIdentityNumber.TrailingIcon = null;
            this.textBoxIdentityNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(43, 150);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 24);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Số điện thoại:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(43, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 24);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Họ và tên:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.AnimateReadOnly = false;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Depth = 0;
            this.textBoxPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPhone.Hint = "Nhập số điện thoại";
            this.textBoxPhone.LeadingIcon = null;
            this.textBoxPhone.Location = new System.Drawing.Point(179, 137);
            this.textBoxPhone.MaxLength = 50;
            this.textBoxPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPhone.Multiline = false;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(330, 50);
            this.textBoxPhone.TabIndex = 7;
            this.textBoxPhone.Text = "";
            this.textBoxPhone.TrailingIcon = null;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.AnimateReadOnly = false;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Depth = 0;
            this.textBoxName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxName.Hint = "Nhập họ và tên";
            this.textBoxName.LeadingIcon = null;
            this.textBoxName.Location = new System.Drawing.Point(179, 78);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(330, 50);
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
            this.buttonSave.Location = new System.Drawing.Point(422, 438);
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
            // ComboBoxRole
            // 
            this.ComboBoxRole.AutoResize = false;
            this.ComboBoxRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxRole.Depth = 0;
            this.ComboBoxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxRole.DropDownHeight = 174;
            this.ComboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRole.DropDownWidth = 121;
            this.ComboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxRole.FormattingEnabled = true;
            this.ComboBoxRole.IntegralHeight = false;
            this.ComboBoxRole.ItemHeight = 43;
            this.ComboBoxRole.Location = new System.Drawing.Point(329, 369);
            this.ComboBoxRole.MaxDropDownItems = 4;
            this.ComboBoxRole.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxRole.Name = "ComboBoxRole";
            this.ComboBoxRole.Size = new System.Drawing.Size(180, 49);
            this.ComboBoxRole.StartIndex = 0;
            this.ComboBoxRole.TabIndex = 18;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(258, 379);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(65, 24);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "Vai trò:";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 495);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.ComboBoxRole);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.switchSex);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.textBoxIdentityNumber);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSave);
            this.MaximumSize = new System.Drawing.Size(543, 495);
            this.MinimumSize = new System.Drawing.Size(543, 495);
            this.Name = "UserForm";
            this.Text = "Thêm thông tin người dùng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox textBoxPhone;
        private MaterialSkin.Controls.MaterialTextBox textBoxName;
        private MaterialSkin.Controls.MaterialButton buttonSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox textBoxIdentityNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox textBoxEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSwitch switchSex;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox ComboBoxRole;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}