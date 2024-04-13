using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class BuildingStatisticForm : BaseForm
    {
        private readonly BuildingService _buildingService;
        private readonly RoomService _roomService;
        private readonly ContractService _contractService;
        private readonly BillService _billService;
        private double revenue1;
        private double debt1;
        private double revenue2;
        private double debt2;
        private double revenue3;
        private double debt3;
        private int rentedRoom1;
        private int rentedRoom2;
        private int rentedRoom3;
        public BuildingStatisticForm()
        {
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;
            InitializeComponent();
            
        }

        private void BuildingStatisticForm_Load(object sender, EventArgs e)
        {
            List<Building> buildings = _buildingService.GetAll();
            foreach(Building building in buildings)
            {
                if(building.Id == 1)
                {
                    List<Room> rooms = _roomService.GetAllWithBuildingIdAndNotTerminatedContract(building.Id);
                    int totalRoom = rooms.Count;
                    rentRoomBuilding1.Text = totalRoom.ToString();
                    rentedRoom1 = totalRoom;
                    double revenue = 0;
                    double debt = 0;
                    foreach(Room room in rooms)
                    {
                        List<Contract> contracts = _contractService.GetByRoomIdAndNonExpired(room.Id);
                        if (contracts.Count > 0) { 
                            foreach(Contract contract in contracts)
                            {
                                List<Bill> bills = _billService.GetAllByContractId(contract.Id);
                                List<Bill> UnpaidBill = bills.Where(b => b.Status == BillStatus.Unpaid).ToList();
                                List<Bill> PaidBill = bills.Where(b => b.Status == BillStatus.Paid).ToList();
                                foreach(Bill bill in UnpaidBill)
                                {
                                    debt += bill.ElectricityQuantity * bill.ElectricityFee + bill.WaterQuantity * bill.WaterFee + bill.InternetFee + bill.RentFee + bill.VehicleFee;
                                }
                                foreach(Bill bill in PaidBill)
                                {
                                    revenue += bill.ElectricityQuantity * bill.ElectricityFee + bill.WaterQuantity * bill.WaterFee + bill.InternetFee + bill.RentFee + bill.VehicleFee;
                                }
                            }
                        }
                    }
                    revenue1 = revenue;
                    debt1 = debt;
                    revenueBuilding1.Text = revenue.ToString("N0");
                    debtBuilding1.Text = debt.ToString("N0");

                }
                else if(building.Id == 2)
                {
                    List<Room> rooms = _roomService.GetAllWithBuildingIdAndNotTerminatedContract(building.Id);
                    int totalRoom = rooms.Count;
                    rentRoomBuilding2.Text = totalRoom.ToString();
                    rentedRoom2 = totalRoom;
                    double revenue = 0;
                    double debt = 0;
                    foreach (Room room in rooms)
                    {
                        List<Contract> contracts = _contractService.GetByRoomIdAndNonExpired(room.Id);
                        if (contracts.Count > 0)
                        {
                            foreach (Contract contract in contracts)
                            {
                                List<Bill> bills = _billService.GetAllByContractId(contract.Id);
                                List<Bill> UnpaidBill = bills.Where(b => b.Status == BillStatus.Unpaid).ToList();
                                List<Bill> PaidBill = bills.Where(b => b.Status == BillStatus.Paid).ToList();
                                foreach (Bill bill in UnpaidBill)
                                {
                                    debt += bill.ElectricityQuantity * bill.ElectricityFee + bill.WaterQuantity * bill.WaterFee + bill.InternetFee + bill.RentFee + bill.VehicleFee;
                                }
                                foreach (Bill bill in PaidBill)
                                {
                                    revenue += bill.ElectricityQuantity * bill.ElectricityFee + bill.WaterQuantity * bill.WaterFee + bill.InternetFee + bill.RentFee + bill.VehicleFee;
                                }
                            }
                        }
                    }
                    revenue2 = revenue;
                    debt2 = debt;
                    revenueBuilding2.Text = revenue.ToString("N0");
                    debtBuilding2.Text = debt.ToString("N0");
                }
                else if(building.Id == 3)
                {
                    List<Room> rooms = _roomService.GetAllWithBuildingIdAndNotTerminatedContract(building.Id);
                    int totalRoom = rooms.Count;
                    rentRoomBuilding3.Text = totalRoom.ToString();
                    rentedRoom3 = totalRoom;
                    double revenue = 0;
                    double debt = 0;
                    foreach (Room room in rooms)
                    {
                        List<Contract> contracts = _contractService.GetByRoomIdAndNonExpired(room.Id);
                        if (contracts.Count > 0)
                        {
                            foreach (Contract contract in contracts)
                            {
                                List<Bill> bills = _billService.GetAllByContractId(contract.Id);
                                List<Bill> UnpaidBill = bills.Where(b => b.Status == BillStatus.Unpaid).ToList();
                                List<Bill> PaidBill = bills.Where(b => b.Status == BillStatus.Paid).ToList();
                                foreach (Bill bill in UnpaidBill)
                                {
                                    debt += bill.ElectricityQuantity * bill.ElectricityFee + bill.WaterQuantity * bill.WaterFee + bill.InternetFee + bill.RentFee + bill.VehicleFee;
                                }
                                foreach (Bill bill in PaidBill)
                                {
                                    revenue += bill.ElectricityQuantity * bill.ElectricityFee + bill.WaterQuantity * bill.WaterFee + bill.InternetFee + bill.RentFee + bill.VehicleFee;
                                }
                            }
                        }
                    }
                    revenue3 = revenue;
                    debt3 = debt;
                    revenueBuilding3.Text = revenue.ToString("N0");
                    debtBuilding3.Text = debt.ToString("N0");
                    DrawPieChart();
                    DrawRentedRoomChart();
                }
            }
        }

        private void DrawPieChart()
        {
            debtPieChart.LegendLocation = LegendLocation.Right;
            debtPieChart.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            series.Add(
                    new PieSeries
                    {
                        Title = "Nợ tòa 1",
                        Values = new ChartValues<double> { debt1 },
                        DataLabels = true
                    }
                );
            series.Add(
                     new PieSeries
                     {
                        Title = "Nợ tòa 2",
                        Values = new ChartValues<double> { debt2 },
                        DataLabels = true
                     }
            );
            series.Add(
                                    new PieSeries
                                    {
                         Title = "Nợ tòa 3",
                         Values = new ChartValues<double> { debt3 },
                         DataLabels = true
                     }
                                               );
            debtPieChart.Series = series;
            

        }

        private void DrawRentedRoomChart()
        {
            numberRentedRoom.Series["Số lượng phòng"].Points.Clear();
            int nowDate = DateTime.Now.Month;
            numberRentedRoom.Series["Số lượng phòng"].Points.AddXY("Tòa 1", rentedRoom1);
            numberRentedRoom.Series["Số lượng phòng"].Points.AddXY("Tòa 2", rentedRoom2);
            numberRentedRoom.Series["Số lượng phòng"].Points.AddXY("Tòa 3", rentedRoom3);
        }
    }
}
