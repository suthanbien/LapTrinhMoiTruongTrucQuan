using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoooooo
{
    class Class1
    {
#define DEBUG
        class MainClass
        {
            static void Main()
            {
#if DEBUG
#warning DEBUG is defined  
#endif
            }
        }
    }
}
