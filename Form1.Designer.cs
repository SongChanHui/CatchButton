namespace CatchButton
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
            MyButton = new Button();
            SuspendLayout();
            // 
            // MyButton
            // 
            MyButton.BackColor = Color.Cyan;
            MyButton.Font = new Font("휴먼둥근헤드라인", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            MyButton.Location = new Point(546, 270);
            MyButton.Name = "MyButton";
            MyButton.Size = new Size(510, 170);
            MyButton.TabIndex = 0;
            MyButton.Text = "잡으면 햄버거\r\n";
            MyButton.UseVisualStyleBackColor = false;
            MyButton.Click += button1_Click;
            MyButton.MouseEnter += MyButton_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1659, 895);
            Controls.Add(MyButton);
            Name = "Form1";
            Text = "버튼 잡기 게임";
            ResumeLayout(false);
        }

        #endregion

        private Button MyButton;
    }
}
