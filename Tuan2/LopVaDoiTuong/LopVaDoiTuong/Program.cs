using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopVaDoiTuong
{
    class Program
    {
        static void Main(string[] args)
        {
            //KhachHang.mTenKH="Quy";
            // KhachHang.In();

            KhachHang objKH = new KhachHang();
            objKH.mTenKH = "Quy";
            objKH.In();
            


            Console.Read();
        }

    }
}
