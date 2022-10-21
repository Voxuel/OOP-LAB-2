using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLAB2
{
    class Cat : Animals
    {
        private readonly bool ClawCutNeeded;
        public Cat(int _age, string _color, string _gender, bool _isHungry, string _name, bool _clawCutNeeded) 
            : base(_age, _color, _gender, _isHungry, _name)
        {
            this.ClawCutNeeded = _clawCutNeeded;
        }
        public void CutClaws()
        {
            if (!ClawCutNeeded)
            {
                Console.WriteLine("The claw ain't long enough");
            }
            else
            {
                Console.WriteLine($"You cut {Name} the cat claws");
            }
        }
        public override void MakeSound()
        {
             Console.WriteLine("Meow");
        }
    }
}
