using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class KhachHang
    {
      
        private int mMaKH;
        private string mTenKH;
        public KhachHang()
        {
            mMaKH = 0;
            mTenKH = "Quy";
        }
        public KhachHang(int MaKH, string TenKH)
        {
            mMaKH = MaKH;
            mTenKH = TenKH;
        }
        public void In()
        {
            Console.WriteLine("Ma KH: " + mMaKH);
            Console.WriteLine("Ten KH: " + mTenKH);
        }

    }
}
