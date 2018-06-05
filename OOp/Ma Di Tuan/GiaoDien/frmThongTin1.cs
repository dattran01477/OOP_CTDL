/************************************************************************/
/* Form About: Giới thiệu về người thực hiện và bài toán Mã Đi Tuần     */
/************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ma_Di_Tuan
{
    public partial class ThongTin : Form
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        #region Load Form
        private void AboutForm_Load(object sender, EventArgs e)
        {
            //kích thước mặc định
            this.Height = 545;
            this.Width = 545;

            //Tab select đầu tiên là tab 1: Giới thiệu bài toán
            this.tabCtlGioiThieu.SelectedIndex = 1;

            //Load hình nền cho các tabpage
            this.tabPageTacTia.BackgroundImage = global::Ma_Di_Tuan.Properties.Resources.Nen_do;
            this.tabPageTacTia.BackgroundImageLayout = ImageLayout.Tile;

            this.tabPageMaDiTuan.BackgroundImage = global::Ma_Di_Tuan.Properties.Resources.Nen_do;
            this.tabPageMaDiTuan.BackgroundImageLayout = ImageLayout.Tile;

            //Khởi tạo sự kiện click vào nút OK
            this.btnOk.Click += new EventHandler(button1_Click);
        }
        #endregion

        #region Sự kiện tabControl1_SelectedIndexChanged
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabCtlGioiThieu.SelectedIndex == 0)
            {
                //Kích thước của tab Tác Giả
                this.Height = 277;
                this.Width = 545;

                this.tabPageTacTia.Controls.Add(picLogo);
                this.tabPageTacTia.Controls.Add(lblTieuDe);
                this.lblTieuDe.Text = "SINH VIÊN THỰC HIỆN";
                this.tabPageTacTia.Controls.Add(lblTruong);
                this.tabPageTacTia.Controls.Add(btnOk);
                this.lblTruong.Location = new System.Drawing.Point(32, 195);
                this.btnOk.Location = new System.Drawing.Point(471, 192);
            }
            else
            {
                //Kích thước của tab: Mã Đi Tuần
                this.Height = 555;
                this.Width = 545;

                this.tabPageMaDiTuan.Controls.Add(picLogo);
                this.tabPageMaDiTuan.Controls.Add(lblTieuDe);
                this.lblTieuDe.Text = "GIỚI THIỆU BÀI TOÁN MÃ ĐI TUẦN";
                this.tabPageMaDiTuan.Controls.Add(lblTruong);
                this.tabPageMaDiTuan.Controls.Add(btnOk);
                this.lblTruong.Location = new System.Drawing.Point(32, 475);
                this.btnOk.Location = new System.Drawing.Point(471, 470);
            }

            this.AcceptButton = this.btnOk;
        }
        #endregion

        #region Sự kiện Click button OK
        void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
