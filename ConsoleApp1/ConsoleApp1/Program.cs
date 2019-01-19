using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;
            decimal maxDec = decimal.MaxValue;
            decimal minDec = decimal.MinValue;

            Console.WriteLine("Max int :"+maxInt);
            Console.WriteLine("Min int :"+minInt);
            Console.WriteLine("Max Float :"+maxFloat);
            Console.WriteLine("Min float :"+minFloat);
            Console.WriteLine("Max Decimal :"+maxDec);
            Console.WriteLine("Min Decimal :"+minDec);
            */
            while (true)
            {
                var line = Console.ReadLine();
                if (line == null) break;
                var num = line.Split(' ');
                var num1 = Convert.ToInt32(num[0]);
                var num2 = Convert.ToInt32(num[1]);

                Console.WriteLine($"x :{num1}, y : {num2}");
            }
        }
    }
}
