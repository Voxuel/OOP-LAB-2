using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLAB2
{
    class Shiba : Dog
    {
        private readonly string Trick = "the shiba stands on 2 legs!";
        public Shiba(int _age, string _color, string _gender, bool _isHungry, string _name, bool _needsWash)
        : base(_age, _color, _gender, _isHungry, _name, _needsWash)
        {

        }
        public Shiba() : base()
        {

        }
        public void MakeTrick()
        {
            Console.WriteLine($"{Name} " + Trick);
        }
    }
}
