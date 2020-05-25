#define QUY         //Định nghĩa một chỉ thị/chỉ dẫn
#define TRAM
#define HUYEN
//#define HUNG
#define TUAN

#undef HUYEN 

//#define MY_NAME "quy"
//#define ADD_TWO_NUMBER(x, y) x + y
//#define 1
//#define true

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBaoCao
{
    class Program
    {
        static void Main(string[] args)
        {

            #region #if, #else , #elif , #endif 

            //ví dụ #if 
            //không được gán số
#if QUY
            Console.WriteLine("Hello QUY");
#endif

#if HUNG    //chưa khai báo
            Console.WriteLine("Hello HUNG");
#endif

#if HUYEN   //khai báo nhưng #undef
             Console.WriteLine("Hello HUYEN");
#endif
            

            #if true
                        Console.WriteLine("Hello");
            #endif


            #if (QUY == true) && (TUAN == true)&&(!HUYEN)
                        Console.WriteLine("Hello QUY and TUAN");
            #endif

            
            #if HUNG
                        Console.WriteLine("Hello HUNG");
            #else
                        Console.WriteLine("what your name ?");
            #endif

            

            #if HUYEN
                        Console.WriteLine("Hello HUYEN ");
            #elif TRAM

                        Console.WriteLine("Hello TRAM");
            #endif

            /*
            #if HUYEN
                        Console.WriteLine("Hello HUYEN ");
            #elif true

                        Console.WriteLine("Hello");
            #endif

            */
            #endregion

            #region #line, #region,#endregion
            
          #line 100 "Tên File"

            inta soDong = 100; //tạo ở dòng 84
            
            #endregion

            #region #Warning Và #Error
   /*         
#error  lỗi gì đó
#warning cẩn thận gì đó
    */
            #endregion

            #region #prama, #prama waring, #prama checksum

            #endregion



            Console.Read();
        }
    }
}
