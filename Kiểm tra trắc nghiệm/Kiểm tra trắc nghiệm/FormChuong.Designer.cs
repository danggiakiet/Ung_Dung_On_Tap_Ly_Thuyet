namespace Kiểm_tra_trắc_nghiệm
{
    partial class FormChuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTenMonHoc = new System.Windows.Forms.Label();
            this.panelChuong = new System.Windows.Forms.Panel();
            this.bttback = new System.Windows.Forms.Button();
            this.bttThiThu = new System.Windows.Forms.Button();
            this.bttLamLaiCacCauSai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTenMonHoc
            // 
            this.labelTenMonHoc.AutoSize = true;
            this.labelTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenMonHoc.Location = new System.Drawing.Point(23, 14);
            this.labelTenMonHoc.Name = "labelTenMonHoc";
            this.labelTenMonHoc.Size = new System.Drawing.Size(387, 37);
            this.labelTenMonHoc.TabIndex = 0;
            this.labelTenMonHoc.Text = "PHÁP LUẬT ĐẠI CƯƠNG";
            // 
            // panelChuong
            // 
            this.panelChuong.AutoScroll = true;
            this.panelChuong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChuong.Location = new System.Drawing.Point(30, 74);
            this.panelChuong.Name = "panelChuong";
            this.panelChuong.Size = new System.Drawing.Size(747, 208);
            this.panelChuong.TabIndex = 7;
            // 
            // bttback
            // 
            this.bttback.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttback.Location = new System.Drawing.Point(699, 12);
            this.bttback.Name = "bttback";
            this.bttback.Size = new System.Drawing.Size(89, 39);
            this.bttback.TabIndex = 15;
            this.bttback.Text = "Quay lại";
            this.bttback.UseVisualStyleBackColor = true;
            this.bttback.Click += new System.EventHandler(this.bttback_Click);
            // 
            // bttThiThu
            // 
            this.bttThiThu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThiThu.Location = new System.Drawing.Point(445, 12);
            this.bttThiThu.Name = "bttThiThu";
            this.bttThiThu.Size = new System.Drawing.Size(111, 39);
            this.bttThiThu.TabIndex = 16;
            this.bttThiThu.Text = "Thi thử";
            this.bttThiThu.UseVisualStyleBackColor = true;
            this.bttThiThu.Click += new System.EventHandler(this.bttThiThu_Click);
            // 
            // bttLamLaiCacCauSai
            // 
            this.bttLamLaiCacCauSai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLamLaiCacCauSai.Location = new System.Drawing.Point(562, 12);
            this.bttLamLaiCacCauSai.Name = "bttLamLaiCacCauSai";
            this.bttLamLaiCacCauSai.Size = new System.Drawing.Size(131, 39);
            this.bttLamLaiCacCauSai.TabIndex = 17;
            this.bttLamLaiCacCauSai.Text = "Các câu hay sai";
            this.bttLamLaiCacCauSai.UseVisualStyleBackColor = true;
            this.bttLamLaiCacCauSai.Click += new System.EventHandler(this.bttLamLaiCacCauSai_Click);
            // 
            // FormChuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.bttLamLaiCacCauSai);
            this.Controls.Add(this.bttThiThu);
            this.Controls.Add(this.bttback);
            this.Controls.Add(this.panelChuong);
            this.Controls.Add(this.labelTenMonHoc);
            this.Name = "FormChuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn chương";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChuong_FormClosing);
            this.Load += new System.EventHandler(this.FormChuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTenMonHoc;
        private System.Windows.Forms.Panel panelChuong;
        private System.Windows.Forms.Button bttback;
        private System.Windows.Forms.Button bttThiThu;
        private System.Windows.Forms.Button bttLamLaiCacCauSai;
    }
}