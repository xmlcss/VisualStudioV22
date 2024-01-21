namespace BookManagementSysWinFormsApp
{
#nullable disable
    public partial class Form1 : Form
    {
        //定义图书泛型集合
        List<Book> bookList = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            //初始化出版社的下拉框
            this.InitPublisher();
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitialBookList();//调用方法，初始化图书集合
        }

        #region:初始化图书集合
        private void InitialBookList()
        {
            //第一本书
            Book book1 = new Book();
            book1.Author = "候帅";
            book1.BarCode = "111-111";
            book1.BookId = 1001;
            book1.BookName = "论人帅的重要性";
            book1.Price = 100;
            book1.PublisherId = 1;
            book1.PublisherName = "重庆科技学院出版社";

            //第二本书,属性初始化器
            Book book2 = new Book()
            {
                Author = "许巧妍",
                BarCode = "666-666",
                BookId = 1002,
                BookName = "美丽的花朵",
                Price = 99,
                PublisherId = 2,
                PublisherName = "人民邮电出版社"
            };

            //第三本书,属性初始化器
            Book book3 = new Book()
            {
                Author = "刘影",
                BarCode = "333-333",
                BookId = 1003,
                BookName = "C#",
                Price = 99,
                PublisherId = 2,
                PublisherName = "人民邮电出版社"
            };

            //第二本书,属性初始化器
            Book book4 = new Book()
            {
                Author = "王杰",
                BarCode = "444-444",
                BookId = 1004,
                BookName = "html",
                Price = 99,
                PublisherId = 3,
                PublisherName = "北京大学出版社"
            };

            //图书添加到图书集合中
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);

            //给用户输出添加集合的结果
            MessageBox.Show("添加成功！");
        }
        #endregion
        #region： 初始化出版社下拉框
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
        #endregion

        //显示所有图书
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bookList;
        }

        //添加一本书
        private void button3_Click(object sender, EventArgs e)
        {
            //【1】数据验证（非空、有效性、合法性验证
            if (bookNameTxt.Text.Trim().Length == 0)
            {
                MessageBox.Show("图书名称不能为空！");
                bookNameTxt.Focus();//focus获取焦点，每一个时刻，只有一个控件才能获取焦点
                return;
            }

            //[2]封装图书对象（将用户界面输入的内容转换为我们的图书对象）
            Book addBook = new Book()     //对象初始化器       
            {
                Author = authorTxt.Text.ToString(),//作者           
                BookId = Convert.ToInt32(bookIdTxt.Text.ToString()),//图书编号
                BookName = bookNameTxt.Text.Trim(),//书名
                BarCode = isbnTxt.Text.Trim(),//isbn
                Price = Convert.ToDouble(priceTxt.Text.Trim()),//价格
                PublisherId = Convert.ToInt16(comboBox1.SelectedValue),
                PublisherName = comboBox1.Text //出版社名称
            };

            //【3】将图书对象添加到图书集合中
            bookList.Add(addBook);

            //【4】更新数据源
            dataGridView1.DataSource = null;//清空
            dataGridView1.DataSource = bookList;//图书泛型集合     
        }

        //删除选中的图书
        private void button4_Click(object sender, EventArgs e)
        {
            //获取需要修改的图书编号
            int tempBookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookId"].Value);
            Book DelBook = null;//在集合中的索引，或者根据这本书对象，

            //在图书集合中根据图书编号，查找这本需要修改的图书
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].BookId == tempBookId)
                {
                    DelBook = bookList[i];
                    break;
                }
            }
            bookList.Remove(DelBook);
            //【4】更新数据源
            dataGridView1.DataSource = null;//清空
            dataGridView1.DataSource = bookList;//图书泛型集合   
        }

        //修改所选图书
        private void button5_Click(object sender, EventArgs e)
        {
            //获取需要修改的图书编号
            int tempBookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookId"].Value);

            //需要修改的图书
            Book editBook = null;//在集合中的索引，或者根据这本书对象，

            //在图书集合中根据图书编号，查找这本需要修改的图书
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].BookId == tempBookId)
                {
                    editBook = bookList[i];
                    break;
                }
            }
            //跳转到编辑图书的界面(修改的图书）

            //EditBookForm ebf1 = new EditBookForm();//实例化editBookForm窗体，
            EditBookForm ebf1 = new EditBookForm(editBook);
            

            ebf1.ShowDialog();
            //接受修改之后的返回的书籍

            Book objBook = new Book();
            objBook = (Book)ebf1.Tag;

            //根据图书编号，进行图书信息的更新
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].BookId == tempBookId)
                {
                    bookList[i].Author = objBook.Author;
                    bookList[i].BarCode = objBook.BarCode;
                    bookList[i].BookName = objBook.BookName;
                    bookList[i].Price = objBook.Price;
                    bookList[i].PublisherId = objBook.PublisherId;
                    bookList[i].PublisherName = objBook.PublisherName;
                    break;
                }
            }

            //刷新数据
            dataGridView1.Refresh();
        }
    }
}
