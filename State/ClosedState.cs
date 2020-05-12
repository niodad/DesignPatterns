using System;

namespace State
{
    public class ClosedState : IState
    {

        public void DoStateThing(IStateSubject subject)
        {
            Console.WriteLine("Im opening");
            subject.SetState(new OpenState());
        }
    }
}
