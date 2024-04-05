namespace AccommodationManagerApp.Forms
{
    partial class PreviewResponseForm
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
            this.labelRequestDate = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDesRequest = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.labelRequestUser = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // labelRequestDate
            // 
            this.labelRequestDate.AutoSize = true;
            this.labelRequestDate.Depth = 0;
            this.labelRequestDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelRequestDate.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelRequestDate.Location = new System.Drawing.Point(383, 400);
            this.labelRequestDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRequestDate.Name = "labelRequestDate";
            this.labelRequestDate.Size = new System.Drawing.Size(69, 17);
            this.labelRequestDate.TabIndex = 6;
            this.labelRequestDate.Text = "Ngày đăng";
            // 
            // textBoxDesRequest
            // 
            this.textBoxDesRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxDesRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDesRequest.Depth = 0;
            this.textBoxDesRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxDesRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDesRequest.Location = new System.Drawing.Point(39, 103);
            this.textBoxDesRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDesRequest.Name = "textBoxDesRequest";
            this.textBoxDesRequest.ReadOnly = true;
            this.textBoxDesRequest.Size = new System.Drawing.Size(424, 281);
            this.textBoxDesRequest.TabIndex = 5;
            this.textBoxDesRequest.Text = "";
            // 
            // labelRequestUser
            // 
            this.labelRequestUser.AutoSize = true;
            this.labelRequestUser.Depth = 0;
            this.labelRequestUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelRequestUser.Location = new System.Drawing.Point(36, 78);
            this.labelRequestUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRequestUser.Name = "labelRequestUser";
            this.labelRequestUser.Size = new System.Drawing.Size(138, 19);
            this.labelRequestUser.TabIndex = 4;
            this.labelRequestUser.Text = "Tên Người Yêu Cầu";
            // 
            // PreviewResponseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.labelRequestDate);
            this.Controls.Add(this.textBoxDesRequest);
            this.Controls.Add(this.labelRequestUser);
            this.MaximumSize = new System.Drawing.Size(500, 450);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "PreviewResponseForm";
            this.Text = "Phản hồi từ chủ hộ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel labelRequestDate;
        private MaterialSkin.Controls.MaterialMultiLineTextBox textBoxDesRequest;
        private MaterialSkin.Controls.MaterialLabel labelRequestUser;
    }
}