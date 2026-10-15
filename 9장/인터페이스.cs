using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _9장.메인;

namespace _9장
{
    public partial class 인터페이스 : Form
    {
        private IMyInterface f3 = null; //인터페이스 폼에서 사용할 인터페이스 객체 선언
        public 인터페이스(IMyInterface f)
        //메인 폼에서 인터페이스 폼을 생성할 때 전달된 IMYInterface ➔ f
        {
            InitializeComponent();
            textBox1.Focus();
            this.f3 = f; //메인 폼에서 전달된 인터페이스를 인터페이스 폼의 객체 f3에 저장
        }

        private void button1_Click(object sender, EventArgs e)
        {//메인 폼에게 인터페이스 폼의 textBox.Text를 전달
            f3.SetData2(textBox1.Text); // f3는 메인 폼의 대행자 역할
            this.Close();
        }
    }
}
