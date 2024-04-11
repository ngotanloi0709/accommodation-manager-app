﻿using AccommodationManagerApp.Model;
using Google.Protobuf.WellKnownTypes;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm
    {
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

        private void ClientFormOnLoad(object sender, System.EventArgs e)
        {
            DrawCasterianChart();
            drawRequestChart();
            DrawPieChart();
        }
        private void DrawCasterianChart()
        {
            int nowDate = DateTime.Now.Month;
            electricityAndWaterChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Tháng",
                Labels = new[] { "Tháng " + GetMonth(nowDate-11).ToString(), "Tháng " + GetMonth(nowDate -10).ToString(), "Tháng " + GetMonth(nowDate -9).ToString(), "Tháng " + GetMonth(nowDate -8).ToString(), "Tháng " + GetMonth(nowDate -7).ToString(), "Tháng " + GetMonth(nowDate -6).ToString(), "Tháng " + GetMonth(nowDate -5).ToString(), "Tháng " + GetMonth(nowDate -4).ToString(), "Tháng " + GetMonth(nowDate -3).ToString(), "Tháng " + GetMonth(nowDate -2).ToString(), "Tháng " + GetMonth(nowDate -1).ToString(), "Tháng " + GetMonth(nowDate).ToString() }
            }   
            );
            electricityAndWaterChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Số lượng",
                LabelFormatter = value => value.ToString(),
            });
            electricityAndWaterChart.LegendLocation = LiveCharts.LegendLocation.Right;
            electricityAndWaterChart.Series.Clear();
            electricityAndWaterChart.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Title = "Số điện",
                    Values = new ChartValues<int> { CountElectric((nowDate - 11), DateTime.Now.Year), CountElectric((nowDate - 10), DateTime.Now.Year), CountElectric((nowDate - 9), DateTime.Now.Year), CountElectric((nowDate - 8), DateTime.Now.Year), CountElectric((nowDate - 7), DateTime.Now.Year), CountElectric((nowDate - 6), DateTime.Now.Year), CountElectric((nowDate - 5), DateTime.Now.Year), CountElectric((nowDate - 4), DateTime.Now.Year), CountElectric((nowDate - 3), DateTime.Now.Year), CountElectric((nowDate - 2), DateTime.Now.Year), CountElectric((nowDate - 1), DateTime.Now.Year), CountElectric((nowDate), DateTime.Now.Year) },
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 15,
                    LineSmoothness = 0
                },
                new LineSeries
                {
                    Title = "Số nước",
                    Values = new ChartValues<int> { CountWater((nowDate - 11), DateTime.Now.Year), CountWater((nowDate - 10), DateTime.Now.Year), CountWater((nowDate - 9), DateTime.Now.Year), CountWater((nowDate - 8), DateTime.Now.Year), CountWater((nowDate - 7), DateTime.Now.Year), CountWater((nowDate - 6), DateTime.Now.Year), CountWater((nowDate - 5), DateTime.Now.Year), CountWater((nowDate - 4), DateTime.Now.Year), CountWater((nowDate - 3), DateTime.Now.Year), CountWater((nowDate - 2), DateTime.Now.Year), CountWater((nowDate - 1), DateTime.Now.Year), CountWater((nowDate), DateTime.Now.Year) },
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 15,
                    LineSmoothness = 0
                }
            };

        }

        private void drawRequestChart()
        {
            requestChart.Series["NumberRequest"].Points.Clear();
            int nowDate = DateTime.Now.Month;
            for (int i = (nowDate -2); i <= (nowDate); i++)
            {
                List<Request> requests = _requestService.GetAllByUserId(_user.Id);
                List<Request> requestMonth = requests.Where(request => request.CreatedAt.Month == i).ToList();
                requestChart.Series["NumberRequest"].Points.AddXY("Tháng " + i, requestMonth.Count);
            }
        }

        private void DrawPieChart()
        {
            paidAndUnpaidChart.LegendLocation = LegendLocation.Bottom;
            List<Bill> _bills = _billService.GetAllBillByUserIdIncludeEdit(_user.Id);
            Console.WriteLine(_bills.Count);
            List<Bill> _billUnpaid = _bills.Where(bill =>  bill.Status == BillStatus.Unpaid).ToList();
            List<Bill> _billPaid = _bills.Where(bill => bill.Status == BillStatus.Paid).ToList();
            List<Bill> _billUpdate = _bills.Where(bill => bill.Status == BillStatus.Edit).ToList();
            SeriesCollection series = new SeriesCollection();
            series.Add(new PieSeries
            {
                Title = "Đã thanh toán",
                Values = new ChartValues<int> { _billPaid.Count }
            });
            series.Add(new PieSeries
            {
                Title = "Chưa thanh toán",
                Values = new ChartValues<int> { _billUnpaid.Count }
            });
            series.Add(new PieSeries
            {
                Title = "Đang cập nhật",
                Values = new ChartValues<int> { _billUpdate.Count }
            });
            paidAndUnpaidChart.Series = series;
        }

        private int CountElectric(int month, int year)
        {
            List<Bill> _bill = _billService.GetAllByUserId(_user.Id);
            if(month <= 0)
            {
                month += 12;
                year -= 1;

                return CountElectric(month, year);
            }
            else if (month > 12)
            {
                month -= 12;
                year += 1;
                return CountElectric(month, year);
            }
            else
            {
                Bill result = _bill.Where(bill => bill.DateOfBill.Month == month && bill.DateOfBill.Year == year).FirstOrDefault();
                if(result == null)
                {
                    return 0;
                }
                return result.ElectricityQuantity;
            }
        }

        private int CountWater(int month, int year)
        {
            List<Bill> _bill = _billService.GetAllByUserId(_user.Id);
            if (month <= 0)
            {
                month += 12;
                year -= 1;
                Console.WriteLine("month: " + year);
                return CountWater(month, year);
            }
            else if (month > 12)
            {
                month -= 12;
                year += 1;
                return CountWater(month, year);
            }
            else
            {
                Bill result = _bill.Where(bill => bill.DateOfBill.Month == month && bill.DateOfBill.Year == year).FirstOrDefault();
                if (result == null)
                {
                    return 0;
                }
                return result.WaterQuantity;
            }
        }


    }
}
