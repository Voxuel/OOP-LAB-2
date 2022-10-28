using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLAB2
{
    class Husky : Dog
    {
        private readonly bool IsSleeping;
        public Husky(int _age, string _color, string _gender, bool _isHungry, string _name, bool _needsWash, bool _isSleeping)
        : base(_age, _color, _gender, _isHungry, _name, _needsWash)
        {
            this.IsSleeping = _isSleeping;
        }
        public Husky() : base()
        {

        }
        public void CheckSleep()
        {
            if (!IsSleeping)
            {
                Console.WriteLine($"{Name} is awake, Let's Play!.");
            }
            else
            {
                Console.WriteLine($"{Name} is sleeping, hush now.");
            }
        }
    }
}
