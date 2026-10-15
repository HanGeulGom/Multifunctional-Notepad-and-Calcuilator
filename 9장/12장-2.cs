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
    public partial class _12장_2 : Form
    {
        public _12장_2()
        {
            InitializeComponent();
        }

        private void _12장_2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //펜 2가지
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Blue, 5);
            //좌표 2가지
            Point pt1 = new Point(10, 10); //좌표 기재 안할시 기본 좌표값 0, 0
            Point pt2 = new Point(100, 100);
            //선분 그리기
            g.DrawLine(p1, pt1, pt2);
            g.DrawLine(p2, new Point(10, 110), new Point(110, 10));

            //회오리 그리지
            Point[] pts1 = { //시작점, 끝점 그룹을 지정
                new Point(40, 40), new Point(180, 40),
                new Point(180, 180), new Point(40, 180),
                new Point(40, 60), new Point(160, 60),
                new Point(160, 160), new Point(60, 160),
                new Point(60, 80), new Point(140, 80),
                new Point(140, 140), new Point(80, 140),
                new Point(80, 100), new Point(120, 100),
                new Point(120, 120), new Point(100, 120)
            };
            g.DrawLines(new Pen(Color.BlueViolet), pts1);

            //원 그리기
            Rectangle r1 = new Rectangle(200, 10, 100, 100);
            Rectangle r2 = new Rectangle(300, 10, 200, 100);
            g.DrawEllipse(p1, r1);  //정원
            g.FillEllipse(Brushes.Aqua, r1);
            g.DrawEllipse(p2, r2);  //타원
            g.FillEllipse(Brushes.Pink, r2);

            //아크 그리기
            Rectangle r3 = new Rectangle(600, 10, 200, 200);
            g.DrawArc(p2, r3, 30, 300);

            //파이 그리기
            g.DrawPie(p1, r3, 30, 300);
            g.FillPie(Brushes.Aqua, r3, 30, 300);

            //별 그리기
            Point[] pts2 = { //별 모양의 다각형 좌표값 그룹
                new Point(110, 220), new Point(125, 271),
                new Point(180, 271), new Point(135, 303),
                new Point(152, 352), new Point(110, 321),
                new Point(66, 352), new Point(82, 303),
                new Point(40, 271), new Point(95, 271)
            };
            g.FillPolygon(Brushes.Pink, pts2);
            g.DrawPolygon(Pens.Purple, pts2);

            //곡선 그리기
            Point[] pts = { //중간 점은 제어점
                new Point(40, 100), new Point(50, 60),
                new Point(60, 50), new Point(70, 60),
                new Point(80, 100), new Point(90, 140),
                new Point(100, 150), new Point(110, 140),
                new Point(120, 100), new Point(130, 60),
                new Point(140, 50), new Point(150, 60),
                new Point(160, 100), new Point(170, 140),
                new Point(180, 150), new Point(190, 140),
                new Point(200, 100)
            };
            g.DrawCurve(Pens.Red, pts);

            //문자열 그리기
            Font f1 = new Font("굴림", 14);
            Font f2 = new Font("신명조체", 20, FontStyle.Italic);
            g.DrawString("청운대학교 컴퓨터공학과", f1, Brushes.BlueViolet, 400, 400);
            Rectangle r4 = new Rectangle(400, 450, 400, 40);
            g.DrawString("청운대학교 컴퓨터공학과", f1, Brushes.BlueViolet, r4);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            g.DrawString("청운대 컴퓨터공학과", f1, Brushes.BlueViolet, r4, sf);

            SizeF cm = g.MeasureString("청운대학교 컴퓨터공학과 2학년 김다찬", f2);

            Rectangle r5 = new Rectangle(500, 550, (int)cm.Width, (int)cm.Height);
            g.DrawRectangle(p1, r5);
            g.DrawString("청운대 컴퓨터공학과", f2, Brushes.BlueViolet, r5, sf);

            //이미지 그리기
            Image im1 = new Bitmap("C:\\Temp\\일반사진\\트리.png");
            Rectangle r8 = new Rectangle(800, 50, 300, 300);
            g.DrawImage(im1, r8);
            Point[] pts10 = {
                new Point(0, 0), // ① 원본의 왼쪽 상단 모서리의 대상 위치
                new Point(200, 0), // ② 원본의 오른쪽 상단 모서리의 대상 위치
                new Point(50, 100) // ③ 원본의 왼쪽 하단 모서리의 대상 위치            
            };
        }
    }
}
