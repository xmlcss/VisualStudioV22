//图书管理系统，图书类
using System;
#nullable disable
namespace BookManagementSysWinFormsApp
{
    public class Book
    {
        //数据成员
        //图书编号，id
        public int BookId { get; set; }//自实现属性
        //isbn
        public string BarCode { get; set; }
        //书名
        public string BookName { get; set; }
        //作者
        public string Author { get; set; }
        //价格
        public double Price { get; set; }
        //出版社
        public string PublisherName { get; set; }
        //出版社id
        public int PublisherId { get; set; }
    }
}
