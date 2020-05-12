using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class MilkDecorator : AbstractDecorator
    {
        public AbstractDecorator Decorated { get; }

        public MilkDecorator(AbstractDecorator decorated)
        {
            Decorated = decorated;
        }


        public override string Description()
        {
            return $"{Decorated.Description()} + Milk";
        }

        public override int GetCost()
        {
            return Decorated.GetCost() + 2;
        }
    }
}
