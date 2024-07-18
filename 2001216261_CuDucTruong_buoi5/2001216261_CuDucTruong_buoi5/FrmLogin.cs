using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001216261_CuDucTruong_buoi5
{
    public partial class FrmLogin : Form
    {      
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XuLyDN CauHinh = new XuLyDN();

            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + label1.Text.ToLower());
                this.textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.textBox2.Text))
            {
                MessageBox.Show("Không được bỏ trống" + label2.Text.ToLower());
                this.textBox2.Focus();
                return;
            }
            int kq = CauHinh.Check_Config(); //hàm Check_Config() thuộc Class QL_NguoiDung
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }

        private void ProcessConfig()
        {
            FrmCauHinh frm = new FrmCauHinh();
            frm.Show();
        }

        public void ProcessLogin()
        {
            XuLyDN CauHinh = new XuLyDN();
            LoginResult result;
            result = CauHinh.Check_User(textBox1.Text, textBox2.Text); //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == LoginResult.Invalid)
            {
                MessageBox.Show("Sai " + label1.Text + " Hoặc " +
                label2.Text);
                return;
            }
            // Account had been disabled
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            if (Program.frmMain == null || Program.frmMain.IsDisposed)
            {
                Program.frmMain = new FrmMain();
            }
            this.Visible = false;
            Program.frmMain.Show();
        }


    }
}
