using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm 
    {
        private ISweepstakesManager _manager;
        string name;
        public string Name
        {
            get
            {
                return Name;
            }
        }
       

        public MarketingFirm(ISweepstakesManager manager, string name)
        {
            _manager = manager;
            this.name = name;
        }

        public void CreateSweepStakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(name);
            _manager.InsertSweepstakes(sweepstakes);
            //RegisterContestant();
            //PickWinner();
            //PrintContestantInfo(winner);
        }
       
    }
}
