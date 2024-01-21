namespace BookManagementSysWinFormsApp
{
    partial class EditBookForm
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
            button1 = new Button();
            SuspendLayout();
            // 
            // isbnTxt
            // 
            isbnTxt.Location = new Point(115, 138);
            isbnTxt.Name = "isbnTxt";
            isbnTxt.Size = new Size(139, 23);
            isbnTxt.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 144);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 24;
            label3.Text = "isbn：";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(360, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 25);
            comboBox1.TabIndex = 23;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(335, 92);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(164, 23);
            priceTxt.TabIndex = 22;
            // 
            // authorTxt
            // 
            authorTxt.Location = new Point(115, 89);
            authorTxt.Name = "authorTxt";
            authorTxt.Size = new Size(139, 23);
            authorTxt.TabIndex = 21;
            // 
            // bookIdTxt
            // 
            bookIdTxt.Location = new Point(360, 40);
            bookIdTxt.Name = "bookIdTxt";
            bookIdTxt.Size = new Size(139, 23);
            bookIdTxt.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 141);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 19;
            label6.Text = "出版社：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 95);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 18;
            label5.Text = "价格：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 92);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 17;
            label4.Text = "作者：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 46);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 16;
            label2.Text = "图书编号：";
            // 
            // bookNameTxt
            // 
            bookNameTxt.Location = new Point(115, 40);
            bookNameTxt.Name = "bookNameTxt";
            bookNameTxt.Size = new Size(139, 23);
            bookNameTxt.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 46);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 14;
            label1.Text = "书名:";
            // 
            // button1
            // 
            button1.Location = new Point(207, 183);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 26;
            button1.Text = "确定修改";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 234);
            Controls.Add(button1);
            Controls.Add(isbnTxt);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(priceTxt);
            Controls.Add(authorTxt);
            Controls.Add(bookIdTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(bookNameTxt);
            Controls.Add(label1);
            Name = "EditBookForm";
            Text = "EditBookForm";
            Load += EditBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox isbnTxt;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox priceTxt;
        private TextBox authorTxt;
        private TextBox bookIdTxt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox bookNameTxt;
        private Label label1;
        private Button button1;
    }
}