using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Application = System.Windows.Forms.Application;
using System.Collections;
using System.Drawing;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System.Xml.Linq;
using System.Security.Cryptography;
using Button = System.Windows.Forms.Button;

namespace Kiểm_tra_trắc_nghiệm
{
    public partial class FormLamBai : Form
    {
        private Random random = new Random();
        List<cauHoi> dsCauHoi = new List<cauHoi>();
        List<cauHoi> dsCauHoiCuaDe = new List<cauHoi>();
        List<cauHoi> dsCauSai = new List<cauHoi>();
        Hashtable HashTableCauSai = new Hashtable();
        Hashtable kiemTraDaLamChua = new Hashtable();
        string chuong;
        string monhoc;
        int index = 0;
        int count = 0;
        bool extend = false;
        loadData loadData = new loadData();
        public FormLamBai()
        {
            InitializeComponent();
            bttNopBai.Visible = false;
        }
        public FormLamBai(string monHoc, string Chuong, int De)
        {
            monhoc = monHoc;
            InitializeComponent();
            chuong = Chuong;
            loadData.LoadDataFromExcel(dsCauHoi, monhoc, chuong, extend);
            // Lọc danh sách câu hỏi theo "De"
            dsCauHoiCuaDe = GetQuestionsForDe(dsCauHoi, De);
            Shuffle(dsCauHoiCuaDe);
        }
        public void LamBaiMoRong(List<cauHoi> dsCauHoi)
        {
            dsCauHoiCuaDe = dsCauHoi;
            extend = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bttLui.Visible = false;
            bttNopBai.Visible = false;
            labelChuong.Text = chuong;
            ShuffleAnswers(dsCauHoiCuaDe); // Trộn ngẫu nhiên thứ tự câu trả lời
            LoadCauHoi(dsCauHoiCuaDe, 0);
            labelSoCauDung.Text = $"Số câu đúng: {count} / {dsCauHoiCuaDe.Count}";

        }
        public void Form_CauSai(List<cauHoi> dsCauSai)
        {
            labelChuong.Text = "Câu Sai";
            labelSoCauDung.Visible = false;
            labelSoCauHoi.Visible = false;
            bttNopBai.Visible = false;

        }
        private void Shuffle(List<cauHoi> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                cauHoi temp = list[k];
                list[k] = list[n];
                list[n] = temp;
            }
        }

        private List<cauHoi> GetQuestionsForDe(List<cauHoi> allQuestions, int de)
        {
            // Lọc dsCauHoi theo giá trị "De"
            return allQuestions.Skip((de - 1) * 20).Take(20).ToList();
        }
        private void bttLui_Click(object sender, EventArgs e)
        {
            bttCauA.BackColor = SystemColors.Control;
            bttCauB.BackColor = SystemColors.Control;
            bttCauC.BackColor = SystemColors.Control;
            bttCauD.BackColor = SystemColors.Control;
            index--;
            cauHoi cauHoiHienTai = dsCauHoiCuaDe[index];
            bool containsKey = kiemTraDaLamChua.ContainsKey(index);
            if (containsKey)
            {
                bttCauA.Enabled = false;
                bttCauB.Enabled = false;
                bttCauC.Enabled = false;
                bttCauD.Enabled = false;
                bool containsKey2 = HashTableCauSai.ContainsKey(index);
                if (containsKey2)
                {
                    switch (HashTableCauSai[index])
                    {
                        case 1:
                            bttCauA.BackColor = Color.Red;
                            break;
                        case 2:
                            bttCauB.BackColor = Color.Red;
                            break;
                        case 3:
                            bttCauC.BackColor = Color.Red;
                            break;
                        case 4:
                            bttCauD.BackColor = Color.Red;
                            break;
                    }
                }
                switch (cauHoiHienTai.dapAnDung)
                {
                    case 1:
                        bttCauA.BackColor = Color.LightGreen;
                        break;
                    case 2:
                        bttCauB.BackColor = Color.LightGreen;
                        break;
                    case 3:
                        bttCauC.BackColor = Color.LightGreen;
                        break;
                    case 4:
                        bttCauD.BackColor = Color.LightGreen;
                        break;
                }

            }
            else
            {
                bttCauA.Enabled = true;
                bttCauB.Enabled = true;
                bttCauC.Enabled = true;
                bttCauD.Enabled = true;
            }

            // Kiểm tra điều kiện và thiết lập bttLui.Visible
            if (index <= 0)
            {
                bttLui.Visible = false;
            }
            bttTien.Visible = true;
            LoadCauHoi(dsCauHoiCuaDe, index);
        }
        private void bttTien_Click(object sender, EventArgs e)
        {
            bttCauA.BackColor = SystemColors.Control;
            bttCauB.BackColor = SystemColors.Control;
            bttCauC.BackColor = SystemColors.Control;
            bttCauD.BackColor = SystemColors.Control;
            index++;
            cauHoi cauHoiHienTai = dsCauHoiCuaDe[index];
            bool containsKey = kiemTraDaLamChua.ContainsKey(index);
            if (containsKey)
            {
                bttCauA.Enabled = false;
                bttCauB.Enabled = false;
                bttCauC.Enabled = false;
                bttCauD.Enabled = false;
                bool containsKey2 = HashTableCauSai.ContainsKey(index);
                if (containsKey2)
                {
                    switch (HashTableCauSai[index])
                    {
                        case 1:
                            bttCauA.BackColor = Color.Red;
                            break;
                        case 2:
                            bttCauB.BackColor = Color.Red;
                            break;
                        case 3:
                            bttCauC.BackColor = Color.Red;
                            break;
                        case 4:
                            bttCauD.BackColor = Color.Red;
                            break;
                    }
                }
                switch (cauHoiHienTai.dapAnDung)
                {
                    case 1:
                        bttCauA.BackColor = Color.LightGreen;
                        break;
                    case 2:
                        bttCauB.BackColor = Color.LightGreen;
                        break;
                    case 3:
                        bttCauC.BackColor = Color.LightGreen;
                        break;
                    case 4:
                        bttCauD.BackColor = Color.LightGreen;
                        break;
                }
            }
            else
            {
                bttCauA.Enabled = true;
                bttCauB.Enabled = true;
                bttCauC.Enabled = true;
                bttCauD.Enabled = true;
            }
            if (index >= dsCauHoiCuaDe.Count - 1)
            {
                bttTien.Visible = false;
                bttNopBai.Visible = true;
            }
            bttLui.Visible = true;
            LoadCauHoi(dsCauHoiCuaDe, index);
        }

        private void ShuffleAnswers(List<cauHoi> dsCauHoiCuaDe)
        {
            foreach (cauHoi ch in dsCauHoiCuaDe)
            {
                string dapAnDungBanDau = "";
                switch (ch.dapAnDung)
                {
                    case 1:
                        dapAnDungBanDau = ch.cauA;
                        break;
                    case 2:
                        dapAnDungBanDau = ch.cauB;
                        break;
                    case 3:
                        dapAnDungBanDau = ch.cauC;
                        break;
                    case 4:
                        dapAnDungBanDau = ch.cauD;
                        break;
                }

                List<string> answers = new List<string> { ch.cauA, ch.cauB, ch.cauC, ch.cauD };
                answers = answers.OrderBy(a => Guid.NewGuid()).ToList(); // Sử dụng Guid.NewGuid() để trộn ngẫu nhiên


                // Gán lại câu trả lời theo thứ tự mới
                ch.cauA = answers[0];
                ch.cauB = answers[1];
                ch.cauC = answers[2];
                ch.cauD = answers[3];

                if (ch.cauA == dapAnDungBanDau)
                {
                    ch.dapAnDung = 1;
                }
                if (ch.cauB == dapAnDungBanDau)
                {
                    ch.dapAnDung = 2;
                }
                if (ch.cauC == dapAnDungBanDau)
                {
                    ch.dapAnDung = 3;
                }
                if (ch.cauD == dapAnDungBanDau)
                {
                    ch.dapAnDung = 4;
                }
            }

        }


        private void LoadCauHoi(List<cauHoi> dsCauHoi, int index)
        {
            labelSoCauHoi.Text = $"Câu hỏi: {index + 1} / {dsCauHoiCuaDe.Count}";
            richTextBoxCauHoi.Text = dsCauHoiCuaDe[index].CauHoi;
            bttCauA.Text = dsCauHoiCuaDe[index].cauA;
            bttCauB.Text = dsCauHoiCuaDe[index].cauB;
            bttCauC.Text = dsCauHoiCuaDe[index].cauC;
            bttCauD.Text = dsCauHoiCuaDe[index].cauD;
        }

        private void bttCauA_Click(object sender, EventArgs e)
        {
            KiemTraDapAn(1);
        }

        private void bttCauB_Click(object sender, EventArgs e)
        {
            KiemTraDapAn(2);
        }

        private void bttCauC_Click(object sender, EventArgs e)
        {
            KiemTraDapAn(3);
        }

        private void bttCauD_Click(object sender, EventArgs e)
        {
            KiemTraDapAn(4);
        }

        private void KiemTraDapAn(int dapAn)
        {
            cauHoi cauHoiHienTai = dsCauHoiCuaDe[index];
            kiemTraDaLamChua.Add(index, dapAn);
            if (dapAn == cauHoiHienTai.dapAnDung)
            {
                count++;
                labelSoCauDung.Text = $"Số câu đúng: {count}/{dsCauHoiCuaDe.Count}";
                if (dapAn == 1)
                {
                    bttCauA.BackColor = Color.LightGreen;
                }
                else if (dapAn == 2)
                {
                    bttCauB.BackColor = Color.LightGreen;
                }
                else if (dapAn == 3)
                {
                    bttCauC.BackColor = Color.LightGreen;
                }
                else if (dapAn == 4)
                {
                    bttCauD.BackColor = Color.LightGreen;
                }
                bttCauA.Enabled = false;
                bttCauB.Enabled = false;
                bttCauC.Enabled = false;
                bttCauD.Enabled = false;
            }
            else
            {
                HashTableCauSai.Add(index, dapAn);
                dsCauSai.Add(cauHoiHienTai);
                if (dapAn == 1)
                {
                    bttCauA.BackColor = Color.Red;
                }
                else if (dapAn == 2)
                {
                    bttCauB.BackColor = Color.Red;
                }
                else if (dapAn == 3)
                {
                    bttCauC.BackColor = Color.Red;
                }
                else if (dapAn == 4)
                {
                    bttCauD.BackColor = Color.Red;
                }
                if (cauHoiHienTai.dapAnDung == 1)
                {
                    bttCauA.BackColor = Color.LightGreen;
                }
                else if (cauHoiHienTai.dapAnDung == 2)
                {
                    bttCauB.BackColor = Color.LightGreen;
                }
                else if (cauHoiHienTai.dapAnDung == 3)
                {
                    bttCauC.BackColor = Color.LightGreen;
                }
                else if (cauHoiHienTai.dapAnDung == 4)
                {
                    bttCauD.BackColor = Color.LightGreen;
                }
                bttCauA.Enabled = false;
                bttCauB.Enabled = false;
                bttCauC.Enabled = false;
                bttCauD.Enabled = false;
                LuuCauSaiDuLieuVaoExcel(cauHoiHienTai, "Danh sách câu hỏi hay làm sai.xlsx");
            }
        }

        private void bttNopBai_Click(object sender, EventArgs e)
        {
            FormNopBai formNopBai = new FormNopBai(count, dsCauSai.Count, dsCauSai, dsCauHoiCuaDe);
            formNopBai.ShowDialog();
        }

        private void bttback_Click(object sender, EventArgs e)
        {
            if (extend == false)
            {
                //Mở lại trang chọn đề
                this.Hide();
                FormDe formDe = new FormDe(monhoc, chuong);
                formDe.ShowDialog();
            }
            else if (extend == true)
            {
                this.Hide();
                FormMonHoc formMonHoc = new FormMonHoc();
                formMonHoc.ShowDialog();
                extend = false;
            }    
        }

        private void FormLamBai_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        public static void LuuCauSaiDuLieuVaoExcel(cauHoi CauHoi, string tenTep)
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
                Console.WriteLine("Lỗi khi ghi dữ liệu vào tệp Excel: " + ex.Message);
            }
        }
    }
}
