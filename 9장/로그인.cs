using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9장
{
    public partial class 로그인 : Form
    {
        public 로그인()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "abc") && (textBox2.Text == "1234"))
            {
                MessageBox.Show("환영합니다 abc님");
                this.Close();
            }
            else
            {
                MessageBox.Show("아이디 혹은 비밀번호가 틀립니다.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
        }
    }
}
