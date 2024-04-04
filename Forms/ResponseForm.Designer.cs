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
            this.labelUserName = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDesRequest = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.labelDateRequest = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxResponse = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.buttonResponse = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Depth = 0;
            this.labelUserName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelUserName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelUserName.Location = new System.Drawing.Point(32, 85);
            this.labelUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(175, 24);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Tên người yêu cầu  ";
            // 
            // textBoxDesRequest
            // 
            this.textBoxDesRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxDesRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDesRequest.Depth = 0;
            this.textBoxDesRequest.Enabled = false;
            this.textBoxDesRequest.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxDesRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDesRequest.Location = new System.Drawing.Point(36, 115);
            this.textBoxDesRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDesRequest.Name = "textBoxDesRequest";
            this.textBoxDesRequest.Size = new System.Drawing.Size(654, 112);
            this.textBoxDesRequest.TabIndex = 2;
            this.textBoxDesRequest.Text = "";
            // 
            // labelDateRequest
            // 
            this.labelDateRequest.AutoSize = true;
            this.labelDateRequest.Depth = 0;
            this.labelDateRequest.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelDateRequest.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.labelDateRequest.Location = new System.Drawing.Point(589, 230);
            this.labelDateRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDateRequest.Name = "labelDateRequest";
            this.labelDateRequest.Size = new System.Drawing.Size(101, 19);
            this.labelDateRequest.TabIndex = 3;
            this.labelDateRequest.Text = "Ngày Yêu Cầu";
            this.labelDateRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResponse.Depth = 0;
            this.textBoxResponse.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxResponse.Location = new System.Drawing.Point(36, 288);
            this.textBoxResponse.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(536, 43);
            this.textBoxResponse.TabIndex = 4;
            this.textBoxResponse.Text = "";
            // 
            // buttonResponse
            // 
            this.buttonResponse.AutoSize = false;
            this.buttonResponse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResponse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonResponse.Depth = 0;
            this.buttonResponse.HighEmphasis = true;
            this.buttonResponse.Icon = null;
            this.buttonResponse.Location = new System.Drawing.Point(579, 288);
            this.buttonResponse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonResponse.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonResponse.Name = "buttonResponse";
            this.buttonResponse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonResponse.Size = new System.Drawing.Size(111, 43);
            this.buttonResponse.TabIndex = 5;
            this.buttonResponse.Text = "SEND";
            this.buttonResponse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonResponse.UseAccentColor = false;
            this.buttonResponse.UseVisualStyleBackColor = true;
            // 
            // ResponseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(720, 361);
            this.Controls.Add(this.buttonResponse);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.labelDateRequest);
            this.Controls.Add(this.textBoxDesRequest);
            this.Controls.Add(this.labelUserName);
            this.MinimumSize = new System.Drawing.Size(720, 350);
            this.Name = "ResponseForm";
            this.Text = "Phản Hồi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelUserName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textBoxDesRequest;
        private MaterialSkin.Controls.MaterialLabel labelDateRequest;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textBoxResponse;
        private MaterialSkin.Controls.MaterialButton buttonResponse;
    }
}