using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class DoSomethingGood : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("Be a friend."); ;
        }
    }
}
