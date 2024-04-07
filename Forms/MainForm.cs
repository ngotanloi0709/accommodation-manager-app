using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using AccommodationManagerApp.Service;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class MainForm : BaseForm
    {
        private readonly RoomService _roomService;
        private readonly BuildingService _buildingService;
        private readonly BillService _billService;
        private readonly AuthenticationService _authenticationService;
        private readonly VehicleService _vehicleService;
        private readonly UserService _userService;
        private readonly ContractService _contractService;
        private readonly RequestService _requestService;
        private List<Bill> Bills { get; set; }
        private List<Building> Buildings { get; set; }
        private List<Room> Rooms { get; set; }
        private List<Vehicle> Vehicles { get; set; }
        private List<User> Users { get; set; }
        private List<Contract> Contracts { get; set; }
        private List<Request> _Requests;

        private int waterPrice = 0;
        private int electricityPrice = 0;
        private int internetPrice = 0;

        public MainForm()
        {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _vehicleService = ServiceLocator.ServiceProvider.GetService(typeof(VehicleService)) as VehicleService;
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;
            _requestService = ServiceLocator.ServiceProvider.GetService(typeof(RequestService)) as RequestService;

            InitializeComponent();
            LoadData();
            SetListViewGridEnable();
        }

        private void LoadData()
        {
            LoadPersonalInformation();
            LoadRoomData();
            LoadBuildingData();
            LoadBillData();
            LoadVehicleData();
            LoadUserData();
            LoadContractData();
            LoadFixedPriceData();
            LoadRequestData();
        }
        private void SetListViewGridEnable()
        {
            ListViewBuilding.GridLines = true;
            ListViewRoom.GridLines = true;
            ListViewVehicle.GridLines = true;
            ListViewUser.GridLines = true;
            ListViewUserRentList.GridLines = true;
            ListViewBill.GridLines = true;
            ListViewContract.GridLines = true;
            ListViewRoomUserList.GridLines = true;
        }
        private void buttonCurrentUserInformationManagement_Click(object sender, EventArgs e)
        {
            if (_authenticationService.IsAuthenticated())
            {
                var userManagementForm =
                    new CurrentUserInformationForm(_authenticationService.CurrentUser);
                userManagementForm.ShowDialog();
                LoadPersonalInformation();
            }
            else
            {
                new ToastForm("Vui lòng đăng nhập để sử dụng chức năng này", true).Show();
            }
        }
        private void LoadPersonalInformation()
        {
            labelCurrentUserEmail.Text = _authenticationService.IsAuthenticated() ? _authenticationService.CurrentUser.Email : defaultMail;
        }
        private void Logout(object sender, EventArgs e)
        {
            var confirmation = new ConfirmationForm("Bạn có chắc chắn muốn thoát");
            var result = confirmation.ShowDialog();
            if (result == DialogResult.Yes)
            {
                _authenticationService.Logout();
                Close();
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            drawCasteriaChart();
            drawPieChart();
            drawRoomInBuildingChart();

        }
        private void drawCasteriaChart()
        {
            int nowDate = DateTime.Now.Month;
            paidAndUnpaidChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                //Labels = new[] {GetMonth(nowDate - 11).ToString(), GetMonth(nowDate - 10).ToString(), GetMonth(nowDate - 9).ToString(), GetMonth(nowDate - 8).ToString(), GetMonth(nowDate - 7).ToString(),GetMonth(nowDate - 6).ToString(), GetMonth(nowDate - 5).ToString(), GetMonth(nowDate - 4).ToString(), GetMonth(nowDate - 3).ToString(), GetMonth(nowDate - 2).ToString(), GetMonth(nowDate - 1).ToString(),GetMonth(nowDate).ToString()}
                Labels = new[] { "Tháng " + GetMonth(nowDate).ToString(), "Tháng " + GetMonth(nowDate + 1).ToString(), "Tháng " + GetMonth(nowDate + 2).ToString(), "Tháng " + GetMonth(nowDate + 3).ToString(), "Tháng " + GetMonth(nowDate + 4).ToString(), "Tháng " + GetMonth(nowDate + 5).ToString(), "Tháng " + GetMonth(nowDate + 6).ToString(), "Tháng " + GetMonth(nowDate + 7).ToString(), "Tháng " + GetMonth(nowDate + 8).ToString(), "Tháng " + GetMonth(nowDate + 9).ToString(), "Tháng " + GetMonth(nowDate + 10).ToString(), "Tháng " + GetMonth(nowDate + 11).ToString() }
                //Labels = new[] {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
            });
            paidAndUnpaidChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Amount",
                LabelFormatter = value => value.ToString("N0")
            });
            paidAndUnpaidChart.LegendLocation = LiveCharts.LegendLocation.Right;

            paidAndUnpaidChart.Series.Clear();
            paidAndUnpaidChart.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Title = "Unpaid",
                    Values = new ChartValues <double> {countTotalBillAmounUnpaid(nowDate, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 1, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 2, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 3, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 4, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 5, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 6, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 7, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 8, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 9, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 12, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 11, DateTime.Now.Year)}
                },
                new LineSeries
                {
                    Title = "Paid",
                    Values = new ChartValues <double> {countTotalBillAmounPaid(nowDate, DateTime.Now.Year), countTotalBillAmounPaid(nowDate+1, DateTime.Now.Year), countTotalBillAmounPaid(nowDate+2, DateTime.Now.Year), countTotalBillAmounPaid(nowDate +3, DateTime.Now.Year), countTotalBillAmounPaid(nowDate+4, DateTime.Now.Year), countTotalBillAmounPaid(nowDate+5, DateTime.Now.Year), countTotalBillAmounPaid(nowDate +6, DateTime.Now.Year), countTotalBillAmounPaid(nowDate+7, DateTime.Now.Year), countTotalBillAmounPaid(nowDate + 8, DateTime.Now.Year), countTotalBillAmounPaid(nowDate + 9, DateTime.Now.Year), countTotalBillAmounPaid(nowDate + 10, DateTime.Now.Year), countTotalBillAmounPaid(nowDate + 11, DateTime.Now.Year) }
                }
            };
        }
        private int GetMonth(int month)
        {
            if(month <= 0)
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
            if(month <= 0)
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
                Title = "Unpaid",
                Values = new ChartValues<double> { countNumberUnpaidBill(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });
            series.Add(new PieSeries
            {
                Title = "Paid",
                Values = new ChartValues<double> { countNumberPaidBill(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });
            series.Add(new PieSeries
            {
                Title = "Updated",
                Values = new ChartValues<double> { countNumberBillIsUpdated(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });

            pieChartPaidBillAndUnpaidBill.Series = series;
        }

        public void drawRoomInBuildingChart()
        {
            List<Building> buildings = _buildingService.GetAll();
            RoomInBuildingChart.Series["Number of room"].Points.Clear();
            foreach (Building building in buildings)
            {
                List<Room> rooms = _roomService.GetAllWithBuildingId(building.Id);
                RoomInBuildingChart.Series["Number of room"].Points.AddXY(building.Name, rooms.Count);
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
                    Title = "Unpaid",
                    Values = new ChartValues <double> {countTotalBillAmounUnpaid(nowDate, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 1, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 2, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 3, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 4, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 5, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 6, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 7, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 8, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 9, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 12, DateTime.Now.Year), countTotalBillAmounUnpaid(nowDate + 11, DateTime.Now.Year)}
                },
                new LineSeries
                {
                    Title = "Paid",
                    Values = new ChartValues <double> {countTotalBillAmounPaid(nowDate, DateTime.Now.Year), countTotalBillAmounPaid(nowDate+1, DateTime.Now.Year), countTotalBillAmounPaid(nowDate+2, DateTime.Now.Year), countTotalBillAmounPaid(nowDate +3, DateTime.Now.Year), countTotalBillAmounPaid(nowDate+4, DateTime.Now.Year), countTotalBillAmounPaid(nowDate+5, DateTime.Now.Year), countTotalBillAmounPaid(nowDate +6, DateTime.Now.Year), countTotalBillAmounPaid(nowDate+7, DateTime.Now.Year), countTotalBillAmounPaid(nowDate + 8, DateTime.Now.Year), countTotalBillAmounPaid(nowDate + 9, DateTime.Now.Year), countTotalBillAmounPaid(nowDate + 10, DateTime.Now.Year), countTotalBillAmounPaid(nowDate + 11, DateTime.Now.Year) }
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
                Title = "Unpaid",
                Values = new ChartValues<double> { countNumberUnpaidBill(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });
            series.Add(new PieSeries
            {
                Title = "Paid",
                Values = new ChartValues<double> { countNumberPaidBill(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });
            series.Add(new PieSeries
            {
                Title = "Updated",
                Values = new ChartValues<double> { countNumberBillIsUpdated(nowDate, DateTime.Now.Year) },
                DataLabels = true
            });

            pieChartPaidBillAndUnpaidBill.Series = series;
        }
    }
}