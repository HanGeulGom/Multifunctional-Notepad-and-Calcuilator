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
    public partial class 도움말_계산기 : Form
    {
        public 도움말_계산기()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mspproject2023.tistory.com/326");
        }
        
        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
           System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\Chrome.exe", e.LinkText);
        }
    }
}
