using System.Collections;

namespace ArrayListWinFormsApp
{
    public partial class Form1 : Form
    {
        ArrayList al = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region:用数组给listBox赋值
            //string[] cityName = { "重庆","上海","西安","成都","昆明","北京"};
            //foreach (string cityN in cityName)
            //{
            //    listBox1.Items.Add(cityN );
            //}
            #endregion

            #region:用arrayList给listBox控件赋值
            al.Add("重庆");
            al.Add("上海");
            al.Add("西安");
            al.Add("成都");
            listBox1.DataSource = al;
            #endregion


        }

        //不同类型数据赋值演示
        private void button1_Click(object sender, EventArgs e)
        {
            al.Clear();
            al.Add(1);//整型常量
            al.Add("abc");//字符串常量
            al.Add(4.56789);//实数常量
            al.Add(DateTime.Now.ToShortDateString());

            listBox1.DataSource = null;
            listBox1.DataSource = al;
        }

        //判断是否包含杭州
        private void button2_Click(object sender, EventArgs e)
        {
            bool result = al.Contains("杭州");
            MessageBox.Show(result.ToString());
        }

        //集合的CopyTo方法，将整个集合的内容赋值到数组中
        private void button3_Click(object sender, EventArgs e)
        {
            object[] newArray = new object[al.Count + 2];
            newArray[0] = "我是来占位的";
            newArray[1] = "继续占位";
            al.CopyTo(newArray, 2);//集合的copyTo方法，将整个集合的内容赋值到数组中，起始位置是索引2
            listBox1.DataSource = null;
            listBox1.DataSource = newArray;//数组绑定到listbox上
        }

        //取部分子元素集合
        private void button4_Click(object sender, EventArgs e)
        {
            ArrayList newArrayList = new ArrayList();
            newArrayList = al.GetRange(1, 3);//对于al数组集合，从索引1开始取，取3个元素
            listBox1.DataSource = null;
            listBox1.DataSource = newArrayList;
        }

        //集合AddRange方法
        private void button5_Click(object sender, EventArgs e)
        {
            ArrayList addAl = new ArrayList();
            addAl.Add("num1");
            addAl.Add(2);

            al.AddRange(addAl);
            listBox1.DataSource = null;
            listBox1.DataSource = al;
        }
    }
}
