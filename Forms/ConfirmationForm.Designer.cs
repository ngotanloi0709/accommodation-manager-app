using System.ComponentModel;

namespace AccommodationManagerApp.Forms {
    sealed partial class ConfirmationForm {
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
            this.labelMessage = new MaterialSkin.Controls.MaterialLabel();
            this.buttonYes = new MaterialSkin.Controls.MaterialButton();
            this.buttonNo = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.Depth = 0;
            this.labelMessage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelMessage.Location = new System.Drawing.Point(24, 36);
            this.labelMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(253, 57);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Thông báo";
            // 
            // buttonYes
            // 
            this.buttonYes.AutoSize = false;
            this.buttonYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonYes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonYes.Depth = 0;
            this.buttonYes.HighEmphasis = true;
            this.buttonYes.Icon = null;
            this.buttonYes.Location = new System.Drawing.Point(124, 99);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonYes.Size = new System.Drawing.Size(75, 36);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "Đồng ý";
            this.buttonYes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonYes.UseAccentColor = false;
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.AutoSize = false;
            this.buttonNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonNo.Depth = 0;
            this.buttonNo.HighEmphasis = true;
            this.buttonNo.Icon = null;
            this.buttonNo.Location = new System.Drawing.Point(219, 99);
            this.buttonNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonNo.Size = new System.Drawing.Size(75, 36);
            this.buttonNo.TabIndex = 2;
            this.buttonNo.Text = "Huỷ";
            this.buttonNo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonNo.UseAccentColor = false;
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(298, 144);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelMessage);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(298, 144);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(298, 144);
            this.Name = "ConfirmationForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComfirmationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelMessage;
        private MaterialSkin.Controls.MaterialButton buttonYes;
        private MaterialSkin.Controls.MaterialButton buttonNo;
    }
}