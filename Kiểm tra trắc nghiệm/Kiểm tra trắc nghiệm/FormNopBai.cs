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
        int index = 0;
        List<cauLamSai> dsCauLamSai = new List<cauLamSai>();
        public FormNopBai()
        {
            InitializeComponent();
        }
        public FormNopBai(int count, int soCauLamSai, List<cauHoi> dsCauSai, List<cauHoi> dscauHoi)
        {
            InitializeComponent();
            labelDiem.Text = $"Điểm của bạn là: {count} / {dscauHoi.Count}";
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
        }
        private void LoadCauHoi(List<cauLamSai> dsCauHoi, int index)
        {
            if (dsCauHoi.Count == 0)
            {
                txtCauHoi.Text = "Bạn đã làm đúng tất cả";
                bttLui.Visible = false;
                bttTien.Visible = false;
            }
            else
            {
                txtCauHoi.Text = dsCauLamSai[index].cauHoi;
                txtCauTraLoi.Text = dsCauLamSai[index].cauTraLoi;
            }
        }
        private void FormNopBai_Load(object sender, EventArgs e)
        {
            // Tạo một đối tượng Font mới với font là "Times New Roman"
            Font timesNewRomanFont = new Font("Times New Roman", 14, FontStyle.Regular);
            LoadCauHoi(dsCauLamSai, index);
            if(index == dsCauLamSai.Count - 1)
            {
                bttLui.Visible = false;
                bttTien.Visible = false;
            }    
            else
            {
                bttLui.Visible = false;
            }    
        }

        private void bttLui_Click(object sender, EventArgs e)
        {
            index--;
            LoadCauHoi(dsCauLamSai, index);
            if (index <= 0)
            {
                bttLui.Visible = false;
                bttTien.Visible = true;
            }
            else
            {
                bttLui.Visible = true;
            }
        }

        private void bttTien_Click(object sender, EventArgs e)
        {
            index++;
            LoadCauHoi(dsCauLamSai, index);
            if (index >= dsCauLamSai.Count - 1)
            {
                bttTien.Visible = false;
                bttLui.Visible = true;
            }
            else
            {
                bttTien.Visible = true;
            }
        }
    }
}
