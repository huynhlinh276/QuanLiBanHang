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
    public partial class BillUpdate : Form
    {
        Test textboxs;
        TextBox[] billtb;
        Data data;

        public BillUpdate()
        {
            InitializeComponent();
        }

        private void BillUpdate_Load(object sender, EventArgs e)
        {
            billtb = new TextBox[] { BillUpdate_Code_TextBox, BillUpdate_StaffCode_TextBox, BillUpdate_CustomerCode_TextBox, BillUpdate_Create_TextBox, BillUpdate_Receive_TextBox };
            data = new Data(billtb);
            data = (Data)Transporter.BOX;
            data.TXT = billtb;
            data.Load();
            textboxs = new Test();
            textboxs.Revert_Date(BillUpdate_Create_TextBox, BillUpdate_Receive_TextBox);
        }

        private void BillUpdate_Save_Button_Click(object sender, EventArgs e)
        {
            string[] thuoctinh = new string[] { "MaHD", "MaKH", "MaNV", "NgayLapHD", "NgayNhanHang" };
            string[] thuoctinh_dau = new string[] { "Mã Hóa Đơn", "Mã Nhân Viên", "Mã Khách Hàng", "Ngay Lập Hóa Đơn", "Ngày Nhận Hàng" };
            string[] giatri = new string[thuoctinh.Length];
            for (int i = 0; i < billtb.Length; i++)
                giatri[i] = billtb[i].Text.ToString();
            textboxs = new Test(billtb, thuoctinh_dau);
            bool dk_emperty = false, dk_data = false;
            if (dk_emperty = textboxs.Test_Emperty())
                dk_data = textboxs.Test_Data(new TextBox[] { BillUpdate_Code_TextBox, BillUpdate_StaffCode_TextBox, BillUpdate_CustomerCode_TextBox }, new TextBox[] { }, new TextBox[] { }, new TextBox[] { BillUpdate_Create_TextBox, BillUpdate_Receive_TextBox }, new TextBox[] { });
            if (dk_data && textboxs.Check() && dk_emperty)
            {
                if (data.THEM == true)
                    data.LuuThem("[HOADON]", thuoctinh, giatri);
                if (data.SUA == true)
                    data.LuuSua("[HOADON]", thuoctinh, giatri);
                this.Close();
            }
        }

        private void BillUpdate_Cancel_Button_Click(object sender, EventArgs e)
        {
            if (data.Huy() == true) this.Close();
        }
    }
}
