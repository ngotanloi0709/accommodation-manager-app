using AccommodationManagerApp.Model;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;

namespace AccommodationManagerApp.Forms
{
    public partial class MainForm
    {
        private void MainForm_Load(object sender, EventArgs e)
        {
            DrawCasteriaChart();
            DrawPieChart();
            DrawRoomInBuildingChart();
            LoadDashboardLabelData();
        }
        private void DrawCasteriaChart()
        {
            int nowDate = DateTime.Now.Month;
            paidAndUnpaidChart.AxisX.Add(new Axis
            {
                Title = "Tháng",
                Labels = new[] { "Tháng " + GetMonth(nowDate-11), "Tháng " + GetMonth(nowDate -10), "Tháng " + GetMonth(nowDate -9).ToString(), "Tháng " + GetMonth(nowDate -8).ToString(), "Tháng " + GetMonth(nowDate -7).ToString(), "Tháng " + GetMonth(nowDate -6).ToString(), "Tháng " + GetMonth(nowDate -5).ToString(), "Tháng " + GetMonth(nowDate -4).ToString(), "Tháng " + GetMonth(nowDate -3).ToString(), "Tháng " + GetMonth(nowDate -2), "Tháng " + GetMonth(nowDate -1), "Tháng " + GetMonth(nowDate) }
            });
            paidAndUnpaidChart.AxisY.Add(new Axis
            {
                Title = "Số tiền",
                LabelFormatter = value => value.ToString("N0")
            });
            paidAndUnpaidChart.LegendLocation = LegendLocation.Right;

            paidAndUnpaidChart.Series.Clear();
            paidAndUnpaidChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Chưa trả",
                    Values = new ChartValues <int> {CountTotalBillAmounUnpaid(nowDate-11, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -10, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -9, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -8, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -7, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -6, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -5, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -4, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -3, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -2, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -1, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate , DateTime.Now.Year)}
                },
                new LineSeries
                {
                    Title = "Đã trả",
                    Values = new ChartValues <int> {CountTotalBillAmounPaid(nowDate-11, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate-10, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate-9, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate -8, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate-7, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate-6, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate -5, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate-4, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate -3, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate -2, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate -1, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate, DateTime.Now.Year) }
                }
            };
        }
        private int GetMonth(int month) {
            if (month <= 0)
            {
                month += 12;
                return GetMonth(month);
            }

            if (month > 12)
            {
                month -= 12;
                return GetMonth(month);
            }

            return month;
        }

        private int CountTotalBillAmounUnpaid(int month, int year) {
            if (month <= 0)
            {
                month += 12;
                year -= 1;
                return CountTotalBillAmounUnpaid(month, year);
            }

            if (month > 12)
            {
                month -= 12;
                year += 1;
                return CountTotalBillAmounUnpaid(month, year);
            }

            List<Bill> bills = _billService.GetBillUnpaidByMonthAndYear(month, year);
            int total = 0;
            foreach (Bill bill in bills)
            {
                total = total + bill.ElectricityQuantity * _electricityPrice + bill.WaterQuantity * _waterPrice + bill.InternetFee + bill.RentFee + bill.VehicleFee;
            }
            return total;
        }

        public void DrawPieChart()
        {
            int nowDate = DateTime.Now.Month;
            pieChartPaidBillAndUnpaidBill.LegendLocation = LegendLocation.Bottom;
            SeriesCollection series = new SeriesCollection();
            series.Add(new PieSeries
            {
                Title = "Chưa trả",
                Values = new ChartValues<int> { CountNumberUnpaidBill(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });
            series.Add(new PieSeries
            {
                Title = "Đã trả",
                Values = new ChartValues<int> { CountNumberPaidBill(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });
            series.Add(new PieSeries
            {
                Title = "Đang cập nhật",
                Values = new ChartValues<int> { CountNumberBillIsUpdated(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });

            pieChartPaidBillAndUnpaidBill.Series = series;
        }

        public void DrawRoomInBuildingChart()
        {
            var buildings = _buildingService.GetAll();
            RoomInBuildingChart.Series["Số lượng phòng"].Points.Clear();
            for (var i = 0; i < buildings.Count; i++)
            {
                var rooms = _roomService.GetAllWithBuildingId(buildings[i].Id);
                RoomInBuildingChart.Series["Số lượng phòng"].Points.AddXY(buildings[i].Name, rooms.Count);
            }
        }


        public int CountTotalBillAmounPaid(int month, int year)
        {
            if (month <= 0)
            {
                month += 12;
                year -= 1;
                return CountTotalBillAmounPaid(month, year);
            }
            else if (month > 12)
            {
                month -= 12;
                year += 1;
                return CountTotalBillAmounPaid(month, year);
            }
            else
            {
                List<Bill> bills = _billService.GetBillPaidByMonthAndYear(month, year);
                int total = 0;
                foreach (Bill bill in bills)
                {
                    total = total + bill.ElectricityQuantity * _electricityPrice + bill.WaterQuantity * _waterPrice + bill.InternetFee + bill.RentFee + bill.VehicleFee;
                }
                return total;
            }
        }

        private int CountNumberUnpaidBill(int month, int year)
        {
            List<Bill> bills = _billService.GetBillUnpaidByMonthAndYear(month, year);
            return bills.Count;
        }

        private int CountNumberPaidBill(int month, int year)
        {
            List<Bill> bills = _billService.GetBillPaidByMonthAndYear(month, year);
            return bills.Count;
        }

        private int CountNumberBillIsUpdated(int month, int year)
        {
            List<Bill> bills = _billService.GetBillIsUpdatedByMonthAndYear(month, year);
            return bills.Count;
        }


        private void btnReloadChart_Click(object sender, EventArgs e)
        {
            ReloadChart();
            ReloadPieChart();
            DrawRoomInBuildingChart();
        }

        private void ReloadChart()
        {
            var nowDate = DateTime.Now.Month;
            paidAndUnpaidChart.Series.Clear();
            paidAndUnpaidChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Chưa trả",
                    Values = new ChartValues <int> {CountTotalBillAmounUnpaid(nowDate-11, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -10, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -9, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -8, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -7, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -6, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -5, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -4, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -3, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -2, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate -1, DateTime.Now.Year), CountTotalBillAmounUnpaid(nowDate , DateTime.Now.Year)}
                },
                new LineSeries
                {
                    Title = "Đã trả",
                    Values = new ChartValues <int> {CountTotalBillAmounPaid(nowDate-11, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate-10, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate-9, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate -8, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate-7, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate-6, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate -5, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate-4, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate -3, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate -2, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate -1, DateTime.Now.Year), CountTotalBillAmounPaid(nowDate, DateTime.Now.Year) }
                }
            };
        }

        private void ReloadPieChart()
        {
            var nowDate = DateTime.Now.Month;
            pieChartPaidBillAndUnpaidBill.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            series.Add(new PieSeries
            {
                Title = "Chưa trả",
                Values = new ChartValues<int> { CountNumberUnpaidBill(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });
            series.Add(new PieSeries
            {
                Title = "Đã trả",
                Values = new ChartValues<int> { CountNumberPaidBill(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });
            series.Add(new PieSeries
            {
                Title = "Đang cập nhật",
                Values = new ChartValues<int> { CountNumberBillIsUpdated(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });

            pieChartPaidBillAndUnpaidBill.Series = series;
        }
        private void LoadDashboardLabelData()
        {
            var rooms = _roomService.GetAll();
            var buildings = _buildingService.GetAll();
            var vehicles = _vehicleService.GetAll();
            var users = _userService.GetAllWithRoleTenant();
            var contracts = _contractService.GetAllWithUserAndRoom();
            var requests = _requestService.GetAll();
            lblNumberRoom.Text = rooms.Count + " phòng trọ";
            lblNumberBuilding.Text = buildings.Count + " tòa nhà";
            lblNumberVehicle.Text = vehicles.Count+ " phương tiện";
            lblNumberTennant.Text = users.Count + " người thuê";
            lblNumberContract.Text = contracts.Count + " hợp đồng";
            lblNumberRequest.Text = requests.Count + " yêu cầu";
        }
    }
}
