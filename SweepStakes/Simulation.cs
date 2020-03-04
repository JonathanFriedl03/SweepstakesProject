using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            string sweepstakesName = Userinterface.GetNewSweepstakesName();
            ISweepstakesManager sweepstakesManager = Userinterface.ChooseStackOrQueue();
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManager, sweepstakesName);
            marketingFirm.CreateSweepStakes();
        }
    }
}
