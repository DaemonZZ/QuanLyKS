﻿namespace QuanLyKS
{
    partial class updateForm
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddZoom = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbOrder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbZoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCO = new System.Windows.Forms.TextBox();
            this.tbCI = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRs = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(369, 226);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "OK";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAddZoom);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.tbOrder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbStt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbZoom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCO);
            this.groupBox1.Controls.Add(this.tbCI);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // btnAddZoom
            // 
            this.btnAddZoom.Location = new System.Drawing.Point(70, 158);
            this.btnAddZoom.Name = "btnAddZoom";
            this.btnAddZoom.Size = new System.Drawing.Size(100, 23);
            this.btnAddZoom.TabIndex = 13;
            this.btnAddZoom.Text = "Thêm Phòng";
            this.btnAddZoom.UseVisualStyleBackColor = true;
            this.btnAddZoom.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(356, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Hóa Đơn";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbOrder
            // 
            this.tbOrder.Location = new System.Drawing.Point(356, 123);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.Size = new System.Drawing.Size(150, 20);
            this.tbOrder.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lịch đặt";
            // 
            // cbStt
            // 
            this.cbStt.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbStt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStt.FormattingEnabled = true;
            this.cbStt.Items.AddRange(new object[] {
            "Phong Sạch",
            "Phòng đã đặt",
            "Phòng Dơ",
            "Phòng đang bảo trì",
            "Phòng đang sử dụng",
            "Đoàn 1",
            "Đoàn 2",
            "Đoàn 3"});
            this.cbStt.Location = new System.Drawing.Point(356, 77);
            this.cbStt.Name = "cbStt";
            this.cbStt.Size = new System.Drawing.Size(150, 21);
            this.cbStt.TabIndex = 9;
            this.cbStt.SelectedIndexChanged += new System.EventHandler(this.cbStt_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trạng Thái";
            // 
            // tbZoom
            // 
            this.tbZoom.Location = new System.Drawing.Point(356, 35);
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.ReadOnly = true;
            this.tbZoom.Size = new System.Drawing.Size(68, 20);
            this.tbZoom.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phòng";
            // 
            // tbCO
            // 
            this.tbCO.Location = new System.Drawing.Point(70, 123);
            this.tbCO.Name = "tbCO";
            this.tbCO.Size = new System.Drawing.Size(182, 20);
            this.tbCO.TabIndex = 5;
            // 
            // tbCI
            // 
            this.tbCI.Location = new System.Drawing.Point(70, 77);
            this.tbCI.Name = "tbCI";
            this.tbCI.Size = new System.Drawing.Size(182, 20);
            this.tbCI.TabIndex = 4;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(70, 38);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(182, 20);
            this.tbTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check Out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên KH";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Nhập lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRs
            // 
            this.btnRs.Location = new System.Drawing.Point(72, 226);
            this.btnRs.Name = "btnRs";
            this.btnRs.Size = new System.Drawing.Size(75, 23);
            this.btnRs.TabIndex = 11;
            this.btnRs.Text = "Reset";
            this.btnRs.UseVisualStyleBackColor = true;
            this.btnRs.Click += new System.EventHandler(this.btnRs_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 261);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRs);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdit);
            this.Name = "updateForm";
            this.Text = "Chỉnh Sửa Thông Tin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbZoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCO;
        private System.Windows.Forms.TextBox tbCI;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnRs;
        private System.Windows.Forms.Button btnAddZoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
    }
}