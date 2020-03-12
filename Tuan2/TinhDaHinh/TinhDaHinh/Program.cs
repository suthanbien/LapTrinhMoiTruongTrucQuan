using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaHinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal objA = new Animal();
            Dog objD = new Dog();
            objA = objD;
            objA.Talk();
            Console.Read();
        }
    }
}
