namespace AccommodationManagerApp.Forms
{
    partial class UpdateReq
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
            this.btnUdp = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnUdp
            // 
            this.btnUdp.AutoSize = false;
            this.btnUdp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUdp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUdp.Depth = 0;
            this.btnUdp.HighEmphasis = true;
            this.btnUdp.Icon = global::AccommodationManagerApp.Properties.Resources.save;
            this.btnUdp.Location = new System.Drawing.Point(275, 403);
            this.btnUdp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUdp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUdp.Name = "btnUdp";
            this.btnUdp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUdp.Size = new System.Drawing.Size(95, 36);
            this.btnUdp.TabIndex = 5;
            this.btnUdp.Text = "Lưu";
            this.btnUdp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUdp.UseAccentColor = false;
            this.btnUdp.UseVisualStyleBackColor = true;
            this.btnUdp.Click += new System.EventHandler(this.update);
            // 
            // UpdateReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 539);
            this.Controls.Add(this.btnUdp);
            this.Name = "UpdateReq";
            this.Text = "UpdateReq";
            this.Controls.SetChildIndex(this.lblReqDate, 0);
            this.Controls.SetChildIndex(this.txtReq, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnUdp, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected MaterialSkin.Controls.MaterialButton btnUdp;
    }
}