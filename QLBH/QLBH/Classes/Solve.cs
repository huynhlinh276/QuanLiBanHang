using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    class Solve
    {
        private DataGridView dgv;
        private Connection con;
        private Data data;
        private string[] txt;
        private string lenh_all;
        public Solve() { }
        public Solve(DataGridView _dgv)
        {
            dgv = _dgv;
        }
        public string LENH_ALL
        {
            get { return lenh_all; }
            set { lenh_all = value; }
        }
        public void Load()
        {
            con = new Connection();
            con.KetNoiDataGridView(lenh_all, dgv);
        }
        public void Boxing()
        {
            Transporter.BOX = data;
        }
        public void Them()
        {
            data = new Data(null);
            data.THEM = true; data.SUA = false;
            this.Boxing();
        }
        public void TimKiem_PramiryKey(string table, string pramirykey, string giatri, DataGridView grid)
        {
            con.TimKiem_PramiryKey(table, pramirykey, giatri, grid);
        }
        public void TimKiem_PramiryKeys(string table, string pamirykey_1, string giatri_1, string pamirykey_2, string giatri_2, DataGridView grid)
        {
             con.TimKiem_PramiryKeys(table, pamirykey_1, giatri_1, pamirykey_2, giatri_2, grid);

        }
        public void Sua()
        {
            int check = dgv.CurrentCell.RowIndex;
            txt = new string[dgv.ColumnCount];
            for (int i = 0; i < txt.Length; i++)
                txt[i] = dgv.Rows[check].Cells[i].Value.ToString();
            data = new Data();
            data.UPDATE = txt;
            data.SUA = true; data.THEM = false;
            this.Boxing();
        }
        public void Xoa(string table, string pamirykey, string giatri)
        {
            DialogResult kq = MessageBox.Show("Bạn Có Chắc Không? ", "Quyết Định", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                con.XoaDuLieu(table, pamirykey, giatri);
            this.Load();
        }
        public void Xoa_2Key(string table, string pamirykey_1, string giatri_1, string pamirykey_2, string giatri_2)
        {
            DialogResult kq = MessageBox.Show("Bạn Có Chắc Không? ", "Quyết Định", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                con.XoaDuLieu_2Key(table, pamirykey_1, giatri_1, pamirykey_2, giatri_2);
            this.Load();
        }
    }
}
