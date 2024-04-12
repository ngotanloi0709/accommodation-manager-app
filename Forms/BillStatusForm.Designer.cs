using System.ComponentModel;

namespace AccommodationManagerApp.Forms {
    partial class BillStatusForm {
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
            this.ComboBoxBillStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelBillId = new MaterialSkin.Controls.MaterialLabel();
            this.LabelRoomNumber = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.LabelBillTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelRoomTenant = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelBillOfMonth = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // ComboBoxBillStatus
            // 
            this.ComboBoxBillStatus.AutoResize = false;
            this.ComboBoxBillStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxBillStatus.Depth = 0;
            this.ComboBoxBillStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxBillStatus.DropDownHeight = 174;
            this.ComboBoxBillStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBillStatus.DropDownWidth = 121;
            this.ComboBoxBillStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxBillStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxBillStatus.FormattingEnabled = true;
            this.ComboBoxBillStatus.IntegralHeight = false;
            this.ComboBoxBillStatus.ItemHeight = 43;
            this.ComboBoxBillStatus.Location = new System.Drawing.Point(154, 328);
            this.ComboBoxBillStatus.MaxDropDownItems = 4;
            this.ComboBoxBillStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxBillStatus.Name = "ComboBoxBillStatus";
            this.ComboBoxBillStatus.Size = new System.Drawing.Size(168, 49);
            this.ComboBoxBillStatus.StartIndex = 0;
            this.ComboBoxBillStatus.TabIndex = 17;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(24, 339);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(97, 24);
            this.materialLabel4.TabIndex = 15;
            this.materialLabel4.Text = "Trạng thái:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(23, 142);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 24);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Phòng:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(23, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 24);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Số Hoá đơn:";
            // 
            // LabelBillId
            // 
            this.LabelBillId.AutoSize = true;
            this.LabelBillId.Depth = 0;
            this.LabelBillId.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelBillId.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LabelBillId.Location = new System.Drawing.Point(159, 96);
            this.LabelBillId.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelBillId.Name = "LabelBillId";
            this.LabelBillId.Size = new System.Drawing.Size(163, 24);
            this.LabelBillId.TabIndex = 18;
            this.LabelBillId.Text = "__________________";
            // 
            // LabelRoomNumber
            // 
            this.LabelRoomNumber.AutoSize = true;
            this.LabelRoomNumber.Depth = 0;
            this.LabelRoomNumber.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelRoomNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LabelRoomNumber.Location = new System.Drawing.Point(159, 142);
            this.LabelRoomNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelRoomNumber.Name = "LabelRoomNumber";
            this.LabelRoomNumber.Size = new System.Drawing.Size(163, 24);
            this.LabelRoomNumber.TabIndex = 19;
            this.LabelRoomNumber.Text = "__________________";
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = false;
            this.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonSave.Depth = 0;
            this.ButtonSave.HighEmphasis = true;
            this.ButtonSave.Icon = global::AccommodationManagerApp.Properties.Resources.save;
            this.ButtonSave.Location = new System.Drawing.Point(225, 401);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonSave.Size = new System.Drawing.Size(97, 40);
            this.ButtonSave.TabIndex = 20;
            this.ButtonSave.Text = "Lưu";
            this.ButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonSave.UseAccentColor = false;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelBillTotal
            // 
            this.LabelBillTotal.AutoSize = true;
            this.LabelBillTotal.Depth = 0;
            this.LabelBillTotal.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelBillTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LabelBillTotal.Location = new System.Drawing.Point(159, 233);
            this.LabelBillTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelBillTotal.Name = "LabelBillTotal";
            this.LabelBillTotal.Size = new System.Drawing.Size(163, 24);
            this.LabelBillTotal.TabIndex = 22;
            this.LabelBillTotal.Text = "__________________";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(23, 233);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(85, 24);
            this.materialLabel5.TabIndex = 21;
            this.materialLabel5.Text = "Tổng thu:";
            // 
            // LabelRoomTenant
            // 
            this.LabelRoomTenant.AutoSize = true;
            this.LabelRoomTenant.Depth = 0;
            this.LabelRoomTenant.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelRoomTenant.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LabelRoomTenant.Location = new System.Drawing.Point(159, 186);
            this.LabelRoomTenant.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelRoomTenant.Name = "LabelRoomTenant";
            this.LabelRoomTenant.Size = new System.Drawing.Size(163, 24);
            this.LabelRoomTenant.TabIndex = 24;
            this.LabelRoomTenant.Text = "__________________";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(23, 186);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(105, 24);
            this.materialLabel7.TabIndex = 23;
            this.materialLabel7.Text = "Người thuê:";
            // 
            // LabelBillOfMonth
            // 
            this.LabelBillOfMonth.AutoSize = true;
            this.LabelBillOfMonth.Depth = 0;
            this.LabelBillOfMonth.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelBillOfMonth.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LabelBillOfMonth.Location = new System.Drawing.Point(204, 282);
            this.LabelBillOfMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelBillOfMonth.Name = "LabelBillOfMonth";
            this.LabelBillOfMonth.Size = new System.Drawing.Size(118, 24);
            this.LabelBillOfMonth.TabIndex = 26;
            this.LabelBillOfMonth.Text = "_____________";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(23, 282);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(138, 24);
            this.materialLabel9.TabIndex = 25;
            this.materialLabel9.Text = "Hoá đơn tháng:";
            // 
            // BillStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 468);
            this.Controls.Add(this.LabelBillOfMonth);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.LabelRoomTenant);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.LabelBillTotal);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.LabelRoomNumber);
            this.Controls.Add(this.LabelBillId);
            this.Controls.Add(this.ComboBoxBillStatus);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MinimumSize = new System.Drawing.Size(300, 468);
            this.Name = "BillStatusForm";
            this.Sizable = false;
            this.Text = "Chỉnh sửa trạng thái Hoá đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillStatusForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox ComboBoxBillStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel LabelBillId;
        private MaterialSkin.Controls.MaterialLabel LabelRoomNumber;
        private MaterialSkin.Controls.MaterialButton ButtonSave;
        private MaterialSkin.Controls.MaterialLabel LabelBillTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel LabelRoomTenant;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel LabelBillOfMonth;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
    }
}