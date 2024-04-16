using Microsoft.Office.Interop.Excel;
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
using Button = System.Windows.Forms.Button;
using Point = System.Drawing.Point;

namespace Kiểm_tra_trắc_nghiệm
{
    public partial class FormChuong : Form
    {
        List<string> chuongs = new List<string>();
        string monHoc;
        CreateControls CreateControls = new CreateControls();
        public FormChuong()
        {
            InitializeComponent();
        }
        public FormChuong(string MonHoc)
        {
            InitializeComponent();
            labelTenMonHoc.Text = MonHoc;
            monHoc = MonHoc;
        }
        private void loadSoLuongChuong(string monHoc)
        {
            string folderPath = "data/" + monHoc;
            // Kiểm tra xem thư mục có tồn tại không
            if (Directory.Exists(folderPath))
            {
                // Lấy danh sách tất cả các file Excel trong thư mục
                string[] excelFiles = Directory.GetFiles(folderPath, "*.xlsx");

                // Xuất danh sách tên file Excel
                foreach (string excelFile in excelFiles)
                {
                    // Lấy tên file (không bao gồm phần mở rộng) từ đường dẫn đầy đủ
                    string fileName = Path.GetFileNameWithoutExtension(excelFile);
                    chuongs.Add(fileName);
                }
            }
            else
            {
                MessageBox.Show("Lỗi đường dẫn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormChuong_Load(object sender, EventArgs e)
        {
            int x = 100, y = 30, count = 0;
            loadSoLuongChuong(monHoc);
            foreach (string name in chuongs)
            {
                if (count >= 3)
                {
                    y = y + 90;
                    count = 0;
                    x = 100;
                }

                Button buttonChuong = CreateControls.CreateButton(x, y, 146, 44, name);
                panelChuong.Controls.Add(buttonChuong);
                x = x + 200;

                buttonChuong.Click += (buttonSender, buttonEventArgs) =>
                {
                    this.Hide();
                    FormDe formDe = new FormDe(monHoc, buttonChuong.Text);
                    formDe.ShowDialog();
                };
                count++;

            }
        }

        private void bttback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMonHoc formMonHoc = new FormMonHoc();
            formMonHoc.ShowDialog();
        }

        private void FormChuong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
