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
    public partial class 메인 : Form
    {
        public interface IMyInterface { void SetData2(String Data); } //인터페이스 선언

        public 메인()
        {
            InitializeComponent();
        }

        // 1번 방식 : owner-종속 폼 관계 이용하는 메소드 선언
        public void SetData1(String Data) //종속 폼의 문자열을 메인 폼으로 가져오는 메소드
        { textBox1.Text = Data; }
        // 2번 방식
        public void SetData2(String Data) //인터페이스 폼의 문자열을 폼1로 가져오는 메소드
        { textBox2.Text = Data; }
        public void SetData3(String Data) //이벤트 폼의 문자열을 폼1로 가져오는 메소드
        { textBox3.Text = Data; }
        private string id = string.Empty;
        public string ID // 프러퍼티 선언 : 폼5에서 문자열 set/get
        {
            get { return id; }
            set { id = value; textBox4.Text = string.Format(" ID : {0}", value); }
        }


        private void button1_Click(object sender, EventArgs e)
        {//메인 폼의 정보 this를 인수로 주면서 종속 폼의 객체 f2 생성
            종속 f2 = new 종속(this);
            f2.Show(); //모달 방식도 가능
        }

        private void button2_Click(object sender, EventArgs e)
        {// 메인 폼의 setData2()만 인터페이스로 상속.
            인터페이스 f3 = new 인터페이스(this);
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {//이벤트 폼의 객체를 생성하고 이벤트를 발생시켜 메인 폼에게 정보 넘겨주기
            이벤트 f4 = new 이벤트();
            f4.Show(); //반드시 폼이 모달리스 방식으로 열려야 함
                       //이벤트 폼에서 transData라는 이벤트가 발생되면 SetData3()를 델리게이트 연결
            이벤트.transData += new EventHandler(SetData3);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            프러퍼티 f5 = new 프러퍼티(); //프러퍼티 폼의 객체 생성
            f5.Show();
        }
    }
}
