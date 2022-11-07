using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Programe");
            FindTheMaximum findTheMaximum = new FindTheMaximum();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1:Find The Maximum Integer Number Among 20, 7, 3");
            Console.WriteLine("Maximum Integer Number is :" + FindTheMaximum.FindMaximumIntegerNumber(20, 7, 3));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("2:Find The Maximum Integer Number Among 2, 15, 4");
            Console.WriteLine("Maximum Integer Number is :" + FindTheMaximum.FindMaximumIntegerNumber(2, 15, 4));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("3:Find The Maximum Integer Number Among 11, 7, 9");
            Console.WriteLine("Maximum Integer Number is :" + FindTheMaximum.FindMaximumIntegerNumber(11, 7, 9));

            Console.ReadLine();
        }
    }
}
