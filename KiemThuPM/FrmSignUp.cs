using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KiemThuPM
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }
        static string user, pass , name;
        SqlConnection cn = new SqlConnection(@"Data Source=ADMINPC\THACH;Initial Catalog=duoihinhbatchu;Integrated Security=True;");
        SqlCommand cmd = null;
        private void FrmDangKy_Load(object sender, EventArgs e){ }
        private void btEnter_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            pass = txtPass.Text;
            name = txtNickname.Text;
            try
            {
                if (user.Length < 4 || pass.Length < 4 || user.Length > 12 || pass.Length > 12)
                    throw new OverflowException();
                if (user != "" && pass != "" && name != "")
                {
                    if (KiemTraDangKy(user, pass, name))
                    {
                        MessageBox.Show("Tài khoản đã được tạo thành công!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else MessageBox.Show("Phải nhập liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show(" Nhập từ 4 đến 12 kí tự \n\n Tên đăng nhập hoặc mật khẩu có độ dài sai quá định!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Tài khoản đã được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                cn.Close();
            }

        }
        public bool KiemTraDangKy(string user, string pass, string name)
        {
            cn.Open();
            cmd = new SqlCommand("TaoTaiKhoan", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@user", user));
            cmd.Parameters.Add(new SqlParameter("@pass", pass));
            cmd.Parameters.Add(new SqlParameter("@name", name));
            int numKT = cmd.ExecuteNonQuery();
            cn.Close();
            if (numKT >= 1)
                return true;
            else
                return false;
        }
        
    }
}
