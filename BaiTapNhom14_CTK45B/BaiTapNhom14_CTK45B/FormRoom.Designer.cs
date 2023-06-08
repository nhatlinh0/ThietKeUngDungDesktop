namespace BaiTapNhom14_CTK45B
{
    partial class FormRoom
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
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChuaSD = new System.Windows.Forms.Button();
            this.btnDangSD = new System.Windows.Forms.Button();
            this.btnDaDat = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dtpTraPhong = new System.Windows.Forms.DateTimePicker();
            this.dtpNhanPhong = new System.Windows.Forms.DateTimePicker();
            this.dtpDatPhong = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnSuDung = new System.Windows.Forms.Button();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtTang = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThietLap = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpRoom
            // 
            this.flpRoom.Location = new System.Drawing.Point(2, 153);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(351, 293);
            this.flpRoom.TabIndex = 9;
            // 
            // btnChuaSD
            // 
            this.btnChuaSD.BackColor = System.Drawing.SystemColors.Control;
            this.btnChuaSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuaSD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChuaSD.Location = new System.Drawing.Point(2, 120);
            this.btnChuaSD.Name = "btnChuaSD";
            this.btnChuaSD.Size = new System.Drawing.Size(88, 27);
            this.btnChuaSD.TabIndex = 10;
            this.btnChuaSD.Text = "Chưa sử dụng";
            this.btnChuaSD.UseVisualStyleBackColor = false;
            this.btnChuaSD.Click += new System.EventHandler(this.btnChuaSD_Click);
            // 
            // btnDangSD
            // 
            this.btnDangSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangSD.Location = new System.Drawing.Point(96, 120);
            this.btnDangSD.Name = "btnDangSD";
            this.btnDangSD.Size = new System.Drawing.Size(87, 27);
            this.btnDangSD.TabIndex = 11;
            this.btnDangSD.Text = "Đang sử dụng";
            this.btnDangSD.UseVisualStyleBackColor = true;
            this.btnDangSD.Click += new System.EventHandler(this.btnDangSD_Click);
            // 
            // btnDaDat
            // 
            this.btnDaDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaDat.Location = new System.Drawing.Point(189, 120);
            this.btnDaDat.Name = "btnDaDat";
            this.btnDaDat.Size = new System.Drawing.Size(74, 27);
            this.btnDaDat.TabIndex = 12;
            this.btnDaDat.Text = "Đã đặt";
            this.btnDaDat.UseVisualStyleBackColor = true;
            this.btnDaDat.Click += new System.EventHandler(this.btnDaDat_Click);
            // 
            // btnTatCa
            // 
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Location = new System.Drawing.Point(269, 120);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(84, 27);
            this.btnTatCa.TabIndex = 13;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnDangBaoTri_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.dtpTraPhong);
            this.panel1.Controls.Add(this.dtpNhanPhong);
            this.panel1.Controls.Add(this.dtpDatPhong);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnDatPhong);
            this.panel1.Controls.Add(this.btnSuDung);
            this.panel1.Controls.Add(this.txtCCCD);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.txtTang);
            this.panel1.Controls.Add(this.txtLoaiPhong);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.txtIDPhong);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(375, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 434);
            this.panel1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Ngày trả phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ngày đặt phòng:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(25, 275);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 13);
            this.label.TabIndex = 43;
            this.label.Text = "Ngày nhận phòng:";
            // 
            // dtpTraPhong
            // 
            this.dtpTraPhong.CustomFormat = "dd/MM/yyyy";
            this.dtpTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTraPhong.Location = new System.Drawing.Point(126, 296);
            this.dtpTraPhong.Name = "dtpTraPhong";
            this.dtpTraPhong.Size = new System.Drawing.Size(156, 20);
            this.dtpTraPhong.TabIndex = 42;
            // 
            // dtpNhanPhong
            // 
            this.dtpNhanPhong.CustomFormat = "dd/MM/yyyy";
            this.dtpNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNhanPhong.Location = new System.Drawing.Point(126, 269);
            this.dtpNhanPhong.Name = "dtpNhanPhong";
            this.dtpNhanPhong.Size = new System.Drawing.Size(156, 20);
            this.dtpNhanPhong.TabIndex = 41;
            // 
            // dtpDatPhong
            // 
            this.dtpDatPhong.CustomFormat = "dd/MM/yyyy";
            this.dtpDatPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatPhong.Location = new System.Drawing.Point(126, 242);
            this.dtpDatPhong.Name = "dtpDatPhong";
            this.dtpDatPhong.Size = new System.Drawing.Size(156, 20);
            this.dtpDatPhong.TabIndex = 40;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(264, 336);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 39;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(182, 336);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 38;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(101, 336);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(75, 23);
            this.btnDatPhong.TabIndex = 37;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnSuDung
            // 
            this.btnSuDung.Location = new System.Drawing.Point(19, 336);
            this.btnSuDung.Name = "btnSuDung";
            this.btnSuDung.Size = new System.Drawing.Size(75, 23);
            this.btnSuDung.TabIndex = 36;
            this.btnSuDung.Text = "Sử dụng";
            this.btnSuDung.UseVisualStyleBackColor = true;
            this.btnSuDung.Click += new System.EventHandler(this.btnSuDung_Click);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(126, 205);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(100, 20);
            this.txtCCCD.TabIndex = 35;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(126, 172);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 34;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(126, 138);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(111, 20);
            this.txtTenKH.TabIndex = 33;
            // 
            // txtTang
            // 
            this.txtTang.Location = new System.Drawing.Point(126, 101);
            this.txtTang.Name = "txtTang";
            this.txtTang.ReadOnly = true;
            this.txtTang.Size = new System.Drawing.Size(100, 20);
            this.txtTang.TabIndex = 32;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(126, 62);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.ReadOnly = true;
            this.txtLoaiPhong.Size = new System.Drawing.Size(100, 20);
            this.txtLoaiPhong.TabIndex = 31;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(126, 33);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 30;
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Location = new System.Drawing.Point(126, 11);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.ReadOnly = true;
            this.txtIDPhong.Size = new System.Drawing.Size(156, 20);
            this.txtIDPhong.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "CCCD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "SDT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tên khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tầng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Loại phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Trạng thái:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID Phòng:";
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(96, 22);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiPhong.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Loại phòng:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(96, 58);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThietLap
            // 
            this.btnThietLap.Location = new System.Drawing.Point(241, 23);
            this.btnThietLap.Name = "btnThietLap";
            this.btnThietLap.Size = new System.Drawing.Size(91, 23);
            this.btnThietLap.TabIndex = 18;
            this.btnThietLap.Text = "Thiết lập phòng";
            this.btnThietLap.UseVisualStyleBackColor = true;
            this.btnThietLap.Click += new System.EventHandler(this.btnThietLap_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(241, 53);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(91, 23);
            this.btnBaoCao.TabIndex = 19;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnThietLap);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbLoaiPhong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTatCa);
            this.Controls.Add(this.btnDaDat);
            this.Controls.Add(this.btnDangSD);
            this.Controls.Add(this.btnChuaSD);
            this.Controls.Add(this.flpRoom);
            this.Name = "FormRoom";
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.FormRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Button btnChuaSD;
        private System.Windows.Forms.Button btnDangSD;
        private System.Windows.Forms.Button btnDaDat;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDPhong;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnSuDung;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dtpTraPhong;
        private System.Windows.Forms.DateTimePicker dtpNhanPhong;
        private System.Windows.Forms.DateTimePicker dtpDatPhong;
        private System.Windows.Forms.ComboBox cbbLoaiPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThietLap;
        private System.Windows.Forms.Button btnBaoCao;
    }
}

