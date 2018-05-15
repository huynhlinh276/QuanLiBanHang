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
    public partial class Product : Form
    {
        Test textbox;
        Solve data;

        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            data = new Solve(Product_DataGridView);
            data.LENH_ALL = "Select * From SANPHAM";
            textbox = new Test(new TextBox[] { Product_Search_TextBox }, " Mã Sản Phẩm Cần Tìm....");
            textbox.Show_All();
            data.Load();
        }

        private void Product_Search_Button_Click(object sender, EventArgs e)
        {
            if (textbox.Check() && textbox.Test_Int(Product_Search_TextBox.Text))
                data.TimKiem_PramiryKey("[SANPHAM]", "MaSP", Product_Search_TextBox.Text.ToString(), Product_DataGridView);
        }

        private void Product_Add_Button_Click(object sender, EventArgs e)
        {
            data.Them();
            ProductUpdate update = new ProductUpdate();
            update.ShowDialog();
        }

        private void Product_Fix_Button_Click(object sender, EventArgs e)
        {
            data.Sua();
            ProductUpdate update = new ProductUpdate();
            update.ShowDialog();
        }

        private void Product_Del_Button_Click(object sender, EventArgs e)
        {
            int item = Product_DataGridView.CurrentCell.RowIndex;
            data.Xoa("SANPHAM", "MaSP", Product_DataGridView.Rows[item].Cells[0].Value.ToString());
        }

        private void Product_Refresh_Button_Click(object sender, EventArgs e)
        {
            data.Load();
        }

        private void Product_Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Product_Search_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textbox.Check() && textbox.Test_Int(Product_Search_TextBox.Text))
                    data.TimKiem_PramiryKey("[SANPHAM]", "MaSP", Product_Search_TextBox.Text.ToString(), Product_DataGridView);
            }
        }

        private void Product_Search_TextBox_Enter(object sender, EventArgs e)
        {
            textbox.Click(0);
        }

        private void Product_Search_TextBox_Leave(object sender, EventArgs e)
        {
            textbox.Emperty(0);
        }
    }
}
