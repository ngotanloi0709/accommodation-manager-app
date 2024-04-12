using AccommodationManagerApp.Model;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class MainForm
    {
        private void MainForm_Load(object sender, EventArgs e)
        {
            drawCasteriaChart();
            drawPieChart();
            drawRoomInBuildingChart();
            LoadDashboard();
        }
        private void drawCasteriaChart()
        {
            int nowDate = DateTime.Now.Month;
            paidAndUnpaidChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Tháng",
                //Labels = new[] {GetMonth(nowDate - 11).ToString(), GetMonth(nowDate - 10).ToString(), GetMonth(nowDate - 9).ToString(), GetMonth(nowDate - 8).ToString(), GetMonth(nowDate - 7).ToString(),GetMonth(nowDate - 6).ToString(), GetMonth(nowDate - 5).ToString(), GetMonth(nowDate - 4).ToString(), GetMonth(nowDate - 3).ToString(), GetMonth(nowDate - 2).ToString(), GetMonth(nowDate - 1).ToString(),GetMonth(nowDate).ToString()}
                Labels = new[] { "Tháng " + GetMonth(nowDate-11).ToString(), "Tháng " + GetMonth(nowDate -10).ToString(), "Tháng " + GetMonth(nowDate -9).ToString(), "Tháng " + GetMonth(nowDate -8).ToString(), "Tháng " + GetMonth(nowDate -7).ToString(), "Tháng " + GetMonth(nowDate -6).ToString(), "Tháng " + GetMonth(nowDate -5).ToString(), "Tháng " + GetMonth(nowDate -4).ToString(), "Tháng " + GetMonth(nowDate -3).ToString(), "Tháng " + GetMonth(nowDate -2).ToString(), "Tháng " + GetMonth(nowDate -1).ToString(), "Tháng " + GetMonth(nowDate).ToString() }
                //Labels = new[] {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
            });
            paidAndUnpaidChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Số tiền",
                LabelFormatter = value => value.ToString("N0")
            });
            paidAndUnpaidChart.LegendLocation = LiveCharts.LegendLocation.Right;

            paidAndUnpaidChart.Series.Clear();
            paidAndUnpaidChart.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Title = "Chưa trả",
                    Values = new ChartValues <double> {countTotalBillAmounUnpaid(nowDate-11, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -10, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -9, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -8, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -7, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -6, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -5, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -4, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -3, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -2, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -1, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate , DateTime.Now.Year)}
                },
                new LineSeries
                {
                    Title = "Đã trả",
                    Values = new ChartValues <double> {countTotalBillAmounPaid(nowDate-11, DateTime.Now.Year), countTotalBillAmounPaid(nowDate-10, DateTime.Now.Year), countTotalBillAmounPaid(nowDate-9, DateTime.Now.Year), countTotalBillAmounPaid(nowDate -8, DateTime.Now.Year), countTotalBillAmounPaid(nowDate-7, DateTime.Now.Year), countTotalBillAmounPaid(nowDate-6, DateTime.Now.Year), countTotalBillAmounPaid(nowDate -5, DateTime.Now.Year), countTotalBillAmounPaid(nowDate-4, DateTime.Now.Year), countTotalBillAmounPaid(nowDate -3, DateTime.Now.Year), countTotalBillAmounPaid(nowDate -2, DateTime.Now.Year), countTotalBillAmounPaid(nowDate -1, DateTime.Now.Year), countTotalBillAmounPaid(nowDate, DateTime.Now.Year) }
                }
            };
        }
        private int GetMonth(int month)
        {
            if (month <= 0)
            {
                month += 12;
                return GetMonth(month);
            }
            else if (month > 12)
            {
                month -= 12;
                return GetMonth(month);
            }
            else
            {
                return month;
            }
        }

        public Double countTotalBillAmounUnpaid(int month, int year)
        {
            if (month <= 0)
            {
                month += 12;
                year -= 1;
                return countTotalBillAmounUnpaid(month, year);
            }
            else if (month > 12)
            {
                month -= 12;
                year += 1;
                return countTotalBillAmounUnpaid(month, year);
            }
            else
            {
                List<Bill> bills = _billService.GetBillUnpaidByMonthAndYear(month, year);
                Double total = 0;
                foreach (Bill bill in bills)
                {
                    total = total + bill.ElectricityQuantity * electricityPrice + bill.WaterQuantity * waterPrice + bill.InternetFee + bill.RentFee + bill.VehicleFee;
                }
                return total;
            }
        }

        public void drawPieChart()
        {
            int nowDate = DateTime.Now.Month;
            pieChartPaidBillAndUnpaidBill.LegendLocation = LegendLocation.Bottom;
            SeriesCollection series = new SeriesCollection();
            series.Add(new PieSeries
            {
                Title = "Chưa trả",
                Values = new ChartValues<double> { countNumberUnpaidBill(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });
            series.Add(new PieSeries
            {
                Title = "Đã trả",
                Values = new ChartValues<double> { countNumberPaidBill(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });
            series.Add(new PieSeries
            {
                Title = "Đang cập nhật",
                Values = new ChartValues<double> { countNumberBillIsUpdated(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });

            pieChartPaidBillAndUnpaidBill.Series = series;
        }

        public void drawRoomInBuildingChart()
        {
            List<Building> buildings = _buildingService.GetAll();
            RoomInBuildingChart.Series["Số lượng phòng"].Points.Clear();
            for (int i = 0; i < buildings.Count; i++)
            {

                List<Room> rooms = _roomService.GetAllWithBuildingId(buildings[i].Id);
                RoomInBuildingChart.Series["Số lượng phòng"].Points.AddXY("Tòa " + (i + 1), rooms.Count);
            }
            //RoomInBuildingChart.Series["Number of room"].
        }


        public Double countTotalBillAmounPaid(int month, int year)
        {
            if (month <= 0)
            {
                month += 12;
                year -= 1;
                return countTotalBillAmounPaid(month, year);
            }
            else if (month > 12)
            {
                month -= 12;
                year += 1;
                return countTotalBillAmounPaid(month, year);
            }
            else
            {
                List<Bill> bills = _billService.GetBillPaidByMonthAndYear(month, year);
                Double total = 0;
                foreach (Bill bill in bills)
                {
                    total = total + bill.ElectricityQuantity * electricityPrice + bill.WaterQuantity * waterPrice + bill.InternetFee + bill.RentFee + bill.VehicleFee;
                }
                return total;
            }
        }

        private Double countNumberUnpaidBill(int month, int year)
        {
            List<Bill> bills = _billService.GetBillUnpaidByMonthAndYear(month, year);
            return bills.Count;
        }

        private Double countNumberPaidBill(int month, int year)
        {
            List<Bill> bills = _billService.GetBillPaidByMonthAndYear(month, year);
            return bills.Count;
        }

        private Double countNumberBillIsUpdated(int month, int year)
        {
            List<Bill> bills = _billService.GetBillIsUpdatedByMonthAndYear(month, year);
            return bills.Count;
        }


        private void btnReloadChart_Click(object sender, EventArgs e)
        {
            ReloadChart();
            ReloadPieChart();
            drawRoomInBuildingChart();
        }

        private void ReloadChart()
        {
            int nowDate = DateTime.Now.Month;
            paidAndUnpaidChart.Series.Clear();
            paidAndUnpaidChart.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Title = "Chưa trả",
                    Values = new ChartValues <double> {countTotalBillAmounUnpaid(nowDate-11, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -10, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -9, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -8, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -7, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -6, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -5, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -4, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -3, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -2, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate -1, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate , DateTime.Now.Year)}
                },
                new LineSeries
                {
                    Title = "Đã trả",
                    Values = new ChartValues <double> {countTotalBillAmounPaid(nowDate-11, DateTime.Now.Year), countTotalBillAmounPaid(nowDate-10, DateTime.Now.Year), countTotalBillAmounPaid(nowDate-9, DateTime.Now.Year), countTotalBillAmounPaid(nowDate -8, DateTime.Now.Year), countTotalBillAmounPaid(nowDate-7, DateTime.Now.Year), countTotalBillAmounPaid(nowDate-6, DateTime.Now.Year), countTotalBillAmounPaid(nowDate -5, DateTime.Now.Year), countTotalBillAmounPaid(nowDate-4, DateTime.Now.Year), countTotalBillAmounPaid(nowDate -3, DateTime.Now.Year), countTotalBillAmounPaid(nowDate -2, DateTime.Now.Year), countTotalBillAmounPaid(nowDate -1, DateTime.Now.Year), countTotalBillAmounPaid(nowDate, DateTime.Now.Year) }
                }
            };
        }

        private void ReloadPieChart()
        {
            int nowDate = DateTime.Now.Month;
            pieChartPaidBillAndUnpaidBill.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            series.Add(new PieSeries
            {
                Title = "Chưa trả",
                Values = new ChartValues<double> { countNumberUnpaidBill(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });
            series.Add(new PieSeries
            {
                Title = "Đã trả",
                Values = new ChartValues<double> { countNumberPaidBill(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });
            series.Add(new PieSeries
            {
                Title = "Đang cập nhật",
                Values = new ChartValues<double> { countNumberBillIsUpdated(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });

            pieChartPaidBillAndUnpaidBill.Series = series;
        }
        private void LoadDashboard()
        {
            List<Room> _rooms = _roomService.GetAll();
            List<Building> _buildings = _buildingService.GetAll();
            List<Bill> _bills = _billService.GetAll();
            List<Vehicle> _vehicles = _vehicleService.GetAll();
            List<User> _users = _userService.GetAll();
            List<Contract> contracts = _contractService.GetAllWithUserAndRoom();
            List<Request> requests = _requestService.GetAll();
            lblNumberRoom.Text = _rooms.Count.ToString() + " phòng trọ";
            lblNumberBuilding.Text = _buildings.Count.ToString() + " tòa nhà";
            lblNumberVehicle.Text = _vehicles.Count.ToString()+ " phương tiện";
            lblNumberTennant.Text = _users.Count.ToString() + " người thuê";
            lblNumberContract.Text = contracts.Count.ToString() + " hợp đồng";
            lblNumberRequest.Text = requests.Count.ToString() + " yêu cầu";
        }

    }
}
