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
    public partial class FrmSignIn : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=doihinhbatchu;Integrated Security=True");
        public FrmSignIn()
        {
            InitializeComponent();
        }
        static string name;
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
        }
        private void btXong_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtTen.Text;
                string pass = txtMatKhau.Text;
                if (user.Length < 4 || user.Length > 12 || pass.Length > 12)
                    throw new OverflowException();
                if (user != "" && pass != "")
                {
                    if (KiemTraDangNhap(user, pass) == true)
                    {
                        Form f = new FrmGame();
                        f.Show();
                    }
                }
                else MessageBox.Show("Phải nhập liệu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (OverflowException)
            {
                MessageBox.Show(" Nhập từ 4 đến 12 kí tự \n\n Tên đăng nhập hoặc mật khẩu có độ dài sai quá định!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Boolean KiemTraDangNhap(string ten, string pas)
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
            name = (string)dt.Rows[0][2];
            return check;
        }
        public DataTable Getdata(string cmd)
        {
            try
            {
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
        private void FrmDangNhap_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            FrmSignUp f = new FrmSignUp();
            f.Show();
        }
        public static string getNickname()
        {
            
            string nickname = name;
            return nickname;
        }
    }
}
