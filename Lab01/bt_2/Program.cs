using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace bt_2
{
    class Program
    {
        private static List<Person> input()
        {
            List<Person> person = new List<Person>();
            Person p = new Person();
            Console.Write("==== Nhập danh sách \n1.học sinh \n2.giáo viên \nPress any key to exit====");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1: 
                    p = new Student();
                    p.input();
                    person.Add(p);
                    break;
                case 2:
                    p = new Teacher();
                    p.input();
                    person.Add(p);
                    break;
                default:
                    break;
            }
            return person;
        }
        private static void output(List<Person> person)
        {
            Console.WriteLine("\n ==== Xuất danh sách ====");
            foreach (Person pr in person)
            {
                pr.output();
            }
        }
        private static void svCNTT(List<Person> person)
        {
            Console.Write("\nDanh sách SV khoa CNTT ");
            foreach(Person pr in person)
            {
                if (pr.getloai() == 1 && ((Student)pr).Faculty == "CNTT")
                {
                    pr.output();
                }
                else
                {
                    Console.Write("Empty List !!!");
                }
            }
        }
        private static void svCNTTdtb5(List<Person> person)
        {
            Console.Write("\nDanh sách SV khoa CNTT và có điểm tb < 5 ");
            foreach (Person pr in person)
            {
                if (pr.getloai() == 1 && ((Student)pr).Faculty == "CNTT" && ((Student)pr).AvgScore < 5)
                {
                    pr.output();
                }
                else
                {
                    Console.Write("Not Found !!!");
                }
            }
        }
        private static void GVaddress(List<Person> person)
        {
            Console.Write("\nDanh sách GV có thông tin địa chỉ chứa 'Quận 9' ");
            foreach (Person pr in person)
            {
                if (pr.getloai() == 2 && ((Teacher)pr).Address == "Quận 9")
                {
                    pr.output();
                }
                else
                {
                    Console.Write("Not Exist !!!");
                }
            }
        }
        private static void IDgiaovien(List<Person> person)
        {
            Console.Write("\nTìm kiếm giáo viên có mã giảng viên là CHN060286 ");
            for(int i=0; i<person.Count; i++)
            {
                if(person[i].getloai == 2 && person[i].Id = "CHN060286")
                {
                    return i;
                }
            }
        }
        static void Main(string[] args)
        {
            var Person = input();
            output(Person);
            svCNTT(Person);
            svCNTTdtb5(Person);
            GVaddress(Person);
            if (IDgiaovien(Person) == 0)
            {
                System.Console.WriteLine("Wrong! Can not found");
            }
            else
            {
                Person[IDgiaovien(Person)].Show();
            }
        }
    }
}
