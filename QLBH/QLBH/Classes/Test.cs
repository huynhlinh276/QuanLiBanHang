using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLBH
{
    class Test
    {
        private TextBox[] txt;
        private string[] show;
        private Regex re;
        public Test() { }
        public Test(TextBox[] _txt,params string[] _show){
            txt = _txt;
            show = _show;
        }
        public void Show_All(){
            for(int i=0;i<txt.Length;i++)
                txt[i].Text=show[i];
        }
        public bool Check(){
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i].Text == show[i])
                {
                    MessageBox.Show("Vui Lòng Nhập " + show[i] + "!", " Thông Báo ");
                    txt[i].Focus();
                    return false;
                }
            }
            return true;
        }
        public bool Test_Emperty(){
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i].Text == "")
                {
                    MessageBox.Show("Vui Lòng Nhập " + show[i] + "!", " Thông Báo ");
                    txt[i].Focus();
                    return false;
                }
            }
            return true;
        }
        public void Click(int index, bool pass = false) { // xét có phải mật khẩu hay không
            if (txt[index].Text == show[index])
            {
                txt[index].Text = "";
                if (pass)
                {
                    txt[index].UseSystemPasswordChar = true; 
                    txt[index].Multiline = false; // kich hoat dang mat khau
                }
            }
        }
        public void Emperty(int index,bool pass = false){
            if (txt[index].Text == "")
            {
                txt[index].Text = show[index];
                if (pass)
                  txt[index].Multiline = true; 
            }
        }
        public bool Test_Date(string template){
            string patter = @"(^\d{1,2}\/{1}\d{2}\/{1}\d{4}$)";
             re = new Regex(patter);
             if (!re.IsMatch(template))
            {
                MessageBox.Show("Vui Lòng Nhập Dữ Liệu Dạng mm/dd/yyyy", "Yêu Cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        public bool Test_CMND(string template){
            string patter = @"(^\d{9,10}$)";
            re = new Regex(patter);
            if (!re.IsMatch(template))
            {
                MessageBox.Show("Vui Lòng Nhập CMND Với 9 Chữ Số ", "Yêu Cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        public bool Test_Int(string template) {
            string patter = @"^\d+$";
            re = new Regex(patter);
            if (!re.IsMatch(template))
            {
                MessageBox.Show("Vui Lòng Nhập Dữ Liệu Dạng Số Nguyên ở TextBox này ", "Yêu Cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        public bool Test_Name(string template) {
            string patter = @"(^((\w)+\s{1}){0,2}(\w)+$)";
            re = new Regex(patter);
            if (!re.IsMatch(template))
            {
                MessageBox.Show(@"Vui Lòng Nhập Dữ Liệu Tên Không  /Chứa Số /Kí Tự Đặc Biệt ", "Yêu Cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        public bool Test_PhoneNumber(string template){
            string patter = @"(^0{1})(\d{9,10}$)";
            re = new Regex(patter);
            if (!re.IsMatch(template))
            {
                MessageBox.Show("Vui Lòng Nhập Dữ Liệu Số Điện Thoại 10 đến 11 Số ", "Yêu Cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        //Convert
        public void Convert_Date(params TextBox[] template){
            foreach (TextBox pt in template)
                  if(pt.Text!="")
                      pt.Text = string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(pt.Text));
        }
        public void Revert_Date(params TextBox[] template)
        {
            foreach (TextBox pt in template)
                if (pt.Text != "")
                    pt.Text = string.Format("{0:MM/dd/yyyy}", Convert.ToDateTime(pt.Text));
        }
        public void Convert_Money(params TextBox[] template)
        {
            foreach (TextBox pt in template)
                if (pt.Text != "")
                    pt.Text = string.Format("{0:0,0}", Convert.ToInt32(pt.Text));
        }
        public void Convert_Money_Int(params TextBox[] template)
        {
            foreach (TextBox pt in template)
                if (pt.Text != "")
                    pt.Text = string.Format("{0:g}",Convert.ToDouble(pt.Text));
        }
        //Test
        public bool Test_Data(TextBox[] so = null, TextBox[] hoten = null, TextBox[] phone = null, TextBox[] date = null, TextBox[] cmnd= null)
        {
            foreach (TextBox pt in so)
            {
                if (!this.Test_Int(pt.Text)){
                    pt.BackColor = System.Drawing.Color.Red;
                    pt.Focus();
                    return false;
                }
                pt.BackColor = System.Drawing.Color.White;
            }
            foreach (TextBox pt in hoten)
            {
                if (!this.Test_Name(pt.Text))
                {
                    pt.BackColor = System.Drawing.Color.Red;
                    pt.Focus();
                    return false;
                }
                pt.BackColor = System.Drawing.Color.White;
            }
            foreach (TextBox pt in phone)
            {
                if (!this.Test_PhoneNumber(pt.Text))
                {
                    pt.BackColor = System.Drawing.Color.Red;
                    pt.Focus();
                    return false;
                }
                pt.BackColor = System.Drawing.Color.White;
            }
            foreach (TextBox pt in date)
            {
                if (!this.Test_Date(pt.Text))
                {
                    pt.BackColor = System.Drawing.Color.Red;
                    pt.Focus();
                    return false;
                }
                pt.BackColor = System.Drawing.Color.White;
            }
            foreach (TextBox pt in cmnd)
            {
                if (!this.Test_CMND(pt.Text))
                {
                    pt.BackColor = System.Drawing.Color.Red;
                    pt.Focus();
                    return false;
                }
                pt.BackColor = System.Drawing.Color.White;
            }
            return true;
        }
    }
}
