using Ducks.fly_behavior;
using Ducks.quack_behavior;

namespace Ducks.model
{
    public class RedheadDuck : Duck
    {

        public override void display()
        {
            Console.WriteLine("I'm Redhead Duck!");
        }
        public override void fly()
        {
            FlyBehavior flyBehavior = new FlyWithWings();
            flyBehavior.fly();
        }

        public override void quack()
        {
            QuackBehavior quackBehavior = new Quack();
            quackBehavior.quack();
        }
    }
}
