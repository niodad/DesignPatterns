using System;

namespace State
{
    public class OpenState : IState
    {
 
       public void DoStateThing(IStateSubject subject)
        {
  
            Console.WriteLine("Im closing");
            subject.SetState(new ClosedState());
        }

    }
}
