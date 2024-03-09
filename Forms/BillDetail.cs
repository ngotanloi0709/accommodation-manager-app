using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class BillDetail : Form
    {
        public BillDetail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelHD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btn_ExportPDF_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save as PDF";
            saveFileDialog.FileName = "BillDetail.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = "Bill Detail";

                    PdfPage pdfPage = pdf.AddPage();
                    XGraphics graph = XGraphics.FromPdfPage(pdfPage);

                    // Lấy nội dung của PanelHD và đưa nó vào tài liệu PDF
                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Lấy nội dung của PanelHD
                        Bitmap bmp = new Bitmap(PanelHD.Width, PanelHD.Height);
                        PanelHD.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, PanelHD.Width, PanelHD.Height));

                        // Chuyển đổi hình ảnh từ System.Drawing.Image sang dạng byte[]
                        byte[] imageBytes;
                        using (MemoryStream imageStream = new MemoryStream())
                        {
                            bmp.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
                            imageBytes = imageStream.ToArray();
                        }

                        XImage panelImage = XImage.FromStream(new MemoryStream(imageBytes));

                        // Tính toán vị trí canh giữa trên trang PDF không quan tâm đến rotation
                        double x = (pdfPage.Width - panelImage.PixelWidth) / 2;
                        double y = (pdfPage.Height - panelImage.PixelHeight) / 2;

                        // Vẽ hình ảnh vào tài liệu PDF với vị trí canh giữa
                        graph.DrawImage(panelImage, x, y);
                    }

                    pdf.Save(filePath);

                    // Thông báo khi hoàn thành xuất PDF
                    MessageBox.Show("Xuất PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi khi xuất PDF
                    MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
