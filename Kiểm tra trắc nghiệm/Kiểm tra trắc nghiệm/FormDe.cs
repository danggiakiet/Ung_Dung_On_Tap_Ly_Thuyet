using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Button = System.Windows.Forms.Button;

namespace Kiểm_tra_trắc_nghiệm
{
    public partial class FormDe : Form
    {
        List<cauHoi> dsCauHoi = new List<cauHoi>();
        string monHoc, chuong;
        loadData loadData = new loadData();
        CreateControls CreateControls = new CreateControls();
        private void FormDe_Load(object sender, EventArgs e)
        {
            int xBtt = 82, yBtt = 24;
            int count = 0;
            labelChuong.Text = chuong;
            loadData.LoadDataFromExcel(dsCauHoi, monHoc, chuong, false);
            int soDe = dsCauHoi.Count / 20;
            if (dsCauHoi.Count % 20 > 0)
            {
                soDe++;
            }
            for (int i = 1; i <= soDe; i++)
            {
                if (count >= 3)
                {
                    yBtt += 77;
                    xBtt = 82;
                    count = 0;
                }
                string name = $"Đề {i}";
                int de = i;
                Button bttDe = CreateControls.CreateButton(xBtt, yBtt, 146, 44, name);
                xBtt += 171;

                bttDe.Click += (buttonSender, buttonEventArgs) =>
                {
                    this.Hide();
                    FormLamBai formLamBai = new FormLamBai(monHoc, chuong, de);
                    formLamBai.ShowDialog();
                };

                panelDe.Controls.Add(bttDe);
                count++;
            }
        }
        public FormDe(string MonHoc, string Chuong)
        {
            monHoc = MonHoc;
            chuong = Chuong;
            InitializeComponent();
        }
        public FormDe()
        {
            InitializeComponent();

        }

        private void FormDe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void bttback_Click(object sender, EventArgs e)
        {
            //Mở lại trang chọn chương
            this.Hide();
            FormChuong formChuong = new FormChuong(monHoc);
            formChuong.ShowDialog();
        }
    }
}
