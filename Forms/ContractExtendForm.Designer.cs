using System.ComponentModel;

namespace AccommodationManagerApp.Forms {
    partial class ContractExtendForm {
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
            this.comboBoxMonth = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePickerContractStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelContractEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.labelTenantName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.labelRoomNumber = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.AutoResize = false;
            this.comboBoxMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxMonth.Depth = 0;
            this.comboBoxMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxMonth.DropDownHeight = 174;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.DropDownWidth = 121;
            this.comboBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.IntegralHeight = false;
            this.comboBoxMonth.ItemHeight = 43;
            this.comboBoxMonth.Location = new System.Drawing.Point(161, 218);
            this.comboBoxMonth.MaxDropDownItems = 4;
            this.comboBoxMonth.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(276, 49);
            this.comboBoxMonth.StartIndex = 0;
            this.comboBoxMonth.TabIndex = 22;
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(23, 231);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(85, 24);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Số tháng:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = false;
            this.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonSave.Depth = 0;
            this.ButtonSave.HighEmphasis = true;
            this.ButtonSave.Icon = global::AccommodationManagerApp.Properties.Resources.save;
            this.ButtonSave.Location = new System.Drawing.Point(341, 338);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonSave.Size = new System.Drawing.Size(96, 40);
            this.ButtonSave.TabIndex = 23;
            this.ButtonSave.Text = "Lưu";
            this.ButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonSave.UseAccentColor = false;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(23, 173);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(125, 24);
            this.materialLabel5.TabIndex = 25;
            this.materialLabel5.Text = "Ngày bắt đầu:";
            // 
            // dateTimePickerContractStartDate
            // 
            this.dateTimePickerContractStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerContractStartDate.Location = new System.Drawing.Point(161, 173);
            this.dateTimePickerContractStartDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerContractStartDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerContractStartDate.Name = "dateTimePickerContractStartDate";
            this.dateTimePickerContractStartDate.Size = new System.Drawing.Size(276, 26);
            this.dateTimePickerContractStartDate.TabIndex = 24;
            this.dateTimePickerContractStartDate.Value = new System.DateTime(2024, 3, 28, 0, 0, 0, 0);
            // 
            // labelContractEndDate
            // 
            this.labelContractEndDate.AutoSize = true;
            this.labelContractEndDate.Depth = 0;
            this.labelContractEndDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelContractEndDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelContractEndDate.Location = new System.Drawing.Point(157, 289);
            this.labelContractEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelContractEndDate.Name = "labelContractEndDate";
            this.labelContractEndDate.Size = new System.Drawing.Size(280, 24);
            this.labelContractEndDate.TabIndex = 28;
            this.labelContractEndDate.Text = "_______________________________";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(22, 289);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(129, 24);
            this.materialLabel6.TabIndex = 27;
            this.materialLabel6.Text = "Ngày kết thúc:";
            // 
            // labelTenantName
            // 
            this.labelTenantName.AutoSize = true;
            this.labelTenantName.Depth = 0;
            this.labelTenantName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTenantName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelTenantName.Location = new System.Drawing.Point(157, 81);
            this.labelTenantName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTenantName.Name = "labelTenantName";
            this.labelTenantName.Size = new System.Drawing.Size(280, 24);
            this.labelTenantName.TabIndex = 30;
            this.labelTenantName.Text = "_______________________________";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(22, 81);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(105, 24);
            this.materialLabel2.TabIndex = 29;
            this.materialLabel2.Text = "Người thuê:";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Depth = 0;
            this.labelRoomNumber.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRoomNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelRoomNumber.Location = new System.Drawing.Point(157, 128);
            this.labelRoomNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(280, 24);
            this.labelRoomNumber.TabIndex = 32;
            this.labelRoomNumber.Text = "_______________________________";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(22, 128);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(68, 24);
            this.materialLabel7.TabIndex = 31;
            this.materialLabel7.Text = "Căn hộ:";
            // 
            // ContractExtendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 387);
            this.Controls.Add(this.labelRoomNumber);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.labelTenantName);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.labelContractEndDate);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.dateTimePickerContractStartDate);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.materialLabel4);
            this.MinimumSize = new System.Drawing.Size(463, 330);
            this.Name = "ContractExtendForm";
            this.Sizable = false;
            this.Text = "Gia hạn thời hạn hợp đồng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox comboBoxMonth;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton ButtonSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DateTimePicker dateTimePickerContractStartDate;
        private MaterialSkin.Controls.MaterialLabel labelContractEndDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel labelTenantName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel labelRoomNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}