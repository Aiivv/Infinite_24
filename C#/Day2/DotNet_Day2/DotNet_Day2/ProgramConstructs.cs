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
        }



        public void GetGrade()
        {
            Console.WriteLine("Enter your Grade O/A/B/C");
            char grade = Convert.ToChar(Console.ReadLine());
            if (grade == 'O')
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
                    
                        Console.WriteLine("Excellent");
                        break;
                    
                case 'A':
                    
                        Console.WriteLine("Vey Good");
                        break;
                    
                case 'B':
                    
                        Console.WriteLine("Good");
                       break;
                    
                case 'C':
                    
                        Console.WriteLine("Fair");
                        
                    
                default:
                    
                        Console.WriteLine("Invalid");
                       
                    
            }
            Console.Read();
        }
    }
}
