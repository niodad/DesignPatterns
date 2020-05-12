using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public interface IStateSubject : IState
    {
        void SetState(IState state);
       
    }
}
