using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class DoSomethingBad : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("Be a friend."); ;
        }
    }
}
