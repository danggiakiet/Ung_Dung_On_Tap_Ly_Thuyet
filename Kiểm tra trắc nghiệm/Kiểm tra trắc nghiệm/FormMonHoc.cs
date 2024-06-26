﻿using System;
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
        List<string> dsTenThuMuc = new List<string>();
        CreateControls CreateControls = new CreateControls();
        loadData loadData = new loadData();
        public FormMonHoc()
        {
            InitializeComponent();
        }
        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            int x = 180, y = 20;
            loadData.loadTenThuMuc(dsTenThuMuc);
            foreach (string name in dsTenThuMuc)
            {
                Button bttMonHoc = CreateControls.CreateButton(x, y, 200, 100, name);
                panelMonHoc.Controls.Add(bttMonHoc);
                y = y + 110;

                bttMonHoc.Click += (buttonSender, buttonEventArgs) =>
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
