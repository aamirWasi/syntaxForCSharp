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
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;
            decimal maxDec = decimal.MaxValue;
            decimal mindec = decimal.MinValue;

            Console.WriteLine("Max int :"+maxInt);
            Console.WriteLine("Min int :"+minInt);
            Console.WriteLine("Max Float :"+maxFloat);
            Console.WriteLine("Min float :"+minFloat);
            Console.WriteLine("Max Decimal :"+maxDec);
            Console.WriteLine("Min Decimal :"+minDec);
        }
    }
}
