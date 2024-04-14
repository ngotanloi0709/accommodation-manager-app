using System.ComponentModel;

namespace AccommodationManagerApp.Forms {
    partial class ChangeUserPasswordForm {
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxConfirmPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonSave = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(29, 166);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Nhập lại mật khẩu";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(29, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(145, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Nhập mật khẩu mới:";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.AnimateReadOnly = false;
            this.textBoxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmPassword.Depth = 0;
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxConfirmPassword.Hint = "Mật khẩu mới";
            this.textBoxConfirmPassword.LeadingIcon = null;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(192, 150);
            this.textBoxConfirmPassword.MaxLength = 50;
            this.textBoxConfirmPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxConfirmPassword.Multiline = false;
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(330, 50);
            this.textBoxConfirmPassword.TabIndex = 7;
            this.textBoxConfirmPassword.Text = "";
            this.textBoxConfirmPassword.TrailingIcon = null;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AnimateReadOnly = false;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPassword.Hint = "Mật khẩu mới";
            this.textBoxPassword.LeadingIcon = null;
            this.textBoxPassword.Location = new System.Drawing.Point(192, 77);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(330, 50);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.Text = "";
            this.textBoxPassword.TrailingIcon = null;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = false;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSave.Depth = 0;
            this.buttonSave.HighEmphasis = true;
            this.buttonSave.Icon = null;
            this.buttonSave.Location = new System.Drawing.Point(435, 220);
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
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ChangeUserPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 288);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonSave);
            this.MaximumSize = new System.Drawing.Size(558, 288);
            this.MinimumSize = new System.Drawing.Size(558, 288);
            this.Name = "ChangeUserPasswordForm";
            this.Sizable = false;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox textBoxConfirmPassword;
        private MaterialSkin.Controls.MaterialTextBox textBoxPassword;
        private MaterialSkin.Controls.MaterialButton buttonSave;
    }
}