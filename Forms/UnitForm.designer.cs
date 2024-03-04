namespace TenantManagementSystem.Forms
{
    partial class UnitForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxBuilding = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.ButtonDelete = new MaterialSkin.Controls.MaterialButton();
            this.ButtonClose = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(54, 51);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Name";
            // 
            // TextBoxName
            // 
            this.TextBoxName.AnimateReadOnly = false;
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxName.Depth = 0;
            this.TextBoxName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxName.LeadingIcon = null;
            this.TextBoxName.Location = new System.Drawing.Point(136, 38);
            this.TextBoxName.MaxLength = 50;
            this.TextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxName.Multiline = false;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(212, 50);
            this.TextBoxName.TabIndex = 1;
            this.TextBoxName.Text = "";
            this.TextBoxName.TrailingIcon = null;
            // 
            // TextBoxBuilding
            // 
            this.TextBoxBuilding.AnimateReadOnly = false;
            this.TextBoxBuilding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxBuilding.Depth = 0;
            this.TextBoxBuilding.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxBuilding.LeadingIcon = null;
            this.TextBoxBuilding.Location = new System.Drawing.Point(136, 108);
            this.TextBoxBuilding.MaxLength = 50;
            this.TextBoxBuilding.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxBuilding.Multiline = false;
            this.TextBoxBuilding.Name = "TextBoxBuilding";
            this.TextBoxBuilding.Size = new System.Drawing.Size(212, 50);
            this.TextBoxBuilding.TabIndex = 3;
            this.TextBoxBuilding.Text = "";
            this.TextBoxBuilding.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(54, 126);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(59, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Building";
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = false;
            this.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonSave.Depth = 0;
            this.ButtonSave.HighEmphasis = true;
            this.ButtonSave.Icon = null;
            this.ButtonSave.Location = new System.Drawing.Point(156, 182);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonSave.Size = new System.Drawing.Size(92, 40);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonSave.UseAccentColor = false;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoSize = false;
            this.ButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonDelete.Depth = 0;
            this.ButtonDelete.HighEmphasis = true;
            this.ButtonDelete.Icon = null;
            this.ButtonDelete.Location = new System.Drawing.Point(56, 182);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonDelete.Size = new System.Drawing.Size(92, 40);
            this.ButtonDelete.TabIndex = 5;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonDelete.UseAccentColor = false;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.AutoSize = false;
            this.ButtonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonClose.Depth = 0;
            this.ButtonClose.HighEmphasis = true;
            this.ButtonClose.Icon = null;
            this.ButtonClose.Location = new System.Drawing.Point(256, 182);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonClose.Size = new System.Drawing.Size(92, 40);
            this.ButtonClose.TabIndex = 6;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonClose.UseAccentColor = false;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // UnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(374, 253);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxBuilding);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox TextBoxName;
        private MaterialSkin.Controls.MaterialTextBox TextBoxBuilding;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton ButtonSave;
        private MaterialSkin.Controls.MaterialButton ButtonDelete;
        private MaterialSkin.Controls.MaterialButton ButtonClose;
    }
}