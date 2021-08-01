namespace lib
{
    public class MallardDuck : Duck
    {

        public MallardDuck(IQuackBehaviour quackBehaviour, IFlyBehaviour flyBehaviour) : base(quackBehaviour, flyBehaviour) { }

        public override void Display()
        {
            System.Console.WriteLine("MallardDuck Display..");
        }

    }
}