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
    public partial class ManageData : Form
    {
        public ManageData()
        {
            InitializeComponent();
        }

        private void ManageData_Customer_Button_Click(object sender, EventArgs e)
        {
            Customer customer_form = new Customer();
            this.Visible = false;
            customer_form.ShowDialog();
            this.Visible = true;
        }

        private void ManageData_Staff_Button_Click(object sender, EventArgs e)
        {
            Staff staff_form = new Staff();
            this.Visible = false;
            staff_form.ShowDialog();
            this.Visible = true;
        }

        private void ManageData_Product_Button_Click(object sender, EventArgs e)
        {
            Product product_form = new Product();
            this.Visible = false;
            product_form.ShowDialog();
            this.Visible = true;
        }

        private void ManageData_Bill_Button_Click(object sender, EventArgs e)
        {
            Bill bill_form = new Bill();
            this.Visible = false;
            bill_form.ShowDialog();
            this.Visible = true;
        }

        private void ManageData_BillDetail_Button_Click(object sender, EventArgs e)
        {
            BillDetail billdetail_form = new BillDetail();
            this.Visible = false;
            billdetail_form.ShowDialog();
            this.Visible = true;
        }

        private void ManageData_Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
