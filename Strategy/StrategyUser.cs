using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class StrategyUser : IStrategy
    {
        public IStrategy Strategy { get; set; }

        public StrategyUser(IStrategy strategy)
        {
            Strategy = strategy;
        }
        public void DoSomething()
        {
            Strategy.DoSomething();
        }
    }
}
