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
    public partial class FormNopBai : Form
    {
        List<cauLamSai> dsCauLamSai = new List<cauLamSai>();
        public FormNopBai(int count, int soCauLamSai, List<cauHoi> dsCauSai)
        {
            InitializeComponent();
            labelDiem.Text = $"Điểm của bạn là: {count} / 20";
            labelSoCauSai.Text = $"Số câu sai là: {soCauLamSai}";
            foreach (cauHoi a in dsCauSai)
            {
                string cauHoi = a.CauHoi;
                string dapAn = "";
                switch (a.dapAnDung)
                {
                    case 1: 
                        dapAn = a.cauA;
                        break;
                    case 2:
                        dapAn = a.cauB;
                        break;
                    case 3: 
                        dapAn = a.cauC;
                        break;
                    case 4:
                        dapAn = a.cauD;
                        break;
                }  
                cauLamSai cauSai = new cauLamSai(cauHoi, dapAn);
                dsCauLamSai.Add(cauSai);
            }  
            dataGridView1.DataSource = dsCauLamSai;
        }

        private void FormNopBai_Load(object sender, EventArgs e)
        {
            // Tạo một đối tượng Font mới với font là "Times New Roman"
            Font timesNewRomanFont = new Font("Times New Roman", 14, FontStyle.Regular);

            // Gán font cho dataGridView1
            dataGridView1.Font = timesNewRomanFont;
            dataGridView1.RowTemplate.MinimumHeight = 30;//25 is height.
        }
    }
}
