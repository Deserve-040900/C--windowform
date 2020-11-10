using System;
using System.Collections.Generic;
using System.Text;

namespace bt_1A
{
    class student
{
        // tạo thuộc tính
        private string ID;
        private string fullname;
        private float avgScore;
        private string faculty;

        // tạo các property
        public string Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
        public float AvgScore
        {
            get { return avgScore; }
            set { avgScore = value; }
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        // tạo constructor ko tham số
        public student()
        {
        }
        // tạo constructor co tham số
        public student(string id, string name, float score, string faculty)
        {
            this.ID = id;
            this.fullname = name;
            this.avgScore = score;
            this.faculty = faculty;
        }

        // viết phuong thức nhập, xuất sinh viên
        public void input()
        {
            Console.Write("Nhập MSSV : ");
            this.ID = Console.ReadLine();

            Console.Write("Nhập họ tên SV : ");
            this.fullname = Console.ReadLine();

            Console.Write("Nhập điểm TB : ");
            this.avgScore = float.Parse(Console.ReadLine());// ép kiểu

            Console.Write("Nhập khoa : ");
            this.faculty = Console.ReadLine();
        }
        public void output()
        {
            Console.WriteLine("MSSV: {0} || Họ Tên: {1} || Khoa: {2} || ĐiểmTB: {3}", this.ID, this.fullname, this.faculty, this.avgScore);
        }
    }
}