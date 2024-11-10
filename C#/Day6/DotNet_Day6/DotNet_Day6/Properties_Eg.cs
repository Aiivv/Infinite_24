using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day6
{

    public class Employee
    {
        string _code = "N.A";
        string _name = "Mising";
        int _age = 0;

        string[] projectDetails = new string[10];

        //automatic property implementation
        public double Salary { get; } = 35000;

        //declare properties for all the private fields declared above
        //public Employee(string Code,String Name, int Age)
        //{
        //    _code = Code;
        //    _name = Name;
        //    _age = Age;
        //}


        public string Code
        {
            get { return _code; }  //reads the value of the field
            set { _code = value; }   //write/sets/manipulate the value of the field
        }
        //read only property (where there is only getter and no setter) 
        public int Age
        {
            get { return _age; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != " ")
                    _name = value;
                else
                    Console.WriteLine("Invalid data");
            }
        }

        //we need to override the ToString() of the object class inorder to be
        //display all the property value of the employeee obj
        public override string ToString()
        {
            return "Employee code = "+Code+ "Name = " + Name + "and Age = "+Age;
        }
    }

    class Properties_Eg
    {
        public static void Main()
        {
            Employee emp = new Employee();
            //emp.Code = "ajackson"; //it will call the setter
            //Console.WriteLine(emp.Code); //it will call the getter
            //Console.WriteLine(emp.Name = " ");
            Console.WriteLine(emp.Salary);
            Console.WriteLine("Employee Info {0}", emp.ToString());
            Console.Read();
        }
    }
}
