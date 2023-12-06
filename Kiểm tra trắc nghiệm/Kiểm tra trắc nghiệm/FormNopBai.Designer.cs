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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(562, 326);
            this.dataGridView1.TabIndex = 3;
            // 
            // FormNopBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelSoCauSai);
            this.Controls.Add(this.labelDiem);
            this.Controls.Add(this.label1);
            this.Name = "FormNopBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNopBai";
            this.Load += new System.EventHandler(this.FormNopBai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDiem;
        private System.Windows.Forms.Label labelSoCauSai;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}