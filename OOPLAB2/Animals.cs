using System;


namespace OOPLAB2
{
    /// <summary>
    /// Class to handle animal-atributes that are later derived.
    /// </summary>
    class Animals
    {
        protected int Age = 0;
        protected string Color = "NoDataProvided";
        protected string Gender = "NoDataProvided";
        protected bool IsHungry = false;
        protected string Name = "NoDataProvided";

        public Animals(int _age, string _color, string _gender, bool _isHungry, string _name)
        {
            Age = _age;
            Color = _color;
            Gender = _gender;
            IsHungry = _isHungry;
            Name = _name;
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
        /// <summary>
        /// Method to print the specified animal and all their atributes.
        /// </summary>
        public void PrintAnimal()
        {
            Console.WriteLine($"Name : {Name} \nAge : {Age} \nGender : {Gender} \nColor : {Color}");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("");
        }
    }
}
