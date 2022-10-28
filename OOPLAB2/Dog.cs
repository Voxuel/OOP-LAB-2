using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLAB2
{
    class Dog : Animals
    {
        private readonly bool NeedsWash;
        private readonly string Sound = "Woof";
        public Dog(int _age, string _color, string _gender, bool _isHungry, string _name, bool _needsWash)
        : base(_age, _color, _gender, _isHungry, _name)
        {
            this.NeedsWash = _needsWash;
        }
        public Dog() : base()
        {

        }
        public void Wash()
        {
            if (!NeedsWash)
            {
                Console.WriteLine($"{Name} is already clean!");
            }
            else
            {
                Console.WriteLine($"You wash {Name}");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine(Sound);
        }
    }
}
