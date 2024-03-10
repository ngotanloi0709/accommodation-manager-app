﻿using PdfSharp.Drawing;
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
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MaterialSkin.Controls;
using MaterialSkin;

namespace AccommodationManagerApp.Forms
{
    public partial class BillDetail : MaterialForm
    {
        public BillDetail()
        {
            InitializeComponent();
            SetUpUi();
        }
        private void SetUpUi()
        {
            // Set the MaterialSkinManager to the form
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700, Primary.Green700, Accent.Purple400, TextShade.WHITE);
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
            /*SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save as PDF";
            saveFileDialog.FileName = "PanelHD.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Tạo một tài liệu PDF mới với kích thước bằng PanelHD
                    Document document = new Document(new iTextSharp.text.Rectangle(PanelHD.Width, PanelHD.Height));
                    PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                    document.Open();

                    // Lấy giao diện của PanelHD
                    Bitmap bmp = new Bitmap(PanelHD.Width, PanelHD.Height);
                    PanelHD.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, PanelHD.Width, PanelHD.Height));

                    // Chuyển đổi hình ảnh thành dạng byte[]
                    byte[] imageBytes;
                    using (MemoryStream imageStream = new MemoryStream())
                    {
                        bmp.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
                        imageBytes = imageStream.ToArray();
                    }

                    // Thêm hình ảnh của PanelHD vào tài liệu PDF
                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imageBytes);
                    image.Alignment = iTextSharp.text.Image.ALIGN_LEFT | iTextSharp.text.Image.ALIGN_TOP;
                    document.Add(image);

                    document.Close();

                    // Thông báo khi hoàn thành xuất PDF
                    MessageBox.Show("Xuất PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi khi xuất PDF
                    MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/

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
                    PdfSharp.Pdf.PdfDocument pdf = new PdfSharp.Pdf.PdfDocument();
                    pdf.Info.Title = "Bill Detail";


                    PdfSharp.Pdf.PdfPage pdfPage = pdf.AddPage();
                    pdfPage.Width = PanelHD.Width+5;
                    pdfPage.Height = PanelHD.Height+5;
                    XGraphics graph = XGraphics.FromPdfPage(pdfPage);

                    // Lấy nội dung của PanelHD và đưa nó vào tài liệu PDF
                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Lấy nội dung của PanelHD
                        Bitmap bmp = new Bitmap(PanelHD.Width, PanelHD.Height);
                        PanelHD.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, PanelHD.Width+5, PanelHD.Height+5));

                        // Chuyển đổi hình ảnh từ System.Drawing.Image sang dạng byte[]
                        byte[] imageBytes;
                        using (MemoryStream imageStream = new MemoryStream())
                        {
                            bmp.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);
                            imageBytes = imageStream.ToArray();
                        }

                        XImage panelImage = XImage.FromStream(new MemoryStream(imageBytes));

                        // Tính toán tỉ lệ scale để hình ảnh fit vào trang PDF
                        double scaleX = pdfPage.Width / panelImage.PixelWidth;
                        double scaleY = pdfPage.Height / panelImage.PixelHeight;
                        double scale = Math.Min(scaleX, scaleY);

                        // Vẽ hình ảnh vào tài liệu PDF với tỉ lệ scale
                        graph.DrawImage(panelImage, 0, 0, panelImage.PixelWidth * scale, panelImage.PixelHeight * scale);
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
