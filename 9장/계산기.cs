using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _9장
{
    public partial class 계산기 : Form
    {
        public 계산기()
        {
            InitializeComponent();
            // 처음 수식 누적 카운팅 표기
            textBox2.Text = "0 / 30 (누적 수식 수)";
        }

        public string[] no = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
            "", "", "", "", "", "", "", "", "", "", "", "" };
        public string[] constfun = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
            "", "", "", "", "", "", "", "", "", "", "", "" };
        string r = "";
        public int countN = 0;
        public int countC = 0;
        // public int no2;
        public bool inputstatus;



        public void textbox2_counting()
        {
            if (countC == 31)
            {
                MessageBox.Show("최대 수식 누적치를 초과하였습니다.\n" +
                    "'=' 버튼을 눌러 계산하거나 'Prev' 버튼을 눌러 뒤로 가십시오.", "수식 허용량 초과 오류");
                no[countN] = "";
                constfun[countC] = "";
                countN = 30;
                countC = 30;
                textBox1.Focus();
            }
            else
            {
                textBox2.Text = countN + " / 30  (누적 수식 수)";
                textBox1.Focus();
            }
        }


        public void error_no_number()
        {
            MessageBox.Show("숫자를 입력하고 눌러주세요!", "숫자 미기입 계산 오류");
            textBox1.Focus();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button1.Text;

            }
            else
            {
                textBox1.Text = button1.Text;
                inputstatus = true;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button6.Text;

            }
            else
            {
                textBox1.Text = button6.Text;
                inputstatus = true;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button7.Text;

            }
            else
            {
                textBox1.Text = button7.Text;
                inputstatus = true;
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button8.Text;

            }
            else
            {
                textBox1.Text = button8.Text;
                inputstatus = true;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button11.Text;

            }
            else
            {
                textBox1.Text = button11.Text;
                inputstatus = true;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button12.Text;

            }
            else
            {
                textBox1.Text = button12.Text;
                inputstatus = true;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button13.Text;

            }
            else
            {
                textBox1.Text = button13.Text;
                inputstatus = true;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button16.Text;

            }
            else
            {
                textBox1.Text = button16.Text;
                inputstatus = true;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button17.Text;

            }
            else
            {
                textBox1.Text = button17.Text;
                inputstatus = true;
            }

        }
        //when 9 is pressed
        private void button18_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button18.Text;

            }
            else
            {
                textBox1.Text = button18.Text;
                inputstatus = true;
            }

        }

        //. button
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                if (inputstatus == true)
                {
                    textBox1.Text += button2.Text;

                }
                else
                {
                    textBox1.Text = button2.Text;
                    inputstatus = true;
                }
            }
        }

        //Add Operator 
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                no[countN] = textBox1.Text;
                textBox1.Text = "";
                constfun[countC] = "+";
                countN++;
                countC++;
                textbox2_counting();
            }
        }

        //subtract
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                no[countN] = textBox1.Text;
                textBox1.Text = "";
                constfun[countC] = "-";
                countN++;
                countC++;
                textbox2_counting();
            }
        }

        //multiply
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                no[countN] = textBox1.Text;
                textBox1.Text = "";
                constfun[countC] = "*";
                countN++;
                countC++;
                textbox2_counting();
            }
        }

        //divide
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                no[countN] = textBox1.Text;
                textBox1.Text = "";
                constfun[countC] = "/";
                countN++;
                countC++;
                textbox2_counting();
            }
        }

        //a user defined fun 
        private string funcal()
        {
            String result = "";
            for (int i = 0; i <= countN; i++)
            {
                switch (constfun[i])
                {
                    case "+":
                        no[i + 1] = Convert.ToString(Convert.ToDouble(no[i]) + Convert.ToDouble(no[i + 1]));

                        break;
                    case "-":
                        no[i + 1] = Convert.ToString(Convert.ToDouble(no[i]) - Convert.ToDouble(no[i + 1]));

                        break;
                    case "*":
                        no[i + 1] = Convert.ToString(Convert.ToDouble(no[i]) * Convert.ToDouble(no[i + 1]));
                        break;
                    case "/":
                        if (no[i + 1] == "0")
                        {
                            textBox1.Text = "infinity";
                            i = countC;
                        }
                        else
                        {

                            no[i + 1] = Convert.ToString(Convert.ToDouble(no[i]) / Convert.ToDouble(no[i + 1]));
                        }

                        break;
                    case "x^y":
                        no[i + 1] = Convert.ToString(System.Math.Pow(Convert.ToDouble(no[i]), Convert.ToDouble(no[i + 1])));
                        break;
                    case "mod":
                        no[i + 1] = Convert.ToString(Convert.ToDouble(no[i]) % Convert.ToDouble(no[i + 1]));
                        break;
                    case "nPr":
                        try
                        {
                            int varn, var2, var3;     //variable declaration
                            varn = factorial(Convert.ToInt32(no[i]));   //calling factorial function
                            var2 = factorial(Convert.ToInt32(no[i]) - Convert.ToInt32(no[i + 1]));
                            no[i + 1] = Convert.ToString(varn / var2);
                        }
                        catch
                        {
                            MessageBox.Show("입력된 수가 정수가 아닙니다. 'CE' 버튼으로 초기화 후 다시 계산해주세요.", "계산 타입 오류");
                        }
                        finally { textBox1.Focus(); }
                        break;
                    case "nCr":
                        try
                        {
                            int varn, var2, var3;     //variable declaration
                            varn = factorial(Convert.ToInt32(no[i]));
                            var2 = factorial(Convert.ToInt32(no[i]) - Convert.ToInt32(no[i + 1]));
                            var3 = factorial(Convert.ToInt32(textBox1.Text));
                            no[i + 1] = Convert.ToString(varn / (var3 * var2));
                        }
                        catch
                        {
                            MessageBox.Show("입력된 수가 정수가 아닙니다. 'CE' 버튼으로 초기화 후 다시 계산해주세요.", "계산 타입 오류");
                        }
                        finally
                        {
                            textBox1.Focus();
                        }
                        break;
                    case "pass":
                        break;
                    case "==":
                        result = no[i];
                        i = countN + 1;
                        break;
                }
            }
            return result;
        }


        //a user defined function to calculate factorial 
        private int factorial(int x)
        {
            int i = 1;
            for (int s = 1; s <= x; s++)
            {
                i = i * s;
            }
            return i;
        }


        //when = button is pressed
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                no[countN] = textBox1.Text;
                constfun[countN] = "==";
                textBox1.Text = "";
                countN++;
                countC++;
                r = funcal();
                inputstatus = false;
                textBox1.Text = r;
                countN = 0;
                countC = 0;
                textBox2.Text = countN + " / 30  (누적 수식 수)";
            }
        }


        //when AC is pressed to power on
        private void button14_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= countN; i++)
            {
                no[i] = "0";
                constfun[i] = "0";
            }
            textBox1.Enabled = true;
            textBox1.Text = "0";
        }


        //calculating x raise to power 2
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
                inputstatus = false;
            }
        }

        //calculating x raise to power 3
        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
                inputstatus = false;
            }
        }

        //calculating squareroot
        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
                countN++;
                countC++;
                textbox2_counting();
            }
        }


        //x raise to power y
        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                no[countN] = textBox1.Text;
                textBox1.Text = "";
                constfun[countC] = "x^y";
                countN++;
                countC++;
                textbox2_counting();
            }
        }


        //when CE button is pressed
        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            inputstatus = true;
        }

        //To set Pi value
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592654";

        }

        //sin function
        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                //if radian is selected

                if (radioButton3.Checked == true)
                {

                    textBox1.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(textBox1.Text)));
                    inputstatus = false;
                }
                //if degree is selected
                else
                {
                    textBox1.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                    inputstatus = false;
                }
                countN++;
                countC++;
                textbox2_counting();
            }
        }


        //cos function
        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                //radian selected
                if (radioButton3.Checked == true)
                {
                    textBox1.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(textBox1.Text)));
                    inputstatus = false;
                }

                //degree selected
                else
                {
                    textBox1.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                    inputstatus = false;
                }
                countN++;
                countC++;
                textbox2_counting();
            }
        }


        //tan function
        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                //radian selected
                if (radioButton3.Checked == true)
                {

                    textBox1.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(textBox1.Text)));
                    inputstatus = false;
                }

                //degree selected
                else
                {
                    textBox1.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                    inputstatus = false;
                }
                countN++;
                countC++;
                textbox2_counting();
            }
        }


        //calculationg 1/x
        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
                countN++;
                countC++;
                textbox2_counting();
            }
        }


        //calculting x! 
        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                int var1 = 1;
                for (int i = 1; i <= Convert.ToInt16(textBox1.Text); i++)
                {
                    var1 = var1 * i;
                }
                textBox1.Text = Convert.ToString(var1);
                inputstatus = false;
                countN++;
                countC++;
                textbox2_counting();
            }
        }

        //calculationg log10
        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Log10(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
                countN++;
                countC++;
                textbox2_counting();
            }
        }


        //calculation natural log
        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Log(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
                countN++;
                countC++;
                textbox2_counting();
            }
        }





        //backspace key is presseed
        private void button31_Click(object sender, EventArgs e)
        {
            no[countN] = textBox1.Text;
            int n = no[countN].Length;
            if (textBox1.Text == "")
            {
            }
            else
            {
                textBox1.Text = (no[countN].Substring(0, n - 1));
            }
        }

        //when mod operator(%) is presseed
        private void button32_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                no[countN] = textBox1.Text;
                textBox1.Text = "";
                constfun[countC] = "mod";
                countN++;
                countC++;
                textbox2_counting();
            }
        }

        //coding for +/- key
        private void button33_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                textBox1.Text = Convert.ToString(-Convert.ToDouble(textBox1.Text));
                inputstatus = false;
                countN++;
                countC++;
                textbox2_counting();
            }
        }


        //Sin inverese fun
        private void button35_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                if (radioButton3.Checked == true)
                {

                    textBox1.Text = Convert.ToString(System.Math.Asin(Convert.ToDouble(textBox1.Text)));
                    inputstatus = false;
                }
                else
                {
                    textBox1.Text = Convert.ToString(System.Math.Asin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                    inputstatus = false;
                }
                countN++;
                countC++;
                textbox2_counting();
            }
        }

        //cos inverese fun
        private void button34_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                if (radioButton3.Checked == true)
                {

                    textBox1.Text = Convert.ToString(System.Math.Acos(Convert.ToDouble(textBox1.Text)));
                    inputstatus = false;
                }
                else
                {
                    textBox1.Text = Convert.ToString(System.Math.Acos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                    inputstatus = false;
                }
                countN++;
                countC++;
                textbox2_counting();
            }
        }

        //tan inverese fun
        private void button36_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                if (radioButton3.Checked == true)
                {

                    textBox1.Text = Convert.ToString(System.Math.Atan(Convert.ToDouble(textBox1.Text)));
                    inputstatus = false;
                }
                else
                {
                    textBox1.Text = Convert.ToString(System.Math.Atan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                    inputstatus = false;
                }
                countN++;
                countC++;
                textbox2_counting();
            }
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {


        }


        //permutation
        private void button37_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                no[countN] = textBox1.Text;
                textBox1.Text = "";
                constfun[countC] = "nPr";
                countN++;
                countC++;
                textbox2_counting();
            }
        }

        //combination
        private void button38_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                error_no_number();
            }
            else
            {
                no[countN] = textBox1.Text;
                textBox1.Text = "";
                constfun[countC] = "nCr";
                countN++;
                countC++;
                textbox2_counting();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Focus();
        }


        //coding for off button
        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = "";
            inputstatus = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Text = "";
            inputstatus = true;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (countN == 0)
            {
                MessageBox.Show("이전 내역이 없거나 이미 계산되었습니다.", "뒤로가기 오류");
                textBox1.Focus();
            }
            else
            {
                countN--;
                countC--;
                textBox1.Text = no[countN];
                no[countN] = "";
                constfun[countC] = "";
                textBox2.Text = countN + " / 30  (현재 누적 수식 수 / 최대 수)";
                textBox1.Focus();
            }
        }
    }
}
