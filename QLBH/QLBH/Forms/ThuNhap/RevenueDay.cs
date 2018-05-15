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
    public partial class RevenueDay : Form
    {
        Test textboxs;
        TextBox[] revenuetb;
        DoanhThu data;

        public RevenueDay()
        {
            InitializeComponent();
        }

        private void RevenueDay_Load(object sender, EventArgs e)
        {
            revenuetb = new TextBox[] { RevenueDay_Day_TextBox, RevenueDay_Month_TextBox, RevenueDay_Year_TextBox, RevenueDay_Count_TextBox, RevenueDay_TextBox };
            data = new DoanhThu(RevenueDay_DataGridView, revenuetb);
            data.Load();
        }

        private void RevenueDay_Today_Button_Click(object sender, EventArgs e)
        {
            data.NgayNay();
        }

        private void RevenueDay_Any_Button_Click(object sender, EventArgs e)
        {
            data.Khac(3);
        }

        private void RevenueDay_Button_Click(object sender, EventArgs e)
        {
            textboxs = new Test();
            if (textboxs.Test_Data(new TextBox[] { revenuetb[0], revenuetb[1], revenuetb[2] }, new TextBox[] { }, new TextBox[] { }, new TextBox[] { }, new TextBox[] { }))
            {
                data.DoanhThu_Ngay(revenuetb[0].Text, revenuetb[1].Text, revenuetb[2].Text);
                textboxs.Convert_Money(revenuetb[4]);
            }
        }

        private void RevenueDay_Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
