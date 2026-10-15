using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _9장
{
    public partial class 마우스기본1 : Form
    {
        public 마우스기본1()
        {
            InitializeComponent();
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {//리스트박스 안에서 클릭한 순간.
        }

        private void ul(string msg, int x, int y, MouseEventArgs e)
        {
            string m1 = string.Format("{0} X:{1}, Y:{2}", msg, x, y); // 이벤트 종류, X, Y
            string m2 = DateTime.Now.ToShortTimeString(); // 현재 시간
            string m3 = m2 + " " + m1; // 문자열 m1, m2 연결
            string m4 = "";

            listBox1.Items.Insert(0, m3); // 리스트박스의 첫 아이템으로 삽입
            listBox1.TopIndex = 0;

            if (e != null)
            {
                m4 = string.Format("Clicks:{0}, Delta:{1}," + "Buttons:{2}"
                    , e.Clicks, e.Delta, e.Button.ToString());
            }
            else m4 = string.Format("Clicks: {0}, ", 2, msg); // 더블 클릭이면
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {//리스트박스 안에서 더블클릭한순간.
            ul("클릭", e.X, e.Y, e);
        }

        /*  수업중 지운 이벤트.
        private void 마우스기본1_MouseHover(object sender, EventArgs e)
        {//폼 안으로 마우스포인터가 들어가서 멈추는 순간.
            Point mp1 = MousePosition;
            Point mp2 = PointToClient(MousePosition);

            MessageBox.Show("X좌표 = " + mp1.X + ", Y좌표 = " + mp1.Y + "멈춘 좌표");
        }
        */
    }
}
