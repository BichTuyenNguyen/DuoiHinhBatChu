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
    public partial class FrmSavePoint : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=doihinhbatchu;Integrated Security=True");
        SqlCommand cmd;
        public FrmSavePoint()
        {             
           InitializeComponent();
        }
        private void FrmLuuDiem_Load(object sender, EventArgs e)
        {
            lbNickName.Text = FrmSignIn.getNickname();
            lbDiem.Text = FrmGame.getDiem().ToString();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            try
            {
                string name = lbNickName.Text;
                int diem = int.Parse(lbDiem.Text);
                cn.Open();
                cmd = new SqlCommand("LuuDiem", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@diem", diem));
                cn.Close();
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {

                MessageBox.Show("Không lưu được!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }     
    }
}
