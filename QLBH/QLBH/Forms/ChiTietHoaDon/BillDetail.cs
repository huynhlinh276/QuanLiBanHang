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
    public partial class BillDetail : Form
    {
        Test textboxs;
        Solve data;
        public BillDetail()
        {
            InitializeComponent();
        }

        private void BillDetail_Load(object sender, EventArgs e)
        {
            data = new Solve(BillDetail_DataGridView);
            data.LENH_ALL = "Select * From [CHITIETHOADON]";
            textboxs = new Test(new TextBox[] { BillDetail_BillCode_TextBox, BillDetail_ProductCode_TextBox }, " Mã Hóa Đơn Cần Tìm....", " Mã Sản Phẩm Cần Tìm....");
            textboxs.Show_All();
            data.Load();
        }

        private void BillDetail_BillCode_TextBox_Enter(object sender, EventArgs e)
        {
            textboxs.Click(0);
        }

        private void BillDetail_BillCode_TextBox_Leave(object sender, EventArgs e)
        {
            textboxs.Emperty(0);
        }

        private void BillDetail_ProductCode_TextBox_Enter(object sender, EventArgs e)
        {
            textboxs.Click(1);
        }

        private void BillDetail_ProductCode_TextBox_Leave(object sender, EventArgs e)
        {
            textboxs.Emperty(1);
        }

        private void BillDetail_Search_Button_Click(object sender, EventArgs e)
        {
            if (textboxs.Check() && textboxs.Test_Int(BillDetail_BillCode_TextBox.Text) && textboxs.Test_Int(BillDetail_ProductCode_TextBox.Text))
                data.TimKiem_PramiryKeys("[CHITIETHOADON]", "MaHD", BillDetail_BillCode_TextBox.Text.ToString(), "MaSP", BillDetail_ProductCode_TextBox.Text.ToString(), BillDetail_DataGridView);
        }

        private void BillDetail_Add_Button_Click(object sender, EventArgs e)
        {
            data.Them();
            BillDetailUpdate update = new BillDetailUpdate();
            update.ShowDialog();
        }

        private void BillDetail_Fix_Button_Click(object sender, EventArgs e)
        {
            data.Sua();
            BillDetailUpdate update = new BillDetailUpdate();
            update.ShowDialog();
        }

        private void BillDetail_Del_Button_Click(object sender, EventArgs e)
        {
            int item = BillDetail_DataGridView.CurrentCell.RowIndex;
            data.Xoa_2Key("[CHITIETHOADON]", "MaHD", BillDetail_DataGridView.Rows[item].Cells[0].Value.ToString(), "MaSP", BillDetail_DataGridView.Rows[item].Cells[1].Value.ToString());
        }

        private void BillDetail_Refresh_Button_Click(object sender, EventArgs e)
        {
            data.Load();
        }

        private void BillDetail_Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BillDetail_BillCode_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (textboxs.Check() && textboxs.Test_Int(BillDetail_BillCode_TextBox.Text) && textboxs.Test_Int(BillDetail_ProductCode_TextBox.Text))
                    data.TimKiem_PramiryKeys("[CHITIETHOADON]", "MaHD", BillDetail_BillCode_TextBox.Text.ToString(), "MaSP", BillDetail_ProductCode_TextBox.Text.ToString(), BillDetail_DataGridView);
            }
        }

        private void BillDetail_ProductCode_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textboxs.Check() && textboxs.Test_Int(BillDetail_BillCode_TextBox.Text) && textboxs.Test_Int(BillDetail_ProductCode_TextBox.Text))
                    data.TimKiem_PramiryKeys("[CHITIETHOADON]", "MaHD", BillDetail_BillCode_TextBox.Text.ToString(), "MaSP", BillDetail_ProductCode_TextBox.Text.ToString(), BillDetail_DataGridView);
            }
        }
    }
}
