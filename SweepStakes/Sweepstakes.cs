using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
     public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant> { };
        string Name { get; set;}
       // public int winner;
        Random random = new Random();
       // public int registrationNumber;

        public Sweepstakes(string name)
        {
            this.Name = name;
            //winner = 0;
            //registrationNumber = 0;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestant.firstName = Userinterface.GetUserInfo("First Name");
            contestant.lastName = Userinterface.GetUserInfo("Last Name");
            contestant.email = Userinterface.GetUserInfo("Email Address");
            contestant.registrationNumber = contestants.Count;
            contestants.Add(contestant.registrationNumber, contestant);

        }
        public Contestant PickWinner()
        {

            return ;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"The winner is" + contestant);
            Console.ReadLine();
        }
    }
}
