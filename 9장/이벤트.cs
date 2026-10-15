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
    public partial class 이벤트 : Form
    {
        public static event EventHandler transData;
        //이벤트 폼에서 사용할 이벤트 델리게이트 선언
        public 이벤트()
        {
            InitializeComponent();
            textBox1.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        { //메인 폼에게 이벤트 폼의 textBox.Text를 전달하는 이벤트 transData 활용
            transData(textBox1.Text); // trnsData는 메인 폼의 SetData3() 대체 명칭으로 사용
            this.Close();
        }
    }
}
