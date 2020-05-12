using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class SugarDecorator : AbstractDecorator
    {
        public AbstractDecorator Decorated { get; }

        public SugarDecorator(AbstractDecorator decorated)
        {
            Decorated = decorated;
        }


        public override string Description()
        {
            return $"{Decorated.Description()} + Sugar";
        }

        public override int GetCost()
        {
            return Decorated.GetCost() + 1;
        }
    }
}
