using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{
    class KhachHang
    {
        public static int mMaKH;
        public static string mTenKH;
        
        private KhachHang()
        {
        }
        public static void In()
        {
            Console.WriteLine("Ma KH: " + mMaKH);
            Console.WriteLine("Ten KH: " + mTenKH);
        }
    }
}
