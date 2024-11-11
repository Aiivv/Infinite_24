using System;


namespace DotNet_Day6
{
    public class Flower
    {
        string name;
        string color;

        public Flower(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void Display()
        {
            Console.WriteLine(name + " is in " + color + "color");
        }
    }

    class FloweVase
    {
        Flower[] flowerobj = new Flower[5];  //aggregation

        //indexer,that keeps track of the array object
        public Flower this[int pos]
        {
            get { return flowerobj[pos]; }
            set { flowerobj[pos] = value; }
        }

        

    }
    class Indexers_Eg3
    {
        static void Main()
        {
            FloweVase fv = new FloweVase();
            fv[0] = new Flower("Lilly", "Blue");
            fv[1] = new Flower("Rhododendron", "Red");
            fv[2] = new Flower("Sunflower", "Yellow");
            fv[3] = new Flower("", "");
            fv[4] = new Flower("Lotus", "Pink");
            //Console.WriteLine(fv[2]);

            for (int i = 0; i < 5; i++)
            {
                fv[i].Display();
            }
            Console.Read();
        }
    }
    public sealed class Testing
    {
        public void orderGeneration()
        {

        }
    }

    public class Testing12
    {
        public void orderGeneration()
        {
             
        }
        public static void Main()
        {
            Testing t = new Testing();
            t.orderGeneration();
        }

    }
}

