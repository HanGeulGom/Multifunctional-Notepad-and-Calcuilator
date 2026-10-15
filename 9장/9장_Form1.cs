using System.Diagnostics;
using System.Drawing.Printing;
using 윈도우즈프로그래밍_수업예제모음;
using 윈도우즈프로그래밍_수업예제모음_8장;

namespace _9장
{
    public partial class 마우스기본 : Form
    {
        public 마우스기본()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {// 열기대화상자의 속성 지정, 대화상자 보이기, 지정한 파일을 열기.
            openFileDialog1.FileName = "";
            openFileDialog1.Filter =
                "모든파일(*.*)|*.*|텍스트파일(*.txt)|*.txt|PDF파일(*.pdf)|*.pdf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;
            openFileDialog1.InitialDirectory = @"C:\";
            //대화상자 열기.
            openFileDialog1.ShowDialog();
            //지정한 파일들을 열어라.
            foreach (object i in openFileDialog1.FileNames)
            {
                textBox1.Text += i.ToString() + "\r\n";
                Process.Start("notepad.exe", i.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {// 글꼴 대화상자를 보이고, 지정한 폰트정보를 텍스트박스에 적용하라.
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {// 컬러 대화상자를 보이고, 지정한 색상을 텍스트박스의 바탕색으로.
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }



        private void PrintPage(object sender, PrintPageEventArgs e)
        { // 텍스트박스의 텍스트를 출력 내용(PDF같은 이미지)으로 구성
            string str = textBox1.Text; //텍스트박스 내용을 지정
            Font f = new Font("굴림", 16, FontStyle.Bold); //폰트 지정
            e.Graphics.DrawString(str, f, Brushes.Blue, 100, 100); //인쇄면 그리기
        }

        private void button7_Click(object sender, EventArgs e)
        {// 인쇄대화상자의 속성 지정, 대화상자 보이기, 원하는대로 출력하기.
            PrinterSettings printer = new PrinterSettings();
            // 대화상자에서 설정한 프린터 셋팅(기본 프린터가 있으면 자동)
            printDialog1.PrinterSettings = printer;
            // 인쇄할 내용을 저장할 PrintDocument 객체 pd 선언 및 생성
            PrintDocument pd = new PrintDocument();
            // 인쇄내용을 저장할 pd를 대화상자의 문서로 설정(인쇄문서 전달)
            printDialog1.Document = pd;
            // PrintPage 이벤트에 인쇄쪽을 구성하는 PrintPage() 메소드 델리게이팅
            pd.PrintPage += new PrintPageEventHandler(this.PrintPage);
            // 대화상자에서 인쇄의 “확인”or “취소" 선택결과를 result에 저장
            DialogResult result = printDialog1.ShowDialog();
            // ＂확인”을 클릭했다면 출력할 내용을 가진 pd를 프린팅 시작
            if (result == DialogResult.OK) pd.Print();
        }

        private void button8_Click(object sender, EventArgs e)
        {// 미리보기 대화상자를 보여라.
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintPage);
            printPreviewDialog1.Document = pd;
            // 인쇄와 달리 화면으로 인쇄하므로 프린터 설정은 없음
            printPreviewDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {// 저장 대화상자의 속성 지정하고, 대화상자 보이고, 원하는대로 저장.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter =
                "텍스트파일(*.txt)|*.txt|도큐먼트(*.doc)|*.doc|이미지문서(*.pdf)|*.pdf";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "") //저장 파일명이 지정되었다면
            {
                System.IO.FileStream fs = // 입출력스트림 객체 fs 생성(파일명)
            (System.IO.FileStream)saveFileDialog1.OpenFile();
                StreamWriter sw = new StreamWriter(fs); //파일스트림 생성 & 파일 연결
                sw.WriteLine(textBox1.Text); // 저장 대상은 텍스트박스 내용
                sw.Close(); fs.Close(); // 저장할 때 사용한 객체를 소멸
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {// 폴더탐색 대화상자를 열어서 선택한 폴더를 텍스트박스에 기록하라.
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button11_Click(object sender, EventArgs e)
        {// 텍스트박스에서 선택한 블록이 있으면 클립보드에 오려둬라.
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {// 텍스트박스에서 선택한 블록이 있으면 클립보드에 복사해둬라.
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {// 클립보드에 방금 저장한 텍스트정보가 있으면, 붙여넣어라.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                textBox1.Paste();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void 장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            윈도우즈프로그래밍_수업예제모음.Form1 f7 = new 윈도우즈프로그래밍_수업예제모음.Form1();
            f7.ShowDialog();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {// 열기대화상자의 속성 지정, 대화상자 보이기, 지정한 파일을 열기.
            openFileDialog1.FileName = "";
            openFileDialog1.Filter =
                "모든파일(*.*)|*.*|텍스트파일(*.txt)|*.txt|PDF파일(*.pdf)|*.pdf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;
            openFileDialog1.InitialDirectory = @"C:\";
            //대화상자 열기.
            openFileDialog1.ShowDialog();
            //지정한 파일들을 열어라.
            foreach (object i in openFileDialog1.FileNames)
            {
                textBox1.Text += i.ToString() + "\r\n";
                Process.Start("notepad.exe", i.ToString());
            }
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 저장 대화상자의 속성 지정하고, 대화상자 보이고, 원하는대로 저장.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter =
                "텍스트파일(*.txt)|*.txt|도큐먼트(*.doc)|*.doc|이미지문서(*.pdf)|*.pdf";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "") //저장 파일명이 지정되었다면
            {
                System.IO.FileStream fs = // 입출력스트림 객체 fs 생성(파일명)
            (System.IO.FileStream)saveFileDialog1.OpenFile();
                StreamWriter sw = new StreamWriter(fs); //파일스트림 생성 & 파일 연결
                sw.WriteLine(textBox1.Text); // 저장 대상은 텍스트박스 내용
                sw.Close(); fs.Close(); // 저장할 때 사용한 객체를 소멸
            }
        }

        private void 글꼴FToolStripMenuItem_Click(object sender, EventArgs e)
        {// 글꼴 대화상자를 보이고, 지정한 폰트정보를 텍스트박스에 적용하라.
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;
        }

        private void 색상CToolStripMenuItem_Click(object sender, EventArgs e)
        {// 컬러 대화상자를 보이고, 지정한 색상을 텍스트박스의 바탕색으로.
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }

        private void 인쇄PToolStripMenuItem_Click(object sender, EventArgs e)
        {// 인쇄대화상자의 속성 지정, 대화상자 보이기, 원하는대로 출력하기.
            PrinterSettings printer = new PrinterSettings();
            // 대화상자에서 설정한 프린터 셋팅(기본 프린터가 있으면 자동)
            printDialog1.PrinterSettings = printer;
            // 인쇄할 내용을 저장할 PrintDocument 객체 pd 선언 및 생성
            PrintDocument pd = new PrintDocument();
            // 인쇄내용을 저장할 pd를 대화상자의 문서로 설정(인쇄문서 전달)
            printDialog1.Document = pd;
            // PrintPage 이벤트에 인쇄쪽을 구성하는 PrintPage() 메소드 델리게이팅
            pd.PrintPage += new PrintPageEventHandler(this.PrintPage);
            // 대화상자에서 인쇄의 “확인”or “취소" 선택결과를 result에 저장
            DialogResult result = printDialog1.ShowDialog();
            // ＂확인”을 클릭했다면 출력할 내용을 가진 pd를 프린팅 시작
            if (result == DialogResult.OK) pd.Print();
        }

        private void 미리보기VToolStripMenuItem_Click(object sender, EventArgs e)
        {// 미리보기 대화상자를 보여라.
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintPage);
            printPreviewDialog1.Document = pd;
            // 인쇄와 달리 화면으로 인쇄하므로 프린터 설정은 없음
            printPreviewDialog1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void 폴더탐색SToolStripMenuItem_Click(object sender, EventArgs e)
        {// 폴더탐색 대화상자를 열어서 선택한 폴더를 텍스트박스에 기록하라.
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void 오려두기XToolStripMenuItem_Click(object sender, EventArgs e)
        {// 텍스트박스에서 선택한 블록이 있으면 클립보드에 오려둬라.
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
        }

        private void 복사하기CToolStripMenuItem_Click(object sender, EventArgs e)
        {// 텍스트박스에서 선택한 블록이 있으면 클립보드에 복사해둬라.
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void 붙여넣기VToolStripMenuItem_Click(object sender, EventArgs e)
        {// 클립보드에 방금 저장한 텍스트정보가 있으면, 붙여넣어라.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                textBox1.Paste();
            }
        }

        private void 되돌리기UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {//텍스트박스의 모든 문자열을 블록으로 선택하라.
            textBox1.SelectAll();
        }

        private void 새파일NToolStripMenuItem_Click(object sender, EventArgs e)
        {//메시지박스에서 저장여부를 확인해서 새문서 보이기.
            if (MessageBox.Show("저장하고 새 문서를 여시겠습니까?", "확인",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            { //ok를 클릭했다면
                saveFileDialog1.Filter = "텍스트|*.txt|도큐먼트|*.doc | 이미지문서 | *.pdf";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(textBox1.Text);
                    sw.Close(); fs.Close();
                }
                textBox1.Text = "";
            }
            else textBox1.Text = "";
        }





        private void 열기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {// 열기대화상자의 속성 지정, 대화상자 보이기, 지정한 파일을 열기.
            openFileDialog1.FileName = "";
            openFileDialog1.Filter =
                "모든파일(*.*)|*.*|텍스트파일(*.txt)|*.txt|PDF파일(*.pdf)|*.pdf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;
            openFileDialog1.InitialDirectory = @"C:\";
            //대화상자 열기.
            openFileDialog1.ShowDialog();
            //지정한 파일들을 열어라.
            foreach (object i in openFileDialog1.FileNames)
            {
                textBox1.Text += i.ToString() + "\r\n";
                Process.Start("notepad.exe", i.ToString());
            }
        }

        private void 기본ToolStripMenuItem_Click(object sender, EventArgs e)
        {//마우스기본 폼을 보여라.
            마우스기본1 f1 = new 마우스기본1();
            f1.ShowDialog();
        }

        private void 응용ToolStripMenuItem_Click(object sender, EventArgs e)
        {//마우스응용 폼을 보여라.
            마우스응용 f2 = new 마우스응용();
            f2.ShowDialog();
        }

        private void 기본ToolStripMenuItem1_Click(object sender, EventArgs e)
        {//키보드기본 폼을 보여라.
            키보드기본 f3 = new 키보드기본();
            f3.ShowDialog();
        }

        private void 응용ToolStripMenuItem1_Click(object sender, EventArgs e)
        {//키보드기본 폼을 보여라.
            키보드응용 f4 = new 키보드응용();
            f4.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            _11장 f11 = new _11장();
            f11.ShowDialog();
        }

        private void 번ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _12장_1 f12_1 = new _12장_1();
            f12_1.ShowDialog();
        }

        private void 번ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _12장_2 f12_2 = new _12장_2();
            f12_2.ShowDialog();
        }

        private void 장ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            윈도우즈프로그래밍_수업예제모음_8장.Form1 f8 = new 윈도우즈프로그래밍_수업예제모음_8장.Form1();
            f8.ShowDialog();
        }

        private void 종속ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            메인 fMain = new 메인();
            fMain.ShowDialog();
        }

        private void 아날로그시계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            시계 Clock1 = new 시계();
            Clock1.ShowDialog();
        }

        private void 공학계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            계산기 fCalculator = new 계산기();
            fCalculator.ShowDialog();
        }

        private void 시계개량ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            도움말_시계 fHelpClock = new 도움말_시계();
            fHelpClock.ShowDialog();
        }

        private void 계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            도움말_계산기 fHelpCaculator = new 도움말_계산기();
            fHelpCaculator.ShowDialog();
        }

        private void 제작자PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                제작자\n\n컴퓨터공학과 20230235 김다찬.\n\n" +
                "연락처: 010-8535-7430\n          dachan86@naver.com");
        }

        private void 마우스용인터페이스ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (마우스용인터페이스ToolStripMenuItem.Checked)
            {
                textBox1.Size = new Size(920, 570);
            }
            else
            {
                textBox1.Size = new Size(1010, 570);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 마우스용인터페이스ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            도움말_마우스용_인터페이스 fHelpMouse = new 도움말_마우스용_인터페이스();
            fHelpMouse.ShowDialog();
        }

        private void 로그인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            로그인 fLogin = new 로그인();
            fLogin.ShowDialog();
        }
    }
}
