using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookManagementSysWinFormsApp
{
    public partial class EditBookForm : Form
    {
        public EditBookForm()
        {
            InitializeComponent();
        }
        //editBookForm类带带参构造方法
        public EditBookForm(Book tempBook)
        {
            InitializeComponent();//不能删除！！！
            comboBox1.SelectedIndex = -1;
            bookIdTxt.Text = tempBook.BookId.ToString();//图书编号
            bookNameTxt.Text = tempBook.BookName.ToString();//书名
            authorTxt.Text = tempBook.Author.ToString();//作者
            priceTxt.Text = tempBook.Price.ToString();
            isbnTxt.Text = tempBook.BarCode.ToString();//isbn
                                                       // comboBox1.Text = tempBook.PublisherName.ToString();//出版社名称未修改
            comboBox1.SelectedValue = tempBook.PublisherId;
          //  comboBox1.Text = tempBook.PublisherName.ToString();//出版社名称未修改
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            InitPublisher();//初始化出版社下拉框控件
        }
        //初始化出版社下拉框
        private void InitPublisher()
        {
            //集合初始化的方法
            List<Publisher> publisherList = new List<Publisher>()
        {
        new Publisher(){PublisherId =1,PublisherName ="北京大学出版社"},//对象初始化器
        new Publisher (){PublisherId =2,PublisherName ="清华大学出版社"},
        new Publisher (){PublisherId =3,PublisherName ="人民邮电出版社"}
        };
            this.comboBox1.DataSource = publisherList;
            this.comboBox1.DisplayMember = "PublisherName";
            this.comboBox1.ValueMember = "PublisherId";
            // this.comboBox1.SelectedIndex = -1;
        }
    }
}
