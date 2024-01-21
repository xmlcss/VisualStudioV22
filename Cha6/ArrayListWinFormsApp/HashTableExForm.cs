using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
#nullable disable

namespace ArrayListWinFormsApp
{
    public partial class HashTableExForm : Form
    {
        Hashtable ht = new Hashtable();

        public HashTableExForm()
        {
            InitializeComponent();
        }

        private void HashTableExForm_Load(object sender, EventArgs e)
        {
            //初始化hashtable
            ht.Add("001", "语文");
            ht.Add("002", "数学");
            ht.Add("003", "英语");
            ht.Add("004", "化学");
            ht.Add("005", "物理");

            //定义一个集合，保存hashtable中的每一组键值对
            ArrayList al = new ArrayList();
            foreach (DictionaryEntry de in ht)
            {
                al.Add(de);
            }
            comboBox1.DataSource = al;//组件和集合绑定
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }
        //显示选中元素的键和值
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text.ToString();
            label2.Text = comboBox1.SelectedValue.ToString();
        }
        
        //hashtable的操作演示
        private void button1_Click(object sender, EventArgs e)
        {            
            ht.Add(1, 1);
            ht.Add("a", "english");
            ht.Add("啊", "中文");
            comboBox1.DataSource = null;
            foreach (DictionaryEntry de in ht)
            {
                comboBox1.Items.Add(de.Value.ToString());
            }
        }
    }
}
