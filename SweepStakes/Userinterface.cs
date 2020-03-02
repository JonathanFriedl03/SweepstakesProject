using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Userinterface
    {
        static int registrationNumber;

       public static string GetUserFirstName()
        {
            string name;
            Console.WriteLine("Please enter your First name.");
            name = Console.ReadLine();
            return name;
        }
        public static string GetUserLastName()
        {
            string lastName;
            Console.WriteLine("Please enter your Last name.");
            lastName = Console.ReadLine();
            return lastName;
        }
        public static string GetUserEmail()
        {
            string email;
            Console.WriteLine("Please enter your Email.");
            email = Console.ReadLine();
            return email;
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
