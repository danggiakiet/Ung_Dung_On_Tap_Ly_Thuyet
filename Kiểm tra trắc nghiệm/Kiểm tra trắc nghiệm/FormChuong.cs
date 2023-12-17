using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiểm_tra_trắc_nghiệm
{
    public partial class FormChuong : Form
    {
        string monHoc;
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
        private void button1_Click(object sender, EventArgs e)
        {
            string chuong = "Chương 1";
            FormDe formDe = new FormDe(monHoc, chuong);
            formDe.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chuong = "Chương 2";
            FormDe formDe = new FormDe(monHoc, chuong);
            formDe.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string chuong = "Chương 3";
            FormDe formDe = new FormDe(monHoc, chuong);
            formDe.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string chuong = "Chương 4";
            FormDe formDe = new FormDe(monHoc, chuong);
            formDe.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string chuong = "Chương 5";
            FormDe formDe = new FormDe(monHoc, chuong);
            formDe.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string chuong = "Chương 6";
            FormDe formDe = new FormDe(monHoc, chuong);
            formDe.ShowDialog();
        }
    }
}
