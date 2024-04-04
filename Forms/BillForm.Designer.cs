namespace AccommodationManagerApp.Forms
{
    partial class BillForm
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
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextboxWater = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxElectricity = new MaterialSkin.Controls.MaterialTextBox();
            this.lblElectric = new MaterialSkin.Controls.MaterialLabel();
            this.lblWater = new MaterialSkin.Controls.MaterialLabel();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.LabelDate = new MaterialSkin.Controls.MaterialLabel();
            this.ComboBoxRoom = new MaterialSkin.Controls.MaterialComboBox();
            this.buttonSave = new MaterialSkin.Controls.MaterialButton();
            this.LabelRentFee = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxInternet = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSkipWater = new MaterialSkin.Controls.MaterialButton();
            this.buttonSkipElectricity = new MaterialSkin.Controls.MaterialButton();
            this.buttonSkipInternet = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSkipVehicle = new MaterialSkin.Controls.MaterialButton();
            this.buttonReloadVehicle = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSkipRent = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxRent = new MaterialSkin.Controls.MaterialTextBox();
            this.ButtonLoadContractRentPrice = new MaterialSkin.Controls.MaterialButton();
            this.TextBoxVehicle = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonReloadInternet = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = global::AccommodationManagerApp.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(393, 570);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(91, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccommodationManagerApp.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(13, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TextboxWater
            // 
            this.TextboxWater.AnimateReadOnly = false;
            this.TextboxWater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxWater.Depth = 0;
            this.TextboxWater.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextboxWater.Hint = "Nhập số nước";
            this.TextboxWater.LeadingIcon = null;
            this.TextboxWater.Location = new System.Drawing.Point(126, 411);
            this.TextboxWater.MaxLength = 50;
            this.TextboxWater.MouseState = MaterialSkin.MouseState.OUT;
            this.TextboxWater.Multiline = false;
            this.TextboxWater.Name = "TextboxWater";
            this.TextboxWater.Size = new System.Drawing.Size(259, 50);
            this.TextboxWater.TabIndex = 6;
            this.TextboxWater.Text = "";
            this.TextboxWater.TrailingIcon = null;
            this.TextboxWater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxWater_KeyPress);
            // 
            // TextBoxElectricity
            // 
            this.TextBoxElectricity.AnimateReadOnly = false;
            this.TextBoxElectricity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxElectricity.Depth = 0;
            this.TextBoxElectricity.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxElectricity.Hint = "Nhập số điện";
            this.TextBoxElectricity.LeadingIcon = null;
            this.TextBoxElectricity.Location = new System.Drawing.Point(126, 483);
            this.TextBoxElectricity.MaxLength = 50;
            this.TextBoxElectricity.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxElectricity.Multiline = false;
            this.TextBoxElectricity.Name = "TextBoxElectricity";
            this.TextBoxElectricity.Size = new System.Drawing.Size(259, 50);
            this.TextBoxElectricity.TabIndex = 7;
            this.TextBoxElectricity.Text = "";
            this.TextBoxElectricity.TrailingIcon = null;
            this.TextBoxElectricity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxWater_KeyPress);
            // 
            // lblElectric
            // 
            this.lblElectric.AutoSize = true;
            this.lblElectric.Depth = 0;
            this.lblElectric.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblElectric.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblElectric.Location = new System.Drawing.Point(27, 422);
            this.lblElectric.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblElectric.Name = "lblElectric";
            this.lblElectric.Size = new System.Drawing.Size(82, 24);
            this.lblElectric.TabIndex = 8;
            this.lblElectric.Text = "Số Nước:";
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Depth = 0;
            this.lblWater.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWater.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblWater.Location = new System.Drawing.Point(27, 492);
            this.lblWater.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(74, 24);
            this.lblWater.TabIndex = 9;
            this.lblWater.Text = "Số Điện:";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Depth = 0;
            this.LabelDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LabelDate.Location = new System.Drawing.Point(233, 84);
            this.LabelDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(181, 24);
            this.LabelDate.TabIndex = 11;
            this.LabelDate.Text = "____________________";
            // 
            // ComboBoxRoom
            // 
            this.ComboBoxRoom.AutoResize = false;
            this.ComboBoxRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxRoom.Depth = 0;
            this.ComboBoxRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxRoom.DropDownHeight = 174;
            this.ComboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRoom.DropDownWidth = 121;
            this.ComboBoxRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBoxRoom.FormattingEnabled = true;
            this.ComboBoxRoom.IntegralHeight = false;
            this.ComboBoxRoom.ItemHeight = 43;
            this.ComboBoxRoom.Location = new System.Drawing.Point(127, 129);
            this.ComboBoxRoom.MaxDropDownItems = 4;
            this.ComboBoxRoom.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBoxRoom.Name = "ComboBoxRoom";
            this.ComboBoxRoom.Size = new System.Drawing.Size(90, 49);
            this.ComboBoxRoom.StartIndex = 0;
            this.ComboBoxRoom.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = false;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSave.Depth = 0;
            this.buttonSave.HighEmphasis = true;
            this.buttonSave.Icon = global::AccommodationManagerApp.Properties.Resources.plus1;
            this.buttonSave.Location = new System.Drawing.Point(290, 570);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSave.Size = new System.Drawing.Size(91, 36);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSave.UseAccentColor = false;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // LabelRentFee
            // 
            this.LabelRentFee.AutoSize = true;
            this.LabelRentFee.Depth = 0;
            this.LabelRentFee.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelRentFee.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LabelRentFee.Location = new System.Drawing.Point(323, 140);
            this.LabelRentFee.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelRentFee.Name = "LabelRentFee";
            this.LabelRentFee.Size = new System.Drawing.Size(100, 24);
            this.LabelRentFee.TabIndex = 26;
            this.LabelRentFee.Text = "___________";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel1.Location = new System.Drawing.Point(311, 464);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 14);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "kWh/ Tháng";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel2.Location = new System.Drawing.Point(317, 536);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 14);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "m3/ Tháng";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(131, 84);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(86, 24);
            this.materialLabel3.TabIndex = 29;
            this.materialLabel3.Text = "Ngày tạo:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(28, 277);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(77, 24);
            this.materialLabel4.TabIndex = 31;
            this.materialLabel4.Text = "Internet:";
            // 
            // TextBoxInternet
            // 
            this.TextBoxInternet.AnimateReadOnly = false;
            this.TextBoxInternet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxInternet.Depth = 0;
            this.TextBoxInternet.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxInternet.Hint = "Nhập tiền Internet";
            this.TextBoxInternet.LeadingIcon = null;
            this.TextBoxInternet.Location = new System.Drawing.Point(127, 268);
            this.TextBoxInternet.MaxLength = 50;
            this.TextBoxInternet.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxInternet.Multiline = false;
            this.TextBoxInternet.Name = "TextBoxInternet";
            this.TextBoxInternet.Size = new System.Drawing.Size(259, 50);
            this.TextBoxInternet.TabIndex = 30;
            this.TextBoxInternet.Text = "";
            this.TextBoxInternet.TrailingIcon = null;
            this.TextBoxInternet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxWater_KeyPress);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(27, 344);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(63, 24);
            this.materialLabel5.TabIndex = 33;
            this.materialLabel5.Text = "Gửi xe:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel8.Location = new System.Drawing.Point(29, 391);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(262, 14);
            this.materialLabel8.TabIndex = 36;
            this.materialLabel8.Text = "Tính theo số xe đang gửi vào thời điểm câp nhật";
            // 
            // buttonSkipWater
            // 
            this.buttonSkipWater.AutoSize = false;
            this.buttonSkipWater.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSkipWater.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSkipWater.Depth = 0;
            this.buttonSkipWater.HighEmphasis = true;
            this.buttonSkipWater.Icon = global::AccommodationManagerApp.Properties.Resources.skip;
            this.buttonSkipWater.Location = new System.Drawing.Point(393, 416);
            this.buttonSkipWater.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSkipWater.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSkipWater.Name = "buttonSkipWater";
            this.buttonSkipWater.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSkipWater.Size = new System.Drawing.Size(41, 41);
            this.buttonSkipWater.TabIndex = 41;
            this.buttonSkipWater.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSkipWater.UseAccentColor = false;
            this.buttonSkipWater.UseVisualStyleBackColor = true;
            this.buttonSkipWater.Click += new System.EventHandler(this.buttonSkipWater_Click);
            // 
            // buttonSkipElectricity
            // 
            this.buttonSkipElectricity.AutoSize = false;
            this.buttonSkipElectricity.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSkipElectricity.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSkipElectricity.Depth = 0;
            this.buttonSkipElectricity.HighEmphasis = true;
            this.buttonSkipElectricity.Icon = global::AccommodationManagerApp.Properties.Resources.skip;
            this.buttonSkipElectricity.Location = new System.Drawing.Point(393, 486);
            this.buttonSkipElectricity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSkipElectricity.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSkipElectricity.Name = "buttonSkipElectricity";
            this.buttonSkipElectricity.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSkipElectricity.Size = new System.Drawing.Size(41, 41);
            this.buttonSkipElectricity.TabIndex = 42;
            this.buttonSkipElectricity.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSkipElectricity.UseAccentColor = false;
            this.buttonSkipElectricity.UseVisualStyleBackColor = true;
            this.buttonSkipElectricity.Click += new System.EventHandler(this.buttonSkipElectricity_Click);
            // 
            // buttonSkipInternet
            // 
            this.buttonSkipInternet.AutoSize = false;
            this.buttonSkipInternet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSkipInternet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSkipInternet.Depth = 0;
            this.buttonSkipInternet.HighEmphasis = true;
            this.buttonSkipInternet.Icon = global::AccommodationManagerApp.Properties.Resources.skip;
            this.buttonSkipInternet.Location = new System.Drawing.Point(394, 271);
            this.buttonSkipInternet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSkipInternet.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSkipInternet.Name = "buttonSkipInternet";
            this.buttonSkipInternet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSkipInternet.Size = new System.Drawing.Size(41, 41);
            this.buttonSkipInternet.TabIndex = 44;
            this.buttonSkipInternet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSkipInternet.UseAccentColor = false;
            this.buttonSkipInternet.UseVisualStyleBackColor = true;
            this.buttonSkipInternet.Click += new System.EventHandler(this.buttonSkipInternet_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel10.Location = new System.Drawing.Point(28, 536);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(135, 14);
            this.materialLabel10.TabIndex = 45;
            this.materialLabel10.Text = "Đặt về 0 bằng nút kế bên";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel11.Location = new System.Drawing.Point(28, 464);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(135, 14);
            this.materialLabel11.TabIndex = 46;
            this.materialLabel11.Text = "Đặt về 0 bằng nút kế bên";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel7.Location = new System.Drawing.Point(365, 321);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(21, 14);
            this.materialLabel7.TabIndex = 47;
            this.materialLabel7.Text = "vnd";
            // 
            // buttonSkipVehicle
            // 
            this.buttonSkipVehicle.AutoSize = false;
            this.buttonSkipVehicle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSkipVehicle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSkipVehicle.Depth = 0;
            this.buttonSkipVehicle.HighEmphasis = true;
            this.buttonSkipVehicle.Icon = global::AccommodationManagerApp.Properties.Resources.skip;
            this.buttonSkipVehicle.Location = new System.Drawing.Point(393, 338);
            this.buttonSkipVehicle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSkipVehicle.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSkipVehicle.Name = "buttonSkipVehicle";
            this.buttonSkipVehicle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSkipVehicle.Size = new System.Drawing.Size(41, 41);
            this.buttonSkipVehicle.TabIndex = 48;
            this.buttonSkipVehicle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSkipVehicle.UseAccentColor = false;
            this.buttonSkipVehicle.UseVisualStyleBackColor = true;
            this.buttonSkipVehicle.Click += new System.EventHandler(this.buttonSkipVehicle_Click);
            // 
            // buttonReloadVehicle
            // 
            this.buttonReloadVehicle.AutoSize = false;
            this.buttonReloadVehicle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReloadVehicle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonReloadVehicle.Depth = 0;
            this.buttonReloadVehicle.HighEmphasis = true;
            this.buttonReloadVehicle.Icon = global::AccommodationManagerApp.Properties.Resources.reload;
            this.buttonReloadVehicle.Location = new System.Drawing.Point(443, 338);
            this.buttonReloadVehicle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonReloadVehicle.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonReloadVehicle.Name = "buttonReloadVehicle";
            this.buttonReloadVehicle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonReloadVehicle.Size = new System.Drawing.Size(41, 41);
            this.buttonReloadVehicle.TabIndex = 50;
            this.buttonReloadVehicle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonReloadVehicle.UseAccentColor = false;
            this.buttonReloadVehicle.UseVisualStyleBackColor = true;
            this.buttonReloadVehicle.Click += new System.EventHandler(this.buttonReloadVehicle_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(224, 140);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(93, 24);
            this.materialLabel6.TabIndex = 51;
            this.materialLabel6.Text = "Hợp đồng:";
            // 
            // buttonSkipRent
            // 
            this.buttonSkipRent.AutoSize = false;
            this.buttonSkipRent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSkipRent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSkipRent.Depth = 0;
            this.buttonSkipRent.HighEmphasis = true;
            this.buttonSkipRent.Icon = global::AccommodationManagerApp.Properties.Resources.skip;
            this.buttonSkipRent.Location = new System.Drawing.Point(394, 203);
            this.buttonSkipRent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSkipRent.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSkipRent.Name = "buttonSkipRent";
            this.buttonSkipRent.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSkipRent.Size = new System.Drawing.Size(41, 41);
            this.buttonSkipRent.TabIndex = 55;
            this.buttonSkipRent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSkipRent.UseAccentColor = false;
            this.buttonSkipRent.UseVisualStyleBackColor = true;
            this.buttonSkipRent.Click += new System.EventHandler(this.buttonSkipRent_Click);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel14.Location = new System.Drawing.Point(364, 251);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(21, 14);
            this.materialLabel14.TabIndex = 54;
            this.materialLabel14.Text = "vnd";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel15.Location = new System.Drawing.Point(28, 209);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(90, 24);
            this.materialLabel15.TabIndex = 53;
            this.materialLabel15.Text = "Tiền thuê:";
            // 
            // TextBoxRent
            // 
            this.TextBoxRent.AnimateReadOnly = false;
            this.TextBoxRent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxRent.Depth = 0;
            this.TextBoxRent.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxRent.Hint = "Nhập tiền thuê";
            this.TextBoxRent.LeadingIcon = null;
            this.TextBoxRent.Location = new System.Drawing.Point(127, 198);
            this.TextBoxRent.MaxLength = 50;
            this.TextBoxRent.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxRent.Multiline = false;
            this.TextBoxRent.Name = "TextBoxRent";
            this.TextBoxRent.Size = new System.Drawing.Size(259, 50);
            this.TextBoxRent.TabIndex = 52;
            this.TextBoxRent.Text = "";
            this.TextBoxRent.TrailingIcon = null;
            this.TextBoxRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxWater_KeyPress);
            // 
            // ButtonLoadContractRentPrice
            // 
            this.ButtonLoadContractRentPrice.AutoSize = false;
            this.ButtonLoadContractRentPrice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonLoadContractRentPrice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonLoadContractRentPrice.Depth = 0;
            this.ButtonLoadContractRentPrice.HighEmphasis = true;
            this.ButtonLoadContractRentPrice.Icon = global::AccommodationManagerApp.Properties.Resources.reload;
            this.ButtonLoadContractRentPrice.Location = new System.Drawing.Point(443, 203);
            this.ButtonLoadContractRentPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonLoadContractRentPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonLoadContractRentPrice.Name = "ButtonLoadContractRentPrice";
            this.ButtonLoadContractRentPrice.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonLoadContractRentPrice.Size = new System.Drawing.Size(41, 41);
            this.ButtonLoadContractRentPrice.TabIndex = 57;
            this.ButtonLoadContractRentPrice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonLoadContractRentPrice.UseAccentColor = false;
            this.ButtonLoadContractRentPrice.UseVisualStyleBackColor = true;
            this.ButtonLoadContractRentPrice.Click += new System.EventHandler(this.ButtonLoadContractRentPrice_Click);
            // 
            // TextBoxVehicle
            // 
            this.TextBoxVehicle.AnimateReadOnly = false;
            this.TextBoxVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxVehicle.Depth = 0;
            this.TextBoxVehicle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxVehicle.Hint = "Nhập tiền gửi xe";
            this.TextBoxVehicle.LeadingIcon = null;
            this.TextBoxVehicle.Location = new System.Drawing.Point(126, 338);
            this.TextBoxVehicle.MaxLength = 50;
            this.TextBoxVehicle.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxVehicle.Multiline = false;
            this.TextBoxVehicle.Name = "TextBoxVehicle";
            this.TextBoxVehicle.Size = new System.Drawing.Size(260, 50);
            this.TextBoxVehicle.TabIndex = 59;
            this.TextBoxVehicle.Text = "";
            this.TextBoxVehicle.TrailingIcon = null;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel18.Location = new System.Drawing.Point(364, 391);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(21, 14);
            this.materialLabel18.TabIndex = 61;
            this.materialLabel18.Text = "vnd";
            // 
            // ButtonReloadInternet
            // 
            this.ButtonReloadInternet.AutoSize = false;
            this.ButtonReloadInternet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonReloadInternet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ButtonReloadInternet.Depth = 0;
            this.ButtonReloadInternet.HighEmphasis = true;
            this.ButtonReloadInternet.Icon = global::AccommodationManagerApp.Properties.Resources.reload;
            this.ButtonReloadInternet.Location = new System.Drawing.Point(443, 271);
            this.ButtonReloadInternet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonReloadInternet.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonReloadInternet.Name = "ButtonReloadInternet";
            this.ButtonReloadInternet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ButtonReloadInternet.Size = new System.Drawing.Size(41, 41);
            this.ButtonReloadInternet.TabIndex = 62;
            this.ButtonReloadInternet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ButtonReloadInternet.UseAccentColor = false;
            this.ButtonReloadInternet.UseVisualStyleBackColor = true;
            this.ButtonReloadInternet.Click += new System.EventHandler(this.ButtonReloadInternet_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 637);
            this.Controls.Add(this.ButtonReloadInternet);
            this.Controls.Add(this.materialLabel18);
            this.Controls.Add(this.TextBoxVehicle);
            this.Controls.Add(this.ButtonLoadContractRentPrice);
            this.Controls.Add(this.buttonSkipRent);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.TextBoxRent);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.buttonReloadVehicle);
            this.Controls.Add(this.buttonSkipVehicle);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.buttonSkipInternet);
            this.Controls.Add(this.buttonSkipElectricity);
            this.Controls.Add(this.buttonSkipWater);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.TextBoxInternet);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.LabelRentFee);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.ComboBoxRoom);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.lblElectric);
            this.Controls.Add(this.TextBoxElectricity);
            this.Controls.Add(this.TextboxWater);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.MaximumSize = new System.Drawing.Size(515, 637);
            this.MinimumSize = new System.Drawing.Size(515, 637);
            this.Name = "BillForm";
            this.Sizable = false;
            this.Text = "Thông Tin Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected MaterialSkin.Controls.MaterialButton btnClose;
        protected MaterialSkin.Controls.MaterialTextBox TextboxWater;
        protected MaterialSkin.Controls.MaterialTextBox TextBoxElectricity;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        protected MaterialSkin.Controls.MaterialLabel LabelDate;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected MaterialSkin.Controls.MaterialLabel lblElectric;
        protected MaterialSkin.Controls.MaterialLabel lblWater;
        protected MaterialSkin.Controls.MaterialComboBox ComboBoxRoom;
        protected MaterialSkin.Controls.MaterialButton buttonSave;
        protected MaterialSkin.Controls.MaterialLabel LabelRentFee;
        protected MaterialSkin.Controls.MaterialLabel materialLabel1;
        protected MaterialSkin.Controls.MaterialLabel materialLabel2;
        protected MaterialSkin.Controls.MaterialLabel materialLabel3;
        protected MaterialSkin.Controls.MaterialLabel materialLabel4;
        protected MaterialSkin.Controls.MaterialTextBox TextBoxInternet;
        protected MaterialSkin.Controls.MaterialLabel materialLabel5;
        protected MaterialSkin.Controls.MaterialLabel materialLabel8;
        protected MaterialSkin.Controls.MaterialButton buttonSkipWater;
        protected MaterialSkin.Controls.MaterialButton buttonSkipElectricity;
        protected MaterialSkin.Controls.MaterialButton buttonSkipInternet;
        protected MaterialSkin.Controls.MaterialLabel materialLabel10;
        protected MaterialSkin.Controls.MaterialLabel materialLabel11;
        protected MaterialSkin.Controls.MaterialLabel materialLabel7;
        protected MaterialSkin.Controls.MaterialButton buttonSkipVehicle;
        protected MaterialSkin.Controls.MaterialButton buttonReloadVehicle;
        protected MaterialSkin.Controls.MaterialLabel materialLabel6;
        protected MaterialSkin.Controls.MaterialButton buttonSkipRent;
        protected MaterialSkin.Controls.MaterialLabel materialLabel14;
        protected MaterialSkin.Controls.MaterialLabel materialLabel15;
        protected MaterialSkin.Controls.MaterialTextBox TextBoxRent;
        protected MaterialSkin.Controls.MaterialButton ButtonLoadContractRentPrice;
        protected MaterialSkin.Controls.MaterialTextBox TextBoxVehicle;
        protected MaterialSkin.Controls.MaterialLabel materialLabel18;
        protected MaterialSkin.Controls.MaterialButton ButtonReloadInternet;
    }
}