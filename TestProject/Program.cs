using Adapter;
using Decorator;
using State;
using System;
using System.Data.Common;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //State();
            //Decorator();
            var ITarget = new Adapter.Adapter(new Adaptee());
            Console.WriteLine(ITarget.DoItRight());

        }

        private static void Decorator()
        {
            AbstractDecorator decorator = new Coffee();
            decorator = new MilkDecorator(decorator);
            decorator = new MilkDecorator(decorator);
            decorator = new SugarDecorator(decorator);
            Console.WriteLine(decorator.Description());
            Console.WriteLine($"Kost:€ {decorator.GetCost()}");
        }

        private static void State()
        {
            var state = new DoorWithStates();
            state.DoStateThing(state);
            state.SetState(new ClosedState());
            state.DoStateThing(state);
            state.DoStateThing(state);
        }
    }
}
