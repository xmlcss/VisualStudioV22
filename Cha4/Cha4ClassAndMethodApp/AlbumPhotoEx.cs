//文件名：AlbumPhotoEx.cs
//案例名：相片-相册程序
//知识点：索引器的定义及使用
//需求：照片类Photo，存放相片的信息；相册类Album，实现按照相片名字或者序号检索相册中的相片
using System;
#nullable disable

namespace Cha4ClassAndMethodApp
{
    /// <summary>
    /// Photo类，存放相片的信息
    /// </summary>
    class Photo
    {
        string _title;//represents the title of a photo
                      //readonly, property
        public string Title
        {
            get { return _title; }
        }
        //constructor
        public Photo(string title)
        {
            this._title = title;
        }
    }

    /// <summary>
    /// Album类，实现按照相片名字或者序号检索相册中的相片
    /// </summary>
    class Album
    {
        Photo[] photos;//array and datatype is Photo
        //constructor
        public Album(int capacity)
        {
            photos = new Photo[capacity];
        }

        //indexers takes int argument
        //this类实例化之后的对象
        //photos读写索引器
        public Photo this[int index]
        {
            get
            {
                //verify the range of the indexer
                if (index < 0 || index >= photos.Length)
                {
                    Console.WriteLine("idnex is illeagle");
                    return null;
                }
                return photos[index];
            }
            set
            {
                if (index < 0 || index >= photos.Length)
                {
                    Console.WriteLine("idnex is illeagle");
                    return;
                }
                photos[index] = value;
            }
        }

        //带string参数的photo只读索引器，按照照片名字检索
        public Photo this[string title]
        {
            get
            {
                foreach (Photo p in photos)
                {
                    if (p.Title == title)
                        return p;
                }
                Console.WriteLine("not found");
                return null;
            }
        }
    }

    /// <summary>
    /// 测试类
    /// </summary>
    public class EntryPoint
    {
        public static void Main()
        {
            //creat an album
            Album family = new Album(3);

            //creat 3 photos
            Photo first = new Photo("Mom");
            Photo second = new Photo("Dad");
            Photo third = new Photo("Smith");

            //add the photos to album
            family[0] = first;//setter of the indexer
            family[1] = second;
            family[2] = third;

            //index by indexer
            Photo objPhoto1 = family[2]; //getter of the indexer
            Console.WriteLine(objPhoto1.Title);

            //按名称检索
            Photo objPhoto = family["Mom"];
            Console.WriteLine(objPhoto.Title);
        }
    }
}
