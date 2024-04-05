namespace Kiểm_tra_trắc_nghiệm
{
    partial class FormNopBai
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelDiem = new System.Windows.Forms.Label();
            this.labelSoCauSai = new System.Windows.Forms.Label();
            this.txtCauHoi = new System.Windows.Forms.RichTextBox();
            this.txtCauTraLoi = new System.Windows.Forms.RichTextBox();
            this.bttLui = new System.Windows.Forms.Button();
            this.bttTien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoàn Thành";
            // 
            // labelDiem
            // 
            this.labelDiem.AutoSize = true;
            this.labelDiem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiem.Location = new System.Drawing.Point(12, 87);
            this.labelDiem.Name = "labelDiem";
            this.labelDiem.Size = new System.Drawing.Size(96, 23);
            this.labelDiem.TabIndex = 1;
            this.labelDiem.Text = "labelDiem";
            this.labelDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoCauSai
            // 
            this.labelSoCauSai.AutoSize = true;
            this.labelSoCauSai.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoCauSai.Location = new System.Drawing.Point(12, 123);
            this.labelSoCauSai.Name = "labelSoCauSai";
            this.labelSoCauSai.Size = new System.Drawing.Size(132, 23);
            this.labelSoCauSai.TabIndex = 2;
            this.labelSoCauSai.Text = "labelSoCauSai";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauHoi.Location = new System.Drawing.Point(14, 158);
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.ReadOnly = true;
            this.txtCauHoi.Size = new System.Drawing.Size(560, 169);
            this.txtCauHoi.TabIndex = 3;
            this.txtCauHoi.Text = "";
            // 
            // txtCauTraLoi
            // 
            this.txtCauTraLoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauTraLoi.Location = new System.Drawing.Point(14, 333);
            this.txtCauTraLoi.Name = "txtCauTraLoi";
            this.txtCauTraLoi.ReadOnly = true;
            this.txtCauTraLoi.Size = new System.Drawing.Size(560, 97);
            this.txtCauTraLoi.TabIndex = 4;
            this.txtCauTraLoi.Text = "";
            // 
            // bttLui
            // 
            this.bttLui.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLui.Location = new System.Drawing.Point(195, 447);
            this.bttLui.Name = "bttLui";
            this.bttLui.Size = new System.Drawing.Size(76, 35);
            this.bttLui.TabIndex = 5;
            this.bttLui.Text = "<";
            this.bttLui.UseVisualStyleBackColor = true;
            this.bttLui.Click += new System.EventHandler(this.bttLui_Click);
            // 
            // bttTien
            // 
            this.bttTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTien.Location = new System.Drawing.Point(290, 447);
            this.bttTien.Name = "bttTien";
            this.bttTien.Size = new System.Drawing.Size(76, 35);
            this.bttTien.TabIndex = 6;
            this.bttTien.Text = ">";
            this.bttTien.UseVisualStyleBackColor = true;
            this.bttTien.Click += new System.EventHandler(this.bttTien_Click);
            // 
            // FormNopBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 501);
            this.Controls.Add(this.bttTien);
            this.Controls.Add(this.bttLui);
            this.Controls.Add(this.txtCauTraLoi);
            this.Controls.Add(this.txtCauHoi);
            this.Controls.Add(this.labelSoCauSai);
            this.Controls.Add(this.labelDiem);
            this.Controls.Add(this.label1);
            this.Name = "FormNopBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNopBai";
            this.Load += new System.EventHandler(this.FormNopBai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDiem;
        private System.Windows.Forms.Label labelSoCauSai;
        private System.Windows.Forms.RichTextBox txtCauHoi;
        private System.Windows.Forms.RichTextBox txtCauTraLoi;
        private System.Windows.Forms.Button bttLui;
        private System.Windows.Forms.Button bttTien;
    }
}