namespace _9장
{
    partial class 도움말_마우스용_인터페이스
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("맑은 고딕", 13F);
            textBox2.Location = new Point(2, 86);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(799, 126);
            textBox2.TabIndex = 3;
            textBox2.TabStop = false;
            textBox2.Text = "1. 사용 방법 및 설명\r\n ㄴ 1-1. 본 기능은 키보드 사용이 어렵거나 마우스 사용이 편리한 사용자들에게 추천합니다.\r\n ㄴ 1-2. 토글 방식이며 토글을 켰을시 메모장 우측면에 마우스로 누를 수 있는 버튼들이 추가됩니다.\r\n ㄴ 1-3. 토글이 꺼지면 인터페이스는 다시 사라집니다.\r\n ㄴ 1-4. 각 버튼의 기능은 메뉴바의 기능과 동일합니다.";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("맑은 고딕", 20F);
            textBox1.Location = new Point(233, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(347, 36);
            textBox1.TabIndex = 2;
            textBox1.TabStop = false;
            textBox1.Text = "마우스용 인터페이스 도움말";
            // 
            // 도움말_마우스용_인터페이스
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 217);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "도움말_마우스용_인터페이스";
            Text = "도움말_마우스용_인터페이스";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
    }
}