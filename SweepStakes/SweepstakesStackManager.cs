using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        private Stack<Sweepstakes> stack;

        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            //this is where we do push?
            stack.Push(sweepstakes);//top
        }
        public Sweepstakes GetSweepStakes()//top
        {
            //this is where we do pop?
            return stack.Pop();
        }
    }
}
