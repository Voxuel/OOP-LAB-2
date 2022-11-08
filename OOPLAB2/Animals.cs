using System;


namespace OOPLAB2
{
    /// <summary>
    /// Class to handle animal-atributes that are later derived.
    /// </summary>
    class Animals
    {
        private readonly int Age = 0;
        private readonly string Color;
        private readonly string Gender;
        private readonly bool IsHungry;
        protected readonly string Name;       
   
        public Animals(int _age = 0,string _color = "null", string _gender = "null", bool _isHungry = false, string _name = "null" )
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
