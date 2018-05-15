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
    public partial class Staff : Form
    {
        Test textbox;
        Solve data;

        private string Link()
        {
            int check = Staff_DataGridView.CurrentCell.RowIndex;
            return Staff_DataGridView.Rows[check].Cells[Staff_DataGridView.ColumnCount - 1].Value.ToString();
        }

        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            data = new Solve(Staff_DataGridView); //
            data.LENH_ALL = "Select * From NHANVIEN"; // thong qua getter, setter
            textbox = new Test(new TextBox[] { Staff_Search_TextBox }, " Mã Nhân Viên Cần Tìm....");
            textbox.Show_All();
            data.Load();
        }

        private void Staff_Search_Button_Click(object sender, EventArgs e)
        {
            if (textbox.Check() && textbox.Test_Int(Staff_Search_TextBox.Text)) // kiểm tra textbox
                data.TimKiem_PramiryKey("[NHANVIEN]", "MaNV", Staff_Search_TextBox.Text.ToString(), Staff_DataGridView);
        }

        private void Staff_Search_TextBox_Enter(object sender, EventArgs e)
        {
            textbox.Click(0);
        }

        private void Staff_Search_TextBox_Leave(object sender, EventArgs e)
        {
            textbox.Emperty(0);
        }

        private void Staff_Add_Button_Click(object sender, EventArgs e)
        {
            data.Them();
            StaffUpdate update = new StaffUpdate();
            update.ShowDialog();
        }

        private void Staff_Fix_Button_Click(object sender, EventArgs e)
        {
            data.Sua();
            StaffUpdate update = new StaffUpdate();
            update.ShowDialog();
        }

        private void Staff_Del_Button_Click(object sender, EventArgs e) // xóa
        {
            int check = Staff_DataGridView.CurrentCell.RowIndex;
            data.Xoa("NHANVIEN", "MaNV", Staff_DataGridView.Rows[check].Cells[0].Value.ToString());
        }

        private void Staff_Refresh_Button_Click(object sender, EventArgs e)
        {
            data.Load(); // tải lại
        }

        private void Staff_Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Staff_Picture(object sender, DataGridViewCellEventArgs e)
        {
            Staff_PictureBox.ImageLocation = this.Link();
        }

        private void Staff_Search_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                if (textbox.Check() && textbox.Test_Int(Staff_Search_TextBox.Text))
                    data.TimKiem_PramiryKey("[NHANVIEN]", "MaNV", Staff_Search_TextBox.Text.ToString(), Staff_DataGridView);
        }


    }
}
