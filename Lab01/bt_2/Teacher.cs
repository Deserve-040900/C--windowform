using System;
using System.Collections.Generic;
using System.Text;

namespace bt_2
{
    class Teacher : Person
    {
        private string dia_chi;
        public string Address
        {
            get { return dia_chi; }
            set { dia_chi = value; }
        }
        public override void input()
        {
            base.input();
            Console.Write("Nhập điểm TB : ");
            this.dia_chi = Console.ReadLine();            
        }
        public override void output()
        {
            Console.WriteLine("MSGV: {0} || Họ Tên: {1} || Địa Chỉ: {2} ", this.ma_so, this.ho_ten, this.dia_chi);
        }
        public override int getloai()
        {
            return 2;
        }
    }
}
