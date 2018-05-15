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
    public partial class ProductUpdate : Form
    {
        Test textboxs;
        TextBox[] producttb;
        Data data;
        public ProductUpdate()
        {
            InitializeComponent();
        }

        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            producttb = new TextBox[] { ProductUpdate_Code_TextBox, ProductUpdate_Name_TextBox, ProductUpdate_Price_TextBox };
            data = new Data(producttb);
            data = (Data)Transporter.BOX;
            data.TXT = producttb;
            data.Load();
            textboxs = new Test();
            textboxs.Convert_Money(ProductUpdate_Price_TextBox);
        }

        private void ProductUpdate_Save_Button_Click(object sender, EventArgs e)
        {
            textboxs.Convert_Money_Int(ProductUpdate_Price_TextBox);
            string[] thuoctinh = new string[] { "MaSP", "TenSP", "DonGia" };
            string[] thuoctinh_dau = new string[] { "Mã Sản Phẩm", "Tên Sản Phẩm", "Đơn Giá" };
            string[] giatri = new string[producttb.Length];
            for (int i = 0; i < producttb.Length; i++)
                giatri[i] = producttb[i].Text.ToString();
            textboxs = new Test(producttb, thuoctinh_dau);
            bool dk_emperty = false, dk_data = false;
            if (dk_emperty = textboxs.Test_Emperty())
                dk_data = textboxs.Test_Data(new TextBox[] { ProductUpdate_Code_TextBox, ProductUpdate_Price_TextBox }, new TextBox[] { }, new TextBox[] { }, new TextBox[] { }, new TextBox[] { });
            if (dk_data && textboxs.Check() && dk_emperty)
            {
                if (data.THEM == true)
                    data.LuuThem("[SANPHAM]", thuoctinh, giatri);
                if (data.SUA == true)
                    data.LuuSua("[SANPHAM]", thuoctinh, giatri);
                this.Close();
            }
        }

        private void ProductUpdate_Cancel_Button_Click(object sender, EventArgs e)
        {
            if (data.Huy() == true) this.Close();
        }

        private void ProductUpdate_Price_TextBox_Leave(object sender, EventArgs e)
        {
            if (ProductUpdate_Price_TextBox.Text.LastIndexOf(",") == -1)
                textboxs.Convert_Money(ProductUpdate_Price_TextBox);
        }
    }
}
