using Ducks.fly_behavior;
using Ducks.quack_behavior;

namespace Ducks.model
{
    public abstract class Duck : QuackBehavior, FlyBehavior
    {
        public void swim() { Console.WriteLine("duck is swim!"); }

        public abstract void display();
        public abstract void fly();
        public abstract void quack();
    }
}
