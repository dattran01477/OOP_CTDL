/************************************************************************
 * Chương trình Demo bài toán Mã Đi Tuần                                
 * Form chính của chương trình, vẽ và hiển thị từng bước đi của quân Mã 
 * lên bàn cờ vua
 ************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Ma_Di_Tuan.Properties;
using System.Media;
using System.Diagnostics;

namespace Ma_Di_Tuan
{
    //Thời gian
    struct ThoiGian
    {
        public int giay;
        public int phut;
        public int gio;
    };

    public partial class Main : Form
    {
        #region Khai Báo các Biến cần thiết
        private Label[,]        labelSo;                    //mảng các label hiển thị toạn độ của bàn cờ
        private PictureBox[,]   banCo;                      //Mảng Bàn Cờ
        private BangDieuKhien     bangDieuKhien;               //Bảng ddieuf khiển
        private int             kichThuoc;                 //Kích thước bàn cờ
        private int             initX;
        private int             initY;
        private int             chieuRong = 50;
        #endregion

        public Main()
        {
            InitializeComponent();

            //Load hình nền và Icon cho Form
            this.BackgroundImage        = global::Ma_Di_Tuan.Properties.Resources.bg_cuqg;
            this.BackgroundImageLayout  = ImageLayout.Stretch;
            this.Icon                   = global::Ma_Di_Tuan.Properties.Resources.black_chess;
        }

        #region Hàm Gán giá trị
        public void GanGiaTri(int _X, int _Y, int kt)
        {
            initX       = _X;
            initY       = _Y;
            kichThuoc   = kt;
        }
        #endregion

        //vẽ bàn cờ và vị trí đầu tiên của con Mã lên Form
        #region Hàm Khởi Tạo
        public void KhoiTao()
        {
            VeBanCo();

            bangDieuKhien = new BangDieuKhien();
            bangDieuKhien.GanGiaTri(initX, initY, kichThuoc, banCo);
            bangDieuKhien.InitControl();
            bangDieuKhien.MouseWheel += new MouseEventHandler(groupHandle_MouseWheel);
            this.Controls.Add(bangDieuKhien);
            
            //Điều chỉnh kích thước của Form cho phù hợp với kích thước bàn cờ
            this.Width              = 50 + chieuRong * kichThuoc + bangDieuKhien.Width;
            this.WindowState        = FormWindowState.Normal;
            if (kichThuoc <= 10)
            {
                AutoScroll          = false;
                FormBorderStyle     = FormBorderStyle.FixedSingle;
                this.WindowState    = FormWindowState.Normal;
                MaximizeBox         = false;
                bangDieuKhien.Height  = 521;
                this.Height         = labelSo[1, 1].Height + bangDieuKhien.Height + 34;//34 là chiều cao của thanh tiêu đề
            }
            else
            {
                AutoScroll          = true;
                bangDieuKhien.Height  = 555;
                this.Width          += 20;//20 độ rộng của thanh trượt

                if (kichThuoc == 12)
                {
                    //34 là chiều cao của thanh tiêu đề, 20 là chiều cao thanh trượt
                    this.Height         = 2 * labelSo[1, 1].Height + kichThuoc * chieuRong + 34 + 20;
                    this.WindowState    = FormWindowState.Normal;
                }
                else
                {
                    //Nếu kích thước quá lớn thì chiều cao của Form bằng chiều cao của màn hình
                    this.Height             = Screen.PrimaryScreen.WorkingArea.Height - 5;
                    this.WindowState        = FormWindowState.Maximized;
                    this.FormBorderStyle    = FormBorderStyle.Sizable;
                    MaximizeBox             = true;
                }
            }
        }
        #endregion

        #region Hàm Vẽ Bàn Cờ lên Form
        private void VeBanCo()
        {
            //Hiển thị hệ tọa độ cho bàn cờ
            labelSo = new Label[2, kichThuoc];
            for (int i = 0; i < kichThuoc; i++)
            {
                //Toa Do Ngang
                labelSo[1, i] = new Label();
                labelSo[1, i].Font      = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                labelSo[1, i].BackColor = Color.Transparent;
                labelSo[1, i].ForeColor = Color.White;
                labelSo[1, i].AutoSize  = true;
                labelSo[1, i].Location  = new System.Drawing.Point(chieuRong * (i + 1) - 5, 9);
                labelSo[1, i].Name      = i.ToString();
                labelSo[1, i].Size      = new System.Drawing.Size(19, 13);
                labelSo[1, i].TabIndex  = 1;
                labelSo[1, i].Text      = (i + 1).ToString();
                this.Controls.Add(labelSo[1, i]);

                //Toa Do Doc
                labelSo[0, i]           = new Label();
                labelSo[0, i].Font      = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                labelSo[0, i].BackColor = Color.Transparent;
                labelSo[0, i].ForeColor = Color.White;
                labelSo[0, i].AutoSize  = true;
                labelSo[0, i].Location  = new System.Drawing.Point(1, chieuRong * (i + 1) - 5);
                labelSo[0, i].Name      = i.ToString();
                labelSo[0, i].Size      = new System.Drawing.Size(19, 13);
                labelSo[0, i].TabIndex  = 1;
                labelSo[0, i].Text      = (i + 1).ToString();
                this.Controls.Add(labelSo[0, i]);
            }
            //Khai bao vien
            PictureBox picKhungVien              = new PictureBox();
            picKhungVien.Location                = new System.Drawing.Point(30, 30);
            picKhungVien.BackgroundImage         = global::Ma_Di_Tuan.Properties.Resources.chessboard_3;
            picKhungVien.BackgroundImageLayout   = ImageLayout.Stretch;
            picKhungVien.BackColor               = Color.White;
            picKhungVien.Width                   = kichThuoc * chieuRong + 12;
            picKhungVien.Height                  = picKhungVien.Width;
            this.Controls.Add(picKhungVien);

            //vẽ bàn cờ
            banCo = new PictureBox[kichThuoc + 1, kichThuoc + 1];
            for (int i = 1; i <= kichThuoc; i++)
            {
                for (int j = 1; j <= kichThuoc; j++)
                {
                    banCo[i, j] = new PictureBox();

                    //Nếu là ô lẻ thì vẽ nền màu trắng và ngược lại
                    if (i % 2 != 0)
                    {
                        if (j % 2 != 0)
                        {
                            banCo[i, j].BackgroundImage = global::Ma_Di_Tuan.Properties.Resources.Nen_trang;
                        }
                        else
                        {
                            banCo[i, j].BackgroundImage = global::Ma_Di_Tuan.Properties.Resources.Nen_do;
                        }
                    }
                    else
                    {
                        if (j % 2 != 0)
                        {
                            banCo[i, j].BackgroundImage = global::Ma_Di_Tuan.Properties.Resources.Nen_do;
                        }
                        else
                        {
                            banCo[i, j].BackgroundImage = global::Ma_Di_Tuan.Properties.Resources.Nen_trang;
                        }
                    }

                    //Cài đặt một số thuộc tính của picturebox
                    banCo[i, j].Location = new System.Drawing.Point(6 + (j - 1) * chieuRong, 6 + (i - 1) * chieuRong);
                    banCo[i, j].Name = "pictureBox1";
                    banCo[i, j].Size = new System.Drawing.Size(chieuRong, chieuRong);
                    banCo[i, j].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    banCo[i, j].TabIndex = 0;
                    banCo[i, j].TabStop = false;
                    banCo[i, j].MouseHover += new EventHandler(Main_MouseHover);
                    picKhungVien.Controls.Add(banCo[i, j]);
                }
            }
        }
        #endregion

        #region Sự kiện đóng Form
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Lưu lại các tùy chọn trước khi đóng chương trình
            Settings.Default.strTime    = bangDieuKhien.GetTextCombobox();
            Settings.Default.BoolSound  = bangDieuKhien.GetSoundBox();
            Settings.Default.Save();

            Application.Exit();
        }
        #endregion

        //Khi Scroll Form thì di chuyển bảng Điều khiển chạy theo
        #region Các sự kiện MainScroll và MouseHover của các control để điều chỉnh groupbox
        private void Main_Scroll(object sender, ScrollEventArgs e)
        {
            bangDieuKhien.Top = 20;
        }

        private void Main_MouseHover(object sender, EventArgs e)
        {
            bangDieuKhien.Top = 20;
        }

        void groupHandle_MouseWheel(object sender, MouseEventArgs e)
        {
            bangDieuKhien.Top = 20;
        }
        #endregion
    }
}
