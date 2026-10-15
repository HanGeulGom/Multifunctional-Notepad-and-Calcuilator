namespace 윈도우즈프로그래밍_수업예제모음
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            파일FToolStripMenuItem = new ToolStripMenuItem();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 12F);
            button1.Location = new Point(340, 112);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 0;
            button1.Text = "현재 시간";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 12F);
            button2.Location = new Point(340, 196);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 1;
            button2.Text = "종료";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 12F);
            button3.Location = new Point(340, 275);
            button3.Name = "button3";
            button3.Size = new Size(150, 50);
            button3.TabIndex = 2;
            button3.Text = "폼 색상 변경";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.Paint += button3_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 파일FToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1021, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            파일FToolStripMenuItem.Size = new Size(57, 20);
            파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // button4
            // 
            button4.Font = new Font("맑은 고딕", 12F);
            button4.Location = new Point(539, 123);
            button4.Name = "button4";
            button4.Size = new Size(80, 30);
            button4.TabIndex = 4;
            button4.Text = "여기";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("맑은 고딕", 12F);
            button5.Location = new Point(651, 123);
            button5.Name = "button5";
            button5.Size = new Size(80, 30);
            button5.TabIndex = 5;
            button5.Text = "저기";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("맑은 고딕", 12F);
            button6.Location = new Point(557, 198);
            button6.Name = "button6";
            button6.Size = new Size(150, 50);
            button6.TabIndex = 6;
            button6.Text = "form2 보이기";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1021, 581);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 파일FToolStripMenuItem;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
