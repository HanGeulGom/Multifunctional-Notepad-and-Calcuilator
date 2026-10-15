namespace _9장
{
    partial class 키보드응용
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 438);
            button1.Name = "button1";
            button1.Size = new Size(799, 31);
            button1.TabIndex = 0;
            button1.Text = "클리어";
            button1.UseVisualStyleBackColor = true;
            // 
            // 키보드응용
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(button1);
            Name = "키보드응용";
            Text = "키보드응용";
            //Load += 키보드응용_Load;
            //Paint += 키보드응용_Paint;
            //MouseUp += 키보드응용_MouseUp;
            //Resize += 키보드응용_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}