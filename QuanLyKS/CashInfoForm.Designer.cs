namespace QuanLyKS
{
    partial class CashInfoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNow = new System.Windows.Forms.TextBox();
            this.tbDAnhMuc = new System.Windows.Forms.TextBox();
            this.tbThu = new System.Windows.Forms.TextBox();
            this.tbChi = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh Mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng thu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng Chi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi Chú";
            // 
            // tbNow
            // 
            this.tbNow.Location = new System.Drawing.Point(84, 20);
            this.tbNow.Name = "tbNow";
            this.tbNow.ReadOnly = true;
            this.tbNow.Size = new System.Drawing.Size(154, 20);
            this.tbNow.TabIndex = 5;
            // 
            // tbDAnhMuc
            // 
            this.tbDAnhMuc.Location = new System.Drawing.Point(84, 55);
            this.tbDAnhMuc.Name = "tbDAnhMuc";
            this.tbDAnhMuc.Size = new System.Drawing.Size(305, 20);
            this.tbDAnhMuc.TabIndex = 6;
            // 
            // tbThu
            // 
            this.tbThu.Location = new System.Drawing.Point(84, 98);
            this.tbThu.Name = "tbThu";
            this.tbThu.ReadOnly = true;
            this.tbThu.Size = new System.Drawing.Size(129, 20);
            this.tbThu.TabIndex = 7;
            // 
            // tbChi
            // 
            this.tbChi.Location = new System.Drawing.Point(275, 98);
            this.tbChi.Name = "tbChi";
            this.tbChi.ReadOnly = true;
            this.tbChi.Size = new System.Drawing.Size(114, 20);
            this.tbChi.TabIndex = 8;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(24, 151);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(365, 58);
            this.tbNote.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CashInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbChi);
            this.Controls.Add(this.tbThu);
            this.Controls.Add(this.tbDAnhMuc);
            this.Controls.Add(this.tbNow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CashInfoForm";
            this.Text = "CashInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNow;
        private System.Windows.Forms.TextBox tbDAnhMuc;
        private System.Windows.Forms.TextBox tbThu;
        private System.Windows.Forms.TextBox tbChi;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button button1;
    }
}