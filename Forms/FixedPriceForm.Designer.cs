using System.ComponentModel;

namespace AccommodationManagerApp.Forms {
    partial class FixedPriceForm {
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxInternetPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxElectricityPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxWaterPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonSave = new MaterialSkin.Controls.MaterialButton();
            this.buttonMinusWater = new MaterialSkin.Controls.MaterialButton();
            this.buttonPlusWater = new MaterialSkin.Controls.MaterialButton();
            this.buttonMinusElectricity = new MaterialSkin.Controls.MaterialButton();
            this.buttonPlusElectricity = new MaterialSkin.Controls.MaterialButton();
            this.buttonMinusInternet = new MaterialSkin.Controls.MaterialButton();
            this.buttonPlusInternet = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(45, 209);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(121, 24);
            this.materialLabel3.TabIndex = 30;
            this.materialLabel3.Text = "Tiền Internet:";
            // 
            // textBoxInternetPrice
            // 
            this.textBoxInternetPrice.AnimateReadOnly = false;
            this.textBoxInternetPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInternetPrice.Depth = 0;
            this.textBoxInternetPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxInternetPrice.Hint = "Nhập tiền Internet";
            this.textBoxInternetPrice.LeadingIcon = null;
            this.textBoxInternetPrice.Location = new System.Drawing.Point(251, 200);
            this.textBoxInternetPrice.MaxLength = 50;
            this.textBoxInternetPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxInternetPrice.Multiline = false;
            this.textBoxInternetPrice.Name = "textBoxInternetPrice";
            this.textBoxInternetPrice.Size = new System.Drawing.Size(194, 50);
            this.textBoxInternetPrice.TabIndex = 29;
            this.textBoxInternetPrice.Text = "";
            this.textBoxInternetPrice.TrailingIcon = null;
            this.textBoxInternetPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWaterPrice_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(45, 151);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(175, 24);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "Tiền điện (đơn giá):";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(45, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(184, 24);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "Tiền Nước (đơn giá):";
            // 
            // textBoxElectricityPrice
            // 
            this.textBoxElectricityPrice.AnimateReadOnly = false;
            this.textBoxElectricityPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxElectricityPrice.Depth = 0;
            this.textBoxElectricityPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxElectricityPrice.Hint = "Nhập tiền điện";
            this.textBoxElectricityPrice.LeadingIcon = null;
            this.textBoxElectricityPrice.Location = new System.Drawing.Point(251, 144);
            this.textBoxElectricityPrice.MaxLength = 50;
            this.textBoxElectricityPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxElectricityPrice.Multiline = false;
            this.textBoxElectricityPrice.Name = "textBoxElectricityPrice";
            this.textBoxElectricityPrice.Size = new System.Drawing.Size(194, 50);
            this.textBoxElectricityPrice.TabIndex = 26;
            this.textBoxElectricityPrice.Text = "";
            this.textBoxElectricityPrice.TrailingIcon = null;
            this.textBoxElectricityPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWaterPrice_KeyPress);
            // 
            // textBoxWaterPrice
            // 
            this.textBoxWaterPrice.AnimateReadOnly = false;
            this.textBoxWaterPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWaterPrice.Depth = 0;
            this.textBoxWaterPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxWaterPrice.Hint = "Nhập tiền nước";
            this.textBoxWaterPrice.LeadingIcon = null;
            this.textBoxWaterPrice.Location = new System.Drawing.Point(251, 85);
            this.textBoxWaterPrice.MaxLength = 50;
            this.textBoxWaterPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxWaterPrice.Multiline = false;
            this.textBoxWaterPrice.Name = "textBoxWaterPrice";
            this.textBoxWaterPrice.Size = new System.Drawing.Size(194, 50);
            this.textBoxWaterPrice.TabIndex = 25;
            this.textBoxWaterPrice.Text = "";
            this.textBoxWaterPrice.TrailingIcon = null;
            this.textBoxWaterPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWaterPrice_KeyPress);
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = false;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSave.Depth = 0;
            this.buttonSave.HighEmphasis = true;
            this.buttonSave.Icon = null;
            this.buttonSave.Location = new System.Drawing.Point(578, 270);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSave.Size = new System.Drawing.Size(87, 36);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSave.UseAccentColor = false;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonMinusWater
            // 
            this.buttonMinusWater.AutoSize = false;
            this.buttonMinusWater.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMinusWater.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonMinusWater.Depth = 0;
            this.buttonMinusWater.HighEmphasis = true;
            this.buttonMinusWater.Icon = global::AccommodationManagerApp.Properties.Resources.minus;
            this.buttonMinusWater.Location = new System.Drawing.Point(465, 90);
            this.buttonMinusWater.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonMinusWater.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonMinusWater.Name = "buttonMinusWater";
            this.buttonMinusWater.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonMinusWater.Size = new System.Drawing.Size(96, 40);
            this.buttonMinusWater.TabIndex = 33;
            this.buttonMinusWater.Text = "100";
            this.buttonMinusWater.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonMinusWater.UseAccentColor = false;
            this.buttonMinusWater.UseVisualStyleBackColor = true;
            this.buttonMinusWater.Click += new System.EventHandler(this.buttonMinusWater_Click);
            // 
            // buttonPlusWater
            // 
            this.buttonPlusWater.AutoSize = false;
            this.buttonPlusWater.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlusWater.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonPlusWater.Depth = 0;
            this.buttonPlusWater.HighEmphasis = true;
            this.buttonPlusWater.Icon = global::AccommodationManagerApp.Properties.Resources.plus;
            this.buttonPlusWater.Location = new System.Drawing.Point(569, 90);
            this.buttonPlusWater.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPlusWater.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPlusWater.Name = "buttonPlusWater";
            this.buttonPlusWater.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonPlusWater.Size = new System.Drawing.Size(96, 40);
            this.buttonPlusWater.TabIndex = 32;
            this.buttonPlusWater.Text = "100";
            this.buttonPlusWater.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonPlusWater.UseAccentColor = false;
            this.buttonPlusWater.UseVisualStyleBackColor = true;
            this.buttonPlusWater.Click += new System.EventHandler(this.buttonPlusWater_Click);
            // 
            // buttonMinusElectricity
            // 
            this.buttonMinusElectricity.AutoSize = false;
            this.buttonMinusElectricity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMinusElectricity.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonMinusElectricity.Depth = 0;
            this.buttonMinusElectricity.HighEmphasis = true;
            this.buttonMinusElectricity.Icon = global::AccommodationManagerApp.Properties.Resources.minus;
            this.buttonMinusElectricity.Location = new System.Drawing.Point(465, 145);
            this.buttonMinusElectricity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonMinusElectricity.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonMinusElectricity.Name = "buttonMinusElectricity";
            this.buttonMinusElectricity.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonMinusElectricity.Size = new System.Drawing.Size(96, 40);
            this.buttonMinusElectricity.TabIndex = 35;
            this.buttonMinusElectricity.Text = "100";
            this.buttonMinusElectricity.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonMinusElectricity.UseAccentColor = false;
            this.buttonMinusElectricity.UseVisualStyleBackColor = true;
            this.buttonMinusElectricity.Click += new System.EventHandler(this.buttonMinusElectricity_Click);
            // 
            // buttonPlusElectricity
            // 
            this.buttonPlusElectricity.AutoSize = false;
            this.buttonPlusElectricity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlusElectricity.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonPlusElectricity.Depth = 0;
            this.buttonPlusElectricity.HighEmphasis = true;
            this.buttonPlusElectricity.Icon = global::AccommodationManagerApp.Properties.Resources.plus;
            this.buttonPlusElectricity.Location = new System.Drawing.Point(569, 145);
            this.buttonPlusElectricity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPlusElectricity.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPlusElectricity.Name = "buttonPlusElectricity";
            this.buttonPlusElectricity.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonPlusElectricity.Size = new System.Drawing.Size(96, 40);
            this.buttonPlusElectricity.TabIndex = 34;
            this.buttonPlusElectricity.Text = "100";
            this.buttonPlusElectricity.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonPlusElectricity.UseAccentColor = false;
            this.buttonPlusElectricity.UseVisualStyleBackColor = true;
            this.buttonPlusElectricity.Click += new System.EventHandler(this.buttonPlusElectricity_Click);
            // 
            // buttonMinusInternet
            // 
            this.buttonMinusInternet.AutoSize = false;
            this.buttonMinusInternet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMinusInternet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonMinusInternet.Depth = 0;
            this.buttonMinusInternet.HighEmphasis = true;
            this.buttonMinusInternet.Icon = global::AccommodationManagerApp.Properties.Resources.minus;
            this.buttonMinusInternet.Location = new System.Drawing.Point(465, 203);
            this.buttonMinusInternet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonMinusInternet.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonMinusInternet.Name = "buttonMinusInternet";
            this.buttonMinusInternet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonMinusInternet.Size = new System.Drawing.Size(96, 40);
            this.buttonMinusInternet.TabIndex = 37;
            this.buttonMinusInternet.Text = "10000";
            this.buttonMinusInternet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonMinusInternet.UseAccentColor = false;
            this.buttonMinusInternet.UseVisualStyleBackColor = true;
            this.buttonMinusInternet.Click += new System.EventHandler(this.buttonMinusInternet_Click);
            // 
            // buttonPlusInternet
            // 
            this.buttonPlusInternet.AutoSize = false;
            this.buttonPlusInternet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlusInternet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonPlusInternet.Depth = 0;
            this.buttonPlusInternet.HighEmphasis = true;
            this.buttonPlusInternet.Icon = global::AccommodationManagerApp.Properties.Resources.plus;
            this.buttonPlusInternet.Location = new System.Drawing.Point(569, 203);
            this.buttonPlusInternet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPlusInternet.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPlusInternet.Name = "buttonPlusInternet";
            this.buttonPlusInternet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonPlusInternet.Size = new System.Drawing.Size(96, 40);
            this.buttonPlusInternet.TabIndex = 36;
            this.buttonPlusInternet.Text = "10000";
            this.buttonPlusInternet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonPlusInternet.UseAccentColor = false;
            this.buttonPlusInternet.UseVisualStyleBackColor = true;
            this.buttonPlusInternet.Click += new System.EventHandler(this.buttonPlusInternet_Click);
            // 
            // FixedPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 349);
            this.Controls.Add(this.buttonMinusInternet);
            this.Controls.Add(this.buttonPlusInternet);
            this.Controls.Add(this.buttonMinusElectricity);
            this.Controls.Add(this.buttonPlusElectricity);
            this.Controls.Add(this.buttonMinusWater);
            this.Controls.Add(this.buttonPlusWater);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.textBoxInternetPrice);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxElectricityPrice);
            this.Controls.Add(this.textBoxWaterPrice);
            this.MaximumSize = new System.Drawing.Size(693, 349);
            this.MinimumSize = new System.Drawing.Size(693, 349);
            this.Name = "FixedPriceForm";
            this.Sizable = false;
            this.Text = "Chỉnh sửa chi phí cố định";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FixedPriceForm_FormClosing);
            this.Controls.SetChildIndex(this.textBoxWaterPrice, 0);
            this.Controls.SetChildIndex(this.textBoxElectricityPrice, 0);
            this.Controls.SetChildIndex(this.materialLabel1, 0);
            this.Controls.SetChildIndex(this.materialLabel2, 0);
            this.Controls.SetChildIndex(this.textBoxInternetPrice, 0);
            this.Controls.SetChildIndex(this.materialLabel3, 0);
            this.Controls.SetChildIndex(this.buttonSave, 0);
            this.Controls.SetChildIndex(this.buttonPlusWater, 0);
            this.Controls.SetChildIndex(this.buttonMinusWater, 0);
            this.Controls.SetChildIndex(this.buttonPlusElectricity, 0);
            this.Controls.SetChildIndex(this.buttonMinusElectricity, 0);
            this.Controls.SetChildIndex(this.buttonPlusInternet, 0);
            this.Controls.SetChildIndex(this.buttonMinusInternet, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox textBoxInternetPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox textBoxElectricityPrice;
        private MaterialSkin.Controls.MaterialTextBox textBoxWaterPrice;
        private MaterialSkin.Controls.MaterialButton buttonSave;
        private MaterialSkin.Controls.MaterialButton buttonMinusWater;
        private MaterialSkin.Controls.MaterialButton buttonPlusWater;
        private MaterialSkin.Controls.MaterialButton buttonMinusElectricity;
        private MaterialSkin.Controls.MaterialButton buttonPlusElectricity;
        private MaterialSkin.Controls.MaterialButton buttonMinusInternet;
        private MaterialSkin.Controls.MaterialButton buttonPlusInternet;
    }
}