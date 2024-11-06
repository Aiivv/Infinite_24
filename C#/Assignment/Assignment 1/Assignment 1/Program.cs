using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (j == 1 || j == 3)
                    {

                        Console.Write(num);
                    }
                    else
                    {
                        Console.Write(num + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }

    //Console.WriteLine("Enter a Number: ");
    //int a =Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Enter Second Number: ");
    //int b=Convert.ToInt32(Console.ReadLine());
    //int c;
    //Console.WriteLine("First Number is " + a + "And Second Number is: " + b);
    //c = a;
    //a = b;
    //b = c;
    //Console.WriteLine("First Number is " + a + "Second Number is: " + b);
    //Console.ReadLine();
}

