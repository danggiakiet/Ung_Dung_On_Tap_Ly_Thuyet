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
            this.SuspendLayout();
            // 
            // labelTenMonHoc
            // 
            this.labelTenMonHoc.AutoSize = true;
            this.labelTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenMonHoc.Location = new System.Drawing.Point(210, 26);
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
            // FormChuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.panelChuong);
            this.Controls.Add(this.labelTenMonHoc);
            this.Name = "FormChuong";
            this.Text = "FormChuong";
            this.Load += new System.EventHandler(this.FormChuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTenMonHoc;
        private System.Windows.Forms.Panel panelChuong;
    }
}