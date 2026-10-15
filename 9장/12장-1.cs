using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; //해치브러쉬 사용하려면 필요.
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9장
{
    public partial class _12장_1 : Form
    {
        public _12장_1()
        {
            InitializeComponent();
        }

        private void _12장_1_Paint(object sender, PaintEventArgs e)
        {//이 폼이 화면에 로드될 때, 다음과 같이 그려달라.
            Graphics g = e.Graphics;

            // 펜 모양.
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Blue, 5);
            Pen p3 = new Pen(Color.Purple, 5);
            // 사각형 구조 5개 생성.
            Rectangle r1 = new Rectangle(10, 10, 250, 200);
            Rectangle r2 = new Rectangle(270, 10, 250, 200);
            Rectangle r3 = new Rectangle(560, 10, 250, 200);
            Rectangle r4 = new Rectangle(840, 10, 250, 200);
            Rectangle r5 = new Rectangle(1060, 10, 250, 200);
            // 사각형 5개 그리기.
            g.DrawRectangle(p3, r1);
            g.DrawRectangle(p3, r2);
            g.DrawRectangle(p3, r3);
            g.DrawRectangle(p3, r4);
            g.DrawRectangle(p3, r5);
            // 브러쉬 5가지 설정 및 채우기
            SolidBrush b1 = new SolidBrush(Color.Pink);
            g.FillRectangle(b1, r1);
            Image img = new Bitmap("C:\\Temp\\역도\\역도1.png");
            TextureBrush b2 = new TextureBrush(img);
            g.FillRectangle(b2, r2);
            HatchBrush b3 = new HatchBrush(HatchStyle.Sphere, Color.Blue, Color.Yellow);
            g.FillRectangle(b3, r3);
            LinearGradientBrush b4 =
                new LinearGradientBrush(new Point(0, 0), new Point(60, 60), Color.Red, Color.Blue);
            g.FillRectangle(b4, r4);
            Point[] pts =   // r5의 내의 기준점 3개 사용
            {
                new Point(1205, 10),
                new Point(1080, 210),
                new Point(1330, 210)
            };
            PathGradientBrush b5 = new PathGradientBrush(pts);
            g.FillRectangle(b5, r5);

            // 문자열 그리기.
            Font f1 = new Font("굴림", 15, FontStyle.Italic);
            Font f2 = new Font("신명조", 19);

            Rectangle r6 = new Rectangle(10, 300, 250, 50);
            g.DrawRectangle(p1, r6);
            g.DrawString("청운대학교", f2, b3, r6);

            // 이미지 그리기
            Image img2 = new Bitmap(@"C:\\Temp\\일반사진\\트리.png");
            Rectangle r7 = new Rectangle(200, 300, 400, 320);
            g.DrawImage(img2, r7);
        }
    }
}
