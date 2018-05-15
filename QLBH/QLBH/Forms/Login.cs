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
    public partial class Login : Form
    {
        Test textboxs;
        Connection conn;
        string id;
        string pass;
        string save;

        //Constructor Khởi Tạo
        public Login()
        {
            InitializeComponent();
        }

        //Load những gì hiển thị trên Form Login
        private void Login_Load(object sender, EventArgs e)
        {
            string[] s = new string[] { "Tên Đăng Nhập...", "Mật Khẩu..." };
            TextBox[] txt = new TextBox[] { Login_ID_TextBox, Login_Pass_TextBox };
            conn = new Connection();
            conn.User(out id, out pass, out save);
            textboxs = new Test(txt, s);
            textboxs.Show_All();
            if (save == "1")
            {
                Login_Pass_TextBox.UseSystemPasswordChar = true;
                Login_Pass_TextBox.Multiline = false;
                Login_Pass_TextBox.Text = pass;
                Login_ID_TextBox.Text = id;
                Login_CheckBox.CheckState = CheckState.Checked;
            }
        }
        private void Login_Enter()
        {
            if (!textboxs.Check())
                return;
            else
            {
                if (Login_ID_TextBox.Text == id)
                {
                    if (Login_Pass_TextBox.Text == pass)
                    {
                        if (Login_CheckBox.Checked)
                            conn.TruyVan(@"Update [User] Set luu='1'");
                        else
                            conn.TruyVan(@"Update [User] Set luu='0'");
                        MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo");
                        Home home_form = new Home();
                        this.Visible = false;
                        home_form.ShowDialog();
                        this.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu Không Đúng!", "Thông Báo");
                        Login_Pass_TextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tên Đăng Nhập Không Tồn Tại!", "Thông Báo");
                    Login_ID_TextBox.Focus();
                }
            }
        }
        //Nút Đăng Nhập
        private void Login_Button_Click(object sender, EventArgs e)
        {
            this.Login_Enter();
        }

        //Nút Thoát
        private void Login_Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Quản lý TextBoxs và CheckBoxs
        //
        //TextBox Tên Đăng Nhập khi đang chọn
        private void Login_ID_TextBox_Enter(object sender, EventArgs e)
        {
            textboxs.Click(0);
        }

        //TextBox Tên Đăng Nhập khi không chọn
        private void Login_ID_TextBox_Leave(object sender, EventArgs e)
        {
            textboxs.Emperty(0);
        }

        //TextBox Mật Khẩu khi đang chọn
        private void Login_Pass_TextBox_Enter(object sender, EventArgs e)
        {
            textboxs.Click(1, true);
        }

        //TextBox Mật Khẩu khi không chọn
        private void Login_Pass_TextBox_Leave(object sender, EventArgs e)
        {
            textboxs.Emperty(1, true);
        }

        private void Login_ID_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Login_Enter();
            }
        }

        private void Login_Pass_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Login_Enter();
            }
        }

        private void Login_ID_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
