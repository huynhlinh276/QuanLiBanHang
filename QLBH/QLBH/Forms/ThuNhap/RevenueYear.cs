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
    public partial class RevenueYear : Form
    {
        Test textboxs;
        TextBox[] revenuetb;
        DoanhThu data;

        public RevenueYear()
        {
            InitializeComponent();
        }

        private void RevenueYear_Load(object sender, EventArgs e)
        {
            revenuetb = new TextBox[] {  RevenueYear_Year_TextBox, RevenueYear_Count_TextBox, RevenueYear_TextBox };
            data = new DoanhThu(RevenueYear_DataGirdView, revenuetb);
            data.Load();
        }

        private void RevenueYear_ThisYear_Button_Click(object sender, EventArgs e)
        {
            data.NamNay();
        }

        private void RevenueYear_Any_Button_Click(object sender, EventArgs e)
        {
            data.Khac(1);
        }

        private void RevenueYear_Button_Click(object sender, EventArgs e)
        {
            textboxs = new Test();
            if (textboxs.Test_Int(revenuetb[0].Text))
            {
                data.DoanhThu_Nam(revenuetb[0].Text);
                textboxs.Convert_Money(revenuetb[2]);
            }
            else
            {
                revenuetb[0].BackColor = System.Drawing.Color.Red;
                revenuetb[0].Focus();
            }
        }

        private void RevenueYear_Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
