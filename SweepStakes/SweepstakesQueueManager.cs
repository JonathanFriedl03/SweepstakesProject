using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        private Queue<Sweepstakes> queue;
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            //this is where we do push?
            queue.Enqueue(sweepstakes);//top
        }
        public Sweepstakes GetSweepStakes()//top
        {
            //this is where we do pop?
            return queue.Dequeue();
        }
    }
}
