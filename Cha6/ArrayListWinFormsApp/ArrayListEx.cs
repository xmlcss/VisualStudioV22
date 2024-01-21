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
            #region:�������listBox��ֵ
            //string[] cityName = { "����","�Ϻ�","����","�ɶ�","����","����"};
            //foreach (string cityN in cityName)
            //{
            //    listBox1.Items.Add(cityN );
            //}
            #endregion

            #region:��arrayList��listBox�ؼ���ֵ
            al.Add("����");
            al.Add("�Ϻ�");
            al.Add("����");
            al.Add("�ɶ�");
            listBox1.DataSource = al;
            #endregion


        }

        //��ͬ�������ݸ�ֵ��ʾ
        private void button1_Click(object sender, EventArgs e)
        {
            al.Clear();
            al.Add(1);//���ͳ���
            al.Add("abc");//�ַ�������
            al.Add(4.56789);//ʵ������
            al.Add(DateTime.Now.ToShortDateString());

            listBox1.DataSource = null;
            listBox1.DataSource = al;
        }

        //�ж��Ƿ��������
        private void button2_Click(object sender, EventArgs e)
        {
            bool result = al.Contains("����");
            MessageBox.Show(result.ToString());
        }

        //���ϵ�CopyTo���������������ϵ����ݸ�ֵ��������
        private void button3_Click(object sender, EventArgs e)
        {
            object[] newArray = new object[al.Count + 2];
            newArray[0] = "������ռλ��";
            newArray[1] = "����ռλ";
            al.CopyTo(newArray, 2);//���ϵ�copyTo���������������ϵ����ݸ�ֵ�������У���ʼλ��������2
            listBox1.DataSource = null;
            listBox1.DataSource = newArray;//����󶨵�listbox��
        }

        //ȡ������Ԫ�ؼ���
        private void button4_Click(object sender, EventArgs e)
        {
            ArrayList newArrayList = new ArrayList();
            newArrayList = al.GetRange(1, 3);//����al���鼯�ϣ�������1��ʼȡ��ȡ3��Ԫ��
            listBox1.DataSource = null;
            listBox1.DataSource = newArrayList;
        }

        //����AddRange����
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
