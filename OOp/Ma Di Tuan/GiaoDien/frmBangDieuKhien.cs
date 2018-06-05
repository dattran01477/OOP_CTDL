/************************************************************************/
/* Chương trình Demo bài toán Mã Đi Tuần                                */
/* Class BangDieuKhien chứa các control khiển chương trình                */
/************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ma_Di_Tuan.Properties;
using System.Diagnostics;
using System.Media;
using System.IO;

namespace Ma_Di_Tuan
{
    public partial class BangDieuKhien : UserControl
    {
        #region Khai Báo các Biến cần thiết
        private string[]        outPut = new string[5];
        private ThoiGian        thoiGianChay;                 //Thời gian chạy chương trình
        private int             kichThuoc;                      //Kích thước bàn cờ
        private PictureBox[,]   banCo;
        private int             initX, x;
        private int             initY, y;
        private int[,]          vt = new int[2, 2501];          //Mảng lưu Vị trí của quân Mã
        private int             chieuRong = 50;
        private bool            dung = false;                   //Tuy chon Start hay Stop
        private int             buoc = 0;                       //So buoc di cua Ma
        #endregion

        public BangDieuKhien()
        {
            InitializeComponent();

            cboThoiGianCho.Items.Add("0.5");
            for (int i = 1; i < 6; i++)
            {
                cboThoiGianCho.Items.Add(i);
            }
            cboThoiGianCho.Text = Settings.Default.strTime;

            VisiblePictureBox();
            this.btnBatDau.Focus();
        }

        #region Hàm Gan gia tri
        public void GanGiaTri(int _initX,int _initY,int KT,PictureBox[,] _banCo)
        {
            initX       =   _initX;
            initY       =   _initY;
            kichThuoc   =   KT;
            banCo       =   _banCo;
        }
        #endregion

        #region Các Hàm Get
        public bool GetSoundBox()
        {
            return this.chkAmThanh.Checked;
        }

        public string GetTextCombobox()
        {
            return this.cboThoiGianCho.Text;
        }
        #endregion

        //Ẩn voi thoi gian cho < 2
        #region Hiển thị bảng điều khiển
        public void VisiblePictureBox()
        {
            if (cboThoiGianCho.Text == "0.5" || cboThoiGianCho.Text == "1")
            {
                picNguaDong.Visible =   false;
                lblBuocTiep.Visible      =   false;
                grpKiHieu.Height    =   103;
                grpThucHien.Top       =   218;
                grpChucNang.Top       =   422;
            }
            else
            {
                picNguaDong.Visible =   true;
                lblBuocTiep.Visible      =   true;
                grpKiHieu.Height    =   136;
                grpThucHien.Top       =   248;
                grpChucNang.Top       =   452;
            }
        }
        #endregion

        //Khởi tạo các Control
        #region Khời tạo các control
        public void InitControl()
        {
            //Đi Tuần
            MaDiTuan maDiTuan = new MaDiTuan();
            maDiTuan.SetGT(initX, initY, kichThuoc);
            maDiTuan.DiTuan();
            vt = maDiTuan._vt;

            this.Top                    =   20;
            this.Left                   =   30 + 17 + chieuRong * kichThuoc;
            this.lblKichThuoc.Text             +=  kichThuoc.ToString() + " x " + kichThuoc.ToString();
            this.lblToaDoXuatPhat.Text          +=  "(" + initX.ToString() + " ; " + initY.ToString() + ")";
            this.lblBuocThu.Text           +=  "1";
            this.l.Text          +=  "(" + initX.ToString() + " ; " + initY.ToString() + ")";
            this.lblTDBuocTiep.Text           +=  "(" + vt[0, 1].ToString() + " ; " + vt[1, 1].ToString() + ")";
            this.lblTGThucHien.Text           =   "Thời Gian Thực Hiện: 0: 0: 0";
            this.btnLuu.Enabled        =   false;

            //Load các tùy chọn đã đc lưu ở lần chạy trước
            this.cboThoiGianCho.Text         = Settings.Default.strTime;
            this.chkAmThanh.Checked  = Settings.Default.BoolSound;

            //Đặt con Mã vào ô đầu tiên trên bàn cờ
            banCo[initX, initY].Image = global::Ma_Di_Tuan.Properties.Resources.Ngua_do;
            if (this.cboThoiGianCho.Text != "0.5" && int.Parse(this.cboThoiGianCho.Text) > 1)
            {
                banCo[vt[0, 1], vt[1, 1]].Image = global::Ma_Di_Tuan.Properties.Resources.Ngua_Dong;
            }

            if (this.chkAmThanh.Checked)
            {
                PlaySound(global::Ma_Di_Tuan.Properties.Resources.ReadyGo);
            }

            //Lưu kết quả vào mảng outPut để tiện cho lúc xuất file
            outPut[0]   = "Kích Thước Bàn Cờ: " + kichThuoc.ToString() + " x " + kichThuoc.ToString();
            outPut[1]   = "Tọa Độ Xuất Phát: (" + initX.ToString() + "; " + initY.ToString() + ")";

            x           = initX;
            y           = initY;
            buoc        = 1;
            dung        = false;

            //Khởi tạo giá trị thời gian =0
            thoiGianChay      = new ThoiGian();
            thoiGianChay.gio = 0;
            thoiGianChay.phut  = 0;
            thoiGianChay.giay  = 0;
        }
        #endregion

        #region Hàm Play Sound
        public void PlaySound(System.IO.UnmanagedMemoryStream fileName)
        {
            SoundPlayer sound = new SoundPlayer(fileName);
            sound.LoadAsync();
            sound.Play();
        }
        #endregion

        //Xóa tất cả quân mã ra khỏi bàn cờ
        #region Hàm Xóa quân Mã
        private void XoaCacQuanMa()
        {
            for (int i = 1; i <= kichThuoc; i++)
                for (int j = 1; j <= kichThuoc; j++)
                    banCo[i, j].Image = null;
        }
        #endregion

        #region Sự kiện click vào nút khởi tạo mới
        private void btnInit_Click(object sender, EventArgs e)
        {
            //Đưa ra thông báo xác nhận
            DialogResult a = MessageBox.Show("Bạn có muốn khởi tạo lại bàn cờ?",
                                            "Thông Báo",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button1);

            if (a == DialogResult.Yes)
            {
                //chạy chương trình mới và tắt cửa sổ hiện tại đi
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }
        #endregion

        #region Sự kiện click vào nút bắt đầu
        private void btnStart_Click(object sender, EventArgs e)
        {
            //khi chạy lại thì đưa giá trị thời gian về 0
            if (this.btnBatDau.Text == "Bắt Đầu")
            {
                thoiGianChay      = new ThoiGian();
                thoiGianChay.gio = 0;
                thoiGianChay.phut  = 0;
                thoiGianChay.giay  = 0;

                this.lblTGThucHien.Text = "Thời Gian Thực Hiện: " + thoiGianChay.gio.ToString() + ": "
                                            + thoiGianChay.phut.ToString() + ": " + thoiGianChay.giay.ToString();
            }

            if (dung == false)
            {
                dung = true;
                this.btnBatDau.Text = "Tạm Dừng";
                timer1.Enabled = true;
                if (buoc == 1)
                {
                    timer2.Enabled = true;
                }

                cboThoiGianCho_SelectedIndexChanged(null, null);

                //Lam An cac Nut dieu khien neu con Ma dang di tuan
                this.btnKhoiTaoMoi.Enabled = false;
                this.btnLuu.Enabled = false;
                //this.comboBox1.Enabled = false;
            }
            else
            {
                dung                    = false;
                this.btnBatDau.Text      = "Tiếp Tục";
                this.btnKhoiTaoMoi.Enabled    = true;
                timer1.Enabled          = false;
                timer2.Enabled          = false;
            }
        }
        #endregion

        // Lưu kết quả chương trình vào file text
        #region Click vào nút lưu kết quả
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Khởi tạo SavefileDialog
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt";

            //Nhấn Ok khi lưu
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter str = new StreamWriter(save.FileName);

                //Thông tin khởi tạo chương trình đc lưu trong mảng outPut
                for (int i = 0; i < 5; i++)
                {
                    str.WriteLine(outPut[i]);
                }

                //Tọa độ các bước đi của quân Mã
                str.WriteLine(str.NewLine + "Tọa Độ Các Bước Đi:");
                for (int i = 1; i < kichThuoc * kichThuoc; i++)
                {
                    str.WriteLine("bước " + i.ToString() + ": (" + vt[0, i].ToString() + " ; " + vt[1, i].ToString() + ")");
                }
                str.WriteLine("Kết Thúc...");
                str.Close();
            }
        }
        #endregion

        #region Click nút giới thiệu
        private void btnAbout_Click(object sender, EventArgs e)
        {
            ThongTin frmThongTin = new ThongTin();
            frmThongTin.ShowDialog();
        }
        #endregion

        #region sự kiện cboThoiGianCho_SelectindexChange
        private void cboThoiGianCho_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.VisiblePictureBox();

            //Thiết lập cho thuộc tính Interval của timer
            if (this.cboThoiGianCho.Text == "0.5")
            {
                timer1.Interval = 500;
            }
            else
            {
                timer1.Interval = int.Parse(this.cboThoiGianCho.Text) * 1000;
            }

            if (this.cboThoiGianCho.Text != "0.5" && int.Parse(this.cboThoiGianCho.Text) > 1 && buoc == 1)
            {
                banCo[vt[0, 1], vt[1, 1]].Image = global::Ma_Di_Tuan.Properties.Resources.Ngua_Dong;
            }
            else
            {
                if (buoc == 1)
                    banCo[vt[0, 1], vt[1, 1]].Image = null;
            }
        }
        #endregion

        #region Timer1_Tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (buoc == 0)
            {
                //Nếu bước == 0 thì đi tuần lại
                buoc++;
                XoaCacQuanMa();
                timer2.Enabled              = true;
                banCo[initX, initY].Image   = global::Ma_Di_Tuan.Properties.Resources.Ngua_do;
            }
            else
            {
                //Nếu buoc!=0 thì lần lượt cho con Mã đi từng bước một
                banCo[x, y].Image   = global::Ma_Di_Tuan.Properties.Resources.Ngua_trang;
                x                   = vt[0, buoc];
                y                   = vt[1, buoc];
                banCo[x, y].Image   = global::Ma_Di_Tuan.Properties.Resources.Ngua_do;

                //Bật tiếng kêu sau mỗi bước đi (Nếu âm thanh đc bật)
                if (this.chkAmThanh.Checked)
                {
                    PlaySound(global::Ma_Di_Tuan.Properties.Resources.MoveFinish);
                }

                //Cập nhật kết quả lên bảng điều khiển
                this.lblBuocThu.Text   = "Bước Thứ: " + (buoc + 1).ToString();
                this.l.Text  = "Tọa độ bước hiện tại: (" + x.ToString() + " ; " + y.ToString() + ")";
                buoc++;
                this.lblTDBuocTiep.Text   = "Tọa độ bước tiếp theo: (" + vt[0, buoc].ToString() + " ; " +
                                            vt[1, buoc].ToString() + ")";


                //Đi hết bàn cờ
                if (buoc == kichThuoc * kichThuoc)
                {
                    dung                = false;
                    timer2.Enabled      = false;
                    timer1.Enabled      = false;
                    this.btnBatDau.Text  = "Bắt Đầu";

                    //Bật tiếng ngựa Hí khi đi hết bàn cờ
                    if (this.chkAmThanh.Checked)
                        PlaySound(global::Ma_Di_Tuan.Properties.Resources.CavarlyEat);

                    //Cập nhật kết quả cuối cùng lên bảng điều khiển
                    this.l.Text  = "Tọa độ bước cuối cùng: (" + x.ToString() + " ; " + y.ToString() + ")";
                    this.lblTDBuocTiep.Text   = "Tọa độ bước tiếp theo: Finished";

                    //gán kết quả cuối cùng vào mảng outPut
                    outPut[2] = "Tọa Độ Kết Thúc: ( " + x.ToString() + "; " + y.ToString() + ")";
                    outPut[3] = "Tổng Số Bước: " + buoc.ToString();
                    outPut[4] = "Thời Gian Hoàn Thành: " + thoiGianChay.gio.ToString() + " giờ " +
                                thoiGianChay.phut.ToString() + " phút " + thoiGianChay.giay.ToString() + " giây";

                    //đưa tất cả các chuỗi trong mảng outPut vào biến temp để đưa kết quả ra MessageBox
                    string temp = "";
                    for (int i = 0; i < 5; i++)
                        temp += outPut[i] + "\n";

                    this.Focus();
                    DialogResult result = MessageBox.Show(temp, "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);

                    XoaCacQuanMa();
                    banCo[initX, initY].Image = global::Ma_Di_Tuan.Properties.Resources.Ngua_do;
                    if (this.cboThoiGianCho.Text != "0.5" && int.Parse(this.cboThoiGianCho.Text) > 1)
                        banCo[vt[0, 1], vt[1, 1]].Image = global::Ma_Di_Tuan.Properties.Resources.Ngua_Dong;

                    if (this.chkAmThanh.Checked)
                        PlaySound(global::Ma_Di_Tuan.Properties.Resources.ReadyGo);

                    //
                    //Reset lại các giá trị ban đầu
                    //
                    buoc                    = 0;
                    x                       = initX;
                    y                       = initY;

                    this.btnLuu.Enabled    = true;
                    this.btnKhoiTaoMoi.Enabled    = true;
                    this.lblBuocThu.Text       = "Bước Thứ: 1";
                    this.lblTGThucHien.Text       = "Thời Gian Thực Hiện: 0: 0: 0";
                    this.l.Text      = "Tọa độ bước hiện tại: (" + x.ToString() + " ; " + y.ToString() + ")";
                    buoc++;
                    this.lblTDBuocTiep.Text       = "Tọa độ bước tiếp theo: (" + vt[0, buoc].ToString() + " ; " +
                                                       vt[1, buoc].ToString() + ")";
                }
            }
        }
        #endregion

        #region Timer2_tick
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (thoiGianChay.giay++ >= 59)
            {
                thoiGianChay.giay = 0;
                thoiGianChay.phut++;
                if (thoiGianChay.phut >= 59)
                {
                    thoiGianChay.phut = 0;
                    thoiGianChay.gio++;
                }
            }

            this.lblTGThucHien.Text = "Thời Gian Thực Hiện: " + thoiGianChay.gio.ToString() + ": " +
                                        thoiGianChay.phut.ToString() + ": " + thoiGianChay.giay.ToString();

            if (this.cboThoiGianCho.Text != "0.5" && int.Parse(this.cboThoiGianCho.Text) > 1)
                banCo[vt[0, buoc], vt[1, buoc]].Image = global::Ma_Di_Tuan.Properties.Resources.Ngua_Dong;
        }
        #endregion


    }
} 
