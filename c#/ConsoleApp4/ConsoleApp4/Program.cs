using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {

        static void art(int a,  int b)
        {
            Console.WriteLine("\n ********** ARITHMETIC OPERATIONS ********** \n");
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g = a % b;
            Console.WriteLine("addition: " + c);
            Console.WriteLine("subtraction: " + d);
            Console.WriteLine("multiplication: " + e);
            Console.WriteLine("division: " + f);
            Console.WriteLine("modulus: " + g);
        }

        static void rel(int a, int b)
        {
            Console.WriteLine("\n ********** RELATIONAL OPERATIONS ********** \n");
            if (a > b)
            {
                Console.WriteLine(a + " > " + b);
            }

            else
            {
                Console.WriteLine(b + " > " + a);
            }

            if (a == b)
            {
                Console.WriteLine(a + " = " + b);
            }

            else
            {
                Console.WriteLine(a + " != " + b);
            }

            if (a >= b)
            {
                Console.WriteLine(a + " >= " + b);
            }

            else
            {
                Console.WriteLine(b + " >= " + a);
            }

        }

        static void log(int a, int b)
        {
            Console.WriteLine("\n ********** LOGICAL OPERATIONS ********** \n");
            if(a > b && a != b)
            {
                Console.Write("AND operator runs because both the conditions are true \n" + a + ">" + b + " and " + a + "!=" + b);
            }
            else if (a > b || a != b)
            {
                Console.Write("OR operator runs because one condition is true \n" + a + ">" + b + " or " + a + "!=" + b );
            }
            else
            {
                Console.WriteLine("not true");
            }

        }

            static void Main(string[] args)
        {
            art(5, 4);
            rel(4, 7);
            log(5, 6);
            Console.ReadLine();

        }


    }
}
