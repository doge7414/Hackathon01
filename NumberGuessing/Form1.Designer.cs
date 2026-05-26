namespace NumberGuessing
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 38);
            button1.Name = "button1";
            button1.Size = new Size(122, 59);
            button1.TabIndex = 0;
            button1.Text = "開始遊戲";
            button1.UseVisualStyleBackColor = true;
            button1.Click += StartBtn;
            // 
            // button2
            // 
            button2.Location = new Point(33, 124);
            button2.Name = "button2";
            button2.Size = new Size(123, 53);
            button2.TabIndex = 1;
            button2.Text = "看答案";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ShowAnswerBtn;
            // 
            // button3
            // 
            button3.Location = new Point(33, 349);
            button3.Name = "button3";
            button3.Size = new Size(123, 53);
            button3.TabIndex = 2;
            button3.Text = "檢查答案";
            button3.UseVisualStyleBackColor = true;
            button3.Click += checkBtn;
            // 
            // button4
            // 
            button4.Location = new Point(185, 349);
            button4.Name = "button4";
            button4.Size = new Size(123, 53);
            button4.TabIndex = 3;
            button4.Text = "放棄重來";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ResetBtn;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 297);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 271);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 5;
            label1.Text = "輸入";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 9);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 6;
            label2.Text = "遊戲歷程";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "--------------------------------------------------" });
            listBox1.Location = new Point(351, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(345, 372);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
    }
}
