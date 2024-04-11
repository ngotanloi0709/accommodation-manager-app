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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.buttonCurrentUserInformationManagement = new MaterialSkin.Controls.MaterialButton();
            this.imgLstClient = new System.Windows.Forms.ImageList(this.components);
            this.tbCtrlClient = new MaterialSkin.Controls.MaterialTabControl();
            this.pgRequest = new System.Windows.Forms.TabPage();
            this.buttonResponse = new MaterialSkin.Controls.MaterialButton();
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
            this.comboBoxVolumn = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbboxCatg = new MaterialSkin.Controls.MaterialComboBox();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonPreview = new MaterialSkin.Controls.MaterialButton();
            this.lstViewBill = new MaterialSkin.Controls.MaterialListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.elec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.water = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pgConfig = new System.Windows.Forms.TabPage();
            this.pgStatistic = new System.Windows.Forms.TabPage();
            this.paidAndUnpaidChart = new LiveCharts.WinForms.PieChart();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.requestChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnReloadChart = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.electricityAndWaterChart = new LiveCharts.WinForms.CartesianChart();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tbCtrlClient.SuspendLayout();
            this.pgRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pgBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pgStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(360, 31);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(328, 44);
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
            this.btnLogout.Location = new System.Drawing.Point(1085, 34);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(179, 44);
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
            this.buttonCurrentUserInformationManagement.Location = new System.Drawing.Point(105, 31);
            this.buttonCurrentUserInformationManagement.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.buttonCurrentUserInformationManagement.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCurrentUserInformationManagement.Name = "buttonCurrentUserInformationManagement";
            this.buttonCurrentUserInformationManagement.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCurrentUserInformationManagement.Size = new System.Drawing.Size(252, 44);
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
            this.tbCtrlClient.Controls.Add(this.pgStatistic);
            this.tbCtrlClient.Depth = 0;
            this.tbCtrlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlClient.ImageList = this.imgLstClient;
            this.tbCtrlClient.Location = new System.Drawing.Point(5, 97);
            this.tbCtrlClient.Margin = new System.Windows.Forms.Padding(4);
            this.tbCtrlClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCtrlClient.Multiline = true;
            this.tbCtrlClient.Name = "tbCtrlClient";
            this.tbCtrlClient.SelectedIndex = 0;
            this.tbCtrlClient.Size = new System.Drawing.Size(1317, 872);
            this.tbCtrlClient.TabIndex = 25;
            // 
            // pgRequest
            // 
            this.pgRequest.BackColor = System.Drawing.Color.White;
            this.pgRequest.Controls.Add(this.buttonResponse);
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
            this.pgRequest.Margin = new System.Windows.Forms.Padding(4);
            this.pgRequest.Name = "pgRequest";
            this.pgRequest.Padding = new System.Windows.Forms.Padding(4);
            this.pgRequest.Size = new System.Drawing.Size(1309, 829);
            this.pgRequest.TabIndex = 1;
            this.pgRequest.Text = "Yêu Cầu";
            this.pgRequest.UseVisualStyleBackColor = true;
            // 
            // buttonResponse
            // 
            this.buttonResponse.AutoSize = false;
            this.buttonResponse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResponse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonResponse.Depth = 0;
            this.buttonResponse.HighEmphasis = true;
            this.buttonResponse.Icon = global::AccommodationManagerApp.Properties.Resources.preview;
            this.buttonResponse.Location = new System.Drawing.Point(1005, 501);
            this.buttonResponse.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.buttonResponse.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonResponse.Name = "buttonResponse";
            this.buttonResponse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonResponse.Size = new System.Drawing.Size(249, 48);
            this.buttonResponse.TabIndex = 34;
            this.buttonResponse.Text = "Phản Hồi";
            this.buttonResponse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonResponse.UseAccentColor = false;
            this.buttonResponse.UseVisualStyleBackColor = true;
            this.buttonResponse.Click += new System.EventHandler(this.buttonResponse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1005, 160);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 193);
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
            this.btnUpd.Location = new System.Drawing.Point(1005, 375);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnUpd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpd.Size = new System.Drawing.Size(249, 48);
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
            this.btnDelete.Location = new System.Drawing.Point(1137, 438);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(117, 48);
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
            this.btnAdd.Location = new System.Drawing.Point(1005, 438);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(121, 48);
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
            this.lstViewReq.Location = new System.Drawing.Point(37, 134);
            this.lstViewReq.Margin = new System.Windows.Forms.Padding(4);
            this.lstViewReq.MinimumSize = new System.Drawing.Size(267, 123);
            this.lstViewReq.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstViewReq.MouseState = MaterialSkin.MouseState.OUT;
            this.lstViewReq.Name = "lstViewReq";
            this.lstViewReq.OwnerDraw = true;
            this.lstViewReq.ShowGroups = false;
            this.lstViewReq.Size = new System.Drawing.Size(933, 554);
            this.lstViewReq.TabIndex = 29;
            this.lstViewReq.UseCompatibleStateImageBehavior = false;
            this.lstViewReq.View = System.Windows.Forms.View.Details;
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
            this.cmbbxReqCate.Location = new System.Drawing.Point(43, 46);
            this.cmbbxReqCate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxReqCate.MaxDropDownItems = 4;
            this.cmbbxReqCate.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbbxReqCate.Name = "cmbbxReqCate";
            this.cmbbxReqCate.Size = new System.Drawing.Size(115, 49);
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
            this.btnReqSearch.Location = new System.Drawing.Point(881, 49);
            this.btnReqSearch.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
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
            this.txtReqSearch.Location = new System.Drawing.Point(167, 44);
            this.txtReqSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtReqSearch.MaxLength = 50;
            this.txtReqSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReqSearch.Multiline = false;
            this.txtReqSearch.Name = "txtReqSearch";
            this.txtReqSearch.Size = new System.Drawing.Size(705, 50);
            this.txtReqSearch.TabIndex = 25;
            this.txtReqSearch.Text = "";
            this.txtReqSearch.TrailingIcon = null;
            // 
            // pgBill
            // 
            this.pgBill.BackColor = System.Drawing.Color.White;
            this.pgBill.Controls.Add(this.comboBoxVolumn);
            this.pgBill.Controls.Add(this.cmbboxCatg);
            this.pgBill.Controls.Add(this.btnSearch);
            this.pgBill.Controls.Add(this.txtBoxSearch);
            this.pgBill.Controls.Add(this.pictureBox2);
            this.pgBill.Controls.Add(this.buttonPreview);
            this.pgBill.Controls.Add(this.lstViewBill);
            this.pgBill.ImageKey = "contract.png";
            this.pgBill.Location = new System.Drawing.Point(4, 39);
            this.pgBill.Margin = new System.Windows.Forms.Padding(4);
            this.pgBill.Name = "pgBill";
            this.pgBill.Size = new System.Drawing.Size(1309, 829);
            this.pgBill.TabIndex = 2;
            this.pgBill.Text = "Hóa Đơn";
            this.pgBill.UseVisualStyleBackColor = true;
            // 
            // comboBoxVolumn
            // 
            this.comboBoxVolumn.AutoResize = false;
            this.comboBoxVolumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxVolumn.Depth = 0;
            this.comboBoxVolumn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxVolumn.DropDownHeight = 174;
            this.comboBoxVolumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVolumn.DropDownWidth = 121;
            this.comboBoxVolumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxVolumn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxVolumn.FormattingEnabled = true;
            this.comboBoxVolumn.IntegralHeight = false;
            this.comboBoxVolumn.ItemHeight = 43;
            this.comboBoxVolumn.Items.AddRange(new object[] {
            "Tất Cả",
            "Tháng Này"});
            this.comboBoxVolumn.Location = new System.Drawing.Point(51, 31);
            this.comboBoxVolumn.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVolumn.MaxDropDownItems = 4;
            this.comboBoxVolumn.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxVolumn.Name = "comboBoxVolumn";
            this.comboBoxVolumn.Size = new System.Drawing.Size(167, 49);
            this.comboBoxVolumn.StartIndex = 0;
            this.comboBoxVolumn.TabIndex = 69;
            this.comboBoxVolumn.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVolumn_SelectedIndexChanged);
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
            "Thời gian"});
            this.cmbboxCatg.Location = new System.Drawing.Point(227, 31);
            this.cmbboxCatg.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxCatg.MaxDropDownItems = 4;
            this.cmbboxCatg.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbboxCatg.Name = "cmbboxCatg";
            this.cmbboxCatg.Size = new System.Drawing.Size(153, 49);
            this.cmbboxCatg.StartIndex = 0;
            this.cmbboxCatg.TabIndex = 68;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = global::AccommodationManagerApp.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(1084, 39);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(106, 36);
            this.btnSearch.TabIndex = 66;
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
            this.txtBoxSearch.Location = new System.Drawing.Point(389, 30);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearch.MaxLength = 50;
            this.txtBoxSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxSearch.Multiline = false;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(676, 50);
            this.txtBoxSearch.TabIndex = 67;
            this.txtBoxSearch.Text = "";
            this.txtBoxSearch.TrailingIcon = null;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(947, 116);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 186);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // buttonPreview
            // 
            this.buttonPreview.AutoSize = false;
            this.buttonPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPreview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonPreview.Depth = 0;
            this.buttonPreview.HighEmphasis = true;
            this.buttonPreview.Icon = global::AccommodationManagerApp.Properties.Resources.preview;
            this.buttonPreview.Location = new System.Drawing.Point(947, 313);
            this.buttonPreview.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.buttonPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonPreview.Size = new System.Drawing.Size(252, 44);
            this.buttonPreview.TabIndex = 50;
            this.buttonPreview.Text = "Xem Chi Tiết";
            this.buttonPreview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonPreview.UseAccentColor = false;
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // lstViewBill
            // 
            this.lstViewBill.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstViewBill.AutoSizeTable = false;
            this.lstViewBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstViewBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.elec,
            this.water,
            this.room,
            this.date,
            this.state});
            this.lstViewBill.Depth = 0;
            this.lstViewBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lstViewBill.FullRowSelect = true;
            this.lstViewBill.HideSelection = false;
            this.lstViewBill.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstViewBill.Location = new System.Drawing.Point(51, 116);
            this.lstViewBill.Margin = new System.Windows.Forms.Padding(4);
            this.lstViewBill.MinimumSize = new System.Drawing.Size(267, 123);
            this.lstViewBill.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstViewBill.MouseState = MaterialSkin.MouseState.OUT;
            this.lstViewBill.Name = "lstViewBill";
            this.lstViewBill.OwnerDraw = true;
            this.lstViewBill.ShowGroups = false;
            this.lstViewBill.Size = new System.Drawing.Size(820, 690);
            this.lstViewBill.TabIndex = 49;
            this.lstViewBill.UseCompatibleStateImageBehavior = false;
            this.lstViewBill.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 50;
            // 
            // elec
            // 
            this.elec.Text = "Số điện";
            this.elec.Width = 81;
            // 
            // water
            // 
            this.water.Text = "Số nước";
            this.water.Width = 89;
            // 
            // room
            // 
            this.room.Text = "Phòng";
            this.room.Width = 100;
            // 
            // date
            // 
            this.date.Text = "Ngày Tạo";
            this.date.Width = 120;
            // 
            // state
            // 
            this.state.Text = "Tình Trạng";
            this.state.Width = 150;
            // 
            // pgConfig
            // 
            this.pgConfig.ImageKey = "configuration.png";
            this.pgConfig.Location = new System.Drawing.Point(4, 39);
            this.pgConfig.Margin = new System.Windows.Forms.Padding(4);
            this.pgConfig.Name = "pgConfig";
            this.pgConfig.Size = new System.Drawing.Size(1309, 829);
            this.pgConfig.TabIndex = 3;
            this.pgConfig.Text = "Cài Đặt";
            this.pgConfig.UseVisualStyleBackColor = true;
            // 
            // pgStatistic
            // 
            this.pgStatistic.BackColor = System.Drawing.Color.White;
            this.pgStatistic.Controls.Add(this.materialLabel2);
            this.pgStatistic.Controls.Add(this.paidAndUnpaidChart);
            this.pgStatistic.Controls.Add(this.materialLabel1);
            this.pgStatistic.Controls.Add(this.requestChart);
            this.pgStatistic.Controls.Add(this.btnReloadChart);
            this.pgStatistic.Controls.Add(this.materialLabel13);
            this.pgStatistic.Controls.Add(this.electricityAndWaterChart);
            this.pgStatistic.ImageKey = "homepage.png";
            this.pgStatistic.Location = new System.Drawing.Point(4, 39);
            this.pgStatistic.Name = "pgStatistic";
            this.pgStatistic.Size = new System.Drawing.Size(1309, 829);
            this.pgStatistic.TabIndex = 4;
            this.pgStatistic.Text = "Thống kê ";
            // 
            // paidAndUnpaidChart
            // 
            this.paidAndUnpaidChart.Location = new System.Drawing.Point(798, 470);
            this.paidAndUnpaidChart.Name = "paidAndUnpaidChart";
            this.paidAndUnpaidChart.Size = new System.Drawing.Size(335, 279);
            this.paidAndUnpaidChart.TabIndex = 64;
            this.paidAndUnpaidChart.Text = "pieChart1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(65, 752);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(407, 29);
            this.materialLabel1.TabIndex = 63;
            this.materialLabel1.Text = "Biểu đồ số yêu cầu trong vòng 3 tháng";
            // 
            // requestChart
            // 
            chartArea1.Name = "ChartArea1";
            this.requestChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.requestChart.Legends.Add(legend1);
            this.requestChart.Location = new System.Drawing.Point(22, 454);
            this.requestChart.Name = "requestChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "NumberRequest";
            this.requestChart.Series.Add(series1);
            this.requestChart.Size = new System.Drawing.Size(734, 295);
            this.requestChart.TabIndex = 62;
            this.requestChart.Text = "chart1";
            // 
            // btnReloadChart
            // 
            this.btnReloadChart.AutoSize = false;
            this.btnReloadChart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReloadChart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReloadChart.Depth = 0;
            this.btnReloadChart.HighEmphasis = true;
            this.btnReloadChart.Icon = global::AccommodationManagerApp.Properties.Resources.check_list;
            this.btnReloadChart.Location = new System.Drawing.Point(126, 20);
            this.btnReloadChart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReloadChart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReloadChart.Name = "btnReloadChart";
            this.btnReloadChart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReloadChart.Size = new System.Drawing.Size(964, 36);
            this.btnReloadChart.TabIndex = 61;
            this.btnReloadChart.Text = "Cập nhật dữ liệu thống kê";
            this.btnReloadChart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReloadChart.UseAccentColor = false;
            this.btnReloadChart.UseVisualStyleBackColor = true;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel13.Location = new System.Drawing.Point(375, 422);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(465, 29);
            this.materialLabel13.TabIndex = 33;
            this.materialLabel13.Text = "Biểu đồ số điện số nước trong 12 tháng qua";
            // 
            // electricityAndWaterChart
            // 
            this.electricityAndWaterChart.Location = new System.Drawing.Point(96, 78);
            this.electricityAndWaterChart.Name = "electricityAndWaterChart";
            this.electricityAndWaterChart.Size = new System.Drawing.Size(994, 324);
            this.electricityAndWaterChart.TabIndex = 0;
            this.electricityAndWaterChart.Text = "cartesianChart1";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(883, 752);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(175, 29);
            this.materialLabel2.TabIndex = 65;
            this.materialLabel2.Text = "Biểu đồ hóa đơn";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 974);
            this.Controls.Add(this.tbCtrlClient);
            this.Controls.Add(this.buttonCurrentUserInformationManagement);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblEmail);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tbCtrlClient;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1327, 974);
            this.MinimumSize = new System.Drawing.Size(1327, 974);
            this.Name = "ClientForm";
            this.Padding = new System.Windows.Forms.Padding(5, 97, 5, 5);
            this.Text = "";
            this.Load += new System.EventHandler(this.ClientFormOnLoad);
            this.tbCtrlClient.ResumeLayout(false);
            this.pgRequest.ResumeLayout(false);
            this.pgRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pgBill.ResumeLayout(false);
            this.pgBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pgStatistic.ResumeLayout(false);
            this.pgStatistic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestChart)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialButton buttonPreview;
        private MaterialSkin.Controls.MaterialListView lstViewBill;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader elec;
        private System.Windows.Forms.ColumnHeader water;
        private System.Windows.Forms.ColumnHeader room;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader state;
        private MaterialSkin.Controls.MaterialComboBox comboBoxVolumn;
        private MaterialSkin.Controls.MaterialComboBox cmbboxCatg;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialTextBox txtBoxSearch;
        private MaterialSkin.Controls.MaterialButton buttonResponse;
        private System.Windows.Forms.TabPage pgStatistic;
        private LiveCharts.WinForms.CartesianChart electricityAndWaterChart;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialButton btnReloadChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart requestChart;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private LiveCharts.WinForms.PieChart paidAndUnpaidChart;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}