using System;


namespace OOPLAB2
{
    class Snake : Animals,IReptile
    {
        private readonly bool IsPoisonous = true;
        private readonly string Sound = "Hichhz";
        public Snake(int _age, string _color, string _gender, bool _isHungry, string _name, bool _isPoisonous)
        : base(_age, _color, _gender, _isHungry, _name)
        {
            this.IsPoisonous = _isPoisonous;
        }
        public Snake() : base()
        {

        }
        void IReptile.LayEgg()
        {
            Console.WriteLine("The reptile lays an egg!");
        }

        public void SetFree()
        {
            if (!IsPoisonous)
            {
                Console.WriteLine($"{Name} is set free to play outside the cage.");
            }
            else
            {
                Console.WriteLine("Ohh I wouldn't do that!");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine(Sound);
        }
    }
}
