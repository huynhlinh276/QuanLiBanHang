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
    public partial class BillDetailUpdate : Form
    {
        Test textboxs;
        TextBox[] billtb;
        Data data;
        public BillDetailUpdate()
        {
            InitializeComponent();
        }

        private void BillDetailUpdate_Load(object sender, EventArgs e)
        {
            billtb = new TextBox[] { BillDetailUpdate_BillCode_TextBox, BillDetailUpdate_ProductCode_TextBox, BillDetailUpdate_Count_TextBox };
            data = new Data(billtb);
            data = (Data)Transporter.BOX;
            data.TXT = billtb;
            data.Load();
        }

        private void BillDetailUpdate_Save_Button_Click(object sender, EventArgs e)
        {
            string[] thuoctinh = new string[] { "MaHD", "MaSP", "Soluong" };
            string[] thuoctinh_dau = new string[] { "Mã Hóa Đơn", "Mã Sản Phẩm", "Số Lương" };
            string[] giatri = new string[billtb.Length];
            for (int i = 0; i < billtb.Length; i++)
                giatri[i] = billtb[i].Text.ToString();
            textboxs = new Test(billtb, thuoctinh_dau);
            bool dk_emperty = false, dk_data = false;
            if (dk_emperty = textboxs.Test_Emperty())
                dk_data = textboxs.Test_Data(new TextBox[] { BillDetailUpdate_BillCode_TextBox, BillDetailUpdate_ProductCode_TextBox, BillDetailUpdate_Count_TextBox }, new TextBox[] { }, new TextBox[] { }, new TextBox[] { }, new TextBox[] { });
            if (dk_data && textboxs.Check() && dk_emperty)
            {
                if (data.THEM == true)
                    data.LuuThem("[CHITIETHOADON]", thuoctinh, giatri);
                if (data.SUA == true)
                    data.LuuSua("[CHITIETHOADON]", thuoctinh, giatri);
                this.Close();
            }
        }

        private void BillDetailUpdate_Cancel_Button_Click(object sender, EventArgs e)
        {
            if (data.Huy() == true) this.Close();
        }
    }
}
