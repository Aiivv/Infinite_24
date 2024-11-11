using System;

namespace DotNet_Day6
{

    //We are setting and getting the values in this code whereas in 2nd class we have set the values \
    //and we are just getting it through function but with the help of indexer
    class Indexers_Eg
    {
        private string[] names = new string[3];

        //indexer decl.

        public string this[int f]
        {
            get { return names[f]; }
            set { names[f] = value; }
        }

        public static void Main()
        {
            //Indexers_Eg indeg = new Indexers_Eg();
            //indeg[0] = "Avinash";//set the values for names[0]
            //indeg[1] = "Basavaraju";
            //indeg[2] = "Hemlata";
            //Console.WriteLine(indeg[0] + " " + indeg[1] + " " + indeg[2]);
            //Indexers_Eg2 indeg2 = new Indexers_Eg2();
            //indeg2.GetDay("Monday ");
            Indexers_Eg2 indeg2=new Indexers_Eg2();
            Console.WriteLine(indeg2["Tuesday"]);
            Console.WriteLine(indeg2["b"]);
            Console.Read();
        }
    }
    class Indexers_Eg2
    {
        string[] day = { "Sunday ", "Monday ", "Tuesday ", "Wednesday ", " Thursday ", "Friday ", "Saturday " };
        int GetDay(string days)
        {
           string lowerDays = days.ToLower().Trim();
            for (int i = 0; i < day.Length; i++)
            {
                if (day[i].ToLower().Trim() == lowerDays)
                {
                    //Console.WriteLine(day[i].Trim());
                    return i;
                }
            }
            Console.WriteLine("Argument must be like ");
            return -1;
        }

        public int this[string d]
        {
            get { return GetDay(d); }
        }
    }
}



