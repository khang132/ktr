﻿namespace QLTN
{
    partial class BatDauThi
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
            this.lbl_CauHoi = new System.Windows.Forms.Label();
            this.txt_CauHoi = new System.Windows.Forms.TextBox();
            this.lbl_DapAn = new System.Windows.Forms.Label();
            this.rbtn_A = new System.Windows.Forms.RadioButton();
            this.rbtn_B = new System.Windows.Forms.RadioButton();
            this.rbtn_C = new System.Windows.Forms.RadioButton();
            this.rbtn_D = new System.Windows.Forms.RadioButton();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_D = new System.Windows.Forms.TextBox();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.Gr_Đề = new System.Windows.Forms.GroupBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.Gr_Time = new System.Windows.Forms.GroupBox();
            this.lbl_Giay = new System.Windows.Forms.Label();
            this.lbl_useless1 = new System.Windows.Forms.Label();
            this.lbl_Phut = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_DsCauHoi = new System.Windows.Forms.ComboBox();
            this.btn_Truoc = new System.Windows.Forms.Button();
            this.btn_Sau = new System.Windows.Forms.Button();
            this.btn_Nop = new System.Windows.Forms.Button();
            this.Gr_ThongTin = new System.Windows.Forms.GroupBox();
            this.lbl_MSSV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gr_ThongBao = new System.Windows.Forms.GroupBox();
            this.lbl_ThongBao = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.gr_DapAn = new System.Windows.Forms.GroupBox();
            this.Gr_Đề.SuspendLayout();
            this.Gr_Time.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Gr_ThongTin.SuspendLayout();
            this.Gr_ThongBao.SuspendLayout();
            this.gr_DapAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CauHoi
            // 
            this.lbl_CauHoi.AutoSize = true;
            this.lbl_CauHoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CauHoi.Location = new System.Drawing.Point(11, 9);
            this.lbl_CauHoi.Name = "lbl_CauHoi";
            this.lbl_CauHoi.Size = new System.Drawing.Size(113, 36);
            this.lbl_CauHoi.TabIndex = 0;
            this.lbl_CauHoi.Text = "Câu hỏi";
            // 
            // txt_CauHoi
            // 
            this.txt_CauHoi.Location = new System.Drawing.Point(16, 37);
            this.txt_CauHoi.Multiline = true;
            this.txt_CauHoi.Name = "txt_CauHoi";
            this.txt_CauHoi.Size = new System.Drawing.Size(728, 179);
            this.txt_CauHoi.TabIndex = 1;
            // 
            // lbl_DapAn
            // 
            this.lbl_DapAn.AutoSize = true;
            this.lbl_DapAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DapAn.Location = new System.Drawing.Point(16, 234);
            this.lbl_DapAn.Name = "lbl_DapAn";
            this.lbl_DapAn.Size = new System.Drawing.Size(105, 36);
            this.lbl_DapAn.TabIndex = 2;
            this.lbl_DapAn.Text = "Đáp án";
            // 
            // rbtn_A
            // 
            this.rbtn_A.AutoSize = true;
            this.rbtn_A.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_A.Location = new System.Drawing.Point(6, 44);
            this.rbtn_A.Name = "rbtn_A";
            this.rbtn_A.Size = new System.Drawing.Size(68, 40);
            this.rbtn_A.TabIndex = 3;
            this.rbtn_A.TabStop = true;
            this.rbtn_A.Text = "A";
            this.rbtn_A.UseVisualStyleBackColor = true;
            this.rbtn_A.CheckedChanged += new System.EventHandler(this.rbtn_A_CheckedChanged);
            // 
            // rbtn_B
            // 
            this.rbtn_B.AutoSize = true;
            this.rbtn_B.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_B.Location = new System.Drawing.Point(6, 134);
            this.rbtn_B.Name = "rbtn_B";
            this.rbtn_B.Size = new System.Drawing.Size(67, 40);
            this.rbtn_B.TabIndex = 4;
            this.rbtn_B.TabStop = true;
            this.rbtn_B.Text = "B";
            this.rbtn_B.UseVisualStyleBackColor = true;
            this.rbtn_B.CheckedChanged += new System.EventHandler(this.rbtn_B_CheckedChanged);
            // 
            // rbtn_C
            // 
            this.rbtn_C.AutoSize = true;
            this.rbtn_C.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_C.Location = new System.Drawing.Point(6, 214);
            this.rbtn_C.Name = "rbtn_C";
            this.rbtn_C.Size = new System.Drawing.Size(67, 40);
            this.rbtn_C.TabIndex = 5;
            this.rbtn_C.TabStop = true;
            this.rbtn_C.Text = "C";
            this.rbtn_C.UseVisualStyleBackColor = true;
            this.rbtn_C.CheckedChanged += new System.EventHandler(this.rbtn_C_CheckedChanged);
            // 
            // rbtn_D
            // 
            this.rbtn_D.AutoSize = true;
            this.rbtn_D.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_D.Location = new System.Drawing.Point(6, 289);
            this.rbtn_D.Name = "rbtn_D";
            this.rbtn_D.Size = new System.Drawing.Size(69, 40);
            this.rbtn_D.TabIndex = 6;
            this.rbtn_D.TabStop = true;
            this.rbtn_D.Text = "D";
            this.rbtn_D.UseVisualStyleBackColor = true;
            this.rbtn_D.CheckedChanged += new System.EventHandler(this.rbtn_D_CheckedChanged);
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(72, 44);
            this.txt_A.Multiline = true;
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(635, 46);
            this.txt_A.TabIndex = 7;
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(75, 122);
            this.txt_B.Multiline = true;
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(634, 48);
            this.txt_B.TabIndex = 8;
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(77, 200);
            this.txt_C.Multiline = true;
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(633, 40);
            this.txt_C.TabIndex = 9;
            // 
            // txt_D
            // 
            this.txt_D.Location = new System.Drawing.Point(75, 292);
            this.txt_D.Multiline = true;
            this.txt_D.Name = "txt_D";
            this.txt_D.Size = new System.Drawing.Size(632, 45);
            this.txt_D.TabIndex = 10;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(6, 14);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(101, 25);
            this.lbl_Time.TabIndex = 11;
            this.lbl_Time.Text = "Thời gian";
            // 
            // Gr_Đề
            // 
            this.Gr_Đề.Controls.Add(this.lbl_ID);
            this.Gr_Đề.Controls.Add(this.lbl_DapAn);
            this.Gr_Đề.Controls.Add(this.txt_CauHoi);
            this.Gr_Đề.Controls.Add(this.lbl_CauHoi);
            this.Gr_Đề.Location = new System.Drawing.Point(12, 9);
            this.Gr_Đề.Name = "Gr_Đề";
            this.Gr_Đề.Size = new System.Drawing.Size(778, 591);
            this.Gr_Đề.TabIndex = 12;
            this.Gr_Đề.TabStop = false;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(117, 6);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(174, 61);
            this.lbl_ID.TabIndex = 11;
            this.lbl_ID.Text = "Số câu";
            // 
            // Gr_Time
            // 
            this.Gr_Time.Controls.Add(this.lbl_Giay);
            this.Gr_Time.Controls.Add(this.lbl_useless1);
            this.Gr_Time.Controls.Add(this.lbl_Phut);
            this.Gr_Time.Controls.Add(this.lbl_Time);
            this.Gr_Time.Location = new System.Drawing.Point(850, 9);
            this.Gr_Time.Name = "Gr_Time";
            this.Gr_Time.Size = new System.Drawing.Size(290, 131);
            this.Gr_Time.TabIndex = 13;
            this.Gr_Time.TabStop = false;
            // 
            // lbl_Giay
            // 
            this.lbl_Giay.AutoSize = true;
            this.lbl_Giay.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Giay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Giay.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Giay.ForeColor = System.Drawing.Color.Red;
            this.lbl_Giay.Location = new System.Drawing.Point(160, 39);
            this.lbl_Giay.Name = "lbl_Giay";
            this.lbl_Giay.Size = new System.Drawing.Size(98, 75);
            this.lbl_Giay.TabIndex = 14;
            this.lbl_Giay.Text = "00";
            this.lbl_Giay.Click += new System.EventHandler(this.btn_Nop_Click);
            // 
            // lbl_useless1
            // 
            this.lbl_useless1.AutoSize = true;
            this.lbl_useless1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_useless1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_useless1.ForeColor = System.Drawing.Color.Red;
            this.lbl_useless1.Location = new System.Drawing.Point(97, 40);
            this.lbl_useless1.Name = "lbl_useless1";
            this.lbl_useless1.Size = new System.Drawing.Size(53, 73);
            this.lbl_useless1.TabIndex = 13;
            this.lbl_useless1.Text = ":";
            // 
            // lbl_Phut
            // 
            this.lbl_Phut.AutoSize = true;
            this.lbl_Phut.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Phut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Phut.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phut.ForeColor = System.Drawing.Color.Red;
            this.lbl_Phut.Location = new System.Drawing.Point(11, 39);
            this.lbl_Phut.Name = "lbl_Phut";
            this.lbl_Phut.Size = new System.Drawing.Size(98, 75);
            this.lbl_Phut.TabIndex = 12;
            this.lbl_Phut.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_DsCauHoi);
            this.groupBox1.Location = new System.Drawing.Point(850, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 454);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu: ";
            // 
            // cbb_DsCauHoi
            // 
            this.cbb_DsCauHoi.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_DsCauHoi.FormattingEnabled = true;
            this.cbb_DsCauHoi.Location = new System.Drawing.Point(33, 40);
            this.cbb_DsCauHoi.Name = "cbb_DsCauHoi";
            this.cbb_DsCauHoi.Size = new System.Drawing.Size(211, 50);
            this.cbb_DsCauHoi.TabIndex = 0;
            this.cbb_DsCauHoi.SelectedIndexChanged += new System.EventHandler(this.cbb_DsCauHoi_SelectedIndexChanged);
            this.cbb_DsCauHoi.Click += new System.EventHandler(this.cbb_DsCauHoi_SelectedIndexChanged);
            // 
            // btn_Truoc
            // 
            this.btn_Truoc.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Truoc.Location = new System.Drawing.Point(27, 617);
            this.btn_Truoc.Name = "btn_Truoc";
            this.btn_Truoc.Size = new System.Drawing.Size(243, 68);
            this.btn_Truoc.TabIndex = 15;
            this.btn_Truoc.Text = "Câu trước";
            this.btn_Truoc.UseVisualStyleBackColor = true;
            this.btn_Truoc.Click += new System.EventHandler(this.btn_Truoc_Click);
            // 
            // btn_Sau
            // 
            this.btn_Sau.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sau.Location = new System.Drawing.Point(539, 617);
            this.btn_Sau.Name = "btn_Sau";
            this.btn_Sau.Size = new System.Drawing.Size(251, 68);
            this.btn_Sau.TabIndex = 16;
            this.btn_Sau.Text = "Câu sau";
            this.btn_Sau.UseVisualStyleBackColor = true;
            this.btn_Sau.Click += new System.EventHandler(this.btn_Sau_Click);
            // 
            // btn_Nop
            // 
            this.btn_Nop.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nop.Location = new System.Drawing.Point(1184, 762);
            this.btn_Nop.Name = "btn_Nop";
            this.btn_Nop.Size = new System.Drawing.Size(297, 68);
            this.btn_Nop.TabIndex = 17;
            this.btn_Nop.Text = "Nộp bài";
            this.btn_Nop.UseVisualStyleBackColor = true;
            this.btn_Nop.Click += new System.EventHandler(this.btn_Nop_Click);
            // 
            // Gr_ThongTin
            // 
            this.Gr_ThongTin.Controls.Add(this.lbl_MSSV);
            this.Gr_ThongTin.Controls.Add(this.label2);
            this.Gr_ThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gr_ThongTin.Location = new System.Drawing.Point(1161, 18);
            this.Gr_ThongTin.Name = "Gr_ThongTin";
            this.Gr_ThongTin.Size = new System.Drawing.Size(256, 178);
            this.Gr_ThongTin.TabIndex = 18;
            this.Gr_ThongTin.TabStop = false;
            this.Gr_ThongTin.Text = "Thông tin thí sinh";
            // 
            // lbl_MSSV
            // 
            this.lbl_MSSV.AutoSize = true;
            this.lbl_MSSV.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MSSV.Location = new System.Drawing.Point(47, 101);
            this.lbl_MSSV.Name = "lbl_MSSV";
            this.lbl_MSSV.Size = new System.Drawing.Size(66, 61);
            this.lbl_MSSV.TabIndex = 4;
            this.lbl_MSSV.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV:";
            // 
            // Gr_ThongBao
            // 
            this.Gr_ThongBao.Controls.Add(this.lbl_ThongBao);
            this.Gr_ThongBao.Location = new System.Drawing.Point(1161, 232);
            this.Gr_ThongBao.Name = "Gr_ThongBao";
            this.Gr_ThongBao.Size = new System.Drawing.Size(256, 225);
            this.Gr_ThongBao.TabIndex = 19;
            this.Gr_ThongBao.TabStop = false;
            this.Gr_ThongBao.Text = "Thông báo";
            // 
            // lbl_ThongBao
            // 
            this.lbl_ThongBao.AutoSize = true;
            this.lbl_ThongBao.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongBao.Location = new System.Drawing.Point(47, 51);
            this.lbl_ThongBao.Name = "lbl_ThongBao";
            this.lbl_ThongBao.Size = new System.Drawing.Size(66, 61);
            this.lbl_ThongBao.TabIndex = 6;
            this.lbl_ThongBao.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1161, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 68);
            this.button1.TabIndex = 20;
            this.button1.Text = "Nộp Bài";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.nopbai_Click);
            // 
            // gr_DapAn
            // 
            this.gr_DapAn.Controls.Add(this.rbtn_A);
            this.gr_DapAn.Controls.Add(this.rbtn_B);
            this.gr_DapAn.Controls.Add(this.txt_D);
            this.gr_DapAn.Controls.Add(this.rbtn_C);
            this.gr_DapAn.Controls.Add(this.txt_C);
            this.gr_DapAn.Controls.Add(this.rbtn_D);
            this.gr_DapAn.Controls.Add(this.txt_B);
            this.gr_DapAn.Controls.Add(this.txt_A);
            this.gr_DapAn.Location = new System.Drawing.Point(12, 231);
            this.gr_DapAn.Name = "gr_DapAn";
            this.gr_DapAn.Size = new System.Drawing.Size(744, 348);
            this.gr_DapAn.TabIndex = 21;
            this.gr_DapAn.TabStop = false;
            // 
            // BatDauThi
            // 
            this.ClientSize = new System.Drawing.Size(1496, 769);
            this.Controls.Add(this.gr_DapAn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gr_ThongBao);
            this.Controls.Add(this.Gr_ThongTin);
            this.Controls.Add(this.btn_Nop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Sau);
            this.Controls.Add(this.btn_Truoc);
            this.Controls.Add(this.Gr_Time);
            this.Controls.Add(this.Gr_Đề);
            this.Name = "BatDauThi";
            this.Load += new System.EventHandler(this.BatDauThi_Load);
            this.Gr_Đề.ResumeLayout(false);
            this.Gr_Đề.PerformLayout();
            this.Gr_Time.ResumeLayout(false);
            this.Gr_Time.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Gr_ThongTin.ResumeLayout(false);
            this.Gr_ThongTin.PerformLayout();
            this.Gr_ThongBao.ResumeLayout(false);
            this.Gr_ThongBao.PerformLayout();
            this.gr_DapAn.ResumeLayout(false);
            this.gr_DapAn.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label lbl_CauHoi;
        private System.Windows.Forms.TextBox txt_CauHoi;
        private System.Windows.Forms.Label lbl_DapAn;
        private System.Windows.Forms.RadioButton rbtn_A;
        private System.Windows.Forms.RadioButton rbtn_B;
        private System.Windows.Forms.RadioButton rbtn_C;
        private System.Windows.Forms.RadioButton rbtn_D;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.TextBox txt_D;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.GroupBox Gr_Đề;
        private System.Windows.Forms.GroupBox Gr_Time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Truoc;
        private System.Windows.Forms.Button btn_Sau;
        private System.Windows.Forms.Button btn_Nop;
        private System.Windows.Forms.Label lbl_Giay;
        private System.Windows.Forms.Label lbl_useless1;
        private System.Windows.Forms.GroupBox Gr_ThongTin;
        private System.Windows.Forms.GroupBox Gr_ThongBao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_DsCauHoi;
        private System.Windows.Forms.Label lbl_MSSV;
        private System.Windows.Forms.Label lbl_ThongBao;
        private System.Windows.Forms.Label lbl_Phut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.GroupBox gr_DapAn;
    }
}