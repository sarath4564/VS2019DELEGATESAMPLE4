//using System;
// delegate void MyDelegate(int x, int y);
//   class Program
//   {
//        static void Main()
//        {
//            MyDelegate del  = Division;
//            del(9000,3000);
//        }
//                static void Division (int x,int y)
//                {
//                    Console.WriteLine(x/y);
//                }
//   }


using System;
delegate void MyDelegate(int x, int y);
class Program
{
    static void Main()
    {
        MyDelegate del = Division;
        del(9000, 3000);
    }
    static void Division(int x, int y)
    {
        Console.WriteLine(x / y);
    }
}

