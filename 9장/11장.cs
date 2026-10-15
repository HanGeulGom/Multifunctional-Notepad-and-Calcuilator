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

namespace _9장
{
    public partial class _11장 : Form
    {
        private int index;
        private Image[] images;
        private int size = 5;

        private int index2;
        private Image[] images2;
        private int size2 = 21;

        public _11장()
        {
            InitializeComponent();
            treeView1.ExpandAll();

            //이미지 배열 생성 및 이미지 가져오기.
            images = new Image[size];
            images2 = new Image[size2];

            //이미지 패스 및 파일명 지정.
            string path = @"C:\\Temp\\역도\\역도";
            for (int i = 1; i < size; i++)
            {
                images[i] = Image.FromFile(path + i + ".png");
            }

            //이미지 패스 및 파일명 지정.
            string path2 = @"C:\\Temp\\골프테니스\\테니스";
            for (int i = 1; i < size2; i++)
            {
                images2[i] = Image.FromFile(path2 + i + ".png");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {//리스트뷰를 "큰 아이콘 보기"로 보여라.
            listView1.View = View.LargeIcon;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {//리스트뷰를 "작은 아이콘 보기"로 보여라.
            listView1.View = View.SmallIcon;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {//리스트뷰를 "목록 보기"로 보여라.
            listView1.View = View.List;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {//리스트뷰를 "타일 보기"로 보여라.
            listView1.View = View.Tile;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {//리스트뷰를 "자세히 보기"로 보여라.
            listView1.View = View.Details;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//선택한 아이템 번호대로 리스트뷰를 보여라.
            if (comboBox1.SelectedIndex == 0)
            {
                listView1.View = View.LargeIcon;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listView1.View = View.SmallIcon;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                listView1.View = View.List;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                listView1.View = View.Tile;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                listView1.View = View.Details;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {//트리뷰에서 선택한 노드가 있고, 텍스트박스에 노드명이 주어졌다면 삽입.
            if (treeView1.SelectedNode != null && textBox1.Text != "")
            {
                TreeNode x = new TreeNode(textBox1.Text, 12, 277);
                treeView1.SelectedNode.Nodes.Add(x);
                // treeView1.SelectedNode.Nodes.Add(new TreeNode(textBox1.Text, 12, 277));
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//트리뷰에서 선택한 노드가 있다면 삭제하라.
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Remove(treeView1.SelectedNode);
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
        }

        private void domainUpDown1_MouseClick(object sender, MouseEventArgs e)
        {//트리뷰에서 선택한 노드가 있고, 업다운에서 아이템을 선택했다면 노드 추가.
            if (treeView1.SelectedNode != null && domainUpDown1.SelectedIndex > -1)
            {
                TreeNode x = new TreeNode(domainUpDown1.SelectedItem.ToString(), 12, 277);
                treeView1.SelectedNode.Nodes.Add(x);
                // treeView1.SelectedNode.Nodes.Add(new TreeNode(domainUpDown1.SelectedItem.ToString(), 12, 277));
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {//수치업다운의 값이 바뀌면 3가지 함수 계산값도 함께 변경.
            double d = (double)numericUpDown1.Value;

            textBox2.Text = System.Math.Log2(d).ToString();
            textBox2.Text = System.Math.Pow(d, 2).ToString();
            textBox2.Text = System.Math.Sqrt(d).ToString();

            trackBar1.Value = (int)numericUpDown1.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {//트랙바의 값이 바뀌면, 수치업다운과 연동시켜라.
            numericUpDown1.Value = trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < size)
            {
                label4.Image = images[index++];
            }
            else
            {
                index = 1;
                label4.Image = images[index++];
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (index2 < size2)
            {
                label5.Image = images2[index2++];
            }
            else
            {
                index2 = 1;
                label5.Image = images2[index2++];
            }
        }
    }
}
