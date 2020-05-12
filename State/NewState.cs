using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
   public class NewState : IState
    {

        public void DoStateThing(IStateSubject subject)
        {
            Console.WriteLine("Im The new state");
        }
    }
}
