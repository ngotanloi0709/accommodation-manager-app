namespace AccommodationManagerApp.Forms
{
    partial class ResponseForm
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
            this.buttonResponse = new MaterialSkin.Controls.MaterialButton();
            this.labelResponseDate = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDesResponse = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.labelResponseUser = new MaterialSkin.Controls.MaterialLabel();
            this.buttonResponseEmail = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // buttonResponse
            // 
            this.buttonResponse.AutoSize = false;
            this.buttonResponse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResponse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonResponse.Depth = 0;
            this.buttonResponse.HighEmphasis = true;
            this.buttonResponse.Icon = global::AccommodationManagerApp.Properties.Resources.icon_black;
            this.buttonResponse.Location = new System.Drawing.Point(127, 441);
            this.buttonResponse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonResponse.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonResponse.Name = "buttonResponse";
            this.buttonResponse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonResponse.Size = new System.Drawing.Size(130, 36);
            this.buttonResponse.TabIndex = 7;
            this.buttonResponse.Text = "Qua Ứng Dụng";
            this.buttonResponse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonResponse.UseAccentColor = false;
            this.buttonResponse.UseVisualStyleBackColor = true;
            this.buttonResponse.Click += new System.EventHandler(this.buttonResponse_Click);
            // 
            // labelResponseDate
            // 
            this.labelResponseDate.AutoSize = true;
            this.labelResponseDate.Depth = 0;
            this.labelResponseDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelResponseDate.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelResponseDate.Location = new System.Drawing.Point(386, 407);
            this.labelResponseDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelResponseDate.Name = "labelResponseDate";
            this.labelResponseDate.Size = new System.Drawing.Size(69, 17);
            this.labelResponseDate.TabIndex = 6;
            this.labelResponseDate.Text = "Ngày đăng";
            // 
            // textBoxDesResponse
            // 
            this.textBoxDesResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxDesResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDesResponse.Depth = 0;
            this.textBoxDesResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxDesResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDesResponse.Location = new System.Drawing.Point(42, 110);
            this.textBoxDesResponse.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDesResponse.Name = "textBoxDesResponse";
            this.textBoxDesResponse.Size = new System.Drawing.Size(424, 281);
            this.textBoxDesResponse.TabIndex = 5;
            this.textBoxDesResponse.Text = "";
            // 
            // labelResponseUser
            // 
            this.labelResponseUser.AutoSize = true;
            this.labelResponseUser.Depth = 0;
            this.labelResponseUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelResponseUser.Location = new System.Drawing.Point(39, 85);
            this.labelResponseUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelResponseUser.Name = "labelResponseUser";
            this.labelResponseUser.Size = new System.Drawing.Size(138, 19);
            this.labelResponseUser.TabIndex = 4;
            this.labelResponseUser.Text = "Tên Người Yêu Cầu";
            // 
            // buttonResponseEmail
            // 
            this.buttonResponseEmail.AutoSize = false;
            this.buttonResponseEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResponseEmail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonResponseEmail.Depth = 0;
            this.buttonResponseEmail.HighEmphasis = true;
            this.buttonResponseEmail.Icon = global::AccommodationManagerApp.Properties.Resources.email;
            this.buttonResponseEmail.Location = new System.Drawing.Point(265, 441);
            this.buttonResponseEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonResponseEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonResponseEmail.Name = "buttonResponseEmail";
            this.buttonResponseEmail.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonResponseEmail.Size = new System.Drawing.Size(130, 36);
            this.buttonResponseEmail.TabIndex = 8;
            this.buttonResponseEmail.Text = "Qua Email";
            this.buttonResponseEmail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonResponseEmail.UseAccentColor = false;
            this.buttonResponseEmail.UseVisualStyleBackColor = true;
            this.buttonResponseEmail.Click += new System.EventHandler(this.buttonResponseEmail_Click);
            // 
            // ResponseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(510, 500);
            this.Controls.Add(this.buttonResponseEmail);
            this.Controls.Add(this.buttonResponse);
            this.Controls.Add(this.labelResponseDate);
            this.Controls.Add(this.textBoxDesResponse);
            this.Controls.Add(this.labelResponseUser);
            this.MaximumSize = new System.Drawing.Size(510, 500);
            this.MinimumSize = new System.Drawing.Size(510, 500);
            this.Name = "ResponseForm";
            this.Text = "Phản Hồi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton buttonResponse;
        private MaterialSkin.Controls.MaterialLabel labelResponseDate;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textBoxDesResponse;
        private MaterialSkin.Controls.MaterialLabel labelResponseUser;
        private MaterialSkin.Controls.MaterialButton buttonResponseEmail;
    }
}