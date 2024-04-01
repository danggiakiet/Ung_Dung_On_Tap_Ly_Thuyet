using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiểm_tra_trắc_nghiệm
{
    public class loadData
    {
        public loadData() { }
        public void LoadDataFromExcel(List<cauHoi> dsCauHoi, string monHoc, string chuong)
        {
            // Làm mới danh sách
            dsCauHoi.Clear();
            try
            {
                // Mở file excel
                using (var package = new ExcelPackage(new FileInfo($"data/{monHoc}/{chuong}.xlsx")))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    // Cho duyệt từ dòng 3 đến hết
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
                return;            }
        }
    }
}
