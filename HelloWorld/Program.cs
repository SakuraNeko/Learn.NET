using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 2;
            Console.WriteLine(a);
            a = 3;
            Console.WriteLine(a);
            a = a + 1;
            Console.WriteLine(a);

            string s1 = "hello";
            string s2 = "World";
            Console.WriteLine(s1 + s2);
            Console.WriteLine(s1 + a);
            Console.WriteLine("a=" + a);

            a = 3;
            int b = 0;
            bool c = a == 4;

            if(a == 3)
            {
                b = 4;
            }
            else if(a == 4)
            {
                b = 5;
            }
            else if(a == 5)
            {
                b = 6;
            }
            else
            {
                b = 100;
            }
            Console.WriteLine("b=" + b);

            Console.ReadKey();
        }
    }
}
