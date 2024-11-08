using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day5
{
    class Student
    {
        private string RollNo;
        string Name;
        string Class;

        public void GetData()
        {
            Console.WriteLine("Enter Roll no :");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class ");
            Class = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Name of student: " + Name);
            Console.WriteLine("Roll no of student: " + RollNo);
            Console.WriteLine("Class of student: " + Class);
        }
    }


    class Marks : Student
    {
        protected int[] marks = new int[5];
        public void GetMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter marks for each subject: {0}  ", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void PutMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Marks in subject {i + 1}:{marks[i]}");
            }
        }
    }

    class Results : Marks
    {
        public int totalMarks = 0;
        public void GetResults()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                totalMarks = totalMarks + marks[i];
            }
        }
        public int PercentageMarks = 0;
        public void GetResults1()
        {

            PercentageMarks = ((totalMarks) * 100) / marks.Length;
        }

        public void ShowResults()
        {
            Console.WriteLine("=========Results==============");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks = " + totalMarks);
            Console.WriteLine("Percentage = "+ PercentageMarks);

        }
        
    }


    class MultiLevel_Inheritence
    {
        static void Main()
        {
            Results r = new Results();
            r.GetData();
            r.GetMarks();
            r.GetResults();
            r.GetResults1();
            r.ShowResults();
            Console.Read();
        }
    }

}