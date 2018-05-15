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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_ChangePass_Button_Click(object sender, EventArgs e)
        {
            ChangePass changepass_form = new ChangePass();
            this.Visible = false; // an di
            changepass_form.ShowDialog();
            this.Visible = true;
        }

        private void Home_ManageData_Button_Click(object sender, EventArgs e)
        {
            ManageData managedata_form = new ManageData();
            this.Visible = false;
            managedata_form.ShowDialog();
            this.Visible = true;
        }

        private void Home_Revenue_Button_Click(object sender, EventArgs e)
        {
            Revenue revenue_form = new Revenue();
            this.Visible = false;
            revenue_form.ShowDialog();
            this.Visible = true;
        }

        private void Home_Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                Application.Exit();
        }
    }
}
