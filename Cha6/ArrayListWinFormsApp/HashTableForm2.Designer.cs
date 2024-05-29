namespace ArrayListWinFormsApp
{
    partial class HashTableForm2
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft YaHei UI", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 43);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 20F);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(193, 323);
            label1.Name = "label1";
            label1.Size = new Size(92, 35);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 20F);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(193, 368);
            label2.Name = "label2";
            label2.Size = new Size(92, 35);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // HashTableForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "HashTableForm2";
            Text = "HashTableForm2";
            Load += HashTableForm2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
    }
}