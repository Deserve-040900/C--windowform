using System;
using System.Text;

namespace bt_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            // nhập tổng số sv N, convert biến N sang kiểu dữ liệu int
            Console.Write("Nhập tổng số sinh viên = ");
            int N = Convert.ToInt32(Console.ReadLine());
            student[] arr = new student[N];

            Console.WriteLine("\n ==== Nhập danh sách sinh viên ====");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n * Sinh viên thứ {0}", i + 1);
                arr[i] = new student();
                arr[i].input();
            }

            Console.WriteLine("\n ==== Xuất danh sách sinh viên ====");
            foreach (student sv in arr)
            {
                sv.output();
            }
            Console.ReadKey();
        }
    }
}
