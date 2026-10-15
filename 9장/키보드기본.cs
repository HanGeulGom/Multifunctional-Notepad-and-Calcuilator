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
    public partial class 키보드기본 : Form
    {
        public 키보드기본()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void 키보드기본_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { //아이디. '비번 모두 맞으면 메시지박스 보이고 메인화면으로.'
          //비번만 오류이면, 메시지박스 & 2번 텍스트박스 지우고 & 포커스
          //아이디만 오류이면, 메시지박스 & 1~2번 텍스트박스 지우고 & 포커스
          if(textBox1.Text == "abc")
            {
                if(textBox2.Text == "123") //다 맞음.
                {
                    MessageBox.Show("로그인 환영", "로그인 성공");
                    this.Hide();
                }
                else //비번만 틀림.
                {
                    MessageBox.Show("비밀번호 오류", "로그인 실패");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
            }
            else //아이디가 틀림.
            {
                MessageBox.Show("아이디 오류", "로그인 실패");
                textBox1.Text = textBox2.Text = "";
                textBox1.Focus();
            }
        }
    }
}
