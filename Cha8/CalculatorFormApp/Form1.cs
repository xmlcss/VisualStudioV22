using System.Reflection;
using OperationLib;
namespace CalculatorFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //读配置文件
            string[] lines = File.ReadAllLines("Config.txt");
            //270,90; 80,25
            int x = 236;
            int y = 105;
            foreach (string item in lines)
            {
                //有几条数据，就创建几个按钮
                Button btn = new Button();
                btn.Location = new Point(x, y);
                btn.Size = new Size(80, 25);
                y += 30;
                btn.Text = item;
                btn.Click += btn_Click;
                this.Controls.Add(btn);//添加至窗体
            }
        }

        private void btn_Click(object? sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text.Trim());
            int n2 = Convert.ToInt32(textBox2.Text.Trim());
            Button? btn = sender as Button;

            OperationLib.Operation oper = OperationLib.Factory.getOper(btn.Text, n1, n2);
            label1.Text = oper.GetResult().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
