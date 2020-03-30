using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            KhachHang.mMaKH = 1;
            KhachHang.mTenKH = "Quy";
            KhachHang.In();

            Console.Read();
        }
    }
}
