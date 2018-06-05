/*********************************************************
 * Form Khởi tạo của chương trình
 * khởi tạo kích thước và tọa độ ban đầu cho quân Mã
 * ******************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ma_Di_Tuan.Properties;

namespace Ma_Di_Tuan
{
    public partial class KhoiTao : Form
    {
        public KhoiTao()
        {
            InitializeComponent();

            //Thiết lập hình nền và Icon cho Form
            this.BackgroundImage        = global::Ma_Di_Tuan.Properties.Resources.bg_cuqg;
            this.BackgroundImageLayout  = ImageLayout.Stretch;
            this.Icon                   = global::Ma_Di_Tuan.Properties.Resources.black_chess;
        }

        /// <summary>
        /// Kiểm tra các giá trị khởi tạo
        /// kích thước trong khoảng từ 6 đến 50 và là số chẵn
        /// tọa độ phải dương và nhỏ hơn kích thước
        /// </summary>
        #region Hàm kiểm tra giá trị nhập
        public void KiemTraGiaTriNhap()
        {
            if (int.Parse(txtKichThuoc.Text) <= 5 || int.Parse(txtKichThuoc.Text) > 50)
            {
                MessageBox.Show("Nhập kích thước bàn cờ trong khoảng từ 6 đến 50",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);

                txtKichThuoc.Focus();
            }
            else
            {
                //Giá trị nhập là số chẵn
                if (int.Parse(txtKichThuoc.Text) % 2 != 0)
                {
                    MessageBox.Show("Nhập kích thước là số chẵn",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1);

                    txtKichThuoc.Focus();
                }
                else
                {
                    if (int.Parse(txtToaDoX.Text) <= 0 || int.Parse(txtToaDoX.Text) > int.Parse(txtKichThuoc.Text))
                    {
                        MessageBox.Show("Nhập tọa độ X lớn hơn hoặc bằng 1 và nhỏ hơn hoặc bằng " + this.txtKichThuoc.Text,
                                        "Lỗi",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error,
                                        MessageBoxDefaultButton.Button1);

                        txtToaDoX.Focus();
                    }
                    else
                    {
                        if (int.Parse(txtToaDoY.Text) <= 0 || int.Parse(txtToaDoY.Text) > int.Parse(txtKichThuoc.Text))
                        {
                            MessageBox.Show("Nhập tọa độ Y lớn hơn hoặc bằng 1 và nhỏ hơn hoặc bằng " + this.txtKichThuoc.Text,
                                            "Lỗi",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error,
                                            MessageBoxDefaultButton.Button1);

                            txtToaDoY.Focus();
                        }
                        else
                        {
                            //Nếu giá trị nhập vào hợp lệ
                            Main frmMain = new Main();

                            frmMain.GanGiaTri(int.Parse(txtToaDoX.Text), int.Parse(txtToaDoY.Text), int.Parse(txtKichThuoc.Text));
                            frmMain.KhoiTao();
                            this.Hide();
                            frmMain.Show();
                        }
                    }
                }
            }
        }
        #endregion

        #region Sự Kiện Click nút Nhập
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            //Lưu các tùy chọn
            Settings.Default.InitOntop      = this.chkHienThi.Checked;
            Settings.Default.boolRemember   = this.chkGhiNho.Checked;
            if (chkGhiNho.Checked)
            {
                Settings.Default.txtKT      = this.txtKichThuoc.Text;
                Settings.Default.txtX       = this.txtToaDoX.Text;
                Settings.Default.txtY       = this.txtToaDoY.Text;
            }
            Settings.Default.Save();

            KiemTraGiaTriNhap();
            this.Cursor = Cursors.Default;
        }
        #endregion

        #region Sự kiện click nút Hủy
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Lưu các tùy chọn
            Settings.Default.InitOntop = this.chkHienThi.Checked;
            Settings.Default.boolRemember = this.chkGhiNho.Checked;
            if (chkGhiNho.Checked)
            {
                Settings.Default.txtKT = this.txtKichThuoc.Text;
                Settings.Default.txtX = this.txtToaDoX.Text;
                Settings.Default.txtY = this.txtToaDoY.Text;
            }
            Settings.Default.Save();

            Application.Exit();
        }
        #endregion

        #region Sự Kiện Load Form khởi tại
        private void KhoiTao_Load(object sender, EventArgs e)
        {
            //nếu 1 trong các textBox trống, unEnable nút Ok
            if (txtKichThuoc.Text == "" || txtToaDoX.Text == "" || txtToaDoY.Text == "")
                btnNhap.Enabled = false;
            else
                btnNhap.Enabled = true;

            //Load các tùy chọn của chương trình
            this.chkHienThi.Checked = Settings.Default.InitOntop;
            this.TopMost = this.chkHienThi.Checked;
            this.chkGhiNho.Checked = Settings.Default.boolRemember;
            if (chkGhiNho.Checked)
            {
                this.txtKichThuoc.Text = Settings.Default.txtKT;
                this.txtToaDoX.Text = Settings.Default.txtX;
                this.txtToaDoY.Text = Settings.Default.txtY;
            }

            this.Focus();
            this.txtKichThuoc.Focus();
        }
        #endregion

        #region checkBox1_CheckedChanged
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = this.chkHienThi.Checked;
        }
        #endregion

        //Nếu các textbox đc điền đầy đủ thì Enable button OK
        //Nếu không thì ngược lại
        #region Sự kiện Textchange của các TextBox
        private void txtKT_TextChanged(object sender, EventArgs e)
        {
            if (txtKichThuoc.Text != "" && txtToaDoX.Text != "" && txtToaDoY.Text != "")
                btnNhap.Enabled = true;
            else
                btnNhap.Enabled = false;
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            txtKT_TextChanged(sender, e);
        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {
            txtKT_TextChanged(sender, e);
        }
        #endregion

        //chỉ cho nhập số vào các textBox
        #region sự kiện KeyPress của các TextBox
        private void txtKT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion


    }
}
