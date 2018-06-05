namespace Ma_Di_Tuan
{
    partial class BangDieuKhien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpKhoiTao = new System.Windows.Forms.GroupBox();
            this.btnKhoiTaoMoi = new System.Windows.Forms.Button();
            this.lblToaDoXuatPhat = new System.Windows.Forms.Label();
            this.lblKichThuoc = new System.Windows.Forms.Label();
            this.grpThucHien = new System.Windows.Forms.GroupBox();
            this.chkAmThanh = new System.Windows.Forms.CheckBox();
            this.lblTDBuocTiep = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lblTGThucHien = new System.Windows.Forms.Label();
            this.lblBuocThu = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.cboThoiGianCho = new System.Windows.Forms.ComboBox();
            this.lblThoiGianCho = new System.Windows.Forms.Label();
            this.btnGioiThieu = new System.Windows.Forms.Button();
            this.lblVTMaDangDung = new System.Windows.Forms.Label();
            this.lblVTMaDaQua = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grpKiHieu = new System.Windows.Forms.GroupBox();
            this.lblBuocTiep = new System.Windows.Forms.Label();
            this.picNguaTrang = new System.Windows.Forms.PictureBox();
            this.picNguaDong = new System.Windows.Forms.PictureBox();
            this.picNguaDo = new System.Windows.Forms.PictureBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.grpKhoiTao.SuspendLayout();
            this.grpThucHien.SuspendLayout();
            this.grpKiHieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNguaTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNguaDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNguaDo)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKhoiTao
            // 
            this.grpKhoiTao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKhoiTao.Controls.Add(this.btnKhoiTaoMoi);
            this.grpKhoiTao.Controls.Add(this.lblToaDoXuatPhat);
            this.grpKhoiTao.Controls.Add(this.lblKichThuoc);
            this.grpKhoiTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKhoiTao.ForeColor = System.Drawing.Color.LightGray;
            this.grpKhoiTao.Location = new System.Drawing.Point(3, 2);
            this.grpKhoiTao.Name = "grpKhoiTao";
            this.grpKhoiTao.Size = new System.Drawing.Size(241, 105);
            this.grpKhoiTao.TabIndex = 1;
            this.grpKhoiTao.TabStop = false;
            this.grpKhoiTao.Text = "Khởi tạo";
            // 
            // btnKhoiTaoMoi
            // 
            this.btnKhoiTaoMoi.ForeColor = System.Drawing.Color.Black;
            this.btnKhoiTaoMoi.Location = new System.Drawing.Point(6, 69);
            this.btnKhoiTaoMoi.Name = "btnKhoiTaoMoi";
            this.btnKhoiTaoMoi.Size = new System.Drawing.Size(105, 23);
            this.btnKhoiTaoMoi.TabIndex = 2;
            this.btnKhoiTaoMoi.Text = "Khởi Tạo Mới";
            this.btnKhoiTaoMoi.UseVisualStyleBackColor = true;
            this.btnKhoiTaoMoi.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // lblToaDoXuatPhat
            // 
            this.lblToaDoXuatPhat.AutoSize = true;
            this.lblToaDoXuatPhat.ForeColor = System.Drawing.Color.Silver;
            this.lblToaDoXuatPhat.Location = new System.Drawing.Point(7, 44);
            this.lblToaDoXuatPhat.Name = "lblToaDoXuatPhat";
            this.lblToaDoXuatPhat.Size = new System.Drawing.Size(124, 15);
            this.lblToaDoXuatPhat.TabIndex = 7;
            this.lblToaDoXuatPhat.Text = "Tọa Độ xuất phát: ";
            // 
            // lblKichThuoc
            // 
            this.lblKichThuoc.AutoSize = true;
            this.lblKichThuoc.ForeColor = System.Drawing.Color.Silver;
            this.lblKichThuoc.Location = new System.Drawing.Point(7, 22);
            this.lblKichThuoc.Name = "lblKichThuoc";
            this.lblKichThuoc.Size = new System.Drawing.Size(129, 15);
            this.lblKichThuoc.TabIndex = 7;
            this.lblKichThuoc.Text = "Kich thước bàn cờ: ";
            // 
            // grpThucHien
            // 
            this.grpThucHien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThucHien.Controls.Add(this.chkAmThanh);
            this.grpThucHien.Controls.Add(this.lblTDBuocTiep);
            this.grpThucHien.Controls.Add(this.l);
            this.grpThucHien.Controls.Add(this.lblTGThucHien);
            this.grpThucHien.Controls.Add(this.lblBuocThu);
            this.grpThucHien.Controls.Add(this.btnBatDau);
            this.grpThucHien.Controls.Add(this.cboThoiGianCho);
            this.grpThucHien.Controls.Add(this.lblThoiGianCho);
            this.grpThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThucHien.ForeColor = System.Drawing.Color.LightGray;
            this.grpThucHien.Location = new System.Drawing.Point(3, 248);
            this.grpThucHien.Name = "grpThucHien";
            this.grpThucHien.Size = new System.Drawing.Size(241, 200);
            this.grpThucHien.TabIndex = 0;
            this.grpThucHien.TabStop = false;
            this.grpThucHien.Text = "Thực Hiện";
            // 
            // chkAmThanh
            // 
            this.chkAmThanh.AutoSize = true;
            this.chkAmThanh.Checked = true;
            this.chkAmThanh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAmThanh.ForeColor = System.Drawing.Color.Silver;
            this.chkAmThanh.Location = new System.Drawing.Point(13, 165);
            this.chkAmThanh.Name = "chkAmThanh";
            this.chkAmThanh.Size = new System.Drawing.Size(90, 19);
            this.chkAmThanh.TabIndex = 6;
            this.chkAmThanh.Text = "Âm Thanh";
            this.chkAmThanh.UseVisualStyleBackColor = true;
            // 
            // lblTDBuocTiep
            // 
            this.lblTDBuocTiep.AutoSize = true;
            this.lblTDBuocTiep.ForeColor = System.Drawing.Color.Silver;
            this.lblTDBuocTiep.Location = new System.Drawing.Point(7, 70);
            this.lblTDBuocTiep.Name = "lblTDBuocTiep";
            this.lblTDBuocTiep.Size = new System.Drawing.Size(154, 15);
            this.lblTDBuocTiep.TabIndex = 11;
            this.lblTDBuocTiep.Text = "Tọa độ bước tiếp theo: ";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.ForeColor = System.Drawing.Color.Silver;
            this.l.Location = new System.Drawing.Point(7, 47);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(146, 15);
            this.l.TabIndex = 10;
            this.l.Text = "Tọa độ bước hiện tại: ";
            // 
            // lblTGThucHien
            // 
            this.lblTGThucHien.AutoSize = true;
            this.lblTGThucHien.ForeColor = System.Drawing.Color.Silver;
            this.lblTGThucHien.Location = new System.Drawing.Point(7, 96);
            this.lblTGThucHien.Name = "lblTGThucHien";
            this.lblTGThucHien.Size = new System.Drawing.Size(142, 15);
            this.lblTGThucHien.TabIndex = 7;
            this.lblTGThucHien.Text = "Thời Gian Thực Hiện:";
            // 
            // lblBuocThu
            // 
            this.lblBuocThu.AutoSize = true;
            this.lblBuocThu.ForeColor = System.Drawing.Color.Silver;
            this.lblBuocThu.Location = new System.Drawing.Point(7, 23);
            this.lblBuocThu.Name = "lblBuocThu";
            this.lblBuocThu.Size = new System.Drawing.Size(75, 15);
            this.lblBuocThu.TabIndex = 7;
            this.lblBuocThu.Text = "Bước Thứ: ";
            // 
            // btnBatDau
            // 
            this.btnBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBatDau.Location = new System.Drawing.Point(124, 157);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(102, 34);
            this.btnBatDau.TabIndex = 1;
            this.btnBatDau.Text = "Bắt Đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cboThoiGianCho
            // 
            this.cboThoiGianCho.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cboThoiGianCho.DropDownHeight = 120;
            this.cboThoiGianCho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThoiGianCho.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboThoiGianCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThoiGianCho.ForeColor = System.Drawing.Color.Black;
            this.cboThoiGianCho.FormattingEnabled = true;
            this.cboThoiGianCho.IntegralHeight = false;
            this.cboThoiGianCho.Location = new System.Drawing.Point(124, 122);
            this.cboThoiGianCho.Name = "cboThoiGianCho";
            this.cboThoiGianCho.Size = new System.Drawing.Size(99, 23);
            this.cboThoiGianCho.TabIndex = 5;
            this.cboThoiGianCho.SelectedIndexChanged += new System.EventHandler(this.cboThoiGianCho_SelectedIndexChanged);
            // 
            // lblThoiGianCho
            // 
            this.lblThoiGianCho.AutoSize = true;
            this.lblThoiGianCho.ForeColor = System.Drawing.Color.Silver;
            this.lblThoiGianCho.Location = new System.Drawing.Point(6, 124);
            this.lblThoiGianCho.Name = "lblThoiGianCho";
            this.lblThoiGianCho.Size = new System.Drawing.Size(121, 15);
            this.lblThoiGianCho.TabIndex = 12;
            this.lblThoiGianCho.Text = "Thời Gian chờ (s) ";
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioiThieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGioiThieu.Location = new System.Drawing.Point(6, 24);
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.Size = new System.Drawing.Size(105, 23);
            this.btnGioiThieu.TabIndex = 4;
            this.btnGioiThieu.Text = "Giới Thiệu";
            this.btnGioiThieu.UseVisualStyleBackColor = true;
            this.btnGioiThieu.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblVTMaDangDung
            // 
            this.lblVTMaDangDung.AutoSize = true;
            this.lblVTMaDangDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVTMaDangDung.ForeColor = System.Drawing.Color.Silver;
            this.lblVTMaDangDung.Location = new System.Drawing.Point(46, 67);
            this.lblVTMaDangDung.Name = "lblVTMaDangDung";
            this.lblVTMaDangDung.Size = new System.Drawing.Size(132, 15);
            this.lblVTMaDangDung.TabIndex = 9;
            this.lblVTMaDangDung.Text = "Vị trí Mã đang đứng";
            // 
            // lblVTMaDaQua
            // 
            this.lblVTMaDaQua.AutoSize = true;
            this.lblVTMaDaQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVTMaDaQua.ForeColor = System.Drawing.Color.Silver;
            this.lblVTMaDaQua.Location = new System.Drawing.Point(46, 30);
            this.lblVTMaDaQua.Name = "lblVTMaDaQua";
            this.lblVTMaDaQua.Size = new System.Drawing.Size(124, 15);
            this.lblVTMaDaQua.TabIndex = 8;
            this.lblVTMaDaQua.Text = "Vị trí Mã đã đi qua";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(124, 24);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu Kết Quả";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpKiHieu
            // 
            this.grpKiHieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKiHieu.Controls.Add(this.lblBuocTiep);
            this.grpKiHieu.Controls.Add(this.lblVTMaDangDung);
            this.grpKiHieu.Controls.Add(this.picNguaTrang);
            this.grpKiHieu.Controls.Add(this.picNguaDong);
            this.grpKiHieu.Controls.Add(this.picNguaDo);
            this.grpKiHieu.Controls.Add(this.lblVTMaDaQua);
            this.grpKiHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKiHieu.ForeColor = System.Drawing.Color.LightGray;
            this.grpKiHieu.Location = new System.Drawing.Point(3, 108);
            this.grpKiHieu.Name = "grpKiHieu";
            this.grpKiHieu.Size = new System.Drawing.Size(241, 136);
            this.grpKiHieu.TabIndex = 7;
            this.grpKiHieu.TabStop = false;
            this.grpKiHieu.Text = "Kí Hiệu";
            // 
            // lblBuocTiep
            // 
            this.lblBuocTiep.AutoSize = true;
            this.lblBuocTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuocTiep.ForeColor = System.Drawing.Color.Silver;
            this.lblBuocTiep.Location = new System.Drawing.Point(46, 104);
            this.lblBuocTiep.Name = "lblBuocTiep";
            this.lblBuocTiep.Size = new System.Drawing.Size(150, 15);
            this.lblBuocTiep.TabIndex = 9;
            this.lblBuocTiep.Text = "Bước tiếp theo của Mã";
            // 
            // picNguaTrang
            // 
            this.picNguaTrang.Image = global::Ma_Di_Tuan.Properties.Resources.Ngua_trang;
            this.picNguaTrang.Location = new System.Drawing.Point(9, 21);
            this.picNguaTrang.Name = "picNguaTrang";
            this.picNguaTrang.Size = new System.Drawing.Size(35, 33);
            this.picNguaTrang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNguaTrang.TabIndex = 0;
            this.picNguaTrang.TabStop = false;
            // 
            // picNguaDong
            // 
            this.picNguaDong.Image = global::Ma_Di_Tuan.Properties.Resources.Ngua_Dong1;
            this.picNguaDong.Location = new System.Drawing.Point(9, 95);
            this.picNguaDong.Name = "picNguaDong";
            this.picNguaDong.Size = new System.Drawing.Size(35, 33);
            this.picNguaDong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNguaDong.TabIndex = 0;
            this.picNguaDong.TabStop = false;
            // 
            // picNguaDo
            // 
            this.picNguaDo.Image = global::Ma_Di_Tuan.Properties.Resources.Ngua_do;
            this.picNguaDo.Location = new System.Drawing.Point(9, 59);
            this.picNguaDo.Name = "picNguaDo";
            this.picNguaDo.Size = new System.Drawing.Size(35, 33);
            this.picNguaDo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNguaDo.TabIndex = 0;
            this.picNguaDo.TabStop = false;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChucNang.Controls.Add(this.btnGioiThieu);
            this.grpChucNang.Controls.Add(this.btnLuu);
            this.grpChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChucNang.Location = new System.Drawing.Point(3, 452);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(241, 62);
            this.grpChucNang.TabIndex = 2;
            this.grpChucNang.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // BangDieuKhien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpKiHieu);
            this.Controls.Add(this.grpThucHien);
            this.Controls.Add(this.grpKhoiTao);
            this.Name = "BangDieuKhien";
            this.Size = new System.Drawing.Size(255, 521);
            this.grpKhoiTao.ResumeLayout(false);
            this.grpKhoiTao.PerformLayout();
            this.grpThucHien.ResumeLayout(false);
            this.grpThucHien.PerformLayout();
            this.grpKiHieu.ResumeLayout(false);
            this.grpKiHieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNguaTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNguaDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNguaDo)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKhoiTao;
        private System.Windows.Forms.GroupBox grpThucHien;
        private System.Windows.Forms.PictureBox picNguaTrang;
        private System.Windows.Forms.Label lblThoiGianCho;
        private System.Windows.Forms.Label lblVTMaDangDung;
        private System.Windows.Forms.Label lblVTMaDaQua;
        private System.Windows.Forms.PictureBox picNguaDo;
        public System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.Button btnGioiThieu;
        private System.Windows.Forms.GroupBox grpKiHieu;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Label lblBuocTiep;
        private System.Windows.Forms.PictureBox picNguaDong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblToaDoXuatPhat;
        private System.Windows.Forms.Label lblKichThuoc;
        private System.Windows.Forms.Button btnKhoiTaoMoi;
        private System.Windows.Forms.Label lblBuocThu;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.ComboBox cboThoiGianCho;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lblTDBuocTiep;
        private System.Windows.Forms.CheckBox chkAmThanh;
        private System.Windows.Forms.Label lblTGThucHien;
    }
}
