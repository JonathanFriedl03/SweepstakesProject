using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesFactory
    {
        public ISweepstakesManager CreateFactory(string factoryType)
        {
            switch (factoryType)
            {
                case "queue":
                    return new SweepstakesQueueManager();
                case "stack":
                    return new SweepstakesStackManager();
                
                default:
                    throw new ApplicationException(string.Format("Not a valid input"));
            }
        }
    }
}

