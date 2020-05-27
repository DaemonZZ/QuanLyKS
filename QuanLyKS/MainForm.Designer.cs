
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuanLyKS
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gửiBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinThanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchKháchQuenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchLàmViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảoDưỡngPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button206 = new System.Windows.Forms.Button();
            this.button205 = new System.Windows.Forms.Button();
            this.button204 = new System.Windows.Forms.Button();
            this.button107 = new System.Windows.Forms.Button();
            this.button108 = new System.Windows.Forms.Button();
            this.button106 = new System.Windows.Forms.Button();
            this.button105 = new System.Windows.Forms.Button();
            this.button104 = new System.Windows.Forms.Button();
            this.button207 = new System.Windows.Forms.Button();
            this.button201 = new System.Windows.Forms.Button();
            this.button202 = new System.Windows.Forms.Button();
            this.button203 = new System.Windows.Forms.Button();
            this.button101 = new System.Windows.Forms.Button();
            this.button102 = new System.Windows.Forms.Button();
            this.button103 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCO = new System.Windows.Forms.TextBox();
            this.tbCI = new System.Windows.Forms.TextBox();
            this.tbPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tfXtotal = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.gửiBáoCáoToolStripMenuItem,
            this.đóngToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // gửiBáoCáoToolStripMenuItem
            // 
            this.gửiBáoCáoToolStripMenuItem.Name = "gửiBáoCáoToolStripMenuItem";
            this.gửiBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.gửiBáoCáoToolStripMenuItem.Text = "Gửi Báo Cáo";
            // 
            // đóngToolStripMenuItem
            // 
            this.đóngToolStripMenuItem.Name = "đóngToolStripMenuItem";
            this.đóngToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.đóngToolStripMenuItem.Text = "Đóng";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNhânViênToolStripMenuItem,
            this.thôngTinThanhToánToolStripMenuItem,
            this.danhSáchKháchQuenToolStripMenuItem,
            this.báoCáoNgàyToolStripMenuItem,
            this.lịchLàmViệcToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Danh Sách Nhân Viên";
            // 
            // thôngTinThanhToánToolStripMenuItem
            // 
            this.thôngTinThanhToánToolStripMenuItem.Name = "thôngTinThanhToánToolStripMenuItem";
            this.thôngTinThanhToánToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.thôngTinThanhToánToolStripMenuItem.Text = "Thông tin thanh toán";
            // 
            // danhSáchKháchQuenToolStripMenuItem
            // 
            this.danhSáchKháchQuenToolStripMenuItem.Name = "danhSáchKháchQuenToolStripMenuItem";
            this.danhSáchKháchQuenToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.danhSáchKháchQuenToolStripMenuItem.Text = "Danh sách khách quen";
            // 
            // báoCáoNgàyToolStripMenuItem
            // 
            this.báoCáoNgàyToolStripMenuItem.Name = "báoCáoNgàyToolStripMenuItem";
            this.báoCáoNgàyToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.báoCáoNgàyToolStripMenuItem.Text = "Báo cáo ngày";
            // 
            // lịchLàmViệcToolStripMenuItem
            // 
            this.lịchLàmViệcToolStripMenuItem.Name = "lịchLàmViệcToolStripMenuItem";
            this.lịchLàmViệcToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.lịchLàmViệcToolStripMenuItem.Text = "Lịch làm việc";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngNhậpToolStripMenuItem,
            this.thốngKêDoanhThuToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.bảoDưỡngPhòngToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // hàngNhậpToolStripMenuItem
            // 
            this.hàngNhậpToolStripMenuItem.Name = "hàngNhậpToolStripMenuItem";
            this.hàngNhậpToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.hàngNhậpToolStripMenuItem.Text = "Xuất nhập hàng hoá";
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            this.thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
            this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống kê doanh thu";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // bảoDưỡngPhòngToolStripMenuItem
            // 
            this.bảoDưỡngPhòngToolStripMenuItem.Name = "bảoDưỡngPhòngToolStripMenuItem";
            this.bảoDưỡngPhòngToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.bảoDưỡngPhòngToolStripMenuItem.Text = "Bảo dưỡng phòng";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 38);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 61);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "Danh Bạ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button206);
            this.panel1.Controls.Add(this.button205);
            this.panel1.Controls.Add(this.button204);
            this.panel1.Controls.Add(this.button107);
            this.panel1.Controls.Add(this.button108);
            this.panel1.Controls.Add(this.button106);
            this.panel1.Controls.Add(this.button105);
            this.panel1.Controls.Add(this.button104);
            this.panel1.Controls.Add(this.button207);
            this.panel1.Controls.Add(this.button201);
            this.panel1.Controls.Add(this.button202);
            this.panel1.Controls.Add(this.button203);
            this.panel1.Controls.Add(this.button101);
            this.panel1.Controls.Add(this.button102);
            this.panel1.Controls.Add(this.button103);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 432);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tầng 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tầng 1";
            // 
            // button206
            // 
            this.button206.BackColor = System.Drawing.Color.Yellow;
            this.button206.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button206.Location = new System.Drawing.Point(473, 202);
            this.button206.Name = "button206";
            this.button206.Size = new System.Drawing.Size(100, 50);
            this.button206.TabIndex = 14;
            this.button206.Text = "P206";
            this.button206.UseVisualStyleBackColor = false;
            this.button206.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button205
            // 
            this.button205.BackColor = System.Drawing.Color.Yellow;
            this.button205.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button205.Location = new System.Drawing.Point(473, 146);
            this.button205.Name = "button205";
            this.button205.Size = new System.Drawing.Size(100, 50);
            this.button205.TabIndex = 13;
            this.button205.Text = "P205";
            this.button205.UseVisualStyleBackColor = false;
            this.button205.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button204
            // 
            this.button204.BackColor = System.Drawing.Color.Yellow;
            this.button204.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button204.Location = new System.Drawing.Point(473, 90);
            this.button204.Name = "button204";
            this.button204.Size = new System.Drawing.Size(100, 50);
            this.button204.TabIndex = 12;
            this.button204.Text = "P204";
            this.button204.UseVisualStyleBackColor = false;
            this.button204.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button107
            // 
            this.button107.BackColor = System.Drawing.Color.Yellow;
            this.button107.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button107.Location = new System.Drawing.Point(180, 296);
            this.button107.Name = "button107";
            this.button107.Size = new System.Drawing.Size(100, 50);
            this.button107.TabIndex = 11;
            this.button107.Text = "P107";
            this.button107.UseVisualStyleBackColor = false;
            this.button107.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button108
            // 
            this.button108.BackColor = System.Drawing.Color.Yellow;
            this.button108.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button108.Location = new System.Drawing.Point(180, 352);
            this.button108.Name = "button108";
            this.button108.Size = new System.Drawing.Size(100, 50);
            this.button108.TabIndex = 10;
            this.button108.Text = "P108";
            this.button108.UseVisualStyleBackColor = false;
            this.button108.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button106
            // 
            this.button106.BackColor = System.Drawing.Color.Yellow;
            this.button106.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button106.Location = new System.Drawing.Point(180, 202);
            this.button106.Name = "button106";
            this.button106.Size = new System.Drawing.Size(100, 50);
            this.button106.TabIndex = 9;
            this.button106.Text = "P106";
            this.button106.UseVisualStyleBackColor = false;
            this.button106.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button105
            // 
            this.button105.BackColor = System.Drawing.Color.Yellow;
            this.button105.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button105.Location = new System.Drawing.Point(180, 146);
            this.button105.Name = "button105";
            this.button105.Size = new System.Drawing.Size(100, 50);
            this.button105.TabIndex = 8;
            this.button105.Text = "P105";
            this.button105.UseVisualStyleBackColor = false;
            this.button105.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button104
            // 
            this.button104.BackColor = System.Drawing.Color.Yellow;
            this.button104.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button104.Location = new System.Drawing.Point(180, 90);
            this.button104.Name = "button104";
            this.button104.Size = new System.Drawing.Size(100, 50);
            this.button104.TabIndex = 7;
            this.button104.Text = "P104";
            this.button104.UseVisualStyleBackColor = false;
            this.button104.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button207
            // 
            this.button207.BackColor = System.Drawing.Color.Yellow;
            this.button207.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button207.Location = new System.Drawing.Point(473, 302);
            this.button207.Name = "button207";
            this.button207.Size = new System.Drawing.Size(100, 100);
            this.button207.TabIndex = 6;
            this.button207.Text = "P207";
            this.button207.UseVisualStyleBackColor = false;
            this.button207.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button201
            // 
            this.button201.BackColor = System.Drawing.Color.Yellow;
            this.button201.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button201.Location = new System.Drawing.Point(317, 302);
            this.button201.Name = "button201";
            this.button201.Size = new System.Drawing.Size(100, 100);
            this.button201.TabIndex = 5;
            this.button201.Text = "P201";
            this.button201.UseVisualStyleBackColor = false;
            this.button201.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button202
            // 
            this.button202.BackColor = System.Drawing.Color.Yellow;
            this.button202.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button202.Location = new System.Drawing.Point(317, 196);
            this.button202.Name = "button202";
            this.button202.Size = new System.Drawing.Size(100, 100);
            this.button202.TabIndex = 4;
            this.button202.Text = "P202";
            this.button202.UseVisualStyleBackColor = false;
            this.button202.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button203
            // 
            this.button203.BackColor = System.Drawing.Color.Yellow;
            this.button203.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button203.Location = new System.Drawing.Point(317, 90);
            this.button203.Name = "button203";
            this.button203.Size = new System.Drawing.Size(100, 100);
            this.button203.TabIndex = 3;
            this.button203.Text = "P203";
            this.button203.UseVisualStyleBackColor = false;
            this.button203.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button101
            // 
            this.button101.BackColor = System.Drawing.Color.Yellow;
            this.button101.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button101.Location = new System.Drawing.Point(39, 302);
            this.button101.Name = "button101";
            this.button101.Size = new System.Drawing.Size(100, 100);
            this.button101.TabIndex = 2;
            this.button101.Text = "P101";
            this.button101.UseVisualStyleBackColor = false;
            this.button101.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button102
            // 
            this.button102.BackColor = System.Drawing.Color.Yellow;
            this.button102.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button102.Location = new System.Drawing.Point(39, 196);
            this.button102.Name = "button102";
            this.button102.Size = new System.Drawing.Size(100, 100);
            this.button102.TabIndex = 1;
            this.button102.Text = "P102";
            this.button102.UseVisualStyleBackColor = false;
            this.button102.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // button103
            // 
            this.button103.BackColor = System.Drawing.Color.Yellow;
            this.button103.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button103.Location = new System.Drawing.Point(39, 90);
            this.button103.Name = "button103";
            this.button103.Size = new System.Drawing.Size(100, 100);
            this.button103.TabIndex = 0;
            this.button103.Text = "P103";
            this.button103.UseVisualStyleBackColor = false;
            this.button103.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sơ Đồ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbCO);
            this.panel2.Controls.Add(this.tbCI);
            this.panel2.Controls.Add(this.tbPhong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(690, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 120);
            this.panel2.TabIndex = 5;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(255, 43);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 60);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Chỉnh Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Check out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Check in";
            // 
            // tbCO
            // 
            this.tbCO.Location = new System.Drawing.Point(89, 83);
            this.tbCO.Name = "tbCO";
            this.tbCO.ReadOnly = true;
            this.tbCO.Size = new System.Drawing.Size(140, 20);
            this.tbCO.TabIndex = 5;
            // 
            // tbCI
            // 
            this.tbCI.Location = new System.Drawing.Point(89, 47);
            this.tbCI.Name = "tbCI";
            this.tbCI.ReadOnly = true;
            this.tbCI.Size = new System.Drawing.Size(140, 20);
            this.tbCI.TabIndex = 4;
            // 
            // tbPhong
            // 
            this.tbPhong.Location = new System.Drawing.Point(291, 12);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.ReadOnly = true;
            this.tbPhong.Size = new System.Drawing.Size(63, 20);
            this.tbPhong.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phòng";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(89, 12);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(140, 20);
            this.tbName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên KH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(690, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(371, 305);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(465, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 61);
            this.panel3.TabIndex = 7;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radioButton1.Location = new System.Drawing.Point(81, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nhân Viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Time";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(885, 504);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 9;
            this.button18.Text = "Thêm DV";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(690, 504);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 10;
            this.button19.Text = "Trả Phòng";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(789, 504);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 11;
            this.button20.Text = "In HĐ";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(260, 38);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(95, 61);
            this.button21.TabIndex = 12;
            this.button21.Text = "Báo Cáo";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(837, 572);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tổng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(837, 601);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tổng Đoàn";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(927, 572);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(134, 20);
            this.tbTotal.TabIndex = 15;
            // 
            // tfXtotal
            // 
            this.tfXtotal.Location = new System.Drawing.Point(927, 598);
            this.tfXtotal.Name = "tfXtotal";
            this.tfXtotal.ReadOnly = true;
            this.tfXtotal.Size = new System.Drawing.Size(134, 20);
            this.tfXtotal.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(981, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sửa DV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1086, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tfXtotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Quản Lý Khách Sạn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem gửiBáoCáoToolStripMenuItem;
        private ToolStripMenuItem đóngToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private ToolStripMenuItem thôngTinThanhToánToolStripMenuItem;
        private ToolStripMenuItem danhSáchKháchQuenToolStripMenuItem;
        private ToolStripMenuItem báoCáoNgàyToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem hàngNhậpToolStripMenuItem;
        private ToolStripMenuItem lịchLàmViệcToolStripMenuItem;
        private ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem bảoDưỡngPhòngToolStripMenuItem;
        private Button btnLogout;
        private Button button2;
        private Panel panel1;
        private Button button102;
        private Button button103;
        private Label label2;
        private Label label1;
        private Button button206;
        private Button button205;
        private Button button204;
        private Button button107;
        private Button button108;
        private Button button106;
        private Button button105;
        private Button button104;
        private Button button207;
        private Button button201;
        private Button button202;
        private Button button203;
        private Button button101;
        private Label label3;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private TextBox tbCO;
        private TextBox tbCI;
        private TextBox tbPhong;
        private Label label5;
        private TextBox tbName;
        private Label label4;
        private DataGridView dataGridView1;
        
        private Button btnEdit;
        private Panel panel3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Label label11;
        private Label label12;
        private TextBox tbTotal;
        private TextBox tfXtotal;
        private System.Windows.Forms.Timer timer1;
        private RadioButton radioButton1;
        private Button button1;

    }
}