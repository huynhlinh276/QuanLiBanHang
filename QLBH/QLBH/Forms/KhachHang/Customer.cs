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
    public partial class Customer : Form
    {
        Test textbox;
        Solve data;

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            data = new Solve(Customer_DataGridView);
            data.LENH_ALL = "Select * From KHACHHANG";
            textbox = new Test(new TextBox[] { Customer_Search_TextBox }, "Mã Khách Hàng Cần Tìm...");
            textbox.Show_All();
            data.Load();
        }

        private void Customer_Search_Button_Click(object sender, EventArgs e)
        {
            if (textbox.Check() && textbox.Test_Int(Customer_Search_TextBox.Text))
                data.TimKiem_PramiryKey("[KHACHHANG]", "MaKH", Customer_Search_TextBox.Text.ToString(), Customer_DataGridView);
        }
        private void Customer_Search_TextBox_Enter(object sender, EventArgs e)
        {
            textbox.Click(0);
        }

        private void Customer_Search_TextBox_Leave(object sender, EventArgs e)
        {
            textbox.Emperty(0);
        }

        private void Customer_Add_Button_Click(object sender, EventArgs e)
        {
            data.Them();
            CustomerUpdate update = new CustomerUpdate();
            update.ShowDialog();
        }

        private void Customer_Fix_Button_Click(object sender, EventArgs e) 
        {
            data.Sua();
            CustomerUpdate update = new CustomerUpdate();
            update.ShowDialog();
        }

        private void Customer_Del_Button_Click(object sender, EventArgs e)
        {
            int check = Customer_DataGridView.CurrentCell.RowIndex;
            data.Xoa("[KHACHHANG]", "MaKH", Customer_DataGridView.Rows[check].Cells[0].Value.ToString());
        }

        private void Customer_Refresh_Button_Click(object sender, EventArgs e)
        {
            data.Load(); //  tải lại
        }

        private void Customer_Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();    // trở về thoát form  
        }

        private void Customer_Search_TextBox_KeyDown(object sender, KeyEventArgs e) // button tim kiem
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textbox.Check() && textbox.Test_Int(Customer_Search_TextBox.Text))
                    data.TimKiem_PramiryKey("[KHACHHANG]", "MaKH", Customer_Search_TextBox.Text.ToString(), Customer_DataGridView);
            }
        }
    }
}
