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
    public partial class StaffUpdate : Form
    {
        Test textboxs;
        TextBox[] stafftb;
        Data data;
        public StaffUpdate()
        {
            InitializeComponent();
        }

        private void StaffUpdate_Salary_TextBox_Leave(object sender, EventArgs e)
        {
            if (StaffUpdate_Salary_TextBox.Text.LastIndexOf(",") == -1)
                textboxs.Convert_Money(StaffUpdate_Salary_TextBox);
        }

        private void StaffUpdate_Browse_Button_Click(object sender, EventArgs e)
        {
            data.XuLiHinh(StaffUpdate_PictureBox, StaffUpdate_Link_TextBox);
        }

        private void StaffUpdate_Load(object sender, EventArgs e)
        {
            stafftb = new TextBox[] { StaffUpdate_Code_TextBox, StaffUpdate_Name_TextBox, StaffUpdate_CM_TextBox, StaffUpdate_Phone_TextBox, StaffUpdate_Salary_TextBox, StaffUpdate_Birth_TextBox, StaffUpdate_Ad_TextBox, StaffUpdate_Link_TextBox };
            data = new Data(stafftb);
            data = (Data)Transporter.BOX;
            data.TXT = stafftb;
            data.Load();
            StaffUpdate_PictureBox.ImageLocation = StaffUpdate_Link_TextBox.Text.ToString();
            textboxs = new Test();
            textboxs.Convert_Date(StaffUpdate_Birth_TextBox);
            textboxs.Convert_Money(StaffUpdate_Salary_TextBox);
        }

        private void StaffUpdate_Save_Button_Click(object sender, EventArgs e)
        {
            textboxs.Convert_Money_Int(StaffUpdate_Salary_TextBox);
            string[] thuoctinh = new string[] { "MaNV", "HoTen", "CMND", "SDT", "Luong", "NgaySinh", "DiaChi", "Link" };
            string[] thuoctinh_dau = new string[] { "Mã nhân viên", "Họ và tên", "Chứng minh nhân dân ", "Số điện thoại", "Lương", "Ngày Sinh", "Địa chỉ", "Chọn Hình Ảnh Đại Diện" };
            string[] giatri = new string[thuoctinh.Length];
            for (int i = 0; i < stafftb.Length; i++)
                giatri[i] = stafftb[i].Text.ToString();
            textboxs = new Test(stafftb, thuoctinh_dau);
            //Xử Lí Data
            bool dk_emperty = false, dk_data = false;
            if (dk_emperty = textboxs.Test_Emperty())
                dk_data = textboxs.Test_Data(new TextBox[] { StaffUpdate_Code_TextBox }, new TextBox[] { StaffUpdate_Name_TextBox }, new TextBox[] { StaffUpdate_Phone_TextBox }, new TextBox[] { StaffUpdate_Birth_TextBox }, new TextBox[] { StaffUpdate_CM_TextBox });
            if (dk_data && textboxs.Check() && dk_emperty)
            {
                if (data.THEM == true)
                    data.LuuThem("[NHANVIEN]", thuoctinh, giatri);
                if (data.SUA == true)
                    data.LuuSua("[NHANVIEN]", thuoctinh, giatri);
                this.Close();
            }


        }

        private void StaffUpdate_Cancel_Button_Click(object sender, EventArgs e)
        {
            if (data.Huy() == true) this.Close();
        }
    }
}
