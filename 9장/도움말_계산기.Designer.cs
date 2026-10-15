namespace _9장
{
    partial class 도움말_계산기
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(도움말_계산기));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("맑은 고딕", 20F);
            textBox1.Location = new Point(343, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(177, 36);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "계산기 도움말";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("맑은 고딕", 13F);
            textBox2.Location = new Point(-1, 85);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(921, 542);
            textBox2.TabIndex = 1;
            textBox2.TabStop = false;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("맑은 고딕", 13F, FontStyle.Regular, GraphicsUnit.Point, 129);
            richTextBox1.Location = new Point(553, 587);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(307, 29);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "https://mspproject2023.tistory.com/326";
            richTextBox1.LinkClicked += richTextBox1_LinkClicked;
            // 
            // 도움말_계산기
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 628);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "도움말_계산기";
            Text = "도움말_계산기";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}