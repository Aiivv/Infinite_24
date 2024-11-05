using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day4
{

    class Student
    {
        public int id;
        public string Name;
        string Dept;
        float Totmarks;
        public static string wish;

        public void StudentData()
        {
            Console.WriteLine("Enter Id");
            
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Dept");
            Dept = Console.ReadLine();
            Console.WriteLine("Enter marks: ");
            Totmarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student Roll NO,name,dept,Marks : ");
        }

        public void PrintDetails()
        {
            Console.WriteLine($" {id},{Name},{Dept},{Totmarks}");
        }

        public static string Wishes(string s) 
        {
            wish = s;
            return wish;
        }

    }
    public class Hint {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.StudentData();
            //s1.PrintDetails();
            //Console.WriteLine(Student.Wishes("Hello"));
            Employee e1 = new Employee();
            e1.DisplayEmp();
            Employee e = new Employee(1,"Aesda");
            e.DisplayEmp();
            Employee e2 = new Employee(2, "Jacks", 47573492362);
            e2.DisplayEmp();
            e1 = null; //setting an object reference to null from valid reference
            GC.Collect(); //forceful collection of garbage the momemt the object looses references
            //Employee e1 = new Employee();
            Console.ReadLine();
        }
    }
}
