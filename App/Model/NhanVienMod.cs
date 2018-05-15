using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using App.Object;


namespace App.Model
{
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaNV, TenNV, GioiTinh, NamSinh, DiaChi, SDT  from tb_NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public bool AddData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Insert into NhanVien values ('" + nvObj.Ma + "','" + nvObj.TenNhanVien + "','" + nvObj.GioiTinh + "',CONVERT(DATE,'" + nvObj.NamSinh.ToShortDateString() + "',103)'" +nvObj.DiaChi + "','" +nvObj.SDT + "','"+nvObj.MatKhau+  "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

    }
}
