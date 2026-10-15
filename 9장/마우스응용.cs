using Microsoft.VisualBasic.Devices;
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
    public partial class 마우스응용 : Form
    {

        protected const int xNum = 5; // 가로박스 개수
        protected const int yNum = 5; // 세로박스 개수
        protected int cxBlock, cyBlock; // 박스 가로너비, 세로 높이
        protected bool[,] Check = new bool[yNum, xNum]; //체크 여부


        public 마우스응용()
        {
            InitializeComponent();
        }

        private void 마우스응용_Load(object sender, EventArgs e)
        {
            cxBlock = ClientSize.Width / xNum; // 격자의 가로 너비
            cyBlock = ClientSize.Height / yNum; // 격자의 세로 높이
            Invalidate();
        }

        private void 마우스응용_Resize(object sender, System.EventArgs e)
        {
            // 폼 크기가 변할 때, 폼의 크기에 맞춰서 격자들을 다시 그리기
            cxBlock = ClientSize.Width / xNum;
            cyBlock = ClientSize.Height / yNum;
            Invalidate();
        }

        private void 마우스응용_MouseUp(object sender, MouseEventArgs e)
        {
            // 마우스 버튼을 눌러서 뗄 때, 클릭 이벤트가 발생하므로 격자들을 다시 그리기
            int x = e.X / cxBlock; // 격자의 행 번호
            int y = e.Y / cyBlock; // 격자의 열 번호
            if (x < xNum && y < yNum)
            {
                Check[y, x] = Check[y, x] ^ true;
                // 해당 격자 다시 그리기 : Left Top의 x/y좌표 ~ Right Bottom의 x/y좌표
                Invalidate(new Rectangle(x * cxBlock, y * cyBlock, cxBlock, cyBlock));
            }
        }

        private void 마우스응용_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(ForeColor);
            for (int y = 0; y < yNum; y++)
                for (int x = 0; x < xNum; x++)
                {
                    g.DrawRectangle(p, x * cxBlock, y * cyBlock, cxBlock, cyBlock);
                    if (Check[y, x])
                    { // 격자에 대각선 2개 그리기
                        g.DrawLine(p, x * cxBlock, y * cyBlock, (x + 1) * cxBlock, (y + 1) * cyBlock);
                        g.DrawLine(p, x * cxBlock, (y + 1) * cyBlock, (x + 1) * cxBlock, y * cyBlock);
                    }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 모든 격자의 대각선 지우기 : Invalidate() ➔ 폼 Paint() 실행
            int x, y;
            for (y = 0; y < yNum; y++)
                for (x = 0; x < xNum; x++)
                {
                    Check[y, x] = false;
                    Invalidate(new Rectangle(x * cxBlock, y * cyBlock, cxBlock, cyBlock));
                }
        }

    }


}
