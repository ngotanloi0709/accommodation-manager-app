namespace AccommodationManagerApp.Forms
{
    partial class AdminForm
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
            this.buttonAdminLogin = new MaterialSkin.Controls.MaterialButton();
            this.buttonCurrentUserInformationManagement = new MaterialSkin.Controls.MaterialButton();
            this.buttonAdminLogout = new MaterialSkin.Controls.MaterialButton();
            this.labelAdminEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdminLogin
            // 
            this.buttonAdminLogin.AutoSize = false;
            this.buttonAdminLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdminLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAdminLogin.Depth = 0;
            this.buttonAdminLogin.HighEmphasis = true;
            this.buttonAdminLogin.Icon = global::AccommodationManagerApp.Properties.Resources.login;
            this.buttonAdminLogin.Location = new System.Drawing.Point(653, 25);
            this.buttonAdminLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAdminLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdminLogin.Name = "buttonAdminLogin";
            this.buttonAdminLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAdminLogin.Size = new System.Drawing.Size(134, 36);
            this.buttonAdminLogin.TabIndex = 28;
            this.buttonAdminLogin.Text = "Đăng nhập";
            this.buttonAdminLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonAdminLogin.UseAccentColor = false;
            this.buttonAdminLogin.UseVisualStyleBackColor = true;
            this.buttonAdminLogin.Visible = false;
            // 
            // buttonCurrentUserInformationManagement
            // 
            this.buttonCurrentUserInformationManagement.AutoSize = false;
            this.buttonCurrentUserInformationManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCurrentUserInformationManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCurrentUserInformationManagement.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonCurrentUserInformationManagement.Depth = 0;
            this.buttonCurrentUserInformationManagement.HighEmphasis = true;
            this.buttonCurrentUserInformationManagement.Icon = global::AccommodationManagerApp.Properties.Resources.user_no_color;
            this.buttonCurrentUserInformationManagement.Location = new System.Drawing.Point(83, 25);
            this.buttonCurrentUserInformationManagement.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCurrentUserInformationManagement.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCurrentUserInformationManagement.Name = "buttonCurrentUserInformationManagement";
            this.buttonCurrentUserInformationManagement.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCurrentUserInformationManagement.Size = new System.Drawing.Size(189, 36);
            this.buttonCurrentUserInformationManagement.TabIndex = 27;
            this.buttonCurrentUserInformationManagement.Text = "Thông tin cá nhân";
            this.buttonCurrentUserInformationManagement.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonCurrentUserInformationManagement.UseAccentColor = false;
            this.buttonCurrentUserInformationManagement.UseVisualStyleBackColor = true;
            this.buttonCurrentUserInformationManagement.Click += new System.EventHandler(this.buttonCurrentUserInformationManagement_Click);
            // 
            // buttonAdminLogout
            // 
            this.buttonAdminLogout.AutoSize = false;
            this.buttonAdminLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdminLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdminLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAdminLogout.Depth = 0;
            this.buttonAdminLogout.HighEmphasis = true;
            this.buttonAdminLogout.Icon = global::AccommodationManagerApp.Properties.Resources.logout;
            this.buttonAdminLogout.Location = new System.Drawing.Point(793, 25);
            this.buttonAdminLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAdminLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdminLogout.Name = "buttonAdminLogout";
            this.buttonAdminLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAdminLogout.Size = new System.Drawing.Size(134, 36);
            this.buttonAdminLogout.TabIndex = 26;
            this.buttonAdminLogout.Text = "Đăng Xuất";
            this.buttonAdminLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonAdminLogout.UseAccentColor = false;
            this.buttonAdminLogout.UseVisualStyleBackColor = true;
            // 
            // labelAdminEmail
            // 
            this.labelAdminEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelAdminEmail.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminEmail.Location = new System.Drawing.Point(274, 25);
            this.labelAdminEmail.Name = "labelAdminEmail";
            this.labelAdminEmail.Size = new System.Drawing.Size(246, 36);
            this.labelAdminEmail.TabIndex = 25;
            this.labelAdminEmail.Text = "user@email.com";
            this.labelAdminEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.buttonAdminLogin);
            this.Controls.Add(this.buttonCurrentUserInformationManagement);
            this.Controls.Add(this.buttonAdminLogout);
            this.Controls.Add(this.labelAdminEmail);
            this.Name = "AdminForm";
            this.Text = "";
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.labelAdminEmail, 0);
            this.Controls.SetChildIndex(this.buttonAdminLogout, 0);
            this.Controls.SetChildIndex(this.buttonCurrentUserInformationManagement, 0);
            this.Controls.SetChildIndex(this.buttonAdminLogin, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonAdminLogin;
        private MaterialSkin.Controls.MaterialButton buttonCurrentUserInformationManagement;
        private MaterialSkin.Controls.MaterialButton buttonAdminLogout;
        private System.Windows.Forms.Label labelAdminEmail;
    }
}