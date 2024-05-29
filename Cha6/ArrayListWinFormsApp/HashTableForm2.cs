using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListWinFormsApp
{
    public partial class HashTableForm2 : Form
    {
        Hashtable ht = new Hashtable();
        public HashTableForm2()
        {
            InitializeComponent();
        }

        private void HashTableForm2_Load(object sender, EventArgs e)
        {
            //初始化HashTable
            ht.Add("001", "语文");
            ht.Add("002", "数学");
            ht.Add("003", "化学");
            ht.Add("004", "物理");

            //定义一个集合，保存hashtable中的值列
            ArrayList arrayList = new ArrayList();
            foreach (DictionaryEntry de in ht)
            {
                arrayList.Add(de);
            }

            //前台的combox控件和集合绑定
            comboBox1.DataSource = arrayList;
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text.ToString();
            label2.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
