using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLAB2
{
    class Animals
    {
        private readonly int Age;
        private readonly string Color;
        private readonly string Gender;
        private readonly bool IsHungry;
        public readonly string Name;
        public Animals(int _age,string _color, string _gender, bool _isHungry, string _name)
        {
            this.Age = _age;
            this.Color = _color;
            this.Gender = _gender;
            this.IsHungry = _isHungry;
            this.Name = _name;
        }
        public void Pet()
        {
            Console.WriteLine($"You pet {Name}");
        }
        public void Feed()
        {
            if (!IsHungry)
            {
                Console.WriteLine($"{Name} is not hungry right now");
            }
            else
            {
                Console.WriteLine($"You feed {Name}");
            }
        }
        public void PrintAnimal()
        {
            Console.WriteLine($"Name : {Name} \nAge : {Age} \nGender : {Gender} \nColor : {Color}");
        }
        public virtual void MakeSound()
        {
            
        }
    }
}
