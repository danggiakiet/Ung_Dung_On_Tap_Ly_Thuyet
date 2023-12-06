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
        string chuong;
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
            loadData.LoadDataFromExcel(dsCauHoi, chuong);
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
        public FormDe(string Chuong)
        {
            chuong = Chuong;
            InitializeComponent();
        }
        public FormDe()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1De1 = new Form1(chuong, 1);
            form1De1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1De2 = new Form1(chuong, 2);
            form1De2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1De3 = new Form1(chuong, 3);
            form1De3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1De4 = new Form1(chuong, 4);
            form1De4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1De5 = new Form1(chuong, 5);
            form1De5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1De6 = new Form1(chuong, 6);
            form1De6.ShowDialog();
        }
    }
}
