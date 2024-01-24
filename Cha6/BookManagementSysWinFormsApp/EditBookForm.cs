using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
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
            //  InitializeComponent();
        }
        //editBookForm类带带参构造方法
        public EditBookForm(Book tempBook)
        {
            InitializeComponent();//不能删除！！！
            InitPublisher();//初始化出版社下拉框控件
            bookIdTxt.Text = tempBook.BookId.ToString();//图书编号
            bookNameTxt.Text = tempBook.BookName.ToString();//书名
            authorTxt.Text = tempBook.Author.ToString();//作者
            priceTxt.Text = tempBook.Price.ToString();
            isbnTxt.Text = tempBook.BarCode.ToString();//isbn
            comboBox1.SelectedText = tempBook.PublisherName.ToString();//出版社名称  
        }

        //确认修改并返回主界面
        private void button1_Click(object sender, EventArgs e)
        {
            //数据的非空验证、有效性、合法性验证
            if (bookNameTxt.Text.Trim().Length == 0)
            {
                MessageBox.Show("图书名称不能为空！");
                bookNameTxt.Focus();//focus获取焦点，每一个时刻，只有一个控件才能获取焦点
                return;
            }

            //【2】封装对象（将用户输入的内容，封装到要修改的图书对象中）
            Book book1 = new Book()//对象初始化器
            {
                Author = authorTxt.Text.ToString(),//作者           
               // BookId = Convert.ToInt32(bookIdTxt.Text.ToString()),//图书编号
                BookName = bookNameTxt.Text.Trim(),//书名
                BarCode = isbnTxt.Text.Trim(),//isbn
                Price = Convert.ToDouble(priceTxt.Text.Trim()),//价格
                PublisherId = Convert.ToInt16(comboBox1.SelectedValue),
                PublisherName = comboBox1.Text//出版社名称            
            };

            //【3】保存并返回主界面
            this.Tag = book1;
            this.Close();//关闭当前的窗体
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
          //  this.comboBox1.SelectedIndex = -1;
        }

     
    }
}
