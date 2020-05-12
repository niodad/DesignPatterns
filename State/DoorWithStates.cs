using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
   public class DoorWithStates : IStateSubject
    {
        private  IState State { get; set; }

        public void SetState(IState state)
        {
            State = state;
        }

        public void DoStateThing(IStateSubject subject)
        {
            State.DoStateThing(subject);
        }
    }
}
