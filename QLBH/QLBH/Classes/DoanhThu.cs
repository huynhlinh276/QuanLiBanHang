using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLBH
{
    class DoanhThu
    {
        private DataGridView dgv;
        private TextBox[] txt;
        private Connection con;
        private string ngay, thang, nam;
        private string lenh_all;
        public DoanhThu() { }
        public DoanhThu(DataGridView _dgv,TextBox[] _txt)
        {
            dgv = _dgv;
            txt = _txt;
        }
        public string LENH_ALL
        {
            get { return lenh_all; }
            set { lenh_all = value; }
        }
        public void Load()
        {
            foreach (TextBox pt in txt)
            {
                pt.ResetText();
                pt.Enabled = false;
            }
            con = new Connection();
        }
        public void SLHD_DoanhThu(string symbol_1,string symbol_2,string symbol_3)
        {
            lenh_all= @" SELECT COUNT( Distinct ChiTietHoaDon.MaHD) as SLHD,SUM(Soluong*DonGia) as TongTien 
                         FROM HoaDon,ChiTietHoaDon,SANPHAM 
                         WHERE HoaDon.MaHD=ChiTietHoaDon.MaHD 
                         AND ChiTietHoaDon.MaSP=SANPHAM.MaSP  ";
            lenh_all+= " AND DAY(NgayLapHD)"+symbol_1+"'" + ngay + "' ";
            lenh_all+= " AND MONTH(NgayLapHD)"+symbol_2+"'" + thang + "'";               
            lenh_all += " AND YEAR(NgayLapHD)" + symbol_3 + "'" + nam + "'";
        }
        public void Show(string symbol_1, string symbol_2, string symbol_3)
        {
             lenh_all=@" SELECT ChiTietHoaDon.MaHD,HoaDon.MaKH,HoaDon.MaNV,SUM(Soluong*DonGia) as 'Tổng Tiền' 
                     FROM HoaDon,ChiTietHoaDon,SANPHAM 
                     WHERE HoaDon.MaHD=ChiTietHoaDon.MaHD 
                     AND ChiTietHoaDon.MaSP=SANPHAM.MaSP ";
             lenh_all += " AND DAY(NgayLapHD)" + symbol_1 + "'" + ngay + "'";
             lenh_all += " AND MONTH(NgayLapHD)" + symbol_2 + "'" + thang + "'";
             lenh_all += " AND YEAR(NgayLapHD)" + symbol_3 + "'" + nam + "'";
             lenh_all += @" GROUP BY ChiTietHoaDon.MaHD,HoaDon.MaKH,HoaDon.MaNV         
                             ORDER BY SUM(Soluong*DonGia) ASC ";  
        }
        public void NgayNay()
        {
            for (int i = 0; i < txt.Length; i++)
            {
                txt[i].ResetText();
                txt[i].Enabled = false;
            }
            txt[0].Text=ngay = System.DateTime.Now.Day.ToString();
            txt[1].Text=thang = System.DateTime.Now.Month.ToString();
            txt[2].Text=nam = System.DateTime.Now.Year.ToString();
        }
        public void ThangNay()
        {
            for (int i = 0; i < txt.Length; i++)
            {
                txt[i].ResetText();
                txt[i].Enabled = false;
            }
            ngay = "31";
            txt[0].Text = thang = System.DateTime.Now.Month.ToString();
            txt[1].Text = nam = System.DateTime.Now.Year.ToString();
        }
        public void NamNay()
        {
            for (int i = 0; i < txt.Length; i++)
            {
                txt[i].ResetText();
                txt[i].Enabled = false;
            }
            ngay = "31";
            thang = "12";
            txt[0].Text = thang = System.DateTime.Now.Year.ToString();
        }
        public void Khac(int end)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                txt[i].ResetText();
                if (i <end)
                    txt[i].Enabled = true;
            }
        }
        public bool KT(char loai, TextBox d, TextBox m, TextBox y)
        {
            if (loai == 'd'&&d.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ( Ngày ) vui lòng nhập ngày !", "Thông Báo");
                d.Focus();
                return false;
            }
            else
            {
                if (loai == 'm'&&m.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập ( Tháng ) vui lòng nhập tháng !", "Thông Báo");
                    m.Focus();
                    return false;
                }
                else
                {
                    if (y.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập ( Năm ) vui lòng nhập năm !", "Thông Báo");
                        y.Focus();
                        return false;
                    }
                    else
                        return true;
                }
            }

        }
        public void DoanhThu_Ngay(string _ngay, string _thang, string _nam)
        {
                if (KT('d', txt[0] , txt[1], txt[2]) == false) { }
                else
                {
                    ngay = _ngay;
                    thang = _thang;
                    nam = _nam;
                    this.SLHD_DoanhThu("=", "=", "=");
                    con.KetNoiDataGridView(lenh_all, dgv);
                    txt[3].Text = dgv.Rows[0].Cells[0].Value.ToString();
                    txt[4].Text = dgv.Rows[0].Cells[1].Value.ToString();
                    this.Show("=", "=", "=");
                    con.KetNoiDataGridView(lenh_all, dgv);
                }
        }
        public  void DoanhThu_Thang( string _thang, string _nam)
        {
                 int i = 0;
                 if (KT('m',null,txt[i++], txt[i++]) == false) { }
                else
                {
                    ngay = "31";
                    thang = _thang;
                    nam = _nam;
                    this.SLHD_DoanhThu("<=", "=", "=");
                    con.KetNoiDataGridView(lenh_all, dgv);
                    txt[i++].Text = dgv.Rows[0].Cells[0].Value.ToString();
                    txt[i++].Text = dgv.Rows[0].Cells[1].Value.ToString();
                    this.Show("<=", "=", "=");
                    con.KetNoiDataGridView(lenh_all, dgv);
                }
        }
        public void DoanhThu_Nam(string _nam)
        {
            int i = 0;
            if (KT('y', null, null, txt[i++]) == false) { }
            else
            {
                ngay = "31";
                thang = "12";
                nam = _nam;
                this.SLHD_DoanhThu("<=", "<=", "=");
                con.KetNoiDataGridView(lenh_all, dgv);
                txt[i++].Text = dgv.Rows[0].Cells[0].Value.ToString();
                txt[i].Text = dgv.Rows[0].Cells[1].Value.ToString();
                this.Show("<=", "<=", "=");
                con.KetNoiDataGridView(lenh_all, dgv);
            }
        }  
    }
}
