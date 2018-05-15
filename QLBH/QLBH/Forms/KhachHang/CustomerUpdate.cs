using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class CustomerUpdate : Form
    {
        Test textboxs;
        TextBox[] customertb;
        Data data;
        public CustomerUpdate()
        {
            InitializeComponent();
        }

        private void CustomerUpdate_Load(object sender, EventArgs e)
        {
            customertb = new TextBox[] { CustomerUpdate_Code_TextBox, CustomerUpdate_Name_TextBox, CustomerUpdate_Phone_TextBox, CustomerUpdate_CM_TextBox, CustomerUpdate_Ad_TextBox };
            data = new Data(customertb);
            data = (Data)Transporter.BOX; // vận chuyển dữ liệu vào data // đưa dữ liệu vào data data đã có dữ liệu
            data.TXT = customertb;
            data.Load();
        }

        private void CustomerUpdate_Save_Button_Click(object sender, EventArgs e)
        {
            string[] thuoctinh = new string[] { "MaKH", "HoTen", "SDT", "CMND", "DiaChi" };
            string[] thuoctinh_dau = new string[] { "Mã khách hàng", "Họ và tên", "Số điện thoại", "Chứng minh nhân dân", "Địa chỉ" };
            string[] giatri = new string[customertb.Length];
            for (int i = 0; i < customertb.Length; i++)
                giatri[i] = customertb[i].Text.ToString();
            textboxs = new Test(customertb, thuoctinh_dau);
            bool dk_emperty = false, dk_data = false;
            if (dk_emperty = textboxs.Test_Emperty())
                dk_data = textboxs.Test_Data(new TextBox[] { CustomerUpdate_Code_TextBox }, new TextBox[] { CustomerUpdate_Name_TextBox }, new TextBox[] { CustomerUpdate_Phone_TextBox }, new TextBox[] { }, new TextBox[] { CustomerUpdate_CM_TextBox });
            if (dk_data && textboxs.Check() && dk_emperty)
            {
                if (data.THEM == true)
                    data.LuuThem("[KhachHang]", thuoctinh, giatri);
                if (data.SUA == true)
                    data.LuuSua("[KhachHang]", thuoctinh, giatri);
                this.Close();
            }
        }

        private void CustomerUpdate_Cancel_Button_Click(object sender, EventArgs e)
        {
            if (data.Huy() == true) this.Close();
        }
    }
}
