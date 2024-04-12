namespace AccommodationManagerApp.Forms
{
    partial class BuildingStatisticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.debtPieChart = new LiveCharts.WinForms.PieChart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.debtBuilding3 = new System.Windows.Forms.Label();
            this.revenueBuilding3 = new System.Windows.Forms.Label();
            this.rentRoomBuilding3 = new System.Windows.Forms.Label();
            this.debtBuilding2 = new System.Windows.Forms.Label();
            this.revenueBuilding2 = new System.Windows.Forms.Label();
            this.rentRoomBuilding2 = new System.Windows.Forms.Label();
            this.debtBuilding1 = new System.Windows.Forms.Label();
            this.revenueBuilding1 = new System.Windows.Forms.Label();
            this.rentRoomBuilding1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.numberRentedRoom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberRentedRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialLabel15);
            this.panel1.Controls.Add(this.debtPieChart);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.numberRentedRoom);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 1019);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel15.Location = new System.Drawing.Point(330, 61);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(466, 41);
            this.materialLabel15.TabIndex = 70;
            this.materialLabel15.Text = "Thống kê thông tin các tòa nhà";
            // 
            // debtPieChart
            // 
            this.debtPieChart.Location = new System.Drawing.Point(55, 458);
            this.debtPieChart.Name = "debtPieChart";
            this.debtPieChart.Size = new System.Drawing.Size(445, 363);
            this.debtPieChart.TabIndex = 66;
            this.debtPieChart.Text = "pieChart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.29839F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.70161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.Controls.Add(this.debtBuilding3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.revenueBuilding3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.rentRoomBuilding3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.debtBuilding2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.revenueBuilding2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.rentRoomBuilding2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.debtBuilding1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.revenueBuilding1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rentRoomBuilding1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(55, 128);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.28302F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.71698F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 308);
            this.tableLayoutPanel1.TabIndex = 65;
            // 
            // debtBuilding3
            // 
            this.debtBuilding3.AutoSize = true;
            this.debtBuilding3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debtBuilding3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtBuilding3.Location = new System.Drawing.Point(790, 226);
            this.debtBuilding3.Name = "debtBuilding3";
            this.debtBuilding3.Size = new System.Drawing.Size(204, 81);
            this.debtBuilding3.TabIndex = 72;
            this.debtBuilding3.Text = "Tòa nhà 3";
            this.debtBuilding3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revenueBuilding3
            // 
            this.revenueBuilding3.AutoSize = true;
            this.revenueBuilding3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.revenueBuilding3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueBuilding3.Location = new System.Drawing.Point(577, 226);
            this.revenueBuilding3.Name = "revenueBuilding3";
            this.revenueBuilding3.Size = new System.Drawing.Size(206, 81);
            this.revenueBuilding3.TabIndex = 71;
            this.revenueBuilding3.Text = "Tòa nhà 3";
            this.revenueBuilding3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentRoomBuilding3
            // 
            this.rentRoomBuilding3.AutoSize = true;
            this.rentRoomBuilding3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentRoomBuilding3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentRoomBuilding3.Location = new System.Drawing.Point(218, 226);
            this.rentRoomBuilding3.Name = "rentRoomBuilding3";
            this.rentRoomBuilding3.Size = new System.Drawing.Size(352, 81);
            this.rentRoomBuilding3.TabIndex = 70;
            this.rentRoomBuilding3.Text = "Tòa nhà 3";
            this.rentRoomBuilding3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // debtBuilding2
            // 
            this.debtBuilding2.AutoSize = true;
            this.debtBuilding2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debtBuilding2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtBuilding2.Location = new System.Drawing.Point(790, 146);
            this.debtBuilding2.Name = "debtBuilding2";
            this.debtBuilding2.Size = new System.Drawing.Size(204, 79);
            this.debtBuilding2.TabIndex = 69;
            this.debtBuilding2.Text = "Tòa nhà 2";
            this.debtBuilding2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revenueBuilding2
            // 
            this.revenueBuilding2.AutoSize = true;
            this.revenueBuilding2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.revenueBuilding2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueBuilding2.Location = new System.Drawing.Point(577, 146);
            this.revenueBuilding2.Name = "revenueBuilding2";
            this.revenueBuilding2.Size = new System.Drawing.Size(206, 79);
            this.revenueBuilding2.TabIndex = 68;
            this.revenueBuilding2.Text = "Tòa nhà 2";
            this.revenueBuilding2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentRoomBuilding2
            // 
            this.rentRoomBuilding2.AutoSize = true;
            this.rentRoomBuilding2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentRoomBuilding2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentRoomBuilding2.Location = new System.Drawing.Point(218, 146);
            this.rentRoomBuilding2.Name = "rentRoomBuilding2";
            this.rentRoomBuilding2.Size = new System.Drawing.Size(352, 79);
            this.rentRoomBuilding2.TabIndex = 67;
            this.rentRoomBuilding2.Text = "Tòa nhà 2";
            this.rentRoomBuilding2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // debtBuilding1
            // 
            this.debtBuilding1.AutoSize = true;
            this.debtBuilding1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debtBuilding1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtBuilding1.Location = new System.Drawing.Point(790, 67);
            this.debtBuilding1.Name = "debtBuilding1";
            this.debtBuilding1.Size = new System.Drawing.Size(204, 78);
            this.debtBuilding1.TabIndex = 66;
            this.debtBuilding1.Text = "Tòa nhà 1";
            this.debtBuilding1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revenueBuilding1
            // 
            this.revenueBuilding1.AutoSize = true;
            this.revenueBuilding1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.revenueBuilding1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueBuilding1.Location = new System.Drawing.Point(577, 67);
            this.revenueBuilding1.Name = "revenueBuilding1";
            this.revenueBuilding1.Size = new System.Drawing.Size(206, 78);
            this.revenueBuilding1.TabIndex = 65;
            this.revenueBuilding1.Text = "Tòa nhà 1";
            this.revenueBuilding1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentRoomBuilding1
            // 
            this.rentRoomBuilding1.AutoSize = true;
            this.rentRoomBuilding1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentRoomBuilding1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentRoomBuilding1.Location = new System.Drawing.Point(218, 67);
            this.rentRoomBuilding1.Name = "rentRoomBuilding1";
            this.rentRoomBuilding1.Size = new System.Drawing.Size(352, 78);
            this.rentRoomBuilding1.TabIndex = 64;
            this.rentRoomBuilding1.Text = "Tòa nhà 1";
            this.rentRoomBuilding1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 81);
            this.label7.TabIndex = 60;
            this.label7.Text = "Tòa nhà 3";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 79);
            this.label6.TabIndex = 60;
            this.label6.Text = "Tòa nhà 2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 78);
            this.label5.TabIndex = 60;
            this.label5.Text = "Tòa nhà 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(790, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 65);
            this.label4.TabIndex = 63;
            this.label4.Text = "Tổng nợ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 65);
            this.label3.TabIndex = 62;
            this.label3.Text = "Doanh thu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 65);
            this.label2.TabIndex = 61;
            this.label2.Text = "Số phòng đã thuê";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 65);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tòa nhà";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(625, 854);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(235, 24);
            this.materialLabel2.TabIndex = 69;
            this.materialLabel2.Text = "Biểu đồ số phòng từng tòa";
            // 
            // numberRentedRoom
            // 
            this.numberRentedRoom.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.numberRentedRoom.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.numberRentedRoom.Legends.Add(legend1);
            this.numberRentedRoom.Location = new System.Drawing.Point(506, 458);
            this.numberRentedRoom.Name = "numberRentedRoom";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng phòng";
            this.numberRentedRoom.Series.Add(series1);
            this.numberRentedRoom.Size = new System.Drawing.Size(616, 363);
            this.numberRentedRoom.TabIndex = 68;
            this.numberRentedRoom.Text = "chart1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(152, 854);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(203, 24);
            this.materialLabel1.TabIndex = 67;
            this.materialLabel1.Text = "Biểu đồ số nợ từng tòa";
            // 
            // BuildingStatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1221, 1102);
            this.Controls.Add(this.panel1);
            this.Name = "BuildingStatisticForm";
            this.Text = "BuildingStatisticForm";
            this.Load += new System.EventHandler(this.BuildingStatisticForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberRentedRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private LiveCharts.WinForms.PieChart debtPieChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label debtBuilding3;
        private System.Windows.Forms.Label revenueBuilding3;
        private System.Windows.Forms.Label rentRoomBuilding3;
        private System.Windows.Forms.Label debtBuilding2;
        private System.Windows.Forms.Label revenueBuilding2;
        private System.Windows.Forms.Label rentRoomBuilding2;
        private System.Windows.Forms.Label debtBuilding1;
        private System.Windows.Forms.Label revenueBuilding1;
        private System.Windows.Forms.Label rentRoomBuilding1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart numberRentedRoom;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}