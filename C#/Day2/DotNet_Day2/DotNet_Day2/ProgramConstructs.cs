using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNet_Day2;

namespace DotNet_Day2
{
    internal class ProgramConstructs
    {
        static void Main(string[] args)
        {
            ProgramConstructs obj = new ProgramConstructs();
            obj.GetGrade();
            obj.Grades_SwitchStatement();
            Loops obj1 = new Loops();
            Console.WriteLine("----------While Loop-----------------");
            obj1.WhileLoop();
            Console.WriteLine("---------- Do While Loop-----------------");
            obj1.DoWhile();
            Console.WriteLine("-----------------For Loop-------------------");
            Loops.ForLoop();
            Console.ReadKey();
        }



        public void GetGrade()
        {
            Console.WriteLine("Enter your Grade O/A/B/C");
            char grade = Convert.ToChar(Console.ReadLine());
            if (grade == 'O' || grade == 'A')
            {
                Console.WriteLine("Excellent");
            }
            else if (grade == 'A')
            {
                Console.WriteLine("Very Good");
            }
            else if (grade == 'B')
            {
                Console.WriteLine("Good");
            }
            else if (grade == 'C')
            {
                Console.WriteLine("Fair");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void Grades_SwitchStatement()
        {
            Console.WriteLine("Enter Grades: O/A/B/C");
            char Grades = Convert.ToChar(Console.ReadLine());
            switch (Grades)
            {
                case 'O':
                case 'o':

                    Console.WriteLine("Excellent");
                    break;

                case 'A':
                case 'a':
                    Console.WriteLine("Vey Good");
                    break;

                case 'B':
                case 'b':
                    Console.WriteLine("Good");
                    break;

                case 'C':
                case 'c':
                    Console.WriteLine("Fair");
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }

    class Loops
    {
        //iterations
        public void WhileLoop()
        {
            int i = 1;
            while (i < 5)
            {
                Console.Write(i);
                i++;
            }
            Console.Read();
        }


        public void DoWhile()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

        }

        public static void ForLoop()
        {
            int tot = 0;
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                    //break;
                    continue;
                    tot = tot + i;
            }
            Console.WriteLine(tot);
        }

    }
}

