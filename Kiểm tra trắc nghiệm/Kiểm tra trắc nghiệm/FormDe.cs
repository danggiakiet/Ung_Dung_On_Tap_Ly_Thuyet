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

namespace Kiểm_tra_trắc_nghiệm
{
    public partial class FormDe : Form
    {
        List<cauHoi> dsCauHoi = new List<cauHoi>();
        string monHoc, chuong;
        loadData loadData = new loadData();
        private void FormDe_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            labelChuong.Text = chuong;
            loadData.LoadDataFromExcel(dsCauHoi, monHoc, chuong);
            int soDe = dsCauHoi.Count / 20;
            if(dsCauHoi.Count % 20 > 0)
            {
                soDe++;
            }    
            for(int i = 1; i <= soDe; i ++)
            {
                string buttonName = $"button{i}";
                Controls[buttonName].Visible = true;
            }
        }
        public FormDe(string MonHoc ,string Chuong)
        {
            monHoc = MonHoc;
            chuong = Chuong;
            InitializeComponent();
        }
        public FormDe()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLamBai formLamBaiDe1 = new FormLamBai(monHoc, chuong, 1);
            formLamBaiDe1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLamBai formLamBaiDe2 = new FormLamBai(monHoc, chuong, 2);
            formLamBaiDe2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLamBai formLamBaiDe3 = new FormLamBai(monHoc, chuong, 3);
            formLamBaiDe3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLamBai formLamBaiDe4 = new FormLamBai(monHoc, chuong, 4);
            formLamBaiDe4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLamBai formLamBaiDe5 = new FormLamBai(monHoc, chuong, 5);
            formLamBaiDe5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLamBai formLamBaiDe6 = new FormLamBai(monHoc, chuong, 6);
            formLamBaiDe6.ShowDialog();
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
