using System;
using System.Collections.Generic;
using System.Text;

namespace bt_1B
{
    class hoc_sinh
    {
        private string ma_hs;
        private string hoten_hs;
        private float dtb;
        private string khoa;

        public string Id
        {
            get { return ma_hs; }
            set { ma_hs = value; }
        }
        public string Fullname
        {
            get { return hoten_hs; }
            set { hoten_hs = value; }
        }
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

        public hoc_sinh() { }

        public hoc_sinh(string id, string name, float score, string faculty)
        {
            this.ma_hs = id;
            this.hoten_hs = name;
            this.dtb = score;
            this.khoa = faculty;
        }

        public void input()
        {
            Console.Write("Nhập MSSV : ");
            this.ma_hs = Console.ReadLine();

            Console.Write("Nhập họ tên SV : ");
            this.hoten_hs = Console.ReadLine();

            Console.Write("Nhập điểm TB : ");
            this.dtb = float.Parse(Console.ReadLine());

            Console.Write("Nhập khoa : ");
            this.khoa = Console.ReadLine();
        }
        public void output()
        {
            Console.WriteLine("MSSV: {0} || Họ Tên: {1} || Khoa: {2} || ĐiểmTB: {3}", this.ma_hs, this.hoten_hs, this.khoa, this.dtb);
        }
    }
}
