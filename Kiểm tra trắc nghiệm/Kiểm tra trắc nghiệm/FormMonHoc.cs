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

namespace Kiểm_tra_trắc_nghiệm
{
    public partial class FormMonHoc : Form
    {
        List<string> names = new List<string>();
        public FormMonHoc()
        {
            InitializeComponent();
        }
        public Button CreateButton(int x, int y, int width, int height, string name)
        {
            Button btt = new Button();
            btt.Text = name;
            btt.Width = width;
            btt.Height = height;
            btt.Location = new Point(x, y);
            return btt;
        }
        private void loadTenThuMuc()
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
                    names.Add(folderName);
                }
            }
            else
            {
                MessageBox.Show("Lỗi đường dẫn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            int x = 180, y = 20;
            loadTenThuMuc();
            foreach (string name in names)
            {
                Button buttonMonHoc = CreateButton(x, y, 200, 100, name);
                panelMonHoc.Controls.Add(buttonMonHoc);
                y = y + 110;

                buttonMonHoc.Click += (buttonSender, buttonEventArgs) =>
                {
                    this.Hide();
                    FormChuong formChuong = new FormChuong(name);
                    formChuong.ShowDialog();
                };
            }    
        }

        private void FormMonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
