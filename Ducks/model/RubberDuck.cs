using Ducks.fly_behavior;
using Ducks.quack_behavior;

namespace Ducks.model
{
    public class RubberDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("I'm Rubber Duck!");
        }
        public override void fly()
        {
            FlyBehavior flyBehavior = new FlyNoWay();
            flyBehavior.fly();
        }

        public override void quack()
        {
            QuackBehavior quackBehavior = new Squeak();
            quackBehavior.quack();
        }
    }
}
