using System.ComponentModel;

namespace AccommodationManagerApp.Repository {
    partial class CurrentUserInformationForm {
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
            this.buttonEditAvatar = new MaterialSkin.Controls.MaterialButton();
            this.buttonEditPassword = new MaterialSkin.Controls.MaterialButton();
            this.pictureBoxUserImage = new System.Windows.Forms.PictureBox();
            this.labelUserIdentityNumber = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel32 = new MaterialSkin.Controls.MaterialLabel();
            this.labelUserPhone = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel30 = new MaterialSkin.Controls.MaterialLabel();
            this.labelUserName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.labelUserDateOfBirth = new MaterialSkin.Controls.MaterialLabel();
            this.labelUserSex = new MaterialSkin.Controls.MaterialLabel();
            this.labelUserEmail = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonEdit = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditAvatar
            // 
            this.buttonEditAvatar.AutoSize = false;
            this.buttonEditAvatar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditAvatar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEditAvatar.Depth = 0;
            this.buttonEditAvatar.HighEmphasis = true;
            this.buttonEditAvatar.Icon = global::AccommodationManagerApp.Properties.Resources.user_no_color;
            this.buttonEditAvatar.Location = new System.Drawing.Point(421, 251);
            this.buttonEditAvatar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEditAvatar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEditAvatar.Name = "buttonEditAvatar";
            this.buttonEditAvatar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEditAvatar.Size = new System.Drawing.Size(181, 36);
            this.buttonEditAvatar.TabIndex = 54;
            this.buttonEditAvatar.Text = "Đổi ảnh đại diện ";
            this.buttonEditAvatar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.buttonEditAvatar.UseAccentColor = false;
            this.buttonEditAvatar.UseVisualStyleBackColor = true;
            this.buttonEditAvatar.Click += new System.EventHandler(this.buttonEditAvatar_Click);
            // 
            // buttonEditPassword
            // 
            this.buttonEditPassword.AutoSize = false;
            this.buttonEditPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditPassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEditPassword.Depth = 0;
            this.buttonEditPassword.HighEmphasis = true;
            this.buttonEditPassword.Icon = global::AccommodationManagerApp.Properties.Resources.password;
            this.buttonEditPassword.Location = new System.Drawing.Point(421, 299);
            this.buttonEditPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEditPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEditPassword.Name = "buttonEditPassword";
            this.buttonEditPassword.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEditPassword.Size = new System.Drawing.Size(181, 36);
            this.buttonEditPassword.TabIndex = 53;
            this.buttonEditPassword.Text = "Đổi mật khẩu";
            this.buttonEditPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.buttonEditPassword.UseAccentColor = false;
            this.buttonEditPassword.UseVisualStyleBackColor = true;
            this.buttonEditPassword.Click += new System.EventHandler(this.buttonEditPassword_Click);
            // 
            // pictureBoxUserImage
            // 
            this.pictureBoxUserImage.Image = global::AccommodationManagerApp.Properties.Resources.user;
            this.pictureBoxUserImage.Location = new System.Drawing.Point(438, 86);
            this.pictureBoxUserImage.Name = "pictureBoxUserImage";
            this.pictureBoxUserImage.Size = new System.Drawing.Size(164, 156);
            this.pictureBoxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserImage.TabIndex = 52;
            this.pictureBoxUserImage.TabStop = false;
            // 
            // labelUserIdentityNumber
            // 
            this.labelUserIdentityNumber.AutoSize = true;
            this.labelUserIdentityNumber.Depth = 0;
            this.labelUserIdentityNumber.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelUserIdentityNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelUserIdentityNumber.Location = new System.Drawing.Point(166, 177);
            this.labelUserIdentityNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelUserIdentityNumber.Name = "labelUserIdentityNumber";
            this.labelUserIdentityNumber.Size = new System.Drawing.Size(217, 24);
            this.labelUserIdentityNumber.TabIndex = 51;
            this.labelUserIdentityNumber.Text = "________________________";
            // 
            // materialLabel32
            // 
            this.materialLabel32.AutoSize = true;
            this.materialLabel32.Depth = 0;
            this.materialLabel32.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel32.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel32.Location = new System.Drawing.Point(35, 177);
            this.materialLabel32.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel32.Name = "materialLabel32";
            this.materialLabel32.Size = new System.Drawing.Size(115, 24);
            this.materialLabel32.TabIndex = 50;
            this.materialLabel32.Text = "Số căn cước:";
            // 
            // labelUserPhone
            // 
            this.labelUserPhone.AutoSize = true;
            this.labelUserPhone.Depth = 0;
            this.labelUserPhone.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelUserPhone.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelUserPhone.Location = new System.Drawing.Point(166, 132);
            this.labelUserPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelUserPhone.Name = "labelUserPhone";
            this.labelUserPhone.Size = new System.Drawing.Size(217, 24);
            this.labelUserPhone.TabIndex = 49;
            this.labelUserPhone.Text = "________________________";
            // 
            // materialLabel30
            // 
            this.materialLabel30.AutoSize = true;
            this.materialLabel30.Depth = 0;
            this.materialLabel30.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel30.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel30.Location = new System.Drawing.Point(35, 132);
            this.materialLabel30.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel30.Name = "materialLabel30";
            this.materialLabel30.Size = new System.Drawing.Size(123, 24);
            this.materialLabel30.TabIndex = 48;
            this.materialLabel30.Text = "Số điện thoại:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Depth = 0;
            this.labelUserName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelUserName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelUserName.Location = new System.Drawing.Point(166, 87);
            this.labelUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(217, 24);
            this.labelUserName.TabIndex = 47;
            this.labelUserName.Text = "________________________";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel17.Location = new System.Drawing.Point(36, 87);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(91, 24);
            this.materialLabel17.TabIndex = 46;
            this.materialLabel17.Text = "Họ và tên:";
            // 
            // labelUserDateOfBirth
            // 
            this.labelUserDateOfBirth.AutoSize = true;
            this.labelUserDateOfBirth.Depth = 0;
            this.labelUserDateOfBirth.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelUserDateOfBirth.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelUserDateOfBirth.Location = new System.Drawing.Point(166, 219);
            this.labelUserDateOfBirth.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelUserDateOfBirth.Name = "labelUserDateOfBirth";
            this.labelUserDateOfBirth.Size = new System.Drawing.Size(217, 24);
            this.labelUserDateOfBirth.TabIndex = 45;
            this.labelUserDateOfBirth.Text = "________________________";
            // 
            // labelUserSex
            // 
            this.labelUserSex.AutoSize = true;
            this.labelUserSex.Depth = 0;
            this.labelUserSex.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelUserSex.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelUserSex.Location = new System.Drawing.Point(166, 311);
            this.labelUserSex.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelUserSex.Name = "labelUserSex";
            this.labelUserSex.Size = new System.Drawing.Size(217, 24);
            this.labelUserSex.TabIndex = 44;
            this.labelUserSex.Text = "________________________";
            // 
            // labelUserEmail
            // 
            this.labelUserEmail.AutoSize = true;
            this.labelUserEmail.Depth = 0;
            this.labelUserEmail.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelUserEmail.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelUserEmail.Location = new System.Drawing.Point(166, 263);
            this.labelUserEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelUserEmail.Name = "labelUserEmail";
            this.labelUserEmail.Size = new System.Drawing.Size(217, 24);
            this.labelUserEmail.TabIndex = 43;
            this.labelUserEmail.Text = "________________________";
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel25.Location = new System.Drawing.Point(36, 219);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(94, 24);
            this.materialLabel25.TabIndex = 42;
            this.materialLabel25.Text = "Ngày sinh:";
            // 
            // materialLabel27
            // 
            this.materialLabel27.AutoSize = true;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel27.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel27.Location = new System.Drawing.Point(35, 311);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Size = new System.Drawing.Size(81, 24);
            this.materialLabel27.TabIndex = 41;
            this.materialLabel27.Text = "Giới tính:";
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel28.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel28.Location = new System.Drawing.Point(36, 263);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(55, 24);
            this.materialLabel28.TabIndex = 40;
            this.materialLabel28.Text = "Email:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSize = false;
            this.buttonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEdit.Depth = 0;
            this.buttonEdit.HighEmphasis = true;
            this.buttonEdit.Icon = global::AccommodationManagerApp.Properties.Resources.edit;
            this.buttonEdit.Location = new System.Drawing.Point(39, 351);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEdit.Size = new System.Drawing.Size(344, 36);
            this.buttonEdit.TabIndex = 55;
            this.buttonEdit.Text = "Chỉnh sửa thông tin";
            this.buttonEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonEdit.UseAccentColor = false;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // CurrentUserInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 459);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonEditAvatar);
            this.Controls.Add(this.buttonEditPassword);
            this.Controls.Add(this.pictureBoxUserImage);
            this.Controls.Add(this.labelUserIdentityNumber);
            this.Controls.Add(this.materialLabel32);
            this.Controls.Add(this.labelUserPhone);
            this.Controls.Add(this.materialLabel30);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.labelUserDateOfBirth);
            this.Controls.Add(this.labelUserSex);
            this.Controls.Add(this.labelUserEmail);
            this.Controls.Add(this.materialLabel25);
            this.Controls.Add(this.materialLabel27);
            this.Controls.Add(this.materialLabel28);
            this.Name = "CurrentUserInformationForm";
            this.Text = "Xem thông tin cá nhân";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonEditAvatar;
        private MaterialSkin.Controls.MaterialButton buttonEditPassword;
        private System.Windows.Forms.PictureBox pictureBoxUserImage;
        private MaterialSkin.Controls.MaterialLabel labelUserIdentityNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel32;
        private MaterialSkin.Controls.MaterialLabel labelUserPhone;
        private MaterialSkin.Controls.MaterialLabel materialLabel30;
        private MaterialSkin.Controls.MaterialLabel labelUserName;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel labelUserDateOfBirth;
        private MaterialSkin.Controls.MaterialLabel labelUserSex;
        private MaterialSkin.Controls.MaterialLabel labelUserEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialLabel materialLabel27;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private MaterialSkin.Controls.MaterialButton buttonEdit;
    }
}