using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; //2차원 그래픽스 사용.
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9장
{
    public partial class 시계 : Form
    {
        // 초,분,시침을 만들 4개의 점을 위한 배열
        PointF[] second_face = new PointF[4]; // 초침 모양
        PointF[] minute_face = new PointF[4]; // 분침 모양
        PointF[] hour_face = new PointF[4]; // 시침 모양

        // 만들어진 초,분,시침의 초당 회전각을 저장하는 배열
        Matrix matrix_s = new Matrix(); // 초침 회전 각도 초당 6도
        Matrix matrix_m = new Matrix(); // 분침 회전 각도 초당 6/60도
        Matrix matrix_h = new Matrix(); // 시침 회전 각도 초당 30/3600도

        // 시점, 분점 다각형 좌표를 저장할 배열
        PointF[] h_dot = new PointF[4];
        PointF[] m_dot = new PointF[4];

        // 시점, 분점을 차례대로 그릴 때, 적용할 회전각을 저장하는 배열
        Matrix matrix_h_dot = new Matrix(); // 시점의 회전각 = 30’
        Matrix matrix_m_dot = new Matrix(); // 분점의 회전각 = 6’


        public 시계()
        {
            InitializeComponent();
            Init_Clock(); // 시계 디자인을 셋업하는 메소드 실행
        }

        private void Init_Clock()
        { // 시점 다각형 좌표 지정
            h_dot[0] = new PointF(-2, -198);
            h_dot[1] = new PointF(2, -198);
            h_dot[2] = new PointF(2, -192);
            h_dot[3] = new PointF(-2, -192);
            // 분점 다각형 좌표 지정
            m_dot[0] = new PointF(-1, -198);
            m_dot[1] = new PointF(1, -198);
            m_dot[2] = new PointF(1, -196);
            m_dot[3] = new PointF(-1, -196);

            // 초침 다각형 좌표 지정
            second_face[0] = new PointF(0, -190); //길이 190pts, 두께 2pts
            second_face[1] = new PointF(-1, -160);
            second_face[2] = new PointF(0, 0);
            second_face[3] = new PointF(1, -160);
            // 분침 다각형 좌표 지정
            minute_face[0] = new PointF(0, -170); //길이 170pts, 두께 6pts
            minute_face[1] = new PointF(-3, -140);
            minute_face[2] = new PointF(0, 0);
            minute_face[3] = new PointF(3, -140);
            // 시침 다각형 좌표 지정
            hour_face[0] = new PointF(0, -150); //길이 150pts, 두께 10pts
            hour_face[1] = new PointF(-5, -130);
            hour_face[2] = new PointF(0, 0);
            hour_face[3] = new PointF(5, -130);

            // 초,분,시침의 시작 각도를 설정하기 위하여 현재시간에서 추출
            float startS = DateTime.Now.Second; // 예) 14:20:55
            float startM = DateTime.Now.Minute; // 예) 14:20:55
            float startH = DateTime.Now.Hour; // 예) 14:20:55
                                              // 시점, 분점의 회전각도를 지정하기 전에 회전 Matrix를 0’로 초기화
            matrix_h_dot.Reset();
            matrix_m_dot.Reset();
            // 초침,분침,시침의 회전각도를 지정하기 전에 회전 Matrix를 0’로 초기화
            matrix_s.Reset();
            matrix_m.Reset();
            matrix_h.Reset();

            
            // 현재 초에 대한 회전각도 : (초침)초당 6’, (분침)분당 6’+초, (시침)시당 30’+분+초
            // 이전 위치에서 다음 위치로 추가 그리기를 위하여 Append 적용
            matrix_s.Rotate((float)((startS - 1) * 6.0f), MatrixOrder.Append);
            matrix_m.Rotate((float)((startM) * 6.0f + (startS) * 1 / 10.0f),
            MatrixOrder.Append);
            matrix_h.Rotate((float)((startH) * 30.0f + startM * (30 / 60f) +
            startS * (30 / 3600f)), MatrixOrder.Append);
            //시점(30도), 분점(6도)을 그리기 위해서 회전각도 지정
            matrix_h_dot.Rotate(30.0f, MatrixOrder.Append);
            matrix_m_dot.Rotate(6.0f, MatrixOrder.Append);
            // 초침, 분침, 시침 좌표 기준이 (200, 200)이므로 (0, 0) 좌표로 상대적 변환
            matrix_s.TransformPoints(second_face);
            matrix_m.TransformPoints(minute_face);
            matrix_h.TransformPoints(hour_face);
        }   // Init_Clock() 끝

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;
            string current = string.Format("{0}시 {1}분 {2}초", hour, min, sec + 1);
            String s = "현재 시간 : " + current;
            this.Text = s;
            // interval 1000ms 마다 Invalidate() 호출 ➔ OnPaint() 메소드를 자동 호출
            this.Invalidate();
        }

        private void 시계_Paint(object sender, PaintEventArgs e)
        {//1초마다 Init_Clock() 호출해서 시계를 다시 그려라.
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality; //경계면 부드럽게
            g.TranslateTransform(205f, 210f); //(200, 200) ➔ (0, 0) 좌표 상대변환
            
            DrawCircle(g); //시계 테두리, 배경색 그리는 메소드 호출
            /*
           for (int i = 0; i < 60; i++)
           { //시점, 분점을 회전각에 의해서 그리기
               if (i % 5 == 0) g.FillPolygon(Brushes.Red, h_dot);
               else g.FillPolygon(Brushes.Black, m_dot);
               matrix_h_dot.TransformPoints(h_dot); //시점 회전
               matrix_m_dot.TransformPoints(m_dot);//분점 회전
           }
           */
            //시침, 분침, 초침 그리는 메소드를 각각 호출
            DrawSecond(g); DrawMinute(g); DrawHour(g);
        }

        private void DrawCircle(Graphics g)
        { // 시계 원 그리기 & 채우기
            /*  Pen xpen = new Pen(Color.Blue, 2);
              g.DrawArc(xpen, new Rectangle(-200, -200, 400, 400), 0.0f, 360.0f);
              g.FillEllipse(Brushes.Gold, new Rectangle(-200, -200, 400, 400));
              // 시계 중점 그리기
              g.FillEllipse(Brushes.Black, new Rectangle(-2, -2, 4, 4));
              // 12, 3, 9시 숫자 그려넣기
              Font f1 = new System.Drawing.Font("맑은 고딕", 12);
              g.DrawString("12", f1, Brushes.Black, -15, -190);
              g.DrawString("3", f1, Brushes.Black, 170, -7);
              //g.DrawString("6", f1, Brushes.Black, -8, 160); 오늘 날짜를 그리기 위해서 제외
              g.DrawString("9", f1, Brushes.Black, -185, -7);
              // 날짜 보이기
            */
            Font f2 = new System.Drawing.Font("굴림", 9);
            Rectangle r = new Rectangle(-10, 173, 20, 20);
            //g.DrawRectangle(Pens.Black, r);
            //g.FillRectangle(Brushes.Ivory, r);

            StringFormat sf = new StringFormat(); // 텍스트 정렬 객체
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            g.DrawString(DateTime.Now.Day.ToString(), f2, Brushes.Black, r, sf);
            /*
            // 브랜드 상표 보이기
            Font f3 = new System.Drawing.Font("Times New Roman", 15);
            Rectangle brand = new Rectangle(-50, -120, 100, 18);
            g.DrawString("DC_MEGA", f3, Brushes.Black, brand, sf);
            xpen.Dispose();
          */

        } // DrawCircle() 메소드 의 끝

        private void DrawSecond(Graphics g)
        {
            // Matrix를 이용하여 초침을 회전시키기 전에 초기화
            matrix_s.Reset();
            // 다각형의 4점 회전각을 변경(초당 360/60도)
            matrix_s.Rotate(6.0f);
            // 다각형의 4점 좌표값을 원점 기준으로 재조정
            matrix_s.TransformPoints(second_face);
            // 다각형에 컬러를 지정하여 초침 그리기
            // 다각형의 4점을 6도 회전시키고, 초침 그리기를 1초마다 반복
            g.FillPolygon(new SolidBrush(Color.Black), second_face);
        }

        private void DrawMinute(Graphics g)
        {
            // Matrix를 이용하여 분침을 회전시키기 전에 초기화
            matrix_m.Reset();
            // 다각형의 4점 회전각을 경(초당 6/60도)
            matrix_m.Rotate(6 / 60f);
            // 다각형의 4점 좌표값을 원점 기준으로 재조정
            matrix_m.TransformPoints(minute_face);
            // 다각형에 컬러를 지정하여 분침 그리기
            // 다각형의 4점을 6/60도 움직이고 분침 그리기를 1초마다 반복
            g.FillPolygon(new SolidBrush(Color.Blue), minute_face);
        }

        private void DrawHour(Graphics g)
        {
            // Matrix를 이용하여 시침을 회전하기 전에 초기화
            matrix_h.Reset();
            // 다각형의 4점 회전각을 변경(30/3600도)
            matrix_h.Rotate(30 / 3600f);
            // 다각형의 4점 좌표값을 원점 기준으로 재조정
            matrix_h.TransformPoints(hour_face);
            // 다각형에 컬러를 지정하여 시침 그리기
            // 다각형의 4점을 30/3600도 움직이고 시침 그리기를 1초마다 반복
            g.FillPolygon(new SolidBrush(Color.Red), hour_face);
        }
    }
}
