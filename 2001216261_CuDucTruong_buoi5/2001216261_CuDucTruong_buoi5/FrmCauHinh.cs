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
    public partial class FrmCauHinh : Form
    {
        public FrmCauHinh()
        {
            InitializeComponent();
        }

        XuLyDN CauHinh = new XuLyDN();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCauHinh_Load(object sender, EventArgs e)
        {
            this.comboBox1.DropDown += ComboBox1_DropDown;
            this.comboBox2.DropDown += ComboBox2_DropDown;
        }

        private void ComboBox2_DropDown(object sender, EventArgs e)
        {
            comboBox2.DataSource = CauHinh.GetDBName(comboBox2.Text, textBox1.Text, textBox2.Text);
            comboBox2.DisplayMember = "name";
        }

        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.DataSource = CauHinh.GetServerName();
            comboBox1.DisplayMember = "ServerName";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(comboBox1.Text, this.textBox1.Text, this.textBox2.Text, comboBox2.Text);
            this.Close();
        }
    }
}
