
// Use composition to make a car ( 4 wheel, 1 stering wheel), 
// add functionality(stop, start car)
// Advantages COMPOSITION VS INHERITANCE
// 1/ advatages composition
// With composition, it's easy to change behavior on the fly with Dependency Injection / Setters.
// better encapsulation
// better dividing the code on responsabilities
// better flexibility
// better mentenance because is made of sub-components
// Inheritance is more rigid as most languages do not allow you to derive from more than one type.
using System;

namespace Classes
{

    public class Wheel
    {
        public string Position{get;set;}

        public void Roll()
        {
            Console.WriteLine("The wheel in position '{0}' is rolling ...", Position);
        }

        public void Stop()
        {
            Console.WriteLine("The wheel in position '{0}' has stopped ...", Position);
        }
    }
    
    public class SteeringWheel
    {
        public void SteerRight()
        {
            Console.WriteLine("Steering right ...");
        }

        public void SteerLeft()
        {
            Console.WriteLine("Steering left ...");
        }

        public void KeepStraight()
        {
            Console.WriteLine("Keeping direction straight ...");
        }
    }

    public class CarComposition
    {
        private readonly Wheel[] wheels;
        private readonly SteeringWheel steeringWheel;

        public CarComposition()
        {
            this.wheels = new Wheel[]
            {
                new Wheel { Position = "Front-Left" },
                new Wheel { Position = "Front-Right" },
                new Wheel { Position = "Rear-Left" },
                new Wheel { Position = "Rear-Right" }
            };
            this.steeringWheel = new SteeringWheel();
        }

        public void Start()
        {
            foreach (var wheel in this.wheels)
            {
                wheel.Roll();
            }

            this.steeringWheel.KeepStraight();
        }
        public void TurnRigth()
        {
            this.steeringWheel.SteerLeft();
        }

        public void TurnLeft()
        {
            this.steeringWheel.SteerLeft();
        }

        public void Stop()
        {
            foreach (var wheel in this.wheels)
            {
                wheel.Stop();
            }
        }



    }
}
