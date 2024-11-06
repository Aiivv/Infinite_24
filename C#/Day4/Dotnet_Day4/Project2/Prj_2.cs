using System;
using Dotnet_Day4;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Prj_2:Access_Specifier_Eg
    {
        static void Main(string[] args)
        {
            Access_Specifier_Eg access=new Access_Specifier_Eg();
            access.publicData = 21;
            Prj_2 p1=new Prj_2();
            p1.protectedData = 22;
            //p1.internalprocData = 23;
        }
    }
}
