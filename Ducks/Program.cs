using Ducks.model;

namespace Ducks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new RedheadDuck();

            duck.display(); duck.quack();
            duck.swim(); duck.fly();
        }
    }
}
