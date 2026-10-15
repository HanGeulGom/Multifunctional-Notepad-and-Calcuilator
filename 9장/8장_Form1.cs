using System.Diagnostics;
using 윈도우즈프로그래밍_수업예제모음;

namespace 윈도우즈프로그래밍_수업예제모음_8장
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            윈도우즈프로그래밍_수업예제모음.Form1 f7 = new 윈도우즈프로그래밍_수업예제모음.Form1();
            f7.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = button2.FlatStyle.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = button3.FlatStyle.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = button4.FlatStyle.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = button5.FlatStyle.ToString();
        }


        //과일 체크박스
        private string str;

        private void Updatelabel(string s, bool b)
        {
            if (b)
            {
                label5.Text += s + " ";
            }
            else
            {
                str = label5.Text;
                int i = str.IndexOf(s);
                int j = i + s.Length;
                label5.Text = str.Remove(i, j + 1);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Updatelabel(checkBox1.Text, checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Updatelabel(checkBox2.Text, checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Updatelabel(checkBox3.Text, checkBox3.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Updatelabel(checkBox4.Text, checkBox4.Checked);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = radioButton4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label10.Text = "나는 " + label5.Text + "를 좋아하는" + label8.Text + "의"
            + label11.Text + "학생 입니다.";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = radioButton8.Text;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = radioButton7.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = radioButton6.Text;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = radioButton5.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//엣지를 불러서 홈피를 열어라.
            Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", linkLabel1.Text);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", linkLabel2.Text);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("notepad.exe", linkLabel3.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {//아이디, 비번이 맞을때, 비번만 틀릴때, 아이디부터 틀릴때.
            if (textBox1.Text == "abc")
            {
                if (textBox2.Text == "1234")
                {
                    MessageBox.Show("abc님, 로그인을 환영합니다.", "로그인 성공");
                    textBox3.Text = "아이디 : " + textBox1.Text + "\r\n" +
                                    "비번 : " + textBox2.Text;
                    textBox1.Text = textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀렸습니다.", "로그인 실패");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
            }
            else
            {
                MessageBox.Show("아이디가 틀렸습니다.", "로그인 실패");
                textBox1.Text = textBox2.Text = "";
                textBox1.Focus();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {//텍스트박스4의 과목명을 리스트박스의 아이템으로 추가.
            if (textBox4.Text == "")
            {
                MessageBox.Show("과목명을 입력해주세요.", "과목입력 오류");
                textBox4.Text = "";
                textBox5.Text = "";
                textBox4.Focus();
            }
            else if (textBox5.Text != "")
            {
                listBox1.Items.Insert(int.Parse(textBox5.Text), textBox4.Text);
                textBox4.Text = "";
                textBox5.Text = "";
                textBox4.Focus();
            }
            else
            {
                listBox1.Items.Add(textBox4.Text);
                textBox4.Text = "";
                textBox5.Text = "";
                textBox4.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {//리스트박스에서 선택한 아이템이 있으면, 삭제하라.
            if (listBox1.SelectedItem != null)
            {
                while (listBox1.SelectedItem != null)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("과목명을 입력해주세요.", "과목입력 오류");
                textBox4.Text = "";
                textBox5.Text = "";
                textBox4.Focus();
            }
            else if (textBox5.Text != "")
            {
                comboBox1.Items.Insert(int.Parse(textBox5.Text), textBox4.Text);
                textBox4.Text = "";
                textBox5.Text = "";
                textBox4.Focus();
            }
            else
            {
                comboBox1.Items.Add(textBox4.Text);
                textBox4.Text = "";
                textBox5.Text = "";
                textBox4.Focus();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                while (comboBox1.SelectedItem != null)
                {
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {//리스트박스에서 선택한 아이템이 있으면, 콤보박스로 이동시켜라
            if (listBox1.SelectedItem != null)
            {
                if (textBox5.Text != "")
                {
                    while (listBox1.SelectedItem != null)
                    {
                        comboBox1.Items.Insert(int.Parse(textBox5.Text), listBox1.SelectedItem);
                        listBox1.Items.Remove(listBox1.SelectedItem);
                    }
                    textBox5.Text = "";
                }
                else
                {
                    while (listBox1.SelectedItem != null)
                    {
                        comboBox1.Items.Add(listBox1.SelectedItem);
                        listBox1.Items.Remove(listBox1.SelectedItem);
                    }
                    textBox5.Text = "";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (textBox5.Text != "")
                {
                    while (listBox1.SelectedItem != null)
                    {
                        listBox1.Items.Insert(int.Parse(textBox5.Text), comboBox1.SelectedItem);
                        comboBox1.Items.Remove(comboBox1.SelectedItem);
                    }
                    textBox5.Text = "";
                }
                else
                {
                    while (comboBox1.SelectedItem != null)
                    {
                        listBox1.Items.Add(comboBox1.SelectedItem);
                        comboBox1.Items.Remove(comboBox1.SelectedItem);
                    }
                    textBox5.Text = "";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {//체크리스트박스에서 체크된 아이템들을 추출하여 메시지박스로 전달.
            string s = "";
            foreach (object obj in checkedListBox1.CheckedItems)
            {
                s += obj.ToString() + " ";
            }
            MessageBox.Show(s, "취미 선택");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("과목명을 입력해주세요.", "과목입력 오류");
                textBox4.Text = "";
                textBox5.Text = "";
                textBox4.Focus();
            }
            else if (textBox5.Text != "")
            {
                checkedListBox1.Items.Insert(int.Parse(textBox5.Text), textBox4.Text);
                textBox4.Text = "";
                textBox5.Text = "";
                textBox4.Focus();
            }
            else
            {
                checkedListBox1.Items.Add(textBox4.Text);
                textBox4.Text = "";
                textBox5.Text = "";
                textBox4.Focus();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
            {
                
                foreach (object obj in checkedListBox1.CheckedItems)
                {
                    checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
                }
            }
        }
    }
}
