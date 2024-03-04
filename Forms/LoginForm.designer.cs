namespace AccommodationManagerApp.Forms
{
    partial class LoginForm
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
            this.TextBoxEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.labelEmail = new MaterialSkin.Controls.MaterialLabel();
            this.labelPassword = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.buttonLogin = new MaterialSkin.Controls.MaterialButton();
            this.buttonExit = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.AnimateReadOnly = false;
            this.TextBoxEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxEmail.Depth = 0;
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxEmail.HideSelection = true;
            this.TextBoxEmail.LeadingIcon = null;
            this.TextBoxEmail.Location = new System.Drawing.Point(131, 36);
            this.TextBoxEmail.MaximumSize = new System.Drawing.Size(250, 48);
            this.TextBoxEmail.MaxLength = 32767;
            this.TextBoxEmail.MinimumSize = new System.Drawing.Size(250, 48);
            this.TextBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.PasswordChar = '\0';
            this.TextBoxEmail.PrefixSuffixText = null;
            this.TextBoxEmail.ReadOnly = false;
            this.TextBoxEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxEmail.SelectedText = "";
            this.TextBoxEmail.SelectionLength = 0;
            this.TextBoxEmail.SelectionStart = 0;
            this.TextBoxEmail.ShortcutsEnabled = true;
            this.TextBoxEmail.Size = new System.Drawing.Size(250, 48);
            this.TextBoxEmail.TabIndex = 0;
            this.TextBoxEmail.TabStop = false;
            this.TextBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxEmail.TrailingIcon = null;
            this.TextBoxEmail.UseSystemPasswordChar = false;
            // 
            // labelEmail
            // 
            this.labelEmail.Depth = 0;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelEmail.Location = new System.Drawing.Point(35, 50);
            this.labelEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(75, 21);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.Depth = 0;
            this.labelPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelPassword.Location = new System.Drawing.Point(35, 114);
            this.labelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 19);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.AnimateReadOnly = false;
            this.TextBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxPassword.Depth = 0;
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxPassword.HideSelection = true;
            this.TextBoxPassword.LeadingIcon = null;
            this.TextBoxPassword.Location = new System.Drawing.Point(131, 98);
            this.TextBoxPassword.MaximumSize = new System.Drawing.Size(250, 48);
            this.TextBoxPassword.MaxLength = 32767;
            this.TextBoxPassword.MinimumSize = new System.Drawing.Size(250, 48);
            this.TextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '\0';
            this.TextBoxPassword.PrefixSuffixText = null;
            this.TextBoxPassword.ReadOnly = false;
            this.TextBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.SelectionLength = 0;
            this.TextBoxPassword.SelectionStart = 0;
            this.TextBoxPassword.ShortcutsEnabled = true;
            this.TextBoxPassword.Size = new System.Drawing.Size(250, 48);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.TabStop = false;
            this.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxPassword.TrailingIcon = null;
            this.TextBoxPassword.UseSystemPasswordChar = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = false;
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonLogin.Depth = 0;
            this.buttonLogin.HighEmphasis = true;
            this.buttonLogin.Icon = null;
            this.buttonLogin.Location = new System.Drawing.Point(277, 164);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonLogin.MaximumSize = new System.Drawing.Size(104, 36);
            this.buttonLogin.MinimumSize = new System.Drawing.Size(104, 36);
            this.buttonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonLogin.Size = new System.Drawing.Size(104, 36);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonLogin.UseAccentColor = false;
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = false;
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonExit.Depth = 0;
            this.buttonExit.HighEmphasis = true;
            this.buttonExit.Icon = null;
            this.buttonExit.Location = new System.Drawing.Point(131, 164);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonExit.MaximumSize = new System.Drawing.Size(104, 36);
            this.buttonExit.MinimumSize = new System.Drawing.Size(104, 36);
            this.buttonExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonExit.Size = new System.Drawing.Size(104, 36);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonExit.UseAccentColor = false;
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(411, 231);
            this.ControlBox = false;
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxEmail);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(411, 231);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(411, 231);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 TextBoxEmail;
        private MaterialSkin.Controls.MaterialLabel labelEmail;
        private MaterialSkin.Controls.MaterialLabel labelPassword;
        private MaterialSkin.Controls.MaterialTextBox2 TextBoxPassword;
        private MaterialSkin.Controls.MaterialButton buttonLogin;
        private MaterialSkin.Controls.MaterialButton buttonExit;
    }
}