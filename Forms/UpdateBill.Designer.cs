namespace AccommodationManagerApp.Forms.Bill
{
    partial class UpdateBill
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
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtbxWater
            // 
            this.txtbxWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            // 
            // txtbxElectric
            // 
            this.txtbxElectric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = global::AccommodationManagerApp.Properties.Resources.save;
            this.btnAdd.Location = new System.Drawing.Point(268, 434);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(95, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.update);
            // 
            // UpdateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 617);
            this.Controls.Add(this.btnAdd);
            this.Name = "UpdateBill";
            this.Text = "UpdateBill";
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.cmbboxRent, 0);
            this.Controls.SetChildIndex(this.cmbboxRoom, 0);
            this.Controls.SetChildIndex(this.txtbxWater, 0);
            this.Controls.SetChildIndex(this.txtbxElectric, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAdd;
    }
}