using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    interface iAccessorie
    {
        void mirror();
    }

    class Furniture
    {
        public int height;
        public int width;

        public void printDetails(String furnitureType)
        {
            Console.WriteLine($"Printing Details for {furnitureType}");
            Console.WriteLine($"Height : {height} Width : {width}");
        }
    }
    class Chair : Furniture { 
        public void getDetails()
        {
            //avoiding user input to speed up the explanation
            height = 20; width=40;
            printDetails("Chair"); 
            // calling the printDetails
            // function inherited from Furniture
        }
    }
    class Almirah : Furniture , iAccessorie 
    {
        public void mirror() { Console.WriteLine("See yourself here.."); }

        public void getDetails()
        {
            height = 50; width = 30;
            printDetails("Almirah");
        }
    }
    class table : Furniture
    {
        public void getDetails()
        {
            height = 30;
            width = 80;
            printDetails("Table");
        }
    }
    internal class Program1
    {
        static void Main(string[] args)
        {
            Chair neelkamal = new Chair();
            neelkamal.getDetails();

            Almirah godrej = new Almirah();
            godrej.getDetails();

            table t = new table();
            t.getDetails();
        }
    }
}
