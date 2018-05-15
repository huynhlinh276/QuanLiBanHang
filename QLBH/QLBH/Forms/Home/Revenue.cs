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
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
        }

        private void Revenue_Day_Button_Click(object sender, EventArgs e)
        {
            RevenueDay revenue_form = new RevenueDay();
            this.Visible = false;
            revenue_form.ShowDialog();
            this.Visible = true;
        }

        private void Revenue_Month_Button_Click(object sender, EventArgs e)
        {
            RevenueMonth revenue_form = new RevenueMonth();
            this.Visible = false;
            revenue_form.ShowDialog();
            this.Visible = true;
        }

        private void Revenue_Year_Button_Click(object sender, EventArgs e)
        {
            RevenueYear revenue_form = new RevenueYear();
            this.Visible = false;
            revenue_form.ShowDialog();
            this.Visible = true;
        }

        private void Revenue_Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
