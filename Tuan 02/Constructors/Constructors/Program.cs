﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            KhachHang objKH = new KhachHang();
            objKH.In();
            KhachHang objKH2 = new KhachHang(1,"ABC");
            objKH2.In();

            Console.Read();
        }
    }
}
