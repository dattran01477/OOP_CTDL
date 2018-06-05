namespace Ma_Di_Tuan
{
    partial class KhoiTao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoiTao));
            this.lblKichThuoc = new System.Windows.Forms.Label();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.grpToaDo = new System.Windows.Forms.GroupBox();
            this.txtToaDoY = new System.Windows.Forms.TextBox();
            this.txtToaDoX = new System.Windows.Forms.TextBox();
            this.lblToaDoY = new System.Windows.Forms.Label();
            this.lblToaDoX = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.chkHienThi = new System.Windows.Forms.CheckBox();
            this.chkGhiNho = new System.Windows.Forms.CheckBox();
            this.grpToaDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKichThuoc
            // 
            this.lblKichThuoc.AutoSize = true;
            this.lblKichThuoc.BackColor = System.Drawing.Color.Transparent;
            this.lblKichThuoc.ForeColor = System.Drawing.Color.White;
            this.lblKichThuoc.Location = new System.Drawing.Point(18, 51);
            this.lblKichThuoc.Name = "lblKichThuoc";
            this.lblKichThuoc.Size = new System.Drawing.Size(96, 13);
            this.lblKichThuoc.TabIndex = 0;
            this.lblKichThuoc.Text = "Kích thước bàn cờ";
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Location = new System.Drawing.Point(122, 51);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(197, 20);
            this.txtKichThuoc.TabIndex = 0;
            this.txtKichThuoc.TextChanged += new System.EventHandler(this.txtKT_TextChanged);
            this.txtKichThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKT_KeyPress);
            // 
            // grpToaDo
            // 
            this.grpToaDo.BackColor = System.Drawing.Color.Transparent;
            this.grpToaDo.Controls.Add(this.txtToaDoY);
            this.grpToaDo.Controls.Add(this.txtToaDoX);
            this.grpToaDo.Controls.Add(this.lblToaDoY);
            this.grpToaDo.Controls.Add(this.lblToaDoX);
            this.grpToaDo.ForeColor = System.Drawing.Color.White;
            this.grpToaDo.Location = new System.Drawing.Point(21, 83);
            this.grpToaDo.Name = "grpToaDo";
            this.grpToaDo.Size = new System.Drawing.Size(313, 82);
            this.grpToaDo.TabIndex = 2;
            this.grpToaDo.TabStop = false;
            this.grpToaDo.Text = "Vị trí xuất phát";
            // 
            // txtToaDoY
            // 
            this.txtToaDoY.Location = new System.Drawing.Point(101, 50);
            this.txtToaDoY.Name = "txtToaDoY";
            this.txtToaDoY.Size = new System.Drawing.Size(197, 20);
            this.txtToaDoY.TabIndex = 2;
            this.txtToaDoY.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            this.txtToaDoY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // txtToaDoX
            // 
            this.txtToaDoX.Location = new System.Drawing.Point(101, 21);
            this.txtToaDoX.Name = "txtToaDoX";
            this.txtToaDoX.Size = new System.Drawing.Size(197, 20);
            this.txtToaDoX.TabIndex = 1;
            this.txtToaDoX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            this.txtToaDoX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // lblToaDoY
            // 
            this.lblToaDoY.AutoSize = true;
            this.lblToaDoY.Location = new System.Drawing.Point(23, 53);
            this.lblToaDoY.Name = "lblToaDoY";
            this.lblToaDoY.Size = new System.Drawing.Size(52, 13);
            this.lblToaDoY.TabIndex = 1;
            this.lblToaDoY.Text = "Tọa độ Y";
            // 
            // lblToaDoX
            // 
            this.lblToaDoX.AutoSize = true;
            this.lblToaDoX.Location = new System.Drawing.Point(23, 24);
            this.lblToaDoX.Name = "lblToaDoX";
            this.lblToaDoX.Size = new System.Drawing.Size(52, 13);
            this.lblToaDoX.TabIndex = 0;
            this.lblToaDoX.Text = "Tọa độ X";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(143, 192);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(244, 192);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Silver;
            this.lblTieuDe.Location = new System.Drawing.Point(18, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(321, 16);
            this.lblTieuDe.TabIndex = 5;
            this.lblTieuDe.Text = "Chương Trình Mô Phỏng Bài Toán Mã Đi Tuần";
            // 
            // chkHienThi
            // 
            this.chkHienThi.AutoSize = true;
            this.chkHienThi.BackColor = System.Drawing.Color.Transparent;
            this.chkHienThi.Checked = true;
            this.chkHienThi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHienThi.ForeColor = System.Drawing.Color.Silver;
            this.chkHienThi.Location = new System.Drawing.Point(12, 196);
            this.chkHienThi.Name = "chkHienThi";
            this.chkHienThi.Size = new System.Drawing.Size(121, 17);
            this.chkHienThi.TabIndex = 6;
            this.chkHienThi.Text = "Luôn hiện trên cùng";
            this.chkHienThi.UseVisualStyleBackColor = false;
            this.chkHienThi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkGhiNho
            // 
            this.chkGhiNho.AutoSize = true;
            this.chkGhiNho.BackColor = System.Drawing.Color.Transparent;
            this.chkGhiNho.Checked = true;
            this.chkGhiNho.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGhiNho.ForeColor = System.Drawing.Color.Silver;
            this.chkGhiNho.Location = new System.Drawing.Point(12, 175);
            this.chkGhiNho.Name = "chkGhiNho";
            this.chkGhiNho.Size = new System.Drawing.Size(65, 17);
            this.chkGhiNho.TabIndex = 6;
            this.chkGhiNho.Text = "Ghi Nhớ";
            this.chkGhiNho.UseVisualStyleBackColor = false;
            this.chkGhiNho.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // KhoiTao
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 220);
            this.Controls.Add(this.chkGhiNho);
            this.Controls.Add(this.chkHienThi);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.grpToaDo);
            this.Controls.Add(this.txtKichThuoc);
            this.Controls.Add(this.lblKichThuoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KhoiTao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khởi Tạo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.KhoiTao_Load);
            this.grpToaDo.ResumeLayout(false);
            this.grpToaDo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKichThuoc;
        private System.Windows.Forms.TextBox txtKichThuoc;
        private System.Windows.Forms.GroupBox grpToaDo;
        private System.Windows.Forms.TextBox txtToaDoY;
        private System.Windows.Forms.TextBox txtToaDoX;
        private System.Windows.Forms.Label lblToaDoY;
        private System.Windows.Forms.Label lblToaDoX;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.CheckBox chkHienThi;
        private System.Windows.Forms.CheckBox chkGhiNho;
    }
}