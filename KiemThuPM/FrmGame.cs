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
using System.IO;
using System.Collections;

namespace KiemThuPM
{
    public partial class FrmGame : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=ADMINPC\THACH;Initial Catalog=duoihinhbatchu;Integrated Security=True;");
        SqlCommand cmd = null;

        public FrmGame()
        {
            InitializeComponent();
        }
        int level = 1;
        static int Diem = 5;
        int CauHoi = 1;
        Label [] arrLabel;
        Button[] arrButton;
        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        public void init()
        {
            //câu hỏi
            CauHoi = RandQuestion();
            //hình ảnh
            LoadPicture();
            // điểm
            lbDiem.Text = Diem.ToString();
            //level
            lbLevel.Text = level.ToString();
            // ô chữ
            Addlabels();
            // ô đoán
            AddButtons();
        }
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmXuLy_Load(object sender, EventArgs e)
        {
            init();
        }
        /// <summary>
        /// Button thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form f = new FrmSavePoint();
                f.Show();
                //Hide();                
            }
        }
        /// <summary>
        /// Button gợi ý
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGoiY_Click(object sender, EventArgs e)
        {
            string StrDapAn = getAnswer();
            char[] ArrDapAn = StrDapAn.ToCharArray();
            for (int i = 0; i < ArrDapAn.Length; i++)
            {
                ArrDapAn[i] = char.ToUpper(ArrDapAn[i]);
            }//lấy đáp án
            if (Diem >= 5)
            {
                for(int i = 0;i <arrLabel.Length;i++)
                {
                    if(arrLabel[i].Text == "")
                    {
                        arrLabel[i].Text = ArrDapAn[i].ToString();
                        arrLabel[i].ForeColor = Color.Blue;
                        arrLabel[i].Enabled = true;
                        gbLable.Controls.Add(arrLabel[i]);
                        gbLable.Invalidate();
                        arrLabel[i].TextAlign = ContentAlignment.MiddleCenter;
                        Diem -= 5;
                        lbDiem.Text = Diem.ToString();
                        break;
                    }
                }
                
            }
            else
                MessageBox.Show("Điểm của bạn không đủ!");
            btGoiY.Enabled = false;
        }
        /// <summary>
        /// Hàm lấy đáp án
        /// </summary>
        /// <returns></returns>
        public String getAnswer()
        {

            if (CauHoi > 0)
            {
                cn.Open();
                string sql = "select dapan from Hinh where id=" + CauHoi + "";
                cmd = new SqlCommand(sql, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder cbd = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cn.Close();

                string StrDapAn = (string)ds.Tables[0].Rows[0]["dapan"];
                char[] arrDapAn = StrDapAn.ToCharArray();
                StrDapAn = "";
                foreach(char i in arrDapAn)
                {
                    if (i != ' ')
                        StrDapAn += i;
                }
                StrDapAn.Trim();
                return StrDapAn;
            }
            else
                return null;
        }
        /// <summary>
        /// hàm Trộn đáp án
        /// </summary>

        public String mixAnswer()
        {
            string StrDapAn = getAnswer();
            char[] ArrDapAn = StrDapAn.ToCharArray();
            StrDapAn = "";

            for (int i = 0; i < ArrDapAn.Length; i++)
            {
                for (int j = ArrDapAn.Length - 1; j >= 0; j--)
                {
                    char tmp = ArrDapAn[i];
                    ArrDapAn[i] = ArrDapAn[j];
                    ArrDapAn[j] = tmp;
                }
            }

            for (int i = 0; i < ArrDapAn.Length; i++)
            {
                StrDapAn += ArrDapAn[i];
            }
            StrDapAn.Trim();
            return StrDapAn;
        }
        /// <summary>
        /// Trộn câu hỏi
        /// </summary>
        /// <returns></returns>
        public int RandQuestion()
        {
            Random rand = new Random();

            int kq = rand.Next(1, 64);
            return kq;
        }
        /// <summary>
        /// Lấy hình ảnh
        /// </summary>
        public void LoadPicture()
        {
            try
            {
                if (CauHoi != 0)
                {
                    cn.Open();
                    string sql = "select hinh from Hinh where id=" + CauHoi + "";
                    cmd = new SqlCommand(sql, cn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlCommandBuilder cbd = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    cn.Close();

                    byte[] ap = (byte[])(ds.Tables[0].Rows[0]["hinh"]);
                    MemoryStream ms = new MemoryStream(ap);
                    picHinh.Image = Image.FromStream(ms);
                    picHinh.SizeMode = PictureBoxSizeMode.StretchImage;
                    picHinh.BorderStyle = BorderStyle.Fixed3D;
                    ms.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi xãy ra với dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Hàm reset
        /// </summary>
        public void Reset()
        {
            CauHoi = RandQuestion();
            level = 1;
            Diem = 5;
            LoadPicture();
            lbDiem.Text = Diem.ToString();
            lbLevel.Text = level.ToString();
            btGoiY.Enabled = true;
            AddButtons();
            Addlabels();
        }
        /// <summary>
        /// Button Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEnter_Click(object sender, EventArgs e)
        {
            string strDapAn = "";
            if (level < 64)
            {
                
                for (int i = 0; i < arrLabel.Length; i++)
                {
                    if(arrLabel[i].Text != null)
                    {
                        strDapAn += arrLabel[i].Text.Trim();
                    }
                     
                }
                if (arrLabel != null)
                {
                    char[] c = strDapAn.ToCharArray();
                    strDapAn = "";

                    for (int i = 0; i < c.Length; i++)
                    {
                        if (c[i] != ' ')
                        {
                            c[i] = char.ToLower(c[i]);
                        }

                        strDapAn += c[i].ToString();
                    }
                    if ((strDapAn) == getAnswer())
                    {
                        MessageBox.Show("Đúng!!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        level++;
                        Diem += 5;
                        lbDiem.Text = Diem.ToString();
                        lbLevel.Text = level.ToString();
                        CauHoi = RandQuestion();       
                        LoadPicture();
                        btGoiY.Enabled = true;
                        Addlabels();
                        AddButtons();
                    }
                    else
                    {
                        if (MessageBox.Show("Sai!!!! \nBạn có muốn chơi lại?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Reset();
                        }
                        else
                        {
                            Form f = new FrmSavePoint();
                            f.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập đáp án.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Bạn đã thắng trò chơi!!!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static int getDiem()
        {
            return Diem;
        }
        /// <summary>
        /// Nhấn trên lable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbA_Click(object sender, EventArgs e)
        {
            for (int i = arrLabel.Length - 1; i >= 0; i--)
            {
                if (arrLabel[i].Text != "")
                {
                    for(int j = 0; j < arrButton.Length; j++)
                    {
                        if(arrLabel[i].Text == arrButton[j].Text && arrButton[j].Enabled == false)
                        {
                            arrButton[j].Enabled = true;
                            break;
                        }
                    }
                   // arrLabel[i].BackColor = Color.White;
                    arrLabel[i].Text = "";
                    break;
                }
            }
            
        }
        /// <summary>
        /// Nhấn 1 button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btA_Click(object sender, EventArgs e)
        {

            Button bt = (Button)sender;           
            char c = bt.Text.ToCharArray()[0];
            int i = 0;
            while (i < arrLabel.Length)
            {
                if (arrLabel[i].Text == "")
                {
                    arrLabel[i].Text += c.ToString();
                    arrLabel[i].Enabled = true;
                    gbLable.Controls.Add(arrLabel[i]);
                    gbLable.Invalidate();
                    arrLabel[i].TextAlign = ContentAlignment.MiddleCenter;
                    bt.Enabled = false;
                    break;
                }
                else i++;
            }         
        }
        /// <summary>
        ///  Hàm thêm lable tự dộng
        /// </summary>
        public void Addlabels()
        {
            gbLable.Controls.Clear();
            char[] wordChars = getAnswer().ToCharArray(); //chuyển đáp án thành từng kí tự
            int len = wordChars.Length;
            arrLabel = new Label[len];
            for (int i = 0; i < len; i++)
            {
                if (wordChars[i] != ' ')
                {
                    Label lb = new Label();
                    if (len <= 5)
                    {
                        lb.Size = new Size(35, 35);
                        lb.Location = new Point(200 + i * 35 + i * 10, gbLable.Height - 45);
                    }
                    else if ( len <= 10)
                    {
                        lb.Size = new Size(35, 35);
                        lb.Location = new Point(150 + i * 35 + i*10, gbLable.Height - 45);
                    }
                    else
                    {
                        lb.Size = new Size(25, 25);
                        lb.Location = new Point(75 + i * 25 + i*10, gbLable.Height - 45);
                    }
                    lb.BorderStyle = BorderStyle.FixedSingle;
                    lb.Parent = gbLable;
                    lb.Font = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
                    lb.BackColor = Color.White;
                    lb.ForeColor = Color.Blue;
                    lb.BringToFront();
                    gbLable.Controls.Add(lb);
                    arrLabel[i] = lb;
                    arrLabel[i].Text = "";
                    lb.Click += new System.EventHandler(this.lbA_Click);
                }               
            }
        }
        /// <summary>
        /// Hàm thêm botton tự dộng
        /// </summary>
        public void AddButtons()
        {
            arrButton = new Button[20];
            gbButton.Controls.Clear();
            ArrayList a = new ArrayList();
            Random rd = new Random();
            string s = mixAnswer();
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = char.ToUpper(arr[i]);
                if (arr[i] != ' ')
                    a.Add(arr[i]);
            }//lấy đáp án
            int n = 20 - arr.Length;
            for (int i = 0; i < n; i++) // -> bt rand 
            {
                char ch = (char)rd.Next(65, 90);
                a.Add(ch);
            }//tăng độ khó cho game
            Button bt;
            for (int i = 0; i < a.Count; i++)
            {
                bt = new Button();
                bt.Size = new System.Drawing.Size(50, 40);
                if (i <= 9)
                {
                    bt.Location = new System.Drawing.Point(70 + i * 50 , gbButton.Height - 50);
                }
                else 
                    bt.Location = new System.Drawing.Point(70 + (i - 10) * 50 , gbButton.Height - 90);

                if (a[i] != null)
                {
                    bt.Text = a[i].ToString();
                }
                bt.BringToFront();
                bt.Parent = gbButton;
                bt.Font = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
                bt.ForeColor = Color.Black;
                bt.BackColor = Color.White;
                gbButton.Controls.Add(bt);
                bt.Click += new System.EventHandler(this.btA_Click);
                arrButton[i] = bt;
            }// tạo ra các nút button
            
        }      
    }
}
