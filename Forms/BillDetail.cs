using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
using Aspose.Words;
using PdfSharp.Drawing;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class BillDetail : BaseForm
    {
        private readonly BillService _billService;
        private Bill _bill;
        public BillDetail(Bill bill)
        {
            InitializeComponent();

            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _bill = bill;

            LoadBillDetail();
        }

        private void LoadBillDetail()
        {
            var waterQuantity = _bill.WaterQuantity;
            var electricityQuantity = _bill.ElectricityQuantity;
            var waterPrice = _bill.WaterFee == 0 ? _billService.GetWaterPrice().Price : _bill.WaterFee;
            var electricityPrice = _bill.ElectricityFee == 0 ? _billService.GetElectricityPrice().Price : _bill.ElectricityFee;
            var internetPrice = _bill.InternetFee;
            var vehiclePrice = _bill.VehicleFee;
            var rentPrice = _bill.RentFee;

            LabelRoomId.Text = _bill.Contract.Room.RoomNumber;
            LabelDate.Text = _bill.DateOfBillFormatted;
            LabelRent.Text = FormatText.IntegerToVnd(rentPrice);
            LabelWaterQuantity.Text = waterQuantity.ToString();
            LabelElectricityQuantity.Text = electricityQuantity.ToString();
            LabelWaterPrice.Text = FormatText.IntegerToVnd(waterPrice);
            LabelElectricityPrice.Text = FormatText.IntegerToVnd(electricityPrice);
            LabelInternetPrice.Text = FormatText.IntegerToVnd(internetPrice);
            LabelWaterTotalPrice.Text = FormatText.IntegerToVnd((waterQuantity * waterPrice));
            LabelElectricityTotalPrice.Text = FormatText.IntegerToVnd((electricityQuantity * electricityPrice));
            LabelVehicleTotalPrice.Text = FormatText.IntegerToVnd(vehiclePrice);
            LabelTotalPrice.Text = FormatText.IntegerToVnd(((waterQuantity * waterPrice) + (electricityQuantity * electricityPrice) + internetPrice + rentPrice + vehiclePrice));
        }
        private void ButtonExportPDF_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại lưu file
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Lưu dưới dạng PDF";
            saveFileDialog.FileName = "BillDetail.pdf";

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            var filePath = saveFileDialog.FileName;

            try
            {
                var pdf = new PdfSharp.Pdf.PdfDocument();
                pdf.Info.Title = "Chi tiết hoá đơn";


                var pdfPage = pdf.AddPage();
                pdfPage.Width = PanelHD.Width + 5;
                pdfPage.Height = PanelHD.Height + 5;
                var graph = XGraphics.FromPdfPage(pdfPage);

                // Lấy nội dung của PanelHD và đưa nó vào tài liệu PDF
                using (var ms = new MemoryStream())
                {
                    // Lấy nội dung của PanelHD
                    var bmp = new Bitmap(PanelHD.Width, PanelHD.Height);
                    PanelHD.DrawToBitmap(bmp,
                        new Rectangle(0, 0, PanelHD.Width + 5, PanelHD.Height + 5));

                    // Chuyển đổi hình ảnh từ System.Drawing.Image sang dạng byte[]
                    byte[] imageBytes;
                    using (var imageStream = new MemoryStream())
                    {
                        bmp.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
                        imageBytes = imageStream.ToArray();
                        var panelImage = XImage.FromStream(imageStream);
                        // Tính toán tỉ lệ scale để hình ảnh fit vào trang PDF
                        var scaleX = pdfPage.Width / panelImage.PixelWidth;
                        var scaleY = pdfPage.Height / panelImage.PixelHeight;
                        var scale = Math.Min(scaleX, scaleY);

                        // Vẽ hình ảnh vào tài liệu PDF với tỉ lệ scale
                        graph.DrawImage(panelImage, 0, 0, panelImage.PixelWidth * scale,
                            panelImage.PixelHeight * scale);
                    }
                }

                pdf.Save(filePath);

                // Thông báo khi hoàn thành xuất PDF
                MessageBox.Show("Xuất PDF thành công!", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi xuất PDF
                MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ButtonExportWord_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "DOC Files|*.docx";
            saveFileDialog.Title = "Lưu dưới dạng Docx";
            saveFileDialog.FileName = "BillDetail.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = saveFileDialog.FileName;

                try
                {
                    var doc = new Document("..\\..\\Template\\baocao.doc");

                    doc.MailMerge.Execute(new string[] { "Ho_Ten" }, new[] { lblName.Text });
                    doc.MailMerge.Execute(new string[] { "Date_Bill" }, new[] { LabelDate.Text });
                    doc.MailMerge.Execute(new string[] { "Room_ID" }, new[] { LabelRoomId.Text });
                    doc.MailMerge.Execute(new string[] { "Quan_Rent" }, new[] { lblQuanRent.Text });
                    doc.MailMerge.Execute(new string[] { "Quan_Water" }, new[] { LabelWaterQuantity.Text });
                    doc.MailMerge.Execute(new string[] { "Quan_Elec" }, new[] { LabelElectricityQuantity.Text });
                    doc.MailMerge.Execute(new string[] { "Quan_Other" }, new[] { lblQuanOther.Text });
                    doc.MailMerge.Execute(new string[] { "Price_Rent" }, new[] { lbllls.Text });
                    doc.MailMerge.Execute(new string[] { "Price_Water" }, new[] { LabelWaterPrice.Text });
                    doc.MailMerge.Execute(new string[] { "Price_Elec" }, new[] { LabelElectricityPrice.Text });
                    doc.MailMerge.Execute(new string[] { "Price_Other" }, new[] { lalslasl.Text });
                    doc.MailMerge.Execute(new string[] { "Total_Rent" }, new[] { LabelRent.Text });
                    doc.MailMerge.Execute(new string[] { "Total_Water" }, new[] { LabelWaterTotalPrice.Text });
                    doc.MailMerge.Execute(new string[] { "Total_Elec" }, new[] { LabelElectricityTotalPrice.Text });
                    doc.MailMerge.Execute(new string[] { "Total_Other" }, new[] { LabelInternetPrice.Text });
                    doc.MailMerge.Execute(new string[] { "Total_Price" }, new[] { LabelTotalPrice.Text });
                    doc.Save(filePath);

                    // Thông báo khi hoàn thành xuất PDF
                    MessageBox.Show("Xuất Word thành công!", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi khi xuất PDF
                    MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}