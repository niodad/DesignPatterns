using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Adaptee
    {
        public string DoItWrong() 
        {
            return $"Done by de adaptee through method {nameof(DoItWrong)}";
        }
    }
}
