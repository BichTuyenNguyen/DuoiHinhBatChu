using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuPM
{
    public class ClassKiemTraDangNhap
    {
        private string ten, pas;
        public ClassKiemTraDangNhap(string ten, string pas)
        {
            this.ten = ten;
            this.pas = pas;
        }
        // kiểm tra tài khoản có tồn tại trong CSDL hay chưa?
        public Boolean KiemTraDangNhap()
        {
            DataTable dt = Getdata("select * from dbo.TaiKhoan tk where tk.UserName = N'" + ten + "' and tk.Password = N'" + pas + "'");
            Boolean check = false;
            if (dt != null)
            {
                if (dt.Rows.Count >= 1)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
        public DataTable Getdata(string cmd)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=doihinhbatchu;Integrated Security=True");
                cn.Open();
                SqlCommand cmds = new SqlCommand(cmd, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                cn.Close();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
