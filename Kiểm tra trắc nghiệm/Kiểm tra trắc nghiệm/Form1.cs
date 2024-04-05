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

namespace Kiểm_tra_trắc_nghiệm
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        List<cauHoi> dsCauHoi = new List<cauHoi>();
        List<cauHoi> dsCauHoiCuaDe = new List<cauHoi>();
        List<cauHoi> dsCauSai = new List<cauHoi>();
        Hashtable HashTableCauSai = new Hashtable();
        Hashtable kiemTraDaLamChua = new Hashtable();
        string chuong;
        int index = 0;
        int count = 0;
        loadData loadData = new loadData();
        public Form1()
        {
            InitializeComponent();
            bttNopBai.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bttLui.Visible = false;
            bttNopBai.Visible = false;
            labelChuong.Text = chuong;
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
        public Form1(string monHoc,string Chuong, int De)
        {
            InitializeComponent();
            chuong = Chuong;
            loadData.LoadDataFromExcel(dsCauHoi , monHoc, chuong);
            // Lọc danh sách câu hỏi theo "De"
            dsCauHoiCuaDe = GetQuestionsForDe(dsCauHoi, De);
            Shuffle(dsCauHoiCuaDe);
        }
        private List<cauHoi> GetQuestionsForDe(List<cauHoi> allQuestions, int de)
        {
            // Lọc dsCauHoi theo giá trị "De"
            return allQuestions.Skip((de - 1) * 20).Take(20).ToList();
        }
        private void bttLui_Click(object sender, EventArgs e)
        {
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
                if(containsKey2)
                {
                    switch(HashTableCauSai[index]) 
                    {
                        case 1: bttCauA.BackColor = Color.Red;
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
            }
            else
            {
                bttCauA.Enabled = true;
                bttCauB.Enabled = true;
                bttCauC.Enabled = true;
                bttCauD.Enabled = true;
                bttCauA.BackColor = SystemColors.Control;
                bttCauB.BackColor = SystemColors.Control;
                bttCauC.BackColor = SystemColors.Control;
                bttCauD.BackColor = SystemColors.Control;
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
            }
            else
            {
                bttCauA.Enabled = true;
                bttCauB.Enabled = true;
                bttCauC.Enabled = true;
                bttCauD.Enabled = true;
                bttCauA.BackColor = SystemColors.Control;
                bttCauB.BackColor = SystemColors.Control;
                bttCauC.BackColor = SystemColors.Control;
                bttCauD.BackColor = SystemColors.Control;
            }
            if (index >= dsCauHoiCuaDe.Count - 1)
            {
                bttTien.Visible = false;
                bttNopBai.Visible = true;
            }
            bttLui.Visible = true;
            LoadCauHoi(dsCauHoiCuaDe, index);
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
            if (dapAn == cauHoiHienTai.dapAnDung)
            {
                kiemTraDaLamChua.Add(index, dapAn);
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
                kiemTraDaLamChua.Add(index, dapAn);
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
                if(cauHoiHienTai.dapAnDung == 1)
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
            }
        }

        private void bttNopBai_Click(object sender, EventArgs e)
        {
            FormNopBai formNopBai = new FormNopBai(count,dsCauSai.Count, dsCauSai, dsCauHoiCuaDe);
            formNopBai.ShowDialog();
        }
    }
}
