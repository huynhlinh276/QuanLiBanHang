using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Object
{
    class NhanVienObj
    {
        string ma, ten, gioitinh, diachi, sdt, matkhau;
        DateTime namsinh;
        public String Ma
        {
            get { return ma; }
            set { ma = value; }

        }
        public String TenNhanVien
        {
            get { return ten; }
            set { ten = value; }

        }
        public String GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }

        }
        public String DiaChi
        {
            get { return diachi; }
            set { diachi = value; }

        }
        public String SDT
        {
            get { return sdt; }
            set { sdt = value; }

        }
        public String MatKhau
        {
            get { return matkhau; }
            set { matkhau = value; }

        }
       
        public DateTime NamSinh
        {
            get { return namsinh;}
            set { namsinh = value; }

        }
        public NhanVienObj() { }
        public NhanVienObj(string ma, string ten, string gioitinh, DateTime namsinh, string diachi, string sdt, string matkhau)
        {
            this.ma = ma;
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.namsinh = namsinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.matkhau = matkhau;
        }
    }
}
