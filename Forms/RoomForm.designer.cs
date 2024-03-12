namespace TenantManagementSystem.Forms
{
    partial class RoomForm
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
            this.textBoxRoomName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.ButtonClose = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxRoomBuilding = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxRoomTenant = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxRoomStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(26, 51);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Số/Tên nhà:";
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.AnimateReadOnly = false;
            this.textBoxRoomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRoomName.Depth = 0;
            this.textBoxRoomName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxRoomName.LeadingIcon = null;
            this.textBoxRoomName.Location = new System.Drawing.Point(156, 38);
            this.textBoxRoomName.MaxLength = 50;
            this.textBoxRoomName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxRoomName.Multiline = false;
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(353, 50);
            this.textBoxRoomName.TabIndex = 1;
            this.textBoxRoomName.Text = "";
            this.textBoxRoomName.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(26, 122);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Toà nhà:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = false;
            this.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonSave.Depth = 0;
            this.ButtonSave.HighEmphasis = true;
            this.ButtonSave.Icon = global::AccommodationManagerApp.Properties.Resources.save;
            this.ButtonSave.Location = new System.Drawing.Point(326, 354);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonSave.Size = new System.Drawing.Size(92, 40);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Lưu";
            this.ButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonSave.UseAccentColor = false;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.AutoSize = false;
            this.ButtonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonClose.Depth = 0;
            this.ButtonClose.HighEmphasis = true;
            this.ButtonClose.Icon = global::AccommodationManagerApp.Properties.Resources.cancel;
            this.ButtonClose.Location = new System.Drawing.Point(439, 354);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonClose.Size = new System.Drawing.Size(92, 40);
            this.ButtonClose.TabIndex = 6;
            this.ButtonClose.Text = "Đóng";
            this.ButtonClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonClose.UseAccentColor = false;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(26, 194);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(105, 24);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Người thuê:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(26, 271);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(97, 24);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Trạng thái:";
            // 
            // comboBoxRoomBuilding
            // 
            this.comboBoxRoomBuilding.AutoResize = false;
            this.comboBoxRoomBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxRoomBuilding.Depth = 0;
            this.comboBoxRoomBuilding.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxRoomBuilding.DropDownHeight = 174;
            this.comboBoxRoomBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomBuilding.DropDownWidth = 121;
            this.comboBoxRoomBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxRoomBuilding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxRoomBuilding.FormattingEnabled = true;
            this.comboBoxRoomBuilding.IntegralHeight = false;
            this.comboBoxRoomBuilding.ItemHeight = 43;
            this.comboBoxRoomBuilding.Location = new System.Drawing.Point(156, 111);
            this.comboBoxRoomBuilding.MaxDropDownItems = 4;
            this.comboBoxRoomBuilding.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxRoomBuilding.Name = "comboBoxRoomBuilding";
            this.comboBoxRoomBuilding.Size = new System.Drawing.Size(353, 49);
            this.comboBoxRoomBuilding.StartIndex = 0;
            this.comboBoxRoomBuilding.TabIndex = 9;
            // 
            // comboBoxRoomTenant
            // 
            this.comboBoxRoomTenant.AutoResize = false;
            this.comboBoxRoomTenant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxRoomTenant.Depth = 0;
            this.comboBoxRoomTenant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxRoomTenant.DropDownHeight = 174;
            this.comboBoxRoomTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomTenant.DropDownWidth = 121;
            this.comboBoxRoomTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxRoomTenant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxRoomTenant.FormattingEnabled = true;
            this.comboBoxRoomTenant.IntegralHeight = false;
            this.comboBoxRoomTenant.ItemHeight = 43;
            this.comboBoxRoomTenant.Location = new System.Drawing.Point(156, 182);
            this.comboBoxRoomTenant.MaxDropDownItems = 4;
            this.comboBoxRoomTenant.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxRoomTenant.Name = "comboBoxRoomTenant";
            this.comboBoxRoomTenant.Size = new System.Drawing.Size(353, 49);
            this.comboBoxRoomTenant.StartIndex = 0;
            this.comboBoxRoomTenant.TabIndex = 10;
            // 
            // comboBoxRoomStatus
            // 
            this.comboBoxRoomStatus.AutoResize = false;
            this.comboBoxRoomStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxRoomStatus.Depth = 0;
            this.comboBoxRoomStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxRoomStatus.DropDownHeight = 174;
            this.comboBoxRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomStatus.DropDownWidth = 121;
            this.comboBoxRoomStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxRoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxRoomStatus.FormattingEnabled = true;
            this.comboBoxRoomStatus.IntegralHeight = false;
            this.comboBoxRoomStatus.ItemHeight = 43;
            this.comboBoxRoomStatus.Location = new System.Drawing.Point(156, 258);
            this.comboBoxRoomStatus.MaxDropDownItems = 4;
            this.comboBoxRoomStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxRoomStatus.Name = "comboBoxRoomStatus";
            this.comboBoxRoomStatus.Size = new System.Drawing.Size(353, 49);
            this.comboBoxRoomStatus.StartIndex = 0;
            this.comboBoxRoomStatus.TabIndex = 11;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(573, 421);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxRoomStatus);
            this.Controls.Add(this.comboBoxRoomTenant);
            this.Controls.Add(this.comboBoxRoomBuilding);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "RoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox textBoxRoomName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton ButtonSave;
        private MaterialSkin.Controls.MaterialButton ButtonClose;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox comboBoxRoomBuilding;
        private MaterialSkin.Controls.MaterialComboBox comboBoxRoomTenant;
        private MaterialSkin.Controls.MaterialComboBox comboBoxRoomStatus;
    }
}