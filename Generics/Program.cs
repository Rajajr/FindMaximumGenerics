using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Programe");
            //  FindTheMaximum findTheMaximum = new FindTheMaximum();
            //FindMaximumFloat findMaximumFloat = new FindMaximumFloat();

            FindTheMaximumString findTheMaximumString = new FindTheMaximumString();


            //  Console.WriteLine("--------------------------------------");
            //  Console.WriteLine("1:Find The Maximum Integer Number Among 20, 7, 3");
            //  Console.WriteLine("Maximum Integer Number is :" + FindTheMaximum.FindMaximumIntegerNumber(20, 7, 3));

            // Console.WriteLine("--------------------------------------");
            // Console.WriteLine("2:Find The Maximum Integer Number Among 2, 15, 4");
            // Console.WriteLine("Maximum Integer Number is :" + FindTheMaximum.FindMaximumIntegerNumber(2, 15, 4));
            // Console.WriteLine("--------------------------------------");
            // Console.WriteLine("3:Find The Maximum Integer Number Among 11, 7, 9");
            // Console.WriteLine("Maximum Integer Number is :" + FindTheMaximum.FindMaximumIntegerNumber(11, 7, 9));

            // Console.WriteLine("--------------------------------------");
            // Console.WriteLine("1:Find The Maximum Float Number Among 3.56, 10.78, 5.50");
            // Console.WriteLine("Maximum Float Number is :" + FindMaximumFloat.FindMaximumFloatNumber(3.56f, 10.78f, 5.50f));

            // Console.WriteLine("--------------------------------------");
            // Console.WriteLine("2:Find The Maximum Float Number Among 2.23, 8.45, 4.56");
            // Console.WriteLine("Maximum Float Number is :" + FindMaximumFloat.FindMaximumFloatNumber(2.23f, 8.45f, 4.56f));
            // Console.WriteLine("--------------------------------------");
            // Console.WriteLine("3:Find The Maximum Float Number Among 1.49, 7.23, 9.16");
            //Console.WriteLine("Maximum Float Number is :" + FindMaximumFloat.FindMaximumFloatNumber(1.49f, 7.23f, 9.16f));

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1:Find The Maximum String Among:'Ramya','Daniel','Meena'");
            Console.WriteLine("Maximum String is :" + FindTheMaximumString.FindMaximumString("Ramya","Daniel","Meena"));

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("2:Find The Maximum String Among: 'Daniel','Ajay','Charli'");
            Console.WriteLine("Maximum String is :" + FindTheMaximumString.FindMaximumString("Daniel","Ajay","Charli"));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("3:Find The Maximum String Among: 'Sam','Nelson','Harsha'");
            Console.WriteLine("Maximum String is :" + FindTheMaximumString.FindMaximumString("Sam","Nelson","Harsha"));

            Console.ReadLine();
        }
    }
}
