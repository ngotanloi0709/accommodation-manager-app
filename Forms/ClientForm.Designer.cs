﻿namespace AccommodationManagerApp.Forms
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.buttonCurrentUserInformationManagement = new MaterialSkin.Controls.MaterialButton();
            this.imgLstClient = new System.Windows.Forms.ImageList(this.components);
            this.tbCtrlClient = new MaterialSkin.Controls.MaterialTabControl();
            this.pgRequest = new System.Windows.Forms.TabPage();
            this.labelReqState = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel38 = new MaterialSkin.Controls.MaterialLabel();
            this.labelReqDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel43 = new MaterialSkin.Controls.MaterialLabel();
            this.labelReqContent = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel45 = new MaterialSkin.Controls.MaterialLabel();
            this.labelReqUser = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel65 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpd = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.lstViewReq = new MaterialSkin.Controls.MaterialListView();
            this.idReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stateReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbbxReqCate = new MaterialSkin.Controls.MaterialComboBox();
            this.btnReqSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtReqSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.pgBill = new System.Windows.Forms.TabPage();
            this.materialLabel48 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel50 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxState = new MaterialSkin.Controls.MaterialComboBox();
            this.buttonPriceSearch = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel47 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel46 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxMaxPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxMinPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.comboBoxTime = new MaterialSkin.Controls.MaterialComboBox();
            this.ListViewBill = new MaterialSkin.Controls.MaterialListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateBill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stateBill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LabelBillContractEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel42 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelBillRoomNumber = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel40 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelBillContractValue = new MaterialSkin.Controls.MaterialLabel();
            this.labelSoemthingss = new MaterialSkin.Controls.MaterialLabel();
            this.LabelBillTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel39 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelBillContractOwner = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel37 = new MaterialSkin.Controls.MaterialLabel();
            this.labelInternetPrice = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel35 = new MaterialSkin.Controls.MaterialLabel();
            this.labelElectricityPrice = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            this.labelWaterPrice = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel36 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonPreview = new MaterialSkin.Controls.MaterialButton();
            this.pgConfig = new System.Windows.Forms.TabPage();
            this.tbCtrlClient.SuspendLayout();
            this.pgRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pgBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(270, 25);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(246, 36);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "user@email.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = global::AccommodationManagerApp.Properties.Resources.logout;
            this.btnLogout.Location = new System.Drawing.Point(814, 28);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(134, 36);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.Logout);
            // 
            // buttonCurrentUserInformationManagement
            // 
            this.buttonCurrentUserInformationManagement.AutoSize = false;
            this.buttonCurrentUserInformationManagement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCurrentUserInformationManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCurrentUserInformationManagement.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonCurrentUserInformationManagement.Depth = 0;
            this.buttonCurrentUserInformationManagement.HighEmphasis = true;
            this.buttonCurrentUserInformationManagement.Icon = global::AccommodationManagerApp.Properties.Resources.user_no_color;
            this.buttonCurrentUserInformationManagement.Location = new System.Drawing.Point(79, 25);
            this.buttonCurrentUserInformationManagement.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCurrentUserInformationManagement.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCurrentUserInformationManagement.Name = "buttonCurrentUserInformationManagement";
            this.buttonCurrentUserInformationManagement.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCurrentUserInformationManagement.Size = new System.Drawing.Size(189, 36);
            this.buttonCurrentUserInformationManagement.TabIndex = 21;
            this.buttonCurrentUserInformationManagement.Text = "Thông tin cá nhân";
            this.buttonCurrentUserInformationManagement.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonCurrentUserInformationManagement.UseAccentColor = false;
            this.buttonCurrentUserInformationManagement.UseVisualStyleBackColor = true;
            this.buttonCurrentUserInformationManagement.Click += new System.EventHandler(this.ShowInfor);
            // 
            // imgLstClient
            // 
            this.imgLstClient.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstClient.ImageStream")));
            this.imgLstClient.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstClient.Images.SetKeyName(0, "configuration.png");
            this.imgLstClient.Images.SetKeyName(1, "request.png");
            this.imgLstClient.Images.SetKeyName(2, "homepage.png");
            this.imgLstClient.Images.SetKeyName(3, "contract.png");
            // 
            // tbCtrlClient
            // 
            this.tbCtrlClient.Controls.Add(this.pgRequest);
            this.tbCtrlClient.Controls.Add(this.pgBill);
            this.tbCtrlClient.Controls.Add(this.pgConfig);
            this.tbCtrlClient.Depth = 0;
            this.tbCtrlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlClient.ImageList = this.imgLstClient;
            this.tbCtrlClient.Location = new System.Drawing.Point(3, 64);
            this.tbCtrlClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCtrlClient.Multiline = true;
            this.tbCtrlClient.Name = "tbCtrlClient";
            this.tbCtrlClient.SelectedIndex = 0;
            this.tbCtrlClient.Size = new System.Drawing.Size(994, 733);
            this.tbCtrlClient.TabIndex = 25;
            // 
            // pgRequest
            // 
            this.pgRequest.BackColor = System.Drawing.Color.White;
            this.pgRequest.Controls.Add(this.labelReqState);
            this.pgRequest.Controls.Add(this.materialLabel38);
            this.pgRequest.Controls.Add(this.labelReqDate);
            this.pgRequest.Controls.Add(this.materialLabel43);
            this.pgRequest.Controls.Add(this.labelReqContent);
            this.pgRequest.Controls.Add(this.materialLabel45);
            this.pgRequest.Controls.Add(this.labelReqUser);
            this.pgRequest.Controls.Add(this.materialLabel65);
            this.pgRequest.Controls.Add(this.pictureBox1);
            this.pgRequest.Controls.Add(this.btnUpd);
            this.pgRequest.Controls.Add(this.btnDelete);
            this.pgRequest.Controls.Add(this.btnAdd);
            this.pgRequest.Controls.Add(this.lstViewReq);
            this.pgRequest.Controls.Add(this.cmbbxReqCate);
            this.pgRequest.Controls.Add(this.btnReqSearch);
            this.pgRequest.Controls.Add(this.txtReqSearch);
            this.pgRequest.ImageKey = "request.png";
            this.pgRequest.Location = new System.Drawing.Point(4, 39);
            this.pgRequest.Name = "pgRequest";
            this.pgRequest.Padding = new System.Windows.Forms.Padding(3);
            this.pgRequest.Size = new System.Drawing.Size(986, 690);
            this.pgRequest.TabIndex = 1;
            this.pgRequest.Text = "Yêu Cầu";
            this.pgRequest.UseVisualStyleBackColor = true;
            // 
            // labelReqState
            // 
            this.labelReqState.AutoSize = true;
            this.labelReqState.Depth = 0;
            this.labelReqState.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelReqState.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelReqState.Location = new System.Drawing.Point(765, 483);
            this.labelReqState.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelReqState.Name = "labelReqState";
            this.labelReqState.Size = new System.Drawing.Size(127, 17);
            this.labelReqState.TabIndex = 76;
            this.labelReqState.Text = "_____________________";
            // 
            // materialLabel38
            // 
            this.materialLabel38.AutoSize = true;
            this.materialLabel38.Depth = 0;
            this.materialLabel38.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel38.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel38.Location = new System.Drawing.Point(667, 483);
            this.materialLabel38.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel38.Name = "materialLabel38";
            this.materialLabel38.Size = new System.Drawing.Size(74, 17);
            this.materialLabel38.TabIndex = 75;
            this.materialLabel38.Text = "Tình Trạng: ";
            // 
            // labelReqDate
            // 
            this.labelReqDate.AutoSize = true;
            this.labelReqDate.Depth = 0;
            this.labelReqDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelReqDate.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelReqDate.Location = new System.Drawing.Point(747, 457);
            this.labelReqDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelReqDate.Name = "labelReqDate";
            this.labelReqDate.Size = new System.Drawing.Size(145, 17);
            this.labelReqDate.TabIndex = 74;
            this.labelReqDate.Text = "________________________";
            // 
            // materialLabel43
            // 
            this.materialLabel43.AutoSize = true;
            this.materialLabel43.Depth = 0;
            this.materialLabel43.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel43.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel43.Location = new System.Drawing.Point(675, 457);
            this.materialLabel43.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel43.Name = "materialLabel43";
            this.materialLabel43.Size = new System.Drawing.Size(62, 17);
            this.materialLabel43.TabIndex = 73;
            this.materialLabel43.Text = "Ngày Gửi:";
            // 
            // labelReqContent
            // 
            this.labelReqContent.Depth = 0;
            this.labelReqContent.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelReqContent.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelReqContent.Location = new System.Drawing.Point(750, 429);
            this.labelReqContent.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelReqContent.Name = "labelReqContent";
            this.labelReqContent.Size = new System.Drawing.Size(220, 17);
            this.labelReqContent.TabIndex = 72;
            this.labelReqContent.Text = "________________________";
            // 
            // materialLabel45
            // 
            this.materialLabel45.AutoSize = true;
            this.materialLabel45.Depth = 0;
            this.materialLabel45.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel45.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel45.Location = new System.Drawing.Point(676, 429);
            this.materialLabel45.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel45.Name = "materialLabel45";
            this.materialLabel45.Size = new System.Drawing.Size(61, 17);
            this.materialLabel45.TabIndex = 71;
            this.materialLabel45.Text = "Nội Dung:";
            // 
            // labelReqUser
            // 
            this.labelReqUser.AutoSize = true;
            this.labelReqUser.Depth = 0;
            this.labelReqUser.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelReqUser.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelReqUser.Location = new System.Drawing.Point(750, 403);
            this.labelReqUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelReqUser.Name = "labelReqUser";
            this.labelReqUser.Size = new System.Drawing.Size(145, 17);
            this.labelReqUser.TabIndex = 70;
            this.labelReqUser.Text = "________________________";
            // 
            // materialLabel65
            // 
            this.materialLabel65.AutoSize = true;
            this.materialLabel65.Depth = 0;
            this.materialLabel65.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel65.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel65.Location = new System.Drawing.Point(676, 403);
            this.materialLabel65.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel65.Name = "materialLabel65";
            this.materialLabel65.Size = new System.Drawing.Size(68, 17);
            this.materialLabel65.TabIndex = 69;
            this.materialLabel65.Text = "Người gửi: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(679, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpd
            // 
            this.btnUpd.AutoSize = false;
            this.btnUpd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpd.Depth = 0;
            this.btnUpd.HighEmphasis = true;
            this.btnUpd.Icon = global::AccommodationManagerApp.Properties.Resources.edit;
            this.btnUpd.Location = new System.Drawing.Point(679, 297);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpd.Size = new System.Drawing.Size(179, 39);
            this.btnUpd.TabIndex = 32;
            this.btnUpd.Text = "Cập Nhật";
            this.btnUpd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpd.UseAccentColor = false;
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.UpdateReq);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = global::AccommodationManagerApp.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(778, 348);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(80, 39);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteReq);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = global::AccommodationManagerApp.Properties.Resources.plus1;
            this.btnAdd.Location = new System.Drawing.Point(679, 348);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(91, 39);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddReq);
            // 
            // lstViewReq
            // 
            this.lstViewReq.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstViewReq.AutoSizeTable = false;
            this.lstViewReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstViewReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstViewReq.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idReq,
            this.desReq,
            this.dateReq,
            this.stateReq});
            this.lstViewReq.Depth = 0;
            this.lstViewReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lstViewReq.FullRowSelect = true;
            this.lstViewReq.HideSelection = false;
            this.lstViewReq.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstViewReq.Location = new System.Drawing.Point(28, 108);
            this.lstViewReq.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstViewReq.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstViewReq.MouseState = MaterialSkin.MouseState.OUT;
            this.lstViewReq.Name = "lstViewReq";
            this.lstViewReq.OwnerDraw = true;
            this.lstViewReq.ShowGroups = false;
            this.lstViewReq.Size = new System.Drawing.Size(635, 451);
            this.lstViewReq.TabIndex = 29;
            this.lstViewReq.UseCompatibleStateImageBehavior = false;
            this.lstViewReq.View = System.Windows.Forms.View.Details;
            this.lstViewReq.SelectedIndexChanged += new System.EventHandler(this.LstViewReq_SelectedIndexChanged);
            // 
            // idReq
            // 
            this.idReq.Text = "id";
            // 
            // desReq
            // 
            this.desReq.Text = "Nội Dung ";
            this.desReq.Width = 300;
            // 
            // dateReq
            // 
            this.dateReq.Text = "Ngày Tạo";
            this.dateReq.Width = 150;
            // 
            // stateReq
            // 
            this.stateReq.Text = "Tình Trạng";
            this.stateReq.Width = 100;
            // 
            // cmbbxReqCate
            // 
            this.cmbbxReqCate.AutoResize = false;
            this.cmbbxReqCate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbbxReqCate.Depth = 0;
            this.cmbbxReqCate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbbxReqCate.DropDownHeight = 174;
            this.cmbbxReqCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxReqCate.DropDownWidth = 121;
            this.cmbbxReqCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbbxReqCate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbbxReqCate.FormattingEnabled = true;
            this.cmbbxReqCate.IntegralHeight = false;
            this.cmbbxReqCate.ItemHeight = 43;
            this.cmbbxReqCate.Items.AddRange(new object[] {
            "Ngày",
            "Phòng",
            "Khách Hàng",
            "Giá",
            "Điện",
            "Nước",
            "Phí Thuê"});
            this.cmbbxReqCate.Location = new System.Drawing.Point(32, 37);
            this.cmbbxReqCate.MaxDropDownItems = 4;
            this.cmbbxReqCate.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbbxReqCate.Name = "cmbbxReqCate";
            this.cmbbxReqCate.Size = new System.Drawing.Size(87, 49);
            this.cmbbxReqCate.StartIndex = 0;
            this.cmbbxReqCate.TabIndex = 26;
            // 
            // btnReqSearch
            // 
            this.btnReqSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReqSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReqSearch.Depth = 0;
            this.btnReqSearch.HighEmphasis = true;
            this.btnReqSearch.Icon = global::AccommodationManagerApp.Properties.Resources.search;
            this.btnReqSearch.Location = new System.Drawing.Point(661, 40);
            this.btnReqSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReqSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReqSearch.Name = "btnReqSearch";
            this.btnReqSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReqSearch.Size = new System.Drawing.Size(106, 36);
            this.btnReqSearch.TabIndex = 24;
            this.btnReqSearch.Text = "Search";
            this.btnReqSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReqSearch.UseAccentColor = false;
            this.btnReqSearch.UseCompatibleTextRendering = true;
            this.btnReqSearch.UseVisualStyleBackColor = true;
            // 
            // txtReqSearch
            // 
            this.txtReqSearch.AnimateReadOnly = false;
            this.txtReqSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtReqSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReqSearch.Depth = 0;
            this.txtReqSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReqSearch.ForeColor = System.Drawing.Color.Transparent;
            this.txtReqSearch.Hint = "Tìm Kiếm";
            this.txtReqSearch.LeadingIcon = null;
            this.txtReqSearch.Location = new System.Drawing.Point(125, 36);
            this.txtReqSearch.MaxLength = 50;
            this.txtReqSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReqSearch.Multiline = false;
            this.txtReqSearch.Name = "txtReqSearch";
            this.txtReqSearch.Size = new System.Drawing.Size(529, 50);
            this.txtReqSearch.TabIndex = 25;
            this.txtReqSearch.Text = "";
            this.txtReqSearch.TrailingIcon = null;
            // 
            // pgBill
            // 
            this.pgBill.BackColor = System.Drawing.Color.White;
            this.pgBill.Controls.Add(this.materialLabel48);
            this.pgBill.Controls.Add(this.materialLabel50);
            this.pgBill.Controls.Add(this.comboBoxState);
            this.pgBill.Controls.Add(this.buttonPriceSearch);
            this.pgBill.Controls.Add(this.materialLabel47);
            this.pgBill.Controls.Add(this.materialLabel46);
            this.pgBill.Controls.Add(this.textBoxMaxPrice);
            this.pgBill.Controls.Add(this.textBoxMinPrice);
            this.pgBill.Controls.Add(this.comboBoxTime);
            this.pgBill.Controls.Add(this.ListViewBill);
            this.pgBill.Controls.Add(this.pictureBox2);
            this.pgBill.Controls.Add(this.LabelBillContractEndDate);
            this.pgBill.Controls.Add(this.materialLabel42);
            this.pgBill.Controls.Add(this.LabelBillRoomNumber);
            this.pgBill.Controls.Add(this.materialLabel40);
            this.pgBill.Controls.Add(this.LabelBillContractValue);
            this.pgBill.Controls.Add(this.labelSoemthingss);
            this.pgBill.Controls.Add(this.LabelBillTotal);
            this.pgBill.Controls.Add(this.materialLabel39);
            this.pgBill.Controls.Add(this.LabelBillContractOwner);
            this.pgBill.Controls.Add(this.materialLabel37);
            this.pgBill.Controls.Add(this.labelInternetPrice);
            this.pgBill.Controls.Add(this.materialLabel35);
            this.pgBill.Controls.Add(this.labelElectricityPrice);
            this.pgBill.Controls.Add(this.materialLabel34);
            this.pgBill.Controls.Add(this.labelWaterPrice);
            this.pgBill.Controls.Add(this.materialLabel36);
            this.pgBill.Controls.Add(this.buttonPreview);
            this.pgBill.ImageKey = "contract.png";
            this.pgBill.Location = new System.Drawing.Point(4, 39);
            this.pgBill.Name = "pgBill";
            this.pgBill.Size = new System.Drawing.Size(986, 690);
            this.pgBill.TabIndex = 2;
            this.pgBill.Text = "Hóa Đơn";
            this.pgBill.UseVisualStyleBackColor = true;
            // 
            // materialLabel48
            // 
            this.materialLabel48.AutoSize = true;
            this.materialLabel48.Depth = 0;
            this.materialLabel48.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel48.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel48.Location = new System.Drawing.Point(283, 72);
            this.materialLabel48.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel48.Name = "materialLabel48";
            this.materialLabel48.Size = new System.Drawing.Size(359, 14);
            this.materialLabel48.TabIndex = 106;
            this.materialLabel48.Text = "Mời nhập khoảng giá để tìm kiếm, Lưu ý: giá sàn thấp hơn giá trần";
            // 
            // materialLabel50
            // 
            this.materialLabel50.Depth = 0;
            this.materialLabel50.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel50.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel50.Location = new System.Drawing.Point(141, 72);
            this.materialLabel50.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel50.Name = "materialLabel50";
            this.materialLabel50.Size = new System.Drawing.Size(136, 14);
            this.materialLabel50.TabIndex = 105;
            this.materialLabel50.Text = "Chọn thời gian tìm kiếm";
            // 
            // comboBoxState
            // 
            this.comboBoxState.AutoResize = false;
            this.comboBoxState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxState.Depth = 0;
            this.comboBoxState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxState.DropDownHeight = 174;
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.DropDownWidth = 121;
            this.comboBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.IntegralHeight = false;
            this.comboBoxState.ItemHeight = 43;
            this.comboBoxState.Items.AddRange(new object[] {
            "Tình Trạng",
            "Đang Chỉnh Sửa",
            "Chưa Thanh Toán",
            "Đã Thanh Toán"});
            this.comboBoxState.Location = new System.Drawing.Point(6, 20);
            this.comboBoxState.MaxDropDownItems = 4;
            this.comboBoxState.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(132, 49);
            this.comboBoxState.StartIndex = 0;
            this.comboBoxState.TabIndex = 104;
            // 
            // buttonPriceSearch
            // 
            this.buttonPriceSearch.AutoSize = false;
            this.buttonPriceSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPriceSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonPriceSearch.Depth = 0;
            this.buttonPriceSearch.HighEmphasis = true;
            this.buttonPriceSearch.Icon = global::AccommodationManagerApp.Properties.Resources.search;
            this.buttonPriceSearch.Location = new System.Drawing.Point(576, 25);
            this.buttonPriceSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPriceSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPriceSearch.Name = "buttonPriceSearch";
            this.buttonPriceSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonPriceSearch.Size = new System.Drawing.Size(40, 36);
            this.buttonPriceSearch.TabIndex = 103;
            this.buttonPriceSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonPriceSearch.UseAccentColor = false;
            this.buttonPriceSearch.UseVisualStyleBackColor = true;
            this.buttonPriceSearch.Click += new System.EventHandler(this.ButtonPriceSearch_Click);
            // 
            // materialLabel47
            // 
            this.materialLabel47.AutoSize = true;
            this.materialLabel47.Depth = 0;
            this.materialLabel47.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel47.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel47.Location = new System.Drawing.Point(421, 32);
            this.materialLabel47.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel47.Name = "materialLabel47";
            this.materialLabel47.Size = new System.Drawing.Size(45, 24);
            this.materialLabel47.TabIndex = 102;
            this.materialLabel47.Text = "Max:";
            // 
            // materialLabel46
            // 
            this.materialLabel46.AutoSize = true;
            this.materialLabel46.Depth = 0;
            this.materialLabel46.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel46.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel46.Location = new System.Drawing.Point(272, 32);
            this.materialLabel46.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel46.Name = "materialLabel46";
            this.materialLabel46.Size = new System.Drawing.Size(45, 24);
            this.materialLabel46.TabIndex = 101;
            this.materialLabel46.Text = "Min: ";
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.AnimateReadOnly = false;
            this.textBoxMaxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxPrice.Depth = 0;
            this.textBoxMaxPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxMaxPrice.Hint = "giá trần";
            this.textBoxMaxPrice.LeadingIcon = null;
            this.textBoxMaxPrice.Location = new System.Drawing.Point(469, 19);
            this.textBoxMaxPrice.MaxLength = 50;
            this.textBoxMaxPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxMaxPrice.Multiline = false;
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(100, 50);
            this.textBoxMaxPrice.TabIndex = 100;
            this.textBoxMaxPrice.Text = "";
            this.textBoxMaxPrice.TrailingIcon = null;
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.AnimateReadOnly = false;
            this.textBoxMinPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinPrice.Depth = 0;
            this.textBoxMinPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxMinPrice.Hint = "giá sàn";
            this.textBoxMinPrice.LeadingIcon = null;
            this.textBoxMinPrice.Location = new System.Drawing.Point(319, 19);
            this.textBoxMinPrice.MaxLength = 50;
            this.textBoxMinPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxMinPrice.Multiline = false;
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(100, 50);
            this.textBoxMinPrice.TabIndex = 99;
            this.textBoxMinPrice.Text = "";
            this.textBoxMinPrice.TrailingIcon = null;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.AutoResize = false;
            this.comboBoxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxTime.Depth = 0;
            this.comboBoxTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxTime.DropDownHeight = 174;
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.DropDownWidth = 121;
            this.comboBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.IntegralHeight = false;
            this.comboBoxTime.ItemHeight = 43;
            this.comboBoxTime.Items.AddRange(new object[] {
            "Tất Cả",
            "Tháng Này",
            "Năm Nay",
            "Lịch Sử",
            "Tháng 01",
            "Tháng 02",
            "Tháng 03",
            "Tháng 04",
            "Tháng 05",
            "Tháng 06",
            "Tháng 07",
            "Tháng 08",
            "Tháng 09",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.comboBoxTime.Location = new System.Drawing.Point(144, 20);
            this.comboBoxTime.MaxDropDownItems = 4;
            this.comboBoxTime.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(128, 49);
            this.comboBoxTime.StartIndex = 0;
            this.comboBoxTime.TabIndex = 97;
            // 
            // ListViewBill
            // 
            this.ListViewBill.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.ListViewBill.AutoSizeTable = false;
            this.ListViewBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.rent,
            this.room,
            this.name,
            this.dateBill,
            this.stateBill});
            this.ListViewBill.Depth = 0;
            this.ListViewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ListViewBill.FullRowSelect = true;
            this.ListViewBill.HideSelection = false;
            this.ListViewBill.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListViewBill.Location = new System.Drawing.Point(6, 96);
            this.ListViewBill.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewBill.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewBill.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewBill.Name = "ListViewBill";
            this.ListViewBill.OwnerDraw = true;
            this.ListViewBill.ShowGroups = false;
            this.ListViewBill.Size = new System.Drawing.Size(689, 373);
            this.ListViewBill.TabIndex = 95;
            this.ListViewBill.UseCompatibleStateImageBehavior = false;
            this.ListViewBill.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 50;
            // 
            // rent
            // 
            this.rent.Text = "Tiền Thuê";
            this.rent.Width = 120;
            // 
            // room
            // 
            this.room.Text = "Phòng";
            this.room.Width = 100;
            // 
            // name
            // 
            this.name.Text = "Người nhận";
            this.name.Width = 120;
            // 
            // dateBill
            // 
            this.dateBill.Text = "Tháng";
            this.dateBill.Width = 120;
            // 
            // stateBill
            // 
            this.stateBill.Text = "Tình trạng";
            this.stateBill.Width = 150;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AccommodationManagerApp.Properties.Resources.icon_250;
            this.pictureBox2.Location = new System.Drawing.Point(701, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 94;
            this.pictureBox2.TabStop = false;
            // 
            // LabelBillContractEndDate
            // 
            this.LabelBillContractEndDate.AutoSize = true;
            this.LabelBillContractEndDate.Depth = 0;
            this.LabelBillContractEndDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelBillContractEndDate.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.LabelBillContractEndDate.Location = new System.Drawing.Point(184, 606);
            this.LabelBillContractEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelBillContractEndDate.Name = "LabelBillContractEndDate";
            this.LabelBillContractEndDate.Size = new System.Drawing.Size(127, 17);
            this.LabelBillContractEndDate.TabIndex = 93;
            this.LabelBillContractEndDate.Text = "_____________________";
            // 
            // materialLabel42
            // 
            this.materialLabel42.AutoSize = true;
            this.materialLabel42.Depth = 0;
            this.materialLabel42.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel42.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel42.Location = new System.Drawing.Point(29, 606);
            this.materialLabel42.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel42.Name = "materialLabel42";
            this.materialLabel42.Size = new System.Drawing.Size(149, 17);
            this.materialLabel42.TabIndex = 92;
            this.materialLabel42.Text = "Ngày hết hạn hợp đồng:";
            // 
            // LabelBillRoomNumber
            // 
            this.LabelBillRoomNumber.AutoSize = true;
            this.LabelBillRoomNumber.Depth = 0;
            this.LabelBillRoomNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelBillRoomNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.LabelBillRoomNumber.Location = new System.Drawing.Point(166, 583);
            this.LabelBillRoomNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelBillRoomNumber.Name = "LabelBillRoomNumber";
            this.LabelBillRoomNumber.Size = new System.Drawing.Size(145, 17);
            this.LabelBillRoomNumber.TabIndex = 91;
            this.LabelBillRoomNumber.Text = "________________________";
            // 
            // materialLabel40
            // 
            this.materialLabel40.AutoSize = true;
            this.materialLabel40.Depth = 0;
            this.materialLabel40.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel40.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel40.Location = new System.Drawing.Point(97, 583);
            this.materialLabel40.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel40.Name = "materialLabel40";
            this.materialLabel40.Size = new System.Drawing.Size(63, 17);
            this.materialLabel40.TabIndex = 90;
            this.materialLabel40.Text = "Số phòng:";
            // 
            // LabelBillContractValue
            // 
            this.LabelBillContractValue.AutoSize = true;
            this.LabelBillContractValue.Depth = 0;
            this.LabelBillContractValue.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelBillContractValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.LabelBillContractValue.Location = new System.Drawing.Point(166, 526);
            this.LabelBillContractValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelBillContractValue.Name = "LabelBillContractValue";
            this.LabelBillContractValue.Size = new System.Drawing.Size(145, 17);
            this.LabelBillContractValue.TabIndex = 89;
            this.LabelBillContractValue.Text = "________________________";
            // 
            // labelSoemthingss
            // 
            this.labelSoemthingss.AutoSize = true;
            this.labelSoemthingss.Depth = 0;
            this.labelSoemthingss.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSoemthingss.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelSoemthingss.Location = new System.Drawing.Point(49, 526);
            this.labelSoemthingss.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSoemthingss.Name = "labelSoemthingss";
            this.labelSoemthingss.Size = new System.Drawing.Size(111, 17);
            this.labelSoemthingss.TabIndex = 88;
            this.labelSoemthingss.Text = "Giá thuê niêm yết:";
            // 
            // LabelBillTotal
            // 
            this.LabelBillTotal.AutoSize = true;
            this.LabelBillTotal.Depth = 0;
            this.LabelBillTotal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelBillTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.LabelBillTotal.Location = new System.Drawing.Point(166, 555);
            this.LabelBillTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelBillTotal.Name = "LabelBillTotal";
            this.LabelBillTotal.Size = new System.Drawing.Size(145, 17);
            this.LabelBillTotal.TabIndex = 87;
            this.LabelBillTotal.Text = "________________________";
            // 
            // materialLabel39
            // 
            this.materialLabel39.AutoSize = true;
            this.materialLabel39.Depth = 0;
            this.materialLabel39.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel39.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel39.Location = new System.Drawing.Point(29, 555);
            this.materialLabel39.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel39.Name = "materialLabel39";
            this.materialLabel39.Size = new System.Drawing.Size(131, 17);
            this.materialLabel39.TabIndex = 86;
            this.materialLabel39.Text = "Tổng giá trị hoá đơn: ";
            // 
            // LabelBillContractOwner
            // 
            this.LabelBillContractOwner.AutoSize = true;
            this.LabelBillContractOwner.Depth = 0;
            this.LabelBillContractOwner.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelBillContractOwner.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.LabelBillContractOwner.Location = new System.Drawing.Point(166, 500);
            this.LabelBillContractOwner.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelBillContractOwner.Name = "LabelBillContractOwner";
            this.LabelBillContractOwner.Size = new System.Drawing.Size(145, 17);
            this.LabelBillContractOwner.TabIndex = 85;
            this.LabelBillContractOwner.Text = "________________________";
            // 
            // materialLabel37
            // 
            this.materialLabel37.AutoSize = true;
            this.materialLabel37.Depth = 0;
            this.materialLabel37.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel37.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel37.Location = new System.Drawing.Point(69, 500);
            this.materialLabel37.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel37.Name = "materialLabel37";
            this.materialLabel37.Size = new System.Drawing.Size(91, 17);
            this.materialLabel37.TabIndex = 84;
            this.materialLabel37.Text = "Chủ hợp đồng:";
            // 
            // labelInternetPrice
            // 
            this.labelInternetPrice.AutoSize = true;
            this.labelInternetPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelInternetPrice.Depth = 0;
            this.labelInternetPrice.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelInternetPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelInternetPrice.Location = new System.Drawing.Point(802, 80);
            this.labelInternetPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelInternetPrice.Name = "labelInternetPrice";
            this.labelInternetPrice.Size = new System.Drawing.Size(109, 17);
            this.labelInternetPrice.TabIndex = 72;
            this.labelInternetPrice.Text = "__________________";
            // 
            // materialLabel35
            // 
            this.materialLabel35.AutoSize = true;
            this.materialLabel35.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel35.Depth = 0;
            this.materialLabel35.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel35.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel35.Location = new System.Drawing.Point(708, 80);
            this.materialLabel35.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel35.Name = "materialLabel35";
            this.materialLabel35.Size = new System.Drawing.Size(77, 17);
            this.materialLabel35.TabIndex = 71;
            this.materialLabel35.Text = "Giá Internet:";
            // 
            // labelElectricityPrice
            // 
            this.labelElectricityPrice.AutoSize = true;
            this.labelElectricityPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelElectricityPrice.Depth = 0;
            this.labelElectricityPrice.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelElectricityPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelElectricityPrice.Location = new System.Drawing.Point(802, 52);
            this.labelElectricityPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelElectricityPrice.Name = "labelElectricityPrice";
            this.labelElectricityPrice.Size = new System.Drawing.Size(109, 17);
            this.labelElectricityPrice.TabIndex = 70;
            this.labelElectricityPrice.Text = "__________________";
            // 
            // materialLabel34
            // 
            this.materialLabel34.AutoSize = true;
            this.materialLabel34.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel34.Depth = 0;
            this.materialLabel34.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel34.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel34.Location = new System.Drawing.Point(707, 52);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(78, 17);
            this.materialLabel34.TabIndex = 69;
            this.materialLabel34.Text = "Giá 1 kí điện:";
            // 
            // labelWaterPrice
            // 
            this.labelWaterPrice.AutoSize = true;
            this.labelWaterPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelWaterPrice.Depth = 0;
            this.labelWaterPrice.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelWaterPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelWaterPrice.Location = new System.Drawing.Point(802, 24);
            this.labelWaterPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelWaterPrice.Name = "labelWaterPrice";
            this.labelWaterPrice.Size = new System.Drawing.Size(109, 17);
            this.labelWaterPrice.TabIndex = 68;
            this.labelWaterPrice.Text = "__________________";
            // 
            // materialLabel36
            // 
            this.materialLabel36.AutoSize = true;
            this.materialLabel36.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel36.Depth = 0;
            this.materialLabel36.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel36.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel36.Location = new System.Drawing.Point(685, 24);
            this.materialLabel36.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel36.Name = "materialLabel36";
            this.materialLabel36.Size = new System.Drawing.Size(100, 17);
            this.materialLabel36.TabIndex = 67;
            this.materialLabel36.Text = "Giá 1 khối nước:";
            // 
            // buttonPreview
            // 
            this.buttonPreview.AutoSize = false;
            this.buttonPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonPreview.Depth = 0;
            this.buttonPreview.HighEmphasis = true;
            this.buttonPreview.Icon = global::AccommodationManagerApp.Properties.Resources.preview;
            this.buttonPreview.Location = new System.Drawing.Point(701, 304);
            this.buttonPreview.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonPreview.Size = new System.Drawing.Size(189, 36);
            this.buttonPreview.TabIndex = 50;
            this.buttonPreview.Text = "Xem Chi Tiết";
            this.buttonPreview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonPreview.UseAccentColor = false;
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // pgConfig
            // 
            this.pgConfig.ImageKey = "configuration.png";
            this.pgConfig.Location = new System.Drawing.Point(4, 39);
            this.pgConfig.Name = "pgConfig";
            this.pgConfig.Size = new System.Drawing.Size(986, 690);
            this.pgConfig.TabIndex = 3;
            this.pgConfig.Text = "Cài Đặt";
            this.pgConfig.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.tbCtrlClient);
            this.Controls.Add(this.buttonCurrentUserInformationManagement);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblEmail);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tbCtrlClient;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "ClientForm";
            this.Text = "";
            this.tbCtrlClient.ResumeLayout(false);
            this.pgRequest.ResumeLayout(false);
            this.pgRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pgBill.ResumeLayout(false);
            this.pgBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialButton buttonCurrentUserInformationManagement;
        private System.Windows.Forms.ImageList imgLstClient;
        private MaterialSkin.Controls.MaterialTabControl tbCtrlClient;
        private System.Windows.Forms.TabPage pgRequest;
        private System.Windows.Forms.TabPage pgBill;
        private System.Windows.Forms.TabPage pgConfig;
        private MaterialSkin.Controls.MaterialComboBox cmbbxReqCate;
        private MaterialSkin.Controls.MaterialButton btnReqSearch;
        private MaterialSkin.Controls.MaterialTextBox txtReqSearch;
        private MaterialSkin.Controls.MaterialListView lstViewReq;
        private System.Windows.Forms.ColumnHeader idReq;
        private System.Windows.Forms.ColumnHeader desReq;
        private System.Windows.Forms.ColumnHeader dateReq;
        private System.Windows.Forms.ColumnHeader stateReq;
        private MaterialSkin.Controls.MaterialButton btnUpd;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton buttonPreview;
        private MaterialSkin.Controls.MaterialLabel labelInternetPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel35;
        private MaterialSkin.Controls.MaterialLabel labelElectricityPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel34;
        private MaterialSkin.Controls.MaterialLabel labelWaterPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel36;
        private MaterialSkin.Controls.MaterialLabel LabelBillContractEndDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel42;
        private MaterialSkin.Controls.MaterialLabel LabelBillRoomNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel40;
        private MaterialSkin.Controls.MaterialLabel LabelBillContractValue;
        private MaterialSkin.Controls.MaterialLabel labelSoemthingss;
        private MaterialSkin.Controls.MaterialLabel LabelBillTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel39;
        private MaterialSkin.Controls.MaterialLabel LabelBillContractOwner;
        private MaterialSkin.Controls.MaterialLabel materialLabel37;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialListView ListViewBill;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader rent;
        private System.Windows.Forms.ColumnHeader room;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader dateBill;
        private System.Windows.Forms.ColumnHeader stateBill;
        private MaterialSkin.Controls.MaterialComboBox comboBoxState;
        private MaterialSkin.Controls.MaterialButton buttonPriceSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel47;
        private MaterialSkin.Controls.MaterialLabel materialLabel46;
        private MaterialSkin.Controls.MaterialTextBox textBoxMaxPrice;
        private MaterialSkin.Controls.MaterialTextBox textBoxMinPrice;
        private MaterialSkin.Controls.MaterialComboBox comboBoxTime;
        private MaterialSkin.Controls.MaterialLabel materialLabel50;
        private MaterialSkin.Controls.MaterialLabel materialLabel48;
        private MaterialSkin.Controls.MaterialLabel labelReqState;
        private MaterialSkin.Controls.MaterialLabel materialLabel38;
        private MaterialSkin.Controls.MaterialLabel labelReqDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel43;
        private MaterialSkin.Controls.MaterialLabel labelReqContent;
        private MaterialSkin.Controls.MaterialLabel materialLabel45;
        private MaterialSkin.Controls.MaterialLabel labelReqUser;
        private MaterialSkin.Controls.MaterialLabel materialLabel65;
    }
}