namespace ButtonClickEventWinFormsApp
#nullable disable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            button1.Click += new EventHandler(Button1_Click);
            //���������Լ�дΪ��
            //  button1.Click += Button1_Click;
            button2.Click += Button1_Click;
            button1.Click += FunctionElse;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "button1")
                button1.Text = "button1 was pressed";
            else    
                button2.Text = "button2 was pressed";                   
        }
        //��������
        private void FunctionElse(object sender, EventArgs e)
        {
            label1.Text = "������������";
        }
    }
}
