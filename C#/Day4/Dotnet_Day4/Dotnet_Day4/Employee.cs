using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day4
{
    public class Employee
    {
        public int EmpId;
        public string EmpName;
        double EmpSalary;


       public Employee()  //Private Constructor cannot be called outside the class
        {
            EmpId = 2400;
            EmpName = "Aryan";
            EmpSalary = 1223434;
        }

        internal Employee(int eid, string ename)
        {
            EmpId = eid;
            EmpName = ename;
        }
        public Employee(int EmpId, string EmpName, double EmpSalary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSalary = EmpSalary;
        }
        public void DisplayEmp()
        {
            Console.WriteLine($" Emp id {EmpId},Emp Name {EmpName}, EmpSalary {EmpSalary} ");
        }
    }
}
