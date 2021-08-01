namespace lib
{
    public class Quack : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            System.Console.WriteLine("Quack !");
        }
    }
}