
#include<iostream>
#include<string>
#include<cstdio>
#include<cstdlib>
#include<algorithm>
#include<cmath>
#include<climits>
#include<vector>
#include<stack>
#include<queue>
#include<deque>
#include <time.h>
using namespace std;
//C++ 
// macro giống  đối tượng
 // macro giống đối tượng với một văn bản thay thế

    // macro giống  đối tượng mà không có văn bản thay thế
#define PRINT_HELLO_WORLD printf("Hello world")

// macro giống  hàm
#define ADD_TWO_NUMBER(x, y) x + y

int main()
{
#define PRINT_HELLO_QUY 
     cout << PRINT_HELLO_WORLD << endl;  //đối với có vb thay thế
    //cout << PRINT_HELLO_QUY << endl; // lỗi không dùng theo kiểu này thay vào đó thì như sau:

   /* #ifdef PRINT_HELLO_QUY
        cout << "Hello Quy" << endl; // if PRINT_HELLO_QUY is defined (định nghĩa), compile this code
    #endif*/

   cout << ADD_TWO_NUMBER(5, 6) << endl;
  


}