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
    public partial class RevenueMonth : Form
    {
        Test textboxs;
        TextBox[] revenuetb;
        DoanhThu data;

        public RevenueMonth()
        {
            InitializeComponent();
        }

        private void RevenueMonth_Load(object sender, EventArgs e)
        {
            revenuetb = new TextBox[] { RevenueMonth_Month_TextBox, RevenueMonth_Year_TextBox, RevenueMonth_Count_TextBox, RevenueMonth_TextBox };
            data = new DoanhThu(RevenueMonth_DataGridView, revenuetb);
            data.Load();
        }

        private void RevenueMonth_ThisMonth_Button_Click(object sender, EventArgs e)
        {
            data.ThangNay();
        }

        private void RevenueMonth_Any_Button_Click(object sender, EventArgs e)
        {
            data.Khac(2);
        }

        private void RevenueMonth_Button_Click(object sender, EventArgs e)
        {
            textboxs = new Test();
            if (textboxs.Test_Data(new TextBox[] { revenuetb[0], revenuetb[1] }, new TextBox[] { }, new TextBox[] { }, new TextBox[] { }, new TextBox[] { }))
            {
                data.DoanhThu_Thang(revenuetb[0].Text, revenuetb[1].Text);
                textboxs.Convert_Money(revenuetb[3]);
            }
        }

        private void RevenueMonth_Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
