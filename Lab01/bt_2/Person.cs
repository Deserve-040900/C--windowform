using System;
using System.Collections.Generic;
using System.Text;

namespace bt_2
{
    class Person
    {
        protected string ma_so;
        protected string ho_ten;
        public string Id
        {
            get { return ma_so; }
            set { ma_so = value; }
        }
        public string Fullname
        {
            get { return ho_ten; }
            set { ho_ten = value; }
        }
        public Person() { }

        public Person(string id, string name)
        {
            this.ma_so = id;
            this.ho_ten = name;
        }
        public virtual void input()
        {
            Console.Write("Nhập MSSV : ");
            this.ma_so = Console.ReadLine();

            Console.Write("Nhập họ tên SV : ");
            this.ho_ten = Console.ReadLine();
        }
        public virtual void output()
        {
            Console.WriteLine("MSSV: {0} || Họ Tên: {1} ", this.ma_so, this.ho_ten);
        }
        public virtual void getloai()
        {
            return 0;
        }
    }
}
