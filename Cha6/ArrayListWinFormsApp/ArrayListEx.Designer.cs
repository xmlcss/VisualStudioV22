namespace ArrayListWinFormsApp
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(36, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(149, 259);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(223, 38);
            button1.Name = "button1";
            button1.Size = new Size(159, 33);
            button1.TabIndex = 1;
            button1.Text = "不同类型数据赋值";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(223, 89);
            button2.Name = "button2";
            button2.Size = new Size(159, 23);
            button2.TabIndex = 2;
            button2.Text = "判断是否包含杭州";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(223, 131);
            button3.Name = "button3";
            button3.Size = new Size(159, 25);
            button3.TabIndex = 3;
            button3.Text = "集合的CopyTo方法";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(223, 174);
            button4.Name = "button4";
            button4.Size = new Size(159, 23);
            button4.TabIndex = 4;
            button4.Text = "取部分子元素集合";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(223, 213);
            button5.Name = "button5";
            button5.Size = new Size(159, 23);
            button5.TabIndex = 5;
            button5.Text = "集合AddRange方法";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 310);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
