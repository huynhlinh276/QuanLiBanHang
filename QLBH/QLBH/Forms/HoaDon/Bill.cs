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
    public partial class Bill : Form
    {
        Test textbox;
        Solve data;
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            data = new Solve(Bill_DataGridView);
            data.LENH_ALL = "Select * From HOADON";
            textbox = new Test(new TextBox[] { Bill_Search_TextBox }, " Mã Hóa Đơn Cần Tìm....");
            textbox.Show_All();
            data.Load();
        }

        private void Bill_Search_TextBox_Enter(object sender, EventArgs e)
        {
            textbox.Click(0);
        }

        private void Bill_Search_TextBox_Leave(object sender, EventArgs e)
        {
            textbox.Emperty(0);
        }

        private void Bill_Search_Button_Click(object sender, EventArgs e)
        {
            if (textbox.Check() && textbox.Test_Int(Bill_Search_TextBox.Text))
                data.TimKiem_PramiryKey("[HOADON]", "MaHD", Bill_Search_TextBox.Text.ToString(), Bill_DataGridView);
        }

        private void Bill_Add_Button_Click(object sender, EventArgs e)
        {
            data.Them();
            BillUpdate update = new BillUpdate();
            update.ShowDialog();
        }

        private void Bill_Fix_Button_Click(object sender, EventArgs e)
        {
            data.Sua();
            BillUpdate update = new BillUpdate();
            update.ShowDialog();
        }

        private void Bill_Del_Button_Click(object sender, EventArgs e)
        {
            int item = Bill_DataGridView.CurrentCell.RowIndex;
            data.Xoa("HOADON", "MaHD", Bill_DataGridView.Rows[item].Cells[0].Value.ToString());
        }

        private void Bill_Refresh_Button_Click(object sender, EventArgs e)
        {
            data.Load();
        }

        private void Bill_Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bill_Search_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (textbox.Check() && textbox.Test_Int(Bill_Search_TextBox.Text))
                    data.TimKiem_PramiryKey("[HOADON]", "MaHD", Bill_Search_TextBox.Text.ToString(), Bill_DataGridView);
            }
        }
    }
}
