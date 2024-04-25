namespace Kiểm_tra_trắc_nghiệm
{
    partial class FormDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDe));
            this.labelChuong = new System.Windows.Forms.Label();
            this.bttback = new System.Windows.Forms.Button();
            this.panelDe = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelChuong
            // 
            this.labelChuong.AutoSize = true;
            this.labelChuong.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChuong.Location = new System.Drawing.Point(335, 20);
            this.labelChuong.Name = "labelChuong";
            this.labelChuong.Size = new System.Drawing.Size(85, 31);
            this.labelChuong.TabIndex = 2;
            this.labelChuong.Text = "label1";
            this.labelChuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttback
            // 
            this.bttback.BackColor = System.Drawing.Color.White;
            this.bttback.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttback.Location = new System.Drawing.Point(677, 13);
            this.bttback.Name = "bttback";
            this.bttback.Size = new System.Drawing.Size(111, 42);
            this.bttback.TabIndex = 14;
            this.bttback.Text = "Quay lại";
            this.bttback.UseVisualStyleBackColor = false;
            this.bttback.Click += new System.EventHandler(this.bttback_Click);
            // 
            // panelDe
            // 
            this.panelDe.AutoScroll = true;
            this.panelDe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDe.Location = new System.Drawing.Point(50, 66);
            this.panelDe.Name = "panelDe";
            this.panelDe.Size = new System.Drawing.Size(658, 185);
            this.panelDe.TabIndex = 15;
            // 
            // FormDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 268);
            this.Controls.Add(this.panelDe);
            this.Controls.Add(this.bttback);
            this.Controls.Add(this.labelChuong);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn đề";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDe_FormClosing);
            this.Load += new System.EventHandler(this.FormDe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChuong;
        private System.Windows.Forms.Button bttback;
        private System.Windows.Forms.Panel panelDe;
    }
}