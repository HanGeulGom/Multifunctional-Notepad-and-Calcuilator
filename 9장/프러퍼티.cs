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
    public partial class 프러퍼티 : Form
    {
        public 프러퍼티()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text.Trim(); //프러퍼티 폼의 텍스트박스
            메인 f1 = new 메인();
            f1.ID = id; //메인 폼의 프러퍼티 set 명령을 이용해서 메인 폼에게 전달
            f1.Show(); // 메인 폼을 다시 보여주기
            this.Hide(); // 프러퍼티 폼은 숨기기
        }
    }
}
