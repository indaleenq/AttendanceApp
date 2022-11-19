using System;

namespace AttendanceApp //package
{
    internal class Program //class
    {
        static void Main() //main
        {
            int x = Convert.ToInt32(Console.ReadLine()); //1
            int y = Convert.ToInt32(Console.ReadLine()); //2

            Console.WriteLine($"{x} + {y} = {x + y}");

            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            //output -- 1 + 2 = 3
            Console.WriteLine("{2} + {0} = {1}", x, y, x + y);
            //output -- 3 + 1 = 2

            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} x {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            Console.WriteLine("{0} mod {1} = {2}", x, y, x % y);
        }
    }
}