using System.ComponentModel;

namespace AccommodationManagerApp.Forms {
    partial class ResidentForm {
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
            this.comboBoxRoomNumber = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.comboBoxEmail = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxName = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.AutoResize = false;
            this.comboBoxRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxRoomNumber.Depth = 0;
            this.comboBoxRoomNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxRoomNumber.DropDownHeight = 174;
            this.comboBoxRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomNumber.DropDownWidth = 121;
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.IntegralHeight = false;
            this.comboBoxRoomNumber.ItemHeight = 43;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(160, 215);
            this.comboBoxRoomNumber.MaxDropDownItems = 4;
            this.comboBoxRoomNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(242, 49);
            this.comboBoxRoomNumber.StartIndex = 0;
            this.comboBoxRoomNumber.TabIndex = 26;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(30, 226);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 24);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "Căn hộ số:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = false;
            this.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonSave.Depth = 0;
            this.ButtonSave.HighEmphasis = true;
            this.ButtonSave.Icon = global::AccommodationManagerApp.Properties.Resources.save;
            this.ButtonSave.Location = new System.Drawing.Point(306, 284);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonSave.Size = new System.Drawing.Size(96, 40);
            this.ButtonSave.TabIndex = 27;
            this.ButtonSave.Text = "Lưu";
            this.ButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonSave.UseAccentColor = false;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.AutoResize = false;
            this.comboBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxEmail.Depth = 0;
            this.comboBoxEmail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxEmail.DropDownHeight = 174;
            this.comboBoxEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmail.DropDownWidth = 121;
            this.comboBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.IntegralHeight = false;
            this.comboBoxEmail.ItemHeight = 43;
            this.comboBoxEmail.Location = new System.Drawing.Point(159, 149);
            this.comboBoxEmail.MaxDropDownItems = 4;
            this.comboBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(243, 49);
            this.comboBoxEmail.StartIndex = 0;
            this.comboBoxEmail.TabIndex = 35;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(29, 159);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(55, 24);
            this.materialLabel8.TabIndex = 34;
            this.materialLabel8.Text = "Email:";
            // 
            // comboBoxName
            // 
            this.comboBoxName.AutoResize = false;
            this.comboBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxName.Depth = 0;
            this.comboBoxName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxName.DropDownHeight = 174;
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.DropDownWidth = 121;
            this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.IntegralHeight = false;
            this.comboBoxName.ItemHeight = 43;
            this.comboBoxName.Location = new System.Drawing.Point(160, 84);
            this.comboBoxName.MaxDropDownItems = 4;
            this.comboBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(242, 49);
            this.comboBoxName.StartIndex = 0;
            this.comboBoxName.TabIndex = 33;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(30, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 24);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "Người thuê:";
            // 
            // ResidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 359);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.comboBoxRoomNumber);
            this.Controls.Add(this.materialLabel2);
            this.MaximumSize = new System.Drawing.Size(433, 359);
            this.MinimumSize = new System.Drawing.Size(433, 359);
            this.Name = "ResidentForm";
            this.Text = "Thêm nhân khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResidentForm_FormClosing);
            this.Controls.SetChildIndex(this.materialLabel2, 0);
            this.Controls.SetChildIndex(this.comboBoxRoomNumber, 0);
            this.Controls.SetChildIndex(this.ButtonSave, 0);
            this.Controls.SetChildIndex(this.materialLabel1, 0);
            this.Controls.SetChildIndex(this.comboBoxName, 0);
            this.Controls.SetChildIndex(this.materialLabel8, 0);
            this.Controls.SetChildIndex(this.comboBoxEmail, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox comboBoxRoomNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton ButtonSave;
        private MaterialSkin.Controls.MaterialComboBox comboBoxEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox comboBoxName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}