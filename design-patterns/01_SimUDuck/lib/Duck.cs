using System;

namespace lib
{
    public abstract class Duck : IQuackBehaviour, IFlyBehaviour
    {
        private readonly IQuackBehaviour _quackBehaviour;
        private readonly IFlyBehaviour _flyBehaviour;

        public Duck(IQuackBehaviour quackBehaviour, IFlyBehaviour flyBehaviour)
        {
            _quackBehaviour = quackBehaviour;
            _flyBehaviour = flyBehaviour;
        }

        public void Swim()
        {
            System.Console.WriteLine("Duck Super. (All Ducks Float)");
        }

        public abstract void Display();

        public void Fly()
        {
            _flyBehaviour.Fly();
        }

        public void Quack()
        {
            _quackBehaviour.Quack();
        }
    }
}
