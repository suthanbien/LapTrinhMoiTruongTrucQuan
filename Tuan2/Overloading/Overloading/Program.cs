using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            KhachHang objKH = new KhachHang();
            objKH.In();
            objKH.In("Long An");
            objKH.In("Long AN", 0161235451);
            Console.Read();

            Console.Read();
        }
    }
}
