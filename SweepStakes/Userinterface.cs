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
            Console.Clear();
            return name;
        }
        public static string GetNewSweepstakesName()
        {
            string sweepstakesName;
            Console.WriteLine("Please choose a name for your Sweepstakes.");
            sweepstakesName = Console.ReadLine();
            Console.Clear();
            return sweepstakesName;
        }
        public static string ChooseStackOrQueue()
        {
            Console.WriteLine("Please choose Stack or Queue!");
            
            
                string choice = (Console.ReadLine().ToLower());
                if (choice == "stack" || choice == "queue")
                {
                    return choice;
                }
             else
            {
                Console.WriteLine("Your choice is invalid!");
                Console.Clear();
            }return ChooseStackOrQueue();



        }
    }  
}
