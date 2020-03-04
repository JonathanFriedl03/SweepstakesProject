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
        
        public static int GetRegistrationNumber()
        {
            for (int i = 0; i < 0; i++)
            {
                if (registrationNumber == 0)
                {
                    registrationNumber = i++;
                }
                else
                {
                    return i++;
                }

            }return registrationNumber;
        }
    }
}
