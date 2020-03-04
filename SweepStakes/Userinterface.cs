using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Userinterface
    {

        public static string GetUserInfo(string prompt)
        {
            string name;
            Console.WriteLine("Please enter your {0}", prompt);
            name = Console.ReadLine();
            return name;
        }
        public static string GetNewSweepstakesName()
        {
            string sweepstakesName;
            Console.WriteLine("Please choose a name for your Sweepstakes.");
            sweepstakesName = Console.ReadLine();
            return sweepstakesName;
        }
        public static int ChooseStackOrQueue()
        {
            Console.WriteLine("Please choose Stack or Queue!");
            bool userInputIsAnInteger = false;
            int stack = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {

                {
                    Console.WriteLine("How many " + itemsToGet + " would you like to buy? " + "Each One cost $" + PricePerItem + " Your Inventory= " + numberOfAvailable + " Wallet= $" + moneyInWallet);
                    Console.WriteLine("Please enter a positive whole number (or 0 to cancel):");
                    userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
                }


            }

            return quantityOfItem;
        }
    }  
}
