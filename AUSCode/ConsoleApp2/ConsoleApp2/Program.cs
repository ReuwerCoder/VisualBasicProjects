using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp2
{
    public class Program
    {

        public static void Main(string[] args)
        {
            

            Console.WriteLine("HELLO AND WELCOME TO THE AUS SECURITY SHIFT PATROL HELPER!");
            Console.WriteLine("Created by J.R. 2019");

            Console.WriteLine("Please Use the number keys to naviagte the following menus");
            

            bool continue = true;

            while (continue)
            {
                Console.WriteLine("ALLIED SHIFT APPLICATION OPTIONS:");
                Console.WriteLine("1. Dispatch Hourly Checklist");
                Console.WriteLine("2. Notification Helper");
                Console.WriteLine("3. Exit");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "s":
                        //statement 
                        break;

                    case "u":
                        //statement 
                        break;

                    case "d":
                        //statement 
                        break;

                    case "e":
                    default:
                        continue = false;
                        break;
                }
            }

        }
    }
}
    }
}