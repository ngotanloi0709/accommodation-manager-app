using BillModel = AccommodationManagerApp.Model.Bill;
using AccommodationManagerApp.Service;
using PdfSharp.Drawing;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Aspose.Words;

namespace AccommodationManagerApp.Forms
{
    public partial class BillDetail : BaseForm {
        private readonly BillService _billService;
        private BillModel _bill;
        public BillDetail(BillModel bill) {
            InitializeComponent();
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _bill = bill;
            LoadBillDetail();
        }

        private void LoadBillDetail()
        {
            int waterQty = _bill.WaterQuantity;
            int waterPrice = _billService.GetWaterPrice().Price;
            int elecQty = _bill.ElecQuantity;
            int elecPrice = _billService.GetElectricityPrice().Price;
            int internetPrice = _billService.GetInternetPrice().Price;

            lblRoomId.Text = _bill.Contract.Room.RoomNumber;
            lblDate.Text = _bill.CreatedAt.ToString();
            labelRent.Text = _bill.Contract.Price.ToString();
            labelQtyWater.Text = waterQty.ToString();
            labelQtyElec.Text = elecQty.ToString();
            labelPriceWater.Text = waterPrice.ToString();
            labelPriceElec.Text = elecPrice.ToString();
            labelInternet.Text = internetPrice.ToString();
            labelWater.Text = (waterQty * waterPrice).ToString();
            labelElec.Text = (elecQty * elecPrice).ToString();
            labelTotal.Text = ((waterQty * waterPrice) + (elecQty * elecPrice) + internetPrice).ToString();
        }
        private void btn_ExportPDF_Click_1(object sender, EventArgs e) {
            // Tạo hộp thoại lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save as PDF";
            saveFileDialog.FileName = "BillDetail.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;

                try {
                    PdfSharp.Pdf.PdfDocument pdf = new PdfSharp.Pdf.PdfDocument();
                    pdf.Info.Title = "Bill Detail";


                    PdfSharp.Pdf.PdfPage pdfPage = pdf.AddPage();
                    pdfPage.Width = PanelHD.Width + 5;
                    pdfPage.Height = PanelHD.Height + 5;
                    XGraphics graph = XGraphics.FromPdfPage(pdfPage);

                    // Lấy nội dung của PanelHD và đưa nó vào tài liệu PDF
                    using (MemoryStream ms = new MemoryStream()) {
                        // Lấy nội dung của PanelHD
                        Bitmap bmp = new Bitmap(PanelHD.Width, PanelHD.Height);
                        PanelHD.DrawToBitmap(bmp,
                            new System.Drawing.Rectangle(0, 0, PanelHD.Width + 5, PanelHD.Height + 5));

                        // Chuyển đổi hình ảnh từ System.Drawing.Image sang dạng byte[]
                        byte[] imageBytes;
                        using (MemoryStream imageStream = new MemoryStream()) {
                            bmp.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
                            imageBytes = imageStream.ToArray();
                            XImage panelImage = XImage.FromStream(imageStream);
                            // Tính toán tỉ lệ scale để hình ảnh fit vào trang PDF
                            double scaleX = pdfPage.Width / panelImage.PixelWidth;
                            double scaleY = pdfPage.Height / panelImage.PixelHeight;
                            double scale = Math.Min(scaleX, scaleY);

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
                catch (Exception ex) {
                    // Xử lý lỗi khi xuất PDF
                    MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "DOC Files|*.docx";
            saveFileDialog.Title = "Save as DOCX";
            saveFileDialog.FileName = "BillDetail.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    Document doc = new Document("..\\..\\Template\\baocao.doc");

                    doc.MailMerge.Execute(new string[] { "Ho_Ten" }, new[] { lblName.Text });
                    doc.MailMerge.Execute(new string[] { "Date_Bill" }, new[] { lblDate.Text });
                    doc.MailMerge.Execute(new string[] { "Room_ID" }, new[] { lblRoomId.Text });
                    doc.MailMerge.Execute(new string[] { "Quan_Rent" }, new[] { lblQuanRent.Text });
                    doc.MailMerge.Execute(new string[] { "Quan_Water" }, new[] { labelQtyWater.Text });
                    doc.MailMerge.Execute(new string[] { "Quan_Elec" }, new[] { labelQtyElec.Text });
                    doc.MailMerge.Execute(new string[] { "Quan_Other" }, new[] { lblQuanOther.Text });
                    doc.MailMerge.Execute(new string[] { "Price_Rent" }, new[] { lbllls.Text });
                    doc.MailMerge.Execute(new string[] { "Price_Water" }, new[] { labelPriceWater.Text });
                    doc.MailMerge.Execute(new string[] { "Price_Elec" }, new[] { labelPriceElec.Text });
                    doc.MailMerge.Execute(new string[] { "Price_Other" }, new[] { lalslasl.Text });
                    doc.MailMerge.Execute(new string[] { "Total_Rent" }, new[] { labelRent.Text });
                    doc.MailMerge.Execute(new string[] { "Total_Water" }, new[] { labelWater.Text });
                    doc.MailMerge.Execute(new string[] { "Total_Elec" }, new[] { labelElec.Text });
                    doc.MailMerge.Execute(new string[] { "Total_Other" }, new[] { labelInternet.Text });
                    doc.MailMerge.Execute(new string[] { "Total_Price" }, new[] { labelTotal.Text });
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