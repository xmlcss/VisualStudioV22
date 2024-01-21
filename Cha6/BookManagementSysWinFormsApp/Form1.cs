namespace BookManagementSysWinFormsApp
{
#nullable disable
    public partial class Form1 : Form
    {
        //����ͼ�鷺�ͼ���
        List<Book> bookList = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            //��ʼ���������������
            this.InitPublisher();
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitialBookList();//���÷�������ʼ��ͼ�鼯��
        }

        #region:��ʼ��ͼ�鼯��
        private void InitialBookList()
        {
            //��һ����
            Book book1 = new Book();
            book1.Author = "��˧";
            book1.BarCode = "111-111";
            book1.BookId = 1001;
            book1.BookName = "����˧����Ҫ��";
            book1.Price = 100;
            book1.PublisherId = 1;
            book1.PublisherName = "����Ƽ�ѧԺ������";

            //�ڶ�����,���Գ�ʼ����
            Book book2 = new Book()
            {
                Author = "������",
                BarCode = "666-666",
                BookId = 1002,
                BookName = "�����Ļ���",
                Price = 99,
                PublisherId = 2,
                PublisherName = "�����ʵ������"
            };

            //��������,���Գ�ʼ����
            Book book3 = new Book()
            {
                Author = "��Ӱ",
                BarCode = "333-333",
                BookId = 1003,
                BookName = "C#",
                Price = 99,
                PublisherId = 2,
                PublisherName = "�����ʵ������"
            };

            //�ڶ�����,���Գ�ʼ����
            Book book4 = new Book()
            {
                Author = "����",
                BarCode = "444-444",
                BookId = 1004,
                BookName = "html",
                Price = 99,
                PublisherId = 3,
                PublisherName = "������ѧ������"
            };

            //ͼ����ӵ�ͼ�鼯����
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);

            //���û������Ӽ��ϵĽ��
            MessageBox.Show("��ӳɹ���");
        }
        #endregion
        #region�� ��ʼ��������������
        private void InitPublisher()
        {
            //���ϳ�ʼ���ķ���
            List<Publisher> publisherList = new List<Publisher>()
            {
                new Publisher(){PublisherId =1,PublisherName ="������ѧ������"},//�����ʼ����
                new Publisher (){PublisherId =2,PublisherName ="�廪��ѧ������"},
                new Publisher (){PublisherId =3,PublisherName ="�����ʵ������"}
            };
            this.comboBox1.DataSource = publisherList;
            this.comboBox1.DisplayMember = "PublisherName";
            this.comboBox1.ValueMember = "PublisherId";
            // this.comboBox1.SelectedIndex = -1;
        }
        #endregion

        //��ʾ����ͼ��
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bookList;
        }

        //���һ����
        private void button3_Click(object sender, EventArgs e)
        {
            //��1��������֤���ǿա���Ч�ԡ��Ϸ�����֤
            if (bookNameTxt.Text.Trim().Length == 0)
            {
                MessageBox.Show("ͼ�����Ʋ���Ϊ�գ�");
                bookNameTxt.Focus();//focus��ȡ���㣬ÿһ��ʱ�̣�ֻ��һ���ؼ����ܻ�ȡ����
                return;
            }

            //[2]��װͼ����󣨽��û��������������ת��Ϊ���ǵ�ͼ�����
            Book addBook = new Book()     //�����ʼ����       
            {
                Author = authorTxt.Text.ToString(),//����           
                BookId = Convert.ToInt32(bookIdTxt.Text.ToString()),//ͼ����
                BookName = bookNameTxt.Text.Trim(),//����
                BarCode = isbnTxt.Text.Trim(),//isbn
                Price = Convert.ToDouble(priceTxt.Text.Trim()),//�۸�
                PublisherId = Convert.ToInt16(comboBox1.SelectedValue),
                PublisherName = comboBox1.Text //����������
            };

            //��3����ͼ�������ӵ�ͼ�鼯����
            bookList.Add(addBook);

            //��4����������Դ
            dataGridView1.DataSource = null;//���
            dataGridView1.DataSource = bookList;//ͼ�鷺�ͼ���     
        }

        //ɾ��ѡ�е�ͼ��
        private void button4_Click(object sender, EventArgs e)
        {
            //��ȡ��Ҫ�޸ĵ�ͼ����
            int tempBookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookId"].Value);
            Book DelBook = null;//�ڼ����е����������߸����Ȿ�����

            //��ͼ�鼯���и���ͼ���ţ������Ȿ��Ҫ�޸ĵ�ͼ��
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].BookId == tempBookId)
                {
                    DelBook = bookList[i];
                    break;
                }
            }
            bookList.Remove(DelBook);
            //��4����������Դ
            dataGridView1.DataSource = null;//���
            dataGridView1.DataSource = bookList;//ͼ�鷺�ͼ���   
        }

        //�޸���ѡͼ��
        private void button5_Click(object sender, EventArgs e)
        {
            //��ȡ��Ҫ�޸ĵ�ͼ����
            int tempBookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookId"].Value);

            //��Ҫ�޸ĵ�ͼ��
            Book editBook = null;//�ڼ����е����������߸����Ȿ�����

            //��ͼ�鼯���и���ͼ���ţ������Ȿ��Ҫ�޸ĵ�ͼ��
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].BookId == tempBookId)
                {
                    editBook = bookList[i];
                    break;
                }
            }
            //��ת���༭ͼ��Ľ���(�޸ĵ�ͼ�飩

            //EditBookForm ebf1 = new EditBookForm();//ʵ����editBookForm���壬
            EditBookForm ebf1 = new EditBookForm(editBook);
            

            ebf1.ShowDialog();
            //�����޸�֮��ķ��ص��鼮

            Book objBook = new Book();
            objBook = (Book)ebf1.Tag;

            //����ͼ���ţ�����ͼ����Ϣ�ĸ���
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

            //ˢ������
            dataGridView1.Refresh();
        }
    }
}
