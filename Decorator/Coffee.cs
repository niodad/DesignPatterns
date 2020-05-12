using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Coffee : AbstractDecorator
    {
        public override string Description() {
            return "Decorator";
        }

        public override int GetCost()
        {
            return 1;
        }
    }
}
