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
        Stack<Sweepstakes> stack;
        Queue<Sweepstakes> queue;
        public int newId;

        public MarketingFirm()
        {
            stack = new Stack<Sweepstakes>();
            queue = new Queue<Sweepstakes>();
        }

        public void PickSweepStakesManager()
        {
            void InsertSweepstakes(Sweepstakes sweepStakes);
            Sweepstakes GetSweepStakes();
        }
       
    }
}
