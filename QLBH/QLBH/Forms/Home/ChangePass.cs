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
    public partial class ChangePass : Form
    {
        string id;
        string pass;
        string save;
        Test textboxs;
        TextBox[] arrtb;
        string[] arrstring;

        public ChangePass()
        {
            InitializeComponent();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            arrstring = new string[] { "Tên Đăng Nhập...", "Mật Khẩu Cũ...", "Mật Khẩu Mới...", "Nhập Lại Mật Khẩu Mới..." };
            arrtb = new TextBox[] { ChangePass_ID_TextBox, ChangePass_OldPass_TextBox, ChangePass_NewPass_TextBox, ChangePass_Confirm_TextBox};
            textboxs = new Test(arrtb, arrstring);
            textboxs.Show_All();
        }

        private void ChangePass_ID_TextBox_Enter(object sender, EventArgs e)
        {
            textboxs.Click(0);
        }

        private void ChangePass_ID_TextBox_Leave(object sender, EventArgs e)
        {
            textboxs.Emperty(0);
        }

        private void ChangePass_OldPass_TextBox_Enter(object sender, EventArgs e)
        {
            textboxs.Click(1, true);
        }

        private void ChangePass_OldPass_TextBox_Leave(object sender, EventArgs e)
        {
            textboxs.Emperty(1, true);
        }

        private void ChangePass_NewPass_TextBox_Enter(object sender, EventArgs e)
        {
            textboxs.Click(2, true);
        }

        private void ChangePass_NewPass_TextBox_Leave(object sender, EventArgs e)
        {
            textboxs.Emperty(2, true);
        }

        private void ChangePass_Confirm_TextBox_Enter(object sender, EventArgs e)
        {
            textboxs.Click(3, true);
        }

        private void ChangePass_Confirm_TextBox_Leave(object sender, EventArgs e)
        {
            textboxs.Emperty(3, true);
        }

        private void ChangePass_OK_Button_Click(object sender, EventArgs e)
        {
            if (!textboxs.Check()) { }
            else
            {
                Connection instance = new Connection();
                instance.User(out id, out pass, out save);
                if (ChangePass_ID_TextBox.Text == id)
                {
                    if (ChangePass_OldPass_TextBox.Text == pass)
                    {
                        if (ChangePass_NewPass_TextBox.Text == ChangePass_Confirm_TextBox.Text)
                        {
                            DialogResult result;
                            result = MessageBox.Show("Bạn Có Chắc Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string[] thuoctinh = { "ID", "Pass" };
                                string[] giatri = { ChangePass_ID_TextBox.Text.ToString(), ChangePass_NewPass_TextBox.Text.ToString() };
                                instance.SuaDuLieu("[User]", thuoctinh, giatri);
                            }
                        }
                        else
                            MessageBox.Show("Mật Khẩu Mới Không Khớp ", " Thông Báo ");
                    }
                    else
                        MessageBox.Show("Mật Khẩu Cũ Không Đúng", " Thông Báo ");
                }
                else
                    MessageBox.Show("Tên Đăng Nhập Không Tồn Tại", " Thông Báo ");
            }
            this.Close();
        }

        private void ChangePass_Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
