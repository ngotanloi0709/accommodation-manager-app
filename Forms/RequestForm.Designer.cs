namespace AccommodationManagerApp.Forms
{
    partial class RequestForm
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
            this.pbxReq = new System.Windows.Forms.PictureBox();
            this.lblReqDate = new MaterialSkin.Controls.MaterialLabel();
            this.txtReq = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.ButtonSave = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReq)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxReq
            // 
            this.pbxReq.Image = global::AccommodationManagerApp.Properties.Resources.icon_250;
            this.pbxReq.Location = new System.Drawing.Point(24, 94);
            this.pbxReq.Name = "pbxReq";
            this.pbxReq.Size = new System.Drawing.Size(150, 130);
            this.pbxReq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxReq.TabIndex = 0;
            this.pbxReq.TabStop = false;
            // 
            // lblReqDate
            // 
            this.lblReqDate.AutoSize = true;
            this.lblReqDate.Depth = 0;
            this.lblReqDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblReqDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblReqDate.Location = new System.Drawing.Point(191, 158);
            this.lblReqDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReqDate.Name = "lblReqDate";
            this.lblReqDate.Size = new System.Drawing.Size(86, 24);
            this.lblReqDate.TabIndex = 1;
            this.lblReqDate.Text = "Ngày Tạo";
            // 
            // txtReq
            // 
            this.txtReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReq.Depth = 0;
            this.txtReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtReq.Location = new System.Drawing.Point(24, 249);
            this.txtReq.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtReq.Name = "txtReq";
            this.txtReq.Size = new System.Drawing.Size(449, 126);
            this.txtReq.TabIndex = 2;
            this.txtReq.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(191, 200);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(207, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Mời bạn nhập yêu cầu: ";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = global::AccommodationManagerApp.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(378, 403);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(95, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Close);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = false;
            this.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonSave.Depth = 0;
            this.ButtonSave.HighEmphasis = true;
            this.ButtonSave.Icon = global::AccommodationManagerApp.Properties.Resources.plus1;
            this.ButtonSave.Location = new System.Drawing.Point(275, 403);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonSave.Size = new System.Drawing.Size(95, 36);
            this.ButtonSave.TabIndex = 25;
            this.ButtonSave.Text = "Lưu";
            this.ButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonSave.UseAccentColor = false;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.AddAndUpdateRequest);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 460);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtReq);
            this.Controls.Add(this.lblReqDate);
            this.Controls.Add(this.pbxReq);
            this.MaximumSize = new System.Drawing.Size(490, 460);
            this.MinimumSize = new System.Drawing.Size(490, 460);
            this.Name = "RequestForm";
            this.Text = "ReqForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RequestForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxReq;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        protected MaterialSkin.Controls.MaterialLabel lblReqDate;
        protected MaterialSkin.Controls.MaterialMultiLineTextBox txtReq;
        protected MaterialSkin.Controls.MaterialButton btnClose;
        protected MaterialSkin.Controls.MaterialButton ButtonSave;
    }
}