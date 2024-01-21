namespace BookManagementSysWinFormsApp
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            isbnTxt = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            priceTxt = new TextBox();
            authorTxt = new TextBox();
            bookIdTxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            bookNameTxt = new TextBox();
            label1 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(775, 225);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 64);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.Location = new Point(369, 0);
            button4.Name = "button4";
            button4.Size = new Size(105, 64);
            button4.TabIndex = 3;
            button4.Text = "删除选中图书";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(250, 0);
            button3.Name = "button3";
            button3.Size = new Size(119, 64);
            button3.TabIndex = 2;
            button3.Text = "添加一本新书";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(133, 0);
            button2.Name = "button2";
            button2.Size = new Size(117, 64);
            button2.TabIndex = 1;
            button2.Text = "显示所有图书";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(133, 64);
            button1.TabIndex = 0;
            button1.Text = "初始化图书集合";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(isbnTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(priceTxt);
            groupBox1.Controls.Add(authorTxt);
            groupBox1.Controls.Add(bookIdTxt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(bookNameTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 283);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 229);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "图书基本信息";
            // 
            // isbnTxt
            // 
            isbnTxt.Location = new Point(114, 122);
            isbnTxt.Name = "isbnTxt";
            isbnTxt.Size = new Size(139, 23);
            isbnTxt.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 128);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 12;
            label3.Text = "isbn：";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(359, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 25);
            comboBox1.TabIndex = 11;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(334, 76);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(164, 23);
            priceTxt.TabIndex = 9;
            // 
            // authorTxt
            // 
            authorTxt.Location = new Point(114, 73);
            authorTxt.Name = "authorTxt";
            authorTxt.Size = new Size(139, 23);
            authorTxt.TabIndex = 8;
            // 
            // bookIdTxt
            // 
            bookIdTxt.Location = new Point(359, 24);
            bookIdTxt.Name = "bookIdTxt";
            bookIdTxt.Size = new Size(139, 23);
            bookIdTxt.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(299, 125);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 6;
            label6.Text = "出版社：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(299, 79);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 5;
            label5.Text = "价格：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 76);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 4;
            label4.Text = "作者：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 30);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 2;
            label2.Text = "图书编号：";
            // 
            // bookNameTxt
            // 
            bookNameTxt.Location = new Point(114, 24);
            bookNameTxt.Name = "bookNameTxt";
            bookNameTxt.Size = new Size(139, 23);
            bookNameTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 30);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 0;
            label1.Text = "书名:";
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.Location = new Point(474, 0);
            button5.Name = "button5";
            button5.Size = new Size(131, 64);
            button5.TabIndex = 4;
            button5.Text = "修改所选图书";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 512);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
        private TextBox bookNameTxt;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox priceTxt;
        private TextBox authorTxt;
        private TextBox bookIdTxt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox isbnTxt;
        private Label label3;
        private Button button4;
        private Button button5;
    }
}
