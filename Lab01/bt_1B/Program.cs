using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Linq;

namespace bt_1B
{
    class Program
    {
        private static List<hoc_sinh> Nhap()
        {
            List<hoc_sinh> std = new List<hoc_sinh>();
            Console.Write("Nhập tổng số sinh viên = ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n ==== Nhập danh sách sinh viên ====");
            for (int i = 0; i < N; i++)
            {   
                Console.WriteLine("\n * Sinh viên thứ {0}", i + 1);
                hoc_sinh hs = new hoc_sinh();
                hs.input();
                std.Add(hs);
            }
            return std;
        }
        private static void Xuat(List<hoc_sinh> list)
        {
            Console.WriteLine("\n ==== Xuất danh sách sinh viên ====");
            foreach (hoc_sinh sv in list)
            {
                sv.output();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode; // để sử dụng tiếng việt

            List<hoc_sinh> list = Nhap();
            Xuat(list);
            Console.ReadKey(); // dừng màn hình kiểm tra kết quả

            // cú pháp truy vấn (query syntax)
            Console.WriteLine("1. xuất ra thông tin các SV đều thuộc khoa 'CNTT' ");
            List<hoc_sinh> cau1 = (from s in list
                                   where s.Faculty == "CNTT"
                                   select s).ToList();

            // cú pháp phương thức (method syntax)
            Console.WriteLine("2. xuất ra thông tin các SV có điểm tb lớn hơn bằng 5 ");
            List<hoc_sinh> cau2 = list.Where(p => p.AvgScore >= 5).ToList();
            if (cau2.Count() == 0)
                Console.WriteLine("không có SV có điểm tb >= 5 ");
            else
                Xuat(cau2);

            Console.WriteLine("3. sắp xếp SV theo điểm tb tăng dần ");
            List<hoc_sinh> cau3 = list.OrderBy(p => p.AvgScore).ToList();
            Xuat(cau3);

            Console.WriteLine("4. xuất ra các SV đều thuộc khoa 'CNTT' có điểm tb lớn hơn bằng 5 ");
            List<hoc_sinh> cau4 = (from sv in list
                                   where sv.Faculty == "CNTT" && sv.AvgScore >= 5
                                   select sv).ToList();

            Console.WriteLine("5. xuất ra danh sách SV đều thuộc khoa 'CNTT' có điểm tb lớn nhất ");
            var avg = list.Max(p => p.AvgScore);
            List<hoc_sinh> cau5 = list.Where(p => p.Faculty == "CNTT" && p.AvgScore == avg).ToList();
            Xuat(cau5);
        }
    }
}
