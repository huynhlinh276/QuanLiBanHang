using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLBH
{
    class Connection
    {
        // Truyền Tải Dử Liệu
        private SqlConnection connection;
        private SqlDataAdapter adapter; // thực thi lấy dữ liệu
        private DataTable table;  
        //  Truy Vấn Dử Liệu
        private SqlCommand command;
        private string lenh;
        private string address;
        //Properti
        //Connection
        public string ADDRESS
        {
            get { return address; }
            set { address = value; }
        }
        //Lenh
        public string LENH
        {
            get { return lenh; }
            set { lenh = value; }
        }
        //Method
        public Connection()
        {
             try
            {
                string address = @"Data Source=VUTRONGLUAT\SQL2008;Initial Catalog=_BanHang_;Integrated Security=True";
                connection = new SqlConnection(address);

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }
        private void OpenSQL()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }
        private void CLoseSQL()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
        public void KetNoiDataGridView(string _lenh,DataGridView grid)
        {
                this.OpenSQL();
                lenh = _lenh;
                adapter = new SqlDataAdapter(_lenh, connection); // thực thi 
                table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                grid.DataSource = table;
                this.CLoseSQL();
        }
        public bool KT_KhoaChinh(string _table, string key, string giatri)
        {

            this.OpenSQL();
            adapter = new SqlDataAdapter("SELECT * FROM "+_table+" WHERE "+key+"="+giatri, connection);
            table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show(key + " bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
            this.CLoseSQL();
        }
        public void User(out string id, out string pass,out string save)
        {
             this.OpenSQL();
            adapter = new SqlDataAdapter("SELECT * FROM [User]", connection); // thuc thi lay het tat ca trong bang user ra
            table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            id=table.Rows[0][0].ToString(); // row dong cell la cot
            pass = table.Rows[0][1].ToString();
            save = table.Rows[0][2].ToString();
            this.CLoseSQL();

        }
        public void TruyVan(string _lenh)
        {
             this.OpenSQL();
            lenh = _lenh;
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text; // truy van du lieu
            command.CommandText = System.String.Concat(lenh);
            command.ExecuteNonQuery(); // thực thi câu lệnh truy vấn
            this.CLoseSQL(); 
        }
        public void SuaDuLieu(string table, string[] thuoctinh, string[] giatri)
        {
           try
           {
            string _lenh = @"UPDATE " + table + " SET ";
            for (int i = 1; i < thuoctinh.Length; i++)
            {
                _lenh += thuoctinh[i] + "=N'" + giatri[i] + "'";
                if (i < thuoctinh.Length - 1)
                    _lenh += ",";
            }
            _lenh += " Where " + thuoctinh[0] + "='" + giatri[0]+"'";
            this.TruyVan(_lenh);
            MessageBox.Show("Sửa Dữ Liệu Thành Công", " Thông Báo ");
           }
           catch (SqlException e)
           { MessageBox.Show(e.Message, "Lỗi"); }
        }
        public void XoaDuLieu(string table, string pamirykey, string giatri)
        {
            try
            {
                string _lenh = "Delete From " + table;
                _lenh += " Where " + pamirykey + "='" + giatri + "'";
                this.TruyVan(_lenh);
                MessageBox.Show("Xóa Dữ Liệu Thành Công", " Thông Báo ");
            }
            catch (SqlException e)
            { MessageBox.Show(e.Message, "Lổi"); }

        }
        public void XoaDuLieu_2Key(string table, string pamirykey_1, string giatri_1, string pamirykey_2, string giatri_2)
        {
            try
            {
                string _lenh = "Delete From " + table;
                _lenh += " Where " + pamirykey_1 + "='" + giatri_1 + "'";
                _lenh += " and " + pamirykey_2 + "='" + giatri_2 + "'";
                this.TruyVan(_lenh);
                MessageBox.Show("Xóa Dữ Liệu Thành Công", " Thông Báo ");
            }
            catch (SqlException e)
            { MessageBox.Show(e.Message, "Lổi"); }
        }
        public void ThemDuLieu(string table, string[] thuoctinh, string[] giatri)
        {
            try
            {
                string _lenhI = @"Insert Into " + table + " (";
                string _lenhII = "Values(";
                for (int i = 0; i < thuoctinh.Length; i++)
                {
                    _lenhI += thuoctinh[i];
                    _lenhII +="N'" +giatri[i]+"'";
                    if (i < thuoctinh.Length - 1)
                    {
                        _lenhI += ",";
                        _lenhII += ",";
                    }
                }
                _lenhI += ")";
                _lenhII += ")";
                this.TruyVan(_lenhI + _lenhII);
                MessageBox.Show("Thêm Dữ Liệu Thành Công", " Thông Báo ");
            }
            catch (SqlException e)
            { MessageBox.Show(e.Message, "Lổi"); }
        }
        public void TimKiem_PramiryKey(string table, string pamirykey, string giatri,DataGridView grid)
        {
            string lenh = "SELECT * FROM " + table + " WHERE " + pamirykey + "=" + giatri;
            this.KetNoiDataGridView(lenh, grid);
             if (grid.RowCount < 2) // datagridview dòng nhỏ hơn 2 trong form tìm kiếm thì ko tìm được
                 MessageBox.Show("Không Tìm Thấy", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void TimKiem_PramiryKeys(string table, string pamirykey_1, string giatri_1, string pamirykey_2, string giatri_2, DataGridView grid)
        {
            string lenh = "SELECT * FROM " + table + " WHERE " + pamirykey_1+ " = " + giatri_1 + " and " + pamirykey_2 +  " = " + giatri_2;
            this.KetNoiDataGridView(lenh, grid);
        }
    }
}
