namespace AccommodationManagerApp.Forms
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
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.imgLstClient = new System.Windows.Forms.ImageList(this.components);
            this.tbCtrlClient = new MaterialSkin.Controls.MaterialTabControl();
            this.pgMain = new System.Windows.Forms.TabPage();
            this.pgRequest = new System.Windows.Forms.TabPage();
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
            this.lstViewBill = new MaterialSkin.Controls.MaterialListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPDF = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbboxCatg = new MaterialSkin.Controls.MaterialComboBox();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.pgConfig = new System.Windows.Forms.TabPage();
            this.tbCtrlClient.SuspendLayout();
            this.pgRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pgBill.SuspendLayout();
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
            this.btnLogout.Location = new System.Drawing.Point(789, 25);
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
            this.btnLogout.Click += new System.EventHandler(this.logout);
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
            this.buttonCurrentUserInformationManagement.Click += new System.EventHandler(this.showInfor);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = global::AccommodationManagerApp.Properties.Resources.login;
            this.btnLogin.Location = new System.Drawing.Point(649, 25);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(134, 36);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.login);
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
            this.tbCtrlClient.Controls.Add(this.pgMain);
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
            this.tbCtrlClient.Size = new System.Drawing.Size(1026, 811);
            this.tbCtrlClient.TabIndex = 25;
            // 
            // pgMain
            // 
            this.pgMain.ImageKey = "homepage.png";
            this.pgMain.Location = new System.Drawing.Point(4, 39);
            this.pgMain.Name = "pgMain";
            this.pgMain.Padding = new System.Windows.Forms.Padding(3);
            this.pgMain.Size = new System.Drawing.Size(1018, 768);
            this.pgMain.TabIndex = 0;
            this.pgMain.Text = "Trang Chủ";
            this.pgMain.UseVisualStyleBackColor = true;
            // 
            // pgRequest
            // 
            this.pgRequest.BackColor = System.Drawing.Color.White;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccommodationManagerApp.Properties.Resources.icon_250;
            this.pictureBox1.Location = new System.Drawing.Point(11, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 157);
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
            this.btnUpd.Location = new System.Drawing.Point(11, 302);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpd.Size = new System.Drawing.Size(187, 39);
            this.btnUpd.TabIndex = 32;
            this.btnUpd.Text = "Cập Nhật";
            this.btnUpd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpd.UseAccentColor = false;
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.updateReq);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = global::AccommodationManagerApp.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(110, 353);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(88, 39);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.deleteReq);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = global::AccommodationManagerApp.Properties.Resources.plus1;
            this.btnAdd.Location = new System.Drawing.Point(11, 353);
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
            this.btnAdd.Click += new System.EventHandler(this.addReq);
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
            this.lstViewReq.Location = new System.Drawing.Point(217, 127);
            this.lstViewReq.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstViewReq.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstViewReq.MouseState = MaterialSkin.MouseState.OUT;
            this.lstViewReq.Name = "lstViewReq";
            this.lstViewReq.OwnerDraw = true;
            this.lstViewReq.ShowGroups = false;
            this.lstViewReq.Size = new System.Drawing.Size(700, 450);
            this.lstViewReq.TabIndex = 29;
            this.lstViewReq.UseCompatibleStateImageBehavior = false;
            this.lstViewReq.View = System.Windows.Forms.View.Details;
            this.lstViewReq.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ItemSelectionChanged);
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
            this.cmbbxReqCate.Location = new System.Drawing.Point(137, 38);
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
            this.btnReqSearch.Location = new System.Drawing.Point(766, 41);
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
            this.txtReqSearch.Location = new System.Drawing.Point(230, 37);
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
            this.pgBill.Controls.Add(this.lstViewBill);
            this.pgBill.Controls.Add(this.btnPDF);
            this.pgBill.Controls.Add(this.materialComboBox2);
            this.pgBill.Controls.Add(this.cmbboxCatg);
            this.pgBill.Controls.Add(this.btnSearch);
            this.pgBill.Controls.Add(this.txtBoxSearch);
            this.pgBill.ImageKey = "contract.png";
            this.pgBill.Location = new System.Drawing.Point(4, 39);
            this.pgBill.Name = "pgBill";
            this.pgBill.Size = new System.Drawing.Size(1018, 768);
            this.pgBill.TabIndex = 2;
            this.pgBill.Text = "Hóa Đơn";
            this.pgBill.UseVisualStyleBackColor = true;
            // 
            // lstViewBill
            // 
            this.lstViewBill.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstViewBill.AutoSizeTable = false;
            this.lstViewBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstViewBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.date,
            this.state});
            this.lstViewBill.Depth = 0;
            this.lstViewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lstViewBill.FullRowSelect = true;
            this.lstViewBill.HideSelection = false;
            this.lstViewBill.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstViewBill.Location = new System.Drawing.Point(2, 108);
            this.lstViewBill.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstViewBill.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstViewBill.MouseState = MaterialSkin.MouseState.OUT;
            this.lstViewBill.Name = "lstViewBill";
            this.lstViewBill.OwnerDraw = true;
            this.lstViewBill.ShowGroups = false;
            this.lstViewBill.Size = new System.Drawing.Size(983, 474);
            this.lstViewBill.TabIndex = 28;
            this.lstViewBill.UseCompatibleStateImageBehavior = false;
            this.lstViewBill.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 50;
            // 
            // date
            // 
            this.date.Text = "Ngày";
            this.date.Width = 130;
            // 
            // state
            // 
            this.state.Text = "Tình Trạng";
            this.state.Width = 100;
            // 
            // btnPDF
            // 
            this.btnPDF.AutoSize = false;
            this.btnPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPDF.Depth = 0;
            this.btnPDF.HighEmphasis = true;
            this.btnPDF.Icon = global::AccommodationManagerApp.Properties.Resources.view;
            this.btnPDF.Location = new System.Drawing.Point(415, 591);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPDF.Size = new System.Drawing.Size(187, 44);
            this.btnPDF.TabIndex = 24;
            this.btnPDF.Text = "Xem Trước";
            this.btnPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPDF.UseAccentColor = false;
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.pdfBill);
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Items.AddRange(new object[] {
            "Tăng ",
            "Giảm"});
            this.materialComboBox2.Location = new System.Drawing.Point(66, 20);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(87, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 23;
            // 
            // cmbboxCatg
            // 
            this.cmbboxCatg.AutoResize = false;
            this.cmbboxCatg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbboxCatg.Depth = 0;
            this.cmbboxCatg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbboxCatg.DropDownHeight = 174;
            this.cmbboxCatg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxCatg.DropDownWidth = 121;
            this.cmbboxCatg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbboxCatg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbboxCatg.FormattingEnabled = true;
            this.cmbboxCatg.IntegralHeight = false;
            this.cmbboxCatg.ItemHeight = 43;
            this.cmbboxCatg.Items.AddRange(new object[] {
            "Ngày",
            "Phòng",
            "Khách Hàng",
            "Giá",
            "Điện",
            "Nước",
            "Phí Thuê"});
            this.cmbboxCatg.Location = new System.Drawing.Point(159, 20);
            this.cmbboxCatg.MaxDropDownItems = 4;
            this.cmbboxCatg.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbboxCatg.Name = "cmbboxCatg";
            this.cmbboxCatg.Size = new System.Drawing.Size(87, 49);
            this.cmbboxCatg.StartIndex = 0;
            this.cmbboxCatg.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = global::AccommodationManagerApp.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(830, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(106, 36);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseCompatibleTextRendering = true;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.AnimateReadOnly = false;
            this.txtBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSearch.Depth = 0;
            this.txtBoxSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Transparent;
            this.txtBoxSearch.Hint = "Tìm Kiếm";
            this.txtBoxSearch.LeadingIcon = null;
            this.txtBoxSearch.Location = new System.Drawing.Point(253, 19);
            this.txtBoxSearch.MaxLength = 50;
            this.txtBoxSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxSearch.Multiline = false;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(562, 50);
            this.txtBoxSearch.TabIndex = 21;
            this.txtBoxSearch.Text = "";
            this.txtBoxSearch.TrailingIcon = null;
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
            this.ClientSize = new System.Drawing.Size(1032, 878);
            this.Controls.Add(this.tbCtrlClient);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.buttonCurrentUserInformationManagement);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblEmail);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tbCtrlClient;
            this.Name = "ClientForm";
            this.Text = "";
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.buttonCurrentUserInformationManagement, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.tbCtrlClient, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.tbCtrlClient.ResumeLayout(false);
            this.pgRequest.ResumeLayout(false);
            this.pgRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pgBill.ResumeLayout(false);
            this.pgBill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialButton buttonCurrentUserInformationManagement;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private System.Windows.Forms.ImageList imgLstClient;
        private MaterialSkin.Controls.MaterialTabControl tbCtrlClient;
        private System.Windows.Forms.TabPage pgMain;
        private System.Windows.Forms.TabPage pgRequest;
        private System.Windows.Forms.TabPage pgBill;
        private System.Windows.Forms.TabPage pgConfig;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private MaterialSkin.Controls.MaterialComboBox cmbboxCatg;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialTextBox txtBoxSearch;
        private MaterialSkin.Controls.MaterialButton btnPDF;
        private MaterialSkin.Controls.MaterialListView lstViewBill;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader state;
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
    }
}