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
            bool[] seatAvailability = {false, false, false, false, false, false, false, false, false, false};
            string selection = "";

            while (selection !="3")
            {
                selection = DisplayMenu();
                int indexFirst = 0, indexEco = 0;
                bool seatSelection = false;
                int seatAssigned;

                
               switch (selection)
                {
                    case "1":
                        while (seatSelection == false && indexFirst < 5)
                        {
                            
                            if (seatAvailability[indexFirst] == false)
                            {
                                seatAvailability[indexFirst] = true;
                                seatAssigned = indexFirst + 1;
                                Console.WriteLine("The seat you booked is seat number {0}.", seatAssigned);
                                seatSelection = true;
                                //to see if array is changing
                                DisplayArray(seatAvailability);

                            }
                            else
                            {
                                indexFirst++;
                            }

                        }
                       if (indexFirst >= 5)
                       {
                           string switchClass;
                           Console.WriteLine("Sorry all seats in first class are full. Would you like a seat in economy? Y for yes and N for No: ");
                           switchClass = Console.ReadLine().ToLower();

                           if (switchClass=="y")
                           {
                               indexEco = 5;
                               while (seatSelection == false && indexEco >= 5 && indexEco < 10)
                               {
                                   //have to make so that it doesnt go over the 5th seat
                                   if (seatAvailability[indexEco] == false)
                                   {
                                       seatAvailability[indexEco] = true;
                                       seatAssigned = indexEco + 1;
                                       Console.WriteLine(seatAssigned);
                                       Console.WriteLine("The seat you booked is seat number {0}.", seatAssigned);
                                       seatSelection = true;
                                       //pk\ij\kj
                                       DisplayArray(seatAvailability);

                                   }
                                   else
                                   {
                                       indexEco++;
                                   }
                               }
                               if (indexEco >= 10)
                               {
                                   Console.WriteLine("Sorry the flight is full. The next Flight leaves in three (3) hours.");
                               }
                           }
                           else
                           {
                               Console.WriteLine("The next flight leaves in three (3) hours.");
                           }
                       }
                        break;
                    case "2":
                        indexEco = 5;
                        while (seatSelection == false && indexEco >=5 && indexEco < 10)
                        {
                            //have to make so that it doesnt go over the 5th seat
                            if (seatAvailability[indexEco] == false)
                            {
                                seatAvailability[indexEco] = true;
                                seatAssigned = indexEco + 1;
                                Console.WriteLine(seatAssigned);
                                Console.WriteLine("The seat you booked is seat number {0}.", seatAssigned);
                                seatSelection = true;
                                //lllkllklk
                                DisplayArray(seatAvailability);
                            }
                            else
                            {
                                indexEco++;
                            }
                        }
                        if (indexEco >= 9)
                        {
                            string switchClass;
                            Console.WriteLine("Sorry all seats in economy class are full. Would you like a seat in First Class? Y for yes and N for No: ");
                            switchClass = Console.ReadLine().ToLower();

                            if (switchClass == "y")
                            {
                                indexFirst = 0;
                                while (seatSelection == false && indexFirst < 5)
                                {
                                    //have to make so that it doesnt go over the 5th seat
                                    if (seatAvailability[indexFirst] == false)
                                    {
                                        seatAvailability[indexFirst] = true;
                                        seatAssigned = indexFirst + 1;
                                        Console.WriteLine(seatAssigned);
                                        Console.WriteLine("The seat you booked is seat number {0}.", seatAssigned);
                                        seatSelection = true;
                                        //;;llookkllo
                                        DisplayArray(seatAvailability);

                                    }
                                    else
                                    {
                                        indexFirst++;
                                    }
                                }
                                if (indexFirst >= 5)
                                {
                                    Console.WriteLine("Sorry the flight is full. The next Flight leaves in three (3) hours.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The next flight leaves in three (3) hours.");
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine();
                        break;
               
                }

               
            }
        }

        //Waitforkey method to pause screen
        private static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("**********************************");
            Console.WriteLine("** Press any key to continue... **");
            Console.WriteLine("**********************************");
            Console.ReadKey();
             
        }

        private static string DisplayMenu()
        {
           
                Console.WriteLine("********************************");
                Console.WriteLine("*                              *");
                Console.WriteLine("*    1. First Class Seats      *");
                Console.WriteLine("*    2. Economy Seats          *");
                Console.WriteLine("*    3. Exit                   *");
                Console.WriteLine("*                              *");
                Console.WriteLine("********************************");
                Console.Write("Please make your selection: ");
                return Console.ReadLine();
   
        }
        //Method to display arrays
        private static void DisplayArray(bool[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
