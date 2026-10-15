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
    public partial class 종속 : Form
    {
        private 메인 f2 = null; //종속 폼에서 사용할 메인 폼 객체 f1 선언 & 초기화

        public 종속(메인 f) //메인 폼에서 종속 폼을 생성하면서 전달해온 this ➔ f로 받기
        {
            InitializeComponent();
            textBox1.Focus();
            this.f2 = f; //객체 f2에게 메인 폼 정보 저장 : 메인 폼을 대행하는 객체
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.SetData1(textBox1.Text); // 메인 폼의 SetData1() 호출해서 텍스트 넘겨주기
            this.Close();
        }
    }
}
