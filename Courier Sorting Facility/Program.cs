using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Sorting_Facility
{
    class Program
    {
        static void Main(string[] args)
        {
            Package package = new Package();
            
            Console.WriteLine("Choose function: ");
            Console.WriteLine("1. View Inventory");
            Console.WriteLine("2. Add Inventory");
            Console.WriteLine("3. Remove Inventory");
            
            int function;
            function = Int32.Parse(Console.ReadLine());

            switch (function)
            {
                case 1:
                    {
                        Console.WriteLine("\n ID of Inventory: {0}", package.TrackingID( ID));
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Key in new ID: ");
                        int newID;
                        newID = Int32.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Inventory Added");
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Key in removed ID: ");
                        int oldID;
                        oldID = Int32.Parse(Console.ReadLine());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("!! Wrong Input. Key again. !!");
                        break;
                    }

                    Console.WriteLine("\n Package Added: {0}", Package.ReceiverCounter);
                    Console.ReadLine();
            }



        }
    }
}
