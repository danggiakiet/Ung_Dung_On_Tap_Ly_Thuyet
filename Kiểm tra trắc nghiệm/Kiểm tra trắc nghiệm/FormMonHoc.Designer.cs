﻿namespace Kiểm_tra_trắc_nghiệm
{
    partial class FormMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonHoc));
            this.panelMonHoc = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelMonHoc
            // 
            this.panelMonHoc.AutoScroll = true;
            this.panelMonHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMonHoc.Location = new System.Drawing.Point(20, 24);
            this.panelMonHoc.Name = "panelMonHoc";
            this.panelMonHoc.Size = new System.Drawing.Size(578, 432);
            this.panelMonHoc.TabIndex = 0;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 470);
            this.Controls.Add(this.panelMonHoc);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn môn học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMonHoc_FormClosing);
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMonHoc;
    }
}