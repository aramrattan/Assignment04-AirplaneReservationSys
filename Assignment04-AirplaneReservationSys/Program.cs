using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_AirplaneReservationSys
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //Waitforkey method to pause screen
        private static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("**********************************");
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("**********************************");
            Console.ReadKey();
            Console.Clear();
        }

        private static void DisplayMenu()
        {
           
                Console.WriteLine("********************************");
                Console.WriteLine("*                              *");
                Console.WriteLine("*  1. First Class Seats        *");
                Console.WriteLine("*  2. Economy Seats            *");
                Console.WriteLine("*  3. Exit                     *");
                Console.WriteLine("*                              *");
                Console.WriteLine("********************************");
                Console.Write("Please make your selection: ");

   
        }
    }
}
