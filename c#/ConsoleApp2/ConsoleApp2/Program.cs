using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hello world!");

            Console.WriteLine("\n ********** ASSIGNMENT # 01 **********");

            Console.Write(" Enter your first name: ");
            string fname = Console.ReadLine();

            Console.Write(" Enter your last name: ");
            string lname = Console.ReadLine();

            Console.Write(" Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());

            Console.Write(" Enter your address: ");
            string address = Console.ReadLine();

            Console.Write(" Your gender: ");
            string gender = Console.ReadLine();

            Console.WriteLine("\n YOUR DETAILS");
            Console.WriteLine("* Your name is " + (fname + " " + lname));
            Console.WriteLine("* Your age is " + age);
            Console.WriteLine("* Your address is " + address);
            Console.WriteLine("* Your gender is " + gender);

            Console.WriteLine("\n\n ********** ASSIGNMENT # 02 **********");
            Console.Write("Enter any no: ");
            int num = Int32.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {

                Console.WriteLine(" * The number " + num + " is even ");
            }
            else
            {
                Console.WriteLine(" * The number " + num + " is odd ");
            }

            Console.WriteLine("\n\n ********** ASSIGNMENT # 03 **********");
            Console.Write("Enter any letter: ");
            char a = Char.Parse(Console.ReadLine());

            if(a=='A' || a=='a')
            {

                Console.WriteLine(" * " +  a + " is vowel");
            }
            else if(a == 'A' || a == 'a')
            {

                Console.WriteLine(" * " + a + " is vowel");
            }
            else if (a == 'A' || a == 'a')
            {

                Console.WriteLine(" * " +  a + " is vowel");
            }
            else if (a == 'A' || a == 'a')
            {

                Console.WriteLine(" * " + a + " is vowel");
            }
            else if (a == 'A' || a == 'a')
            {

                Console.WriteLine(" * " + a + " is vowel");
            }

            else
            {
                Console.WriteLine(" * " + a + " is consonent");
            }

            /** Console.WriteLine("\n\n ********** ASSIGNMENT # 04 **********");
             Console.WriteLine("=> press 'y' to continue");
             char y = Char.Parse(Console.ReadLine());

             while(y=='y' || y=='Y'){
                 Console.WriteLine("You are continue........");
             } *
            */

            Console.WriteLine("\n\n ********** ASSIGNMENT # 05 **********");
            Console.Write("Enter any number to see the table: ");
            int no = Int32.Parse(Console.ReadLine());

            for(int n=1; n<=10; n++)
            {
                Console.WriteLine(no + " * " + n + " = " + ( no*n ));
            }

            Console.WriteLine("\n\n ********** ASSIGNMENT # 06 **********");
            Console.Write("Enter first number: ");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int n2 = Int32.Parse(Console.ReadLine());

             Console.WriteLine( n1 + " + " +  n2 + " = " + (n1 + n2));
             Console.WriteLine(n1 + " * " + n2 + " = " + (n1 * n2));
             Console.WriteLine(n1 + " - " + n2 + " = " + (n1 - n2));
             Console.WriteLine(n1 + " / " + n2 + " = " + (n1 / n2));
             Console.WriteLine(n1 + " % " + n2 + " = " + (n1 % n2));

            int i, j, k;
            Console.WriteLine("\n\n ********** PATTERN ASSIGNMENT #07 **********");
            Console.Write("\n Enter the number of rows: ");
            int row = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n **** SQUARE PATTERN ***** \n ");
            for (i = 0; i <= row; i++)
            {
                for (j = 0; j <= row; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n **** LEFT SIDE TRIANGLE PATTERN ***** \n ");
            for (i = 0; i <= row; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n **** REVERSE TRIANGLE PATTERN ***** \n ");
            for (i = 0; i <= row; i++)
            {
                for (j = row; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n **** RIGHT SIDE TRIANGLE PATTERN ***** \n ");
            for (i = 0; i <= row; i++)
            {
                for (j = row; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n **** REVERSE TRIANGLE PATTERN ***** \n ");
            for (i = 0; i <= row; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (k = i; k <= row; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n **** PYRAMID PATTERN ***** \n ");
            for (i = 0; i <= row; i++)
            {
                for (j = row; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }



            Console.ReadLine();
        }

    }
}
