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
            string userInput = Userinterface.ChooseStackOrQueue();
            SweepstakesFactory factory = new SweepstakesFactory();
            ISweepstakesManager sweepstakesManager = factory.CreateFactory(userInput);
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManager, sweepstakesName);
            marketingFirm.CreateSweepStakes();
        }
    }
}
