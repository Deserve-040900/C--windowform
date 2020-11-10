using System;
using System.Collections.Generic;
using System.Text;

namespace bt_2
{
    class Student : Person
    {
        private float dtb;
        private string khoa;
        public float AvgScore
        {
            get { return dtb; }
            set { dtb = value; }
        }
        public string Faculty
        {
            get { return khoa; }
            set { khoa = value; }
        }
        public override void input()
        {
            base.input();
            Console.Write("Nhập điểm TB : ");
            this.dtb = float.Parse(Console.ReadLine());

            Console.Write("Nhập khoa : ");
            this.khoa = Console.ReadLine();
        }
        public override void output()
        {
            Console.WriteLine("MSSV: {0} || Họ Tên: {1} || Khoa: {2} || ĐiểmTB: {3}", this.ma_so, this.ho_ten, this.khoa, this.dtb);
        }
        public override int getloai()
        {
            return 1;
        }
    }
}
