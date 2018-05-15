using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    class Data
    {
         private TextBox[] txt;
        private string[] update;
        private Connection con;
        private bool them, sua;
        public Data() { this.Start(); }
        public Data( TextBox[] _txt,params MaskedTextBox[] _mtxt)
        {
            this.Start();
            txt = _txt;
        }
        public bool THEM
        {
            get { return them; }
            set { them = value; }
        }
        public bool  SUA
        {
            get { return sua; }
            set { sua = value; }
        }
        public string[] UPDATE
        {
            get { return update; }
            set { update= value; }
        }
        public TextBox[] TXT
        {
            get { return txt; }
            set { txt = value; }
        }
        public void Start()
        {
            con = new Connection();
        }
        public void Load()
        {
            if (this.SUA == true)
            {
                for (int i = 0; i < txt.Length; i++)
                    txt[i].Text = update[i].ToString();
                txt[0].Enabled = false;
            }
        }
        public void LuuThem(string table, string[] thuoctinh, string[] giatri)
        {
            if(con.KT_KhoaChinh(table,thuoctinh[0],giatri[0]))
             con.ThemDuLieu(table, thuoctinh, giatri);
        }
        public void LuuSua(string table, string[] thuoctinh, string[] giatri)
        {
            DialogResult kq = MessageBox.Show("Bạn Có Chắc Là Lưu Lại? ", "Quyết Định", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                con.SuaDuLieu(table, thuoctinh, giatri);
        }
        public bool Huy()
        {
            DialogResult kq = MessageBox.Show("Bạn Có Chắc Là Hủy ? ", "Quyết Định", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.OK)
                return true;
            return false;
        }
        public void XuLiHinh(PictureBox hinh, TextBox link)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openfile.RestoreDirectory = true;
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                hinh.ImageLocation = openfile.FileName;
                link.Text = openfile.FileName.ToString();
            }
        }
    }
}
