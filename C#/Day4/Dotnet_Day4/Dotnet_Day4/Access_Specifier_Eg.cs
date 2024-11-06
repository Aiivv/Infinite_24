using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day4
{
    public class Access_Specifier_Eg
    {
        //private int privateData;//Private by default
        public int  publicData;
        internal int internalData;
        protected int protectedData;
        // or  internal protected int internalprocData;

        //protected internal int proctectedInternalData;
        public void TestPrivate()
        { 
        //{
        //    privateData = 5;
            Access_Specifier_Eg edu= new Access_Specifier_Eg();
            //edu.protectedData = 21;
        }
    }

    class Driver:Access_Specifier_Eg 
    {
        public void TestingAccess()
        {
            Access_Specifier_Eg age=new Access_Specifier_Eg();
            age.internalData = 5;
            Driver d1=new Driver();
            d1.protectedData = 5;
            //d1.internalprocData = 50;
        }

    }

}
