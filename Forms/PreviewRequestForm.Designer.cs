namespace AccommodationManagerApp.Forms
{
    partial class PreviewRequestForm
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
            this.labelRequestUser = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDesRequest = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.labelRequestDate = new MaterialSkin.Controls.MaterialLabel();
            this.buttonResponse = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // labelRequestUser
            // 
            this.labelRequestUser.AutoSize = true;
            this.labelRequestUser.Depth = 0;
            this.labelRequestUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelRequestUser.Location = new System.Drawing.Point(32, 78);
            this.labelRequestUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRequestUser.Name = "labelRequestUser";
            this.labelRequestUser.Size = new System.Drawing.Size(138, 19);
            this.labelRequestUser.TabIndex = 0;
            this.labelRequestUser.Text = "Tên Người Yêu Cầu";
            // 
            // textBoxDesRequest
            // 
            this.textBoxDesRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxDesRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDesRequest.Depth = 0;
            this.textBoxDesRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxDesRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDesRequest.Location = new System.Drawing.Point(35, 103);
            this.textBoxDesRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDesRequest.Name = "textBoxDesRequest";
            this.textBoxDesRequest.ReadOnly = true;
            this.textBoxDesRequest.Size = new System.Drawing.Size(424, 281);
            this.textBoxDesRequest.TabIndex = 1;
            this.textBoxDesRequest.Text = "";
            // 
            // labelRequestDate
            // 
            this.labelRequestDate.AutoSize = true;
            this.labelRequestDate.Depth = 0;
            this.labelRequestDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelRequestDate.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelRequestDate.Location = new System.Drawing.Point(379, 400);
            this.labelRequestDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRequestDate.Name = "labelRequestDate";
            this.labelRequestDate.Size = new System.Drawing.Size(69, 17);
            this.labelRequestDate.TabIndex = 2;
            this.labelRequestDate.Text = "Ngày đăng";
            // 
            // buttonResponse
            // 
            this.buttonResponse.AutoSize = false;
            this.buttonResponse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResponse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonResponse.Depth = 0;
            this.buttonResponse.HighEmphasis = true;
            this.buttonResponse.Icon = global::AccommodationManagerApp.Properties.Resources.response;
            this.buttonResponse.Location = new System.Drawing.Point(169, 429);
            this.buttonResponse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonResponse.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonResponse.Name = "buttonResponse";
            this.buttonResponse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonResponse.Size = new System.Drawing.Size(130, 36);
            this.buttonResponse.TabIndex = 3;
            this.buttonResponse.Text = "Phản Hồi";
            this.buttonResponse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonResponse.UseAccentColor = false;
            this.buttonResponse.UseVisualStyleBackColor = true;
            this.buttonResponse.Click += new System.EventHandler(this.buttonResponse_Click);
            // 
            // PreviewRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 500);
            this.Controls.Add(this.buttonResponse);
            this.Controls.Add(this.labelRequestDate);
            this.Controls.Add(this.textBoxDesRequest);
            this.Controls.Add(this.labelRequestUser);
            this.MaximumSize = new System.Drawing.Size(510, 500);
            this.MinimumSize = new System.Drawing.Size(510, 500);
            this.Name = "PreviewRequestForm";
            this.Text = "Xem Chi Tiết Yêu Cầu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelRequestUser;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textBoxDesRequest;
        private MaterialSkin.Controls.MaterialLabel labelRequestDate;
        private MaterialSkin.Controls.MaterialButton buttonResponse;
    }
}