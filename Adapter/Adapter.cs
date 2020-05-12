using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
   public class Adapter : ITarget
    {
        public Adaptee _adaptee { get; set; }
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public string DoItRight()
        {
            return _adaptee.DoItWrong();
        }
    }
}
