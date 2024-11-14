using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day7
{
    class Collections
    {
        static void Main()
        {
            Collections.ArrayList_Function();
            Collections.HashTableFunction();
            Console.Read();
        }

        public static void ArrayList_Function()
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add("Hello");
            arrayList1.Add("Hiee");
            arrayList1.Add(true);
            arrayList1.Add(10);
            arrayList1.Add("Infinite");
            arrayList1.Add(31.21);
            //arrayList1.Sort();




            foreach (var i in arrayList1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------------");
            arrayList1.Add("Ram");
            arrayList1.Add(345.658);
            arrayList1.Insert(9, "sd");
            arrayList1.Insert(10, 12221);
            arrayList1.Insert(2, "sa");
            arrayList1.RemoveAt(2);
            Console.WriteLine("adding a range of values");
            ArrayList arrList2 = new ArrayList();
            arrList2.Add(1);
            arrList2.Add(24);
            arrList2.Add(21);
            arrList2.Add(29);
            arrList2.Add(2090);
            arrayList1.AddRange(arrList2);
            foreach (var i in arrayList1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Count is {0} and capacity is {1}", arrayList1.Count, arrayList1.Capacity);

            Console.WriteLine("-----------List2------------");
            arrList2.Sort();
            foreach (int x in arrList2)
            {
                Console.WriteLine(x);
            }
        }

        public static void HashTableFunction()
        {
            Hashtable ht = new Hashtable();
            ht.Add("E001", "Yashika");
            ht.Add("EOO3", "Samanta");
            ht.Add("E005", "Ajeeva");
            ht.Add("E009", "Simran");

            foreach (var items in ht.Keys)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("===========");
            foreach (var items in ht.Values)
            {
                Console.WriteLine(items);
            }
        }
    }
}