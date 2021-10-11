using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //32 bit 
            int number1 = 0;

            //64 bit 
            long number2 = 18000000;

            //16 bit
            short number3 = 134;

            //8 bit
            byte number4 = 10;

            //true or false
            bool condition = false;

            //
            char character = 'A';

            //
            string city = "sivas";

            // 64 bit
            double doub = 14.5;


            Console.WriteLine(number4);
            Console.WriteLine(number3);
            Console.WriteLine("deneme {0} {1}",number1,number2);
            Console.ReadLine();
        }
    }
}
