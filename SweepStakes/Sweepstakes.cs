using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        string name;
        public string winner;
        Dictionary<int, Contestant> contestants;
        Random random = new Random();
        public int registrationNumber;

        public void SweepStakes(string name)
        {
            this.name = name; 
        }
    }
}
