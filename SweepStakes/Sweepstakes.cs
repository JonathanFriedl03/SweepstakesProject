using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        string Name { get; set;}
        public int winner;
        Random random = new Random();
        public int registrationNumber;

        public Sweepstakes(string name)
        {
            this.Name = name;
            winner = 0;
            registrationNumber = 0;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(registrationNumber, contestant);
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
