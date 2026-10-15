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
    public partial class 키보드응용 : Form
    {
        public 키보드응용()
        {
            InitializeComponent();
        }

        //멤버 추가
        public int xPt, yPt;
        public static readonly int MOVE = 20;

        void button1_KeyUp(object sender, KeyEventArgs e)
        {//어떤 키를 눌렀는지 보여라.(방향키면 움직여라.)
            this.xPt = this.button1.Location.X;
            this.yPt = this.button1.Location.Y;
            switch (e.KeyCode)
            { // 입력 키가 방향키일 경우에는 버튼 이동.
                case Keys.Left: xPt -= MOVE; break; // 왼쪽 이동.
                case Keys.Right: xPt += MOVE; break; // 오른쪽 이동.
                case Keys.Up: yPt -= MOVE; break; // 위쪽 이동.
                case Keys.Down: yPt += MOVE; break; // 아래쪽 이동.
                case Keys.PageUp: yPt -= 100; break; // 위쪽으로 100Pt 이동.
                case Keys.PageDown: yPt += 100; break; // 아래쪽으로 100Pt 이동.
            }
            // 방향키가 아닐 경우, 키 값을 버튼에 표시
            this.button1.Text = DateTime.Now.ToShortTimeString() + " : " + e.KeyCode.ToString(); // 키 코드를 버튼에 표시
            this.button1.Location = new Point(xPt, yPt); // 버튼 꼭지점 좌표 셋팅
        }
    }
}
