namespace 윈도우즈프로그래밍_수업예제모음
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {//현재날짜 시간을 보여라.
            DateTime t = DateTime.Now;
            MessageBox.Show(t.ToString(), "현재 시간");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료 확인",
                             MessageBoxButtons.OKCancel,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {//버튼을 클릭할 때 마다 폼의 바탕색을 변경하라.
            Invalidate();
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {//Invakudate() 메소드에 의해 폼을 다시 그려라
            Graphics g = e.Graphics;
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));

            g.FillRectangle(new SolidBrush(c), e.ClipRectangle);
        }

        private void button4_Click(object sender, EventArgs e)
        {   //버튼5에 포커스 주고 회색으로, 버튼4는 밝은색
            button5.Focus();
            button5.BackColor = Color.Gray;
            button4.BackColor = Color.Pink;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Focus();
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Pink;
        }

        private void button6_Click(object sender, EventArgs e)
        {   //폼2을 등록하고, 보이기
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }
    }
}
