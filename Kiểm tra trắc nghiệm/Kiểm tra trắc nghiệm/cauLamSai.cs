using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiểm_tra_trắc_nghiệm
{
    public class cauLamSai
    {
        public cauLamSai() { }
        
        public string cauHoi { get; set; }
        public string cauTraLoi { get; set;}
        public cauLamSai(string cauHoi, string cauTraLoi)
        {
            this.cauHoi = cauHoi;
            this.cauTraLoi = cauTraLoi;
        }

        public void LuuCauSai(string monhoc, cauHoi cauHoiHienTai)
        {
            try
            {
                // Kiểm tra thư mục có tồn tại không
                DirectoryInfo directory = new DirectoryInfo($"Câu hay làm sai/{monhoc}");
                ExcelPackage package;
                if (directory.Exists)
                {
                    // Kiểm tra nếu tệp Excel đã tồn tại
                    FileInfo fileInfo = new FileInfo($"Câu hay làm sai/{monhoc}/Danh sách câu hỏi hay làm sai.xlsx");
                    if (fileInfo.Exists)
                    {
                        LuuCauSaiVaoExcel(cauHoiHienTai, $"Câu hay làm sai/{monhoc}/Danh sách câu hỏi hay làm sai.xlsx");
                    }
                    else
                    {
                        // Tạo một tệp Excel mới nếu tệp không tồn tại
                        package = new ExcelPackage();
                        // Lưu tệp Excel vào đường dẫn đã chỉ định
                        package.SaveAs(fileInfo);
                    }
                }
                else
                {
                    // Tạo một folder bằng tên monhoc nếu folder chưa tồn tại
                    directory.Create();
                    // Tạo một tệp Excel trong folder đó
                    FileInfo newFileInfo = new FileInfo($"Câu hay làm sai/{monhoc}/Danh sách câu hỏi hay làm sai.xlsx");
                    package = new ExcelPackage(newFileInfo);
                    // Lưu tệp Excel vào đường dẫn đã chỉ định
                    package.SaveAs(newFileInfo);
                    LuuCauSaiVaoExcel(cauHoiHienTai, $"Câu hay làm sai/{monhoc}/Danh sách câu hỏi hay làm sai.xlsx");
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây
                MessageBox.Show("Lỗi ở LuuCauSai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void LuuCauSaiVaoExcel(cauHoi CauHoi, string tenTep)
        {
            try
            {
                // Kiểm tra nếu tệp Excel đã tồn tại
                FileInfo fileInfo = new FileInfo(tenTep);
                ExcelPackage package;
                if (fileInfo.Exists)
                {
                    // Mở tệp Excel đã có
                    package = new ExcelPackage(fileInfo);
                }
                else
                {
                    // Tạo một tệp Excel mới nếu tệp không tồn tại
                    package = new ExcelPackage();
                }

                // Kiểm tra nếu có tồn tại một trang tính có tên "DanhSachCauHoi", nếu không, tạo mới
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == "DsCauHoiLamSai");
                if (worksheet == null)
                {
                    worksheet = package.Workbook.Worksheets.Add("DsCauHoiLamSai");
                }

                // Xác định hàng bắt đầu ghi dữ liệu (nếu tệp đã có dữ liệu, tiếp tục từ hàng tiếp theo)
                int startRow = worksheet.Dimension.End.Row + 1;

                bool tonTai = false;

                // Duyệt qua các dòng trong tệp Excel để kiểm tra sự tồn tại của câu hỏi
                for (int i = 1; i <= worksheet.Dimension.End.Row; i++)
                {
                    string cauHoiTrongExcel = worksheet.Cells[i, 1].Value.ToString();
                    if (cauHoiTrongExcel == CauHoi.CauHoi)
                    {
                        // Nếu câu hỏi đã tồn tại, đặt biến tonTai thành true và thoát khỏi vòng lặp
                        tonTai = true;
                        break;
                    }
                }

                // Nếu câu hỏi không tồn tại, thêm vào tệp Excel
                if (!tonTai)
                {
                    worksheet.Cells[startRow, 1].Value = CauHoi.CauHoi;
                    worksheet.Cells[startRow, 2].Value = CauHoi.cauA;
                    worksheet.Cells[startRow, 3].Value = CauHoi.cauB;
                    worksheet.Cells[startRow, 4].Value = CauHoi.cauC;
                    worksheet.Cells[startRow, 5].Value = CauHoi.cauD;
                    worksheet.Cells[startRow, 6].Value = CauHoi.dapAnDung;
                    startRow++; // Tăng chỉ số hàng bắt đầu ghi dữ liệu lên để ghi vào hàng tiếp theo
                }


                // Lưu tệp Excel
                package.SaveAs(fileInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ở LuuCauSaiDuLieuVaoExcel", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void XoaDanhSachCauHayLamSai(string monhoc)
        {
            try
            {
                // Đường dẫn tệp Excel
                string filePath = $"Câu hay làm sai/{monhoc}/Danh sách câu hỏi hay làm sai.xlsx";

                // Mở tệp Excel
                FileInfo fileInfo = new FileInfo(filePath);
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    // Chọn Sheet cụ thể, ví dụ: Sheet đầu tiên
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];

                    // Xóa dữ liệu từ dòng thứ 2
                    int rowStart = 2; // Dòng bắt đầu xóa
                    int rowCount = worksheet.Dimension.Rows - 1; // Số lượng dòng cần xóa (loại bỏ dòng header)
                    worksheet.DeleteRow(rowStart, rowCount);

                    // Lưu lại các thay đổi vào tệp Excel
                    package.Save();
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây
                MessageBox.Show("Lỗi ở XoaDanhSachCauHayLamSai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
