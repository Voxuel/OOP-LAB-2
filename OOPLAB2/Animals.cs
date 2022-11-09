using System;


namespace OOPLAB2
{
    /// <summary>
    /// Class to handle animal-attributes that are later derived.
    /// </summary>
    class Animals
    {
        private int Age = 0;
        private string Color = "NoDataProvided";
        private string Gender = "NoDataProvided";
        private bool IsHungry = false;
        protected string Name = "NoDataProvided";

        protected Animals(int _age, string _color, string _gender, bool _isHungry, string _name)
        {
            Age = _age;
            Color = _color;
            Gender = _gender;
            IsHungry = _isHungry;
            Name = _name;
        }
        public Animals()
        {

        }
        public void Pet()
        {
            Console.WriteLine($"You pet {Name}");
        }
        public void Feed()
        {
            Console.WriteLine(!IsHungry ? $"{Name} is not hungry right now" : $"You feed {Name}");
        }
        /// <summary>
        /// Method to print the specified animal and all their attributes.
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
