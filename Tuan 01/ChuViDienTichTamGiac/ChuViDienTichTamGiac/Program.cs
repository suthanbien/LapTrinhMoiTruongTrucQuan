using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuViDienTichTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,p, chuVi, dienTich;
            Console.WriteLine("****** Chu Vi Dien Tich Tam Giac *****");
            Console.Write("Nhap vao canh a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao canh b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao canh c: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a>0||b>0||c>0)
            {
                chuVi = a + b + c;
                p = chuVi / 2;
                dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine("Chu vi la: " + chuVi);
                Console.WriteLine("Dien Tich La: " + dienTich);
            }
            else
            {
                Console.WriteLine("Loi canh a,b,c phai > 0");
            }
            
            Console.Read();
        }
    }
}
