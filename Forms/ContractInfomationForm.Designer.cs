using System.ComponentModel;

namespace AccommodationManagerApp.Forms {
    partial class ContractInfomationForm {
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
            this.labelContractIsTerminated = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.labelContractTenantName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.labelContractEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.labelContractStartDate = new MaterialSkin.Controls.MaterialLabel();
            this.labelContractPrice = new MaterialSkin.Controls.MaterialLabel();
            this.labelContractRoomNumber = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel29 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel31 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel33 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonClose = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // labelContractIsTerminated
            // 
            this.labelContractIsTerminated.AutoSize = true;
            this.labelContractIsTerminated.BackColor = System.Drawing.Color.Transparent;
            this.labelContractIsTerminated.Depth = 0;
            this.labelContractIsTerminated.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelContractIsTerminated.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelContractIsTerminated.Location = new System.Drawing.Point(172, 299);
            this.labelContractIsTerminated.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelContractIsTerminated.Name = "labelContractIsTerminated";
            this.labelContractIsTerminated.Size = new System.Drawing.Size(190, 24);
            this.labelContractIsTerminated.TabIndex = 59;
            this.labelContractIsTerminated.Text = "_____________________";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel20.Location = new System.Drawing.Point(24, 299);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(79, 24);
            this.materialLabel20.TabIndex = 58;
            this.materialLabel20.Text = "Hiệu lực:";
            // 
            // labelContractTenantName
            // 
            this.labelContractTenantName.AutoSize = true;
            this.labelContractTenantName.BackColor = System.Drawing.Color.Transparent;
            this.labelContractTenantName.Depth = 0;
            this.labelContractTenantName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelContractTenantName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelContractTenantName.Location = new System.Drawing.Point(172, 83);
            this.labelContractTenantName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelContractTenantName.Name = "labelContractTenantName";
            this.labelContractTenantName.Size = new System.Drawing.Size(190, 24);
            this.labelContractTenantName.TabIndex = 57;
            this.labelContractTenantName.Text = "_____________________";
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel23.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel23.Location = new System.Drawing.Point(25, 83);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(141, 24);
            this.materialLabel23.TabIndex = 56;
            this.materialLabel23.Text = "Tên người thuê:";
            // 
            // labelContractEndDate
            // 
            this.labelContractEndDate.AutoSize = true;
            this.labelContractEndDate.BackColor = System.Drawing.Color.Transparent;
            this.labelContractEndDate.Depth = 0;
            this.labelContractEndDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelContractEndDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelContractEndDate.Location = new System.Drawing.Point(172, 254);
            this.labelContractEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelContractEndDate.Name = "labelContractEndDate";
            this.labelContractEndDate.Size = new System.Drawing.Size(190, 24);
            this.labelContractEndDate.TabIndex = 55;
            this.labelContractEndDate.Text = "_____________________";
            // 
            // labelContractStartDate
            // 
            this.labelContractStartDate.AutoSize = true;
            this.labelContractStartDate.BackColor = System.Drawing.Color.Transparent;
            this.labelContractStartDate.Depth = 0;
            this.labelContractStartDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelContractStartDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelContractStartDate.Location = new System.Drawing.Point(172, 210);
            this.labelContractStartDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelContractStartDate.Name = "labelContractStartDate";
            this.labelContractStartDate.Size = new System.Drawing.Size(190, 24);
            this.labelContractStartDate.TabIndex = 54;
            this.labelContractStartDate.Text = "_____________________";
            // 
            // labelContractPrice
            // 
            this.labelContractPrice.AutoSize = true;
            this.labelContractPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelContractPrice.Depth = 0;
            this.labelContractPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelContractPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelContractPrice.Location = new System.Drawing.Point(172, 165);
            this.labelContractPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelContractPrice.Name = "labelContractPrice";
            this.labelContractPrice.Size = new System.Drawing.Size(190, 24);
            this.labelContractPrice.TabIndex = 53;
            this.labelContractPrice.Text = "_____________________";
            // 
            // labelContractRoomNumber
            // 
            this.labelContractRoomNumber.AutoSize = true;
            this.labelContractRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelContractRoomNumber.Depth = 0;
            this.labelContractRoomNumber.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelContractRoomNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelContractRoomNumber.Location = new System.Drawing.Point(172, 124);
            this.labelContractRoomNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelContractRoomNumber.Name = "labelContractRoomNumber";
            this.labelContractRoomNumber.Size = new System.Drawing.Size(190, 24);
            this.labelContractRoomNumber.TabIndex = 52;
            this.labelContractRoomNumber.Text = "_____________________";
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel26.Location = new System.Drawing.Point(24, 210);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(125, 24);
            this.materialLabel26.TabIndex = 51;
            this.materialLabel26.Text = "Ngày bắt đầu:";
            // 
            // materialLabel29
            // 
            this.materialLabel29.AutoSize = true;
            this.materialLabel29.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel29.Depth = 0;
            this.materialLabel29.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel29.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel29.Location = new System.Drawing.Point(24, 254);
            this.materialLabel29.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel29.Name = "materialLabel29";
            this.materialLabel29.Size = new System.Drawing.Size(129, 24);
            this.materialLabel29.TabIndex = 50;
            this.materialLabel29.Text = "Ngày kết thúc:";
            // 
            // materialLabel31
            // 
            this.materialLabel31.AutoSize = true;
            this.materialLabel31.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel31.Depth = 0;
            this.materialLabel31.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel31.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel31.Location = new System.Drawing.Point(25, 165);
            this.materialLabel31.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel31.Name = "materialLabel31";
            this.materialLabel31.Size = new System.Drawing.Size(74, 24);
            this.materialLabel31.TabIndex = 49;
            this.materialLabel31.Text = "Đơn giá:";
            // 
            // materialLabel33
            // 
            this.materialLabel33.AutoSize = true;
            this.materialLabel33.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel33.Depth = 0;
            this.materialLabel33.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel33.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel33.Location = new System.Drawing.Point(25, 124);
            this.materialLabel33.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel33.Name = "materialLabel33";
            this.materialLabel33.Size = new System.Drawing.Size(89, 24);
            this.materialLabel33.TabIndex = 48;
            this.materialLabel33.Text = "Số phòng:";
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = false;
            this.buttonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonClose.Depth = 0;
            this.buttonClose.HighEmphasis = true;
            this.buttonClose.Icon = global::AccommodationManagerApp.Properties.Resources.cancel;
            this.buttonClose.Location = new System.Drawing.Point(253, 347);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonClose.Size = new System.Drawing.Size(109, 36);
            this.buttonClose.TabIndex = 60;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonClose.UseAccentColor = false;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ContractInfomationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 410);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelContractIsTerminated);
            this.Controls.Add(this.materialLabel20);
            this.Controls.Add(this.labelContractTenantName);
            this.Controls.Add(this.materialLabel23);
            this.Controls.Add(this.labelContractEndDate);
            this.Controls.Add(this.labelContractStartDate);
            this.Controls.Add(this.labelContractPrice);
            this.Controls.Add(this.labelContractRoomNumber);
            this.Controls.Add(this.materialLabel26);
            this.Controls.Add(this.materialLabel29);
            this.Controls.Add(this.materialLabel31);
            this.Controls.Add(this.materialLabel33);
            this.MaximumSize = new System.Drawing.Size(390, 410);
            this.MinimumSize = new System.Drawing.Size(390, 410);
            this.Name = "ContractInfomationForm";
            this.Text = "Thông tin hợp đồng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelContractIsTerminated;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel labelContractTenantName;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private MaterialSkin.Controls.MaterialLabel labelContractEndDate;
        private MaterialSkin.Controls.MaterialLabel labelContractStartDate;
        private MaterialSkin.Controls.MaterialLabel labelContractPrice;
        private MaterialSkin.Controls.MaterialLabel labelContractRoomNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private MaterialSkin.Controls.MaterialLabel materialLabel29;
        private MaterialSkin.Controls.MaterialLabel materialLabel31;
        private MaterialSkin.Controls.MaterialLabel materialLabel33;
        private MaterialSkin.Controls.MaterialButton buttonClose;
    }
}