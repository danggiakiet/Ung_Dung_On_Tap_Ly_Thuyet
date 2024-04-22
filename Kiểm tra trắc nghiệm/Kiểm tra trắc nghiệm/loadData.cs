using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Kiểm_tra_trắc_nghiệm
{
    public class loadData
    {
        public loadData() { }
        public void loadTenThuMuc(List<string> dsTenThuMuc)
        {
            string folderPath = "data";
            // Kiểm tra xem thư mục có tồn tại không
            if (Directory.Exists(folderPath))
            {
                // Lấy danh sách tất cả các thư mục trong thư mục hiện tại
                string[] subDirectories = Directory.GetDirectories(folderPath);

                // Xuất danh sách tên thư mục
                foreach (string subDir in subDirectories)
                {
                    // Lấy tên thư mục từ đường dẫn đầy đủ
                    string folderName = Path.GetFileName(subDir);
                    dsTenThuMuc.Add(folderName);
                }
            }
            else
            {
                MessageBox.Show("Lỗi đường dẫn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadDataFromExcelPath(List<cauHoi> dsCauHayLamSai, string monHoc)
        {
            try
            {
                // Mở file excel
                using (var package = new ExcelPackage(new FileInfo($"Câu hay làm sai/{monHoc}/Danh sách câu hỏi hay làm sai.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    // Kiểm tra xem có dữ liệu trong danh sách không
                    if (worksheet.Dimension.Rows <= 1)
                    {
                        MessageBox.Show("Không có dữ liệu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    // Cho duyệt từ dòng 2 đến hết
                    for (int i = 2; i <= worksheet.Dimension.End.Row; i++)
                    {
                        // Khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng dòng
                        string cauHoi = Convert.ToString(worksheet.Cells[i, 1].Value ?? "");
                        string cauA = Convert.ToString(worksheet.Cells[i, 2].Value ?? "");
                        string cauB = Convert.ToString(worksheet.Cells[i, 3].Value ?? "");
                        string cauC = Convert.ToString(worksheet.Cells[i, 4].Value ?? "");
                        string cauD = Convert.ToString(worksheet.Cells[i, 5].Value ?? "");
                        int dapAnDung = Convert.ToInt32(worksheet.Cells[i, 6].Value ?? "");
                        // Tạo biến cauHoi để thêm vào dsCauHoi
                        cauHoi cauHoii = new cauHoi(cauHoi, cauA, cauB, cauC, cauD, dapAnDung);
                        // Thêm biến vừa tạo vào dsNhanVien
                        dsCauHayLamSai.Add(cauHoii);
                    }
                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi
                MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void LoadDataFromExcel(List<cauHoi> dsCauHoi, string monHoc, string chuong, bool exam)
        {
            if (exam = false)
            {
                // Làm mới danh sách
                dsCauHoi.Clear();
            }
            try
            {
                // Mở file excel
                using (var package = new ExcelPackage(new FileInfo($"data/{monHoc}/{chuong}.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    // Kiểm tra xem có dữ liệu trong danh sách không
                    if (worksheet.Dimension.Rows <= 1)
                    {
                        MessageBox.Show("Không có dữ liệu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    // Cho duyệt từ dòng 2 đến hết
                    for (int i = 2; i <= worksheet.Dimension.End.Row; i++)
                    {
                        // Khởi tạo các biến để chứa các giá trị lấy từ dữ liệu theo từng dòng
                        string cauHoi = Convert.ToString(worksheet.Cells[i, 1].Value ?? "");
                        string cauA = Convert.ToString(worksheet.Cells[i, 2].Value ?? "");
                        string cauB = Convert.ToString(worksheet.Cells[i, 3].Value ?? "");
                        string cauC = Convert.ToString(worksheet.Cells[i, 4].Value ?? "");
                        string cauD = Convert.ToString(worksheet.Cells[i, 5].Value ?? "");
                        int dapAnDung = Convert.ToInt32(worksheet.Cells[i, 6].Value ?? "");
                        // Tạo biến cauHoi để thêm vào dsCauHoi
                        cauHoi cauHoii = new cauHoi(cauHoi, cauA, cauB, cauC, cauD, dapAnDung);
                        // Thêm biến vừa tạo vào dsNhanVien
                        dsCauHoi.Add(cauHoii);
                    }
                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi
                MessageBox.Show("Lỗi khi đọc dữ liệu từ Excel: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;           
            }
        }
    }
}
