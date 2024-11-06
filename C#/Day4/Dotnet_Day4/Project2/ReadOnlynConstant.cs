using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class ReadOnlynConstant
    {
        readonly bool flag = true; //initializing at the time of declaration
        readonly int ronly; //only declaration

        internal ReadOnlynConstant()
        {
            Console.WriteLine(flag + " " + ronly);
            flag = false;
            ronly = 100; //initializng the readonly variable in the current context
            
            Console.WriteLine(flag + " " + ronly);
        }
    }

    class Trial {
        public void trialFunction()
        {
            ReadOnlynConstant rc = new ReadOnlynConstant();
            Console.WriteLine("Hi");
            Console.Read();
        }

    }
}
