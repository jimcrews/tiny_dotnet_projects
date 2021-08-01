using System;
using lib;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyBehaviour flyBehaviour = new FlyWithWings();
            IQuackBehaviour quackBehaviour = new Quack();

            Duck mallardDuck = new MallardDuck(quackBehaviour, flyBehaviour);

            mallardDuck.Display();
            mallardDuck.Swim();
            mallardDuck.Fly();
            mallardDuck.Quack();
        }
    }
}
