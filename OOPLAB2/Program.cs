using System;

namespace OOPLAB2
{
    // Leo F SUT22
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat(10,"Grey","Female",false,"Nath",false);
            cat.PrintAnimal();
            var shiba = new Shiba(10, "Black", "Male", true, "Joe", false);
            shiba.MakeTrick();
            shiba.Wash();
            shiba.MakeSound();
            var husky = new Husky(15, "White", "Male", false, "Darin", false, true);
            husky.CheckSleep();
            var snake = new Snake(3, "Golden", "Male", true, "Vizer", true);
            snake.SetFree();
            snake.PrintAnimal();
            snake.Pet();
            IReptile snake1 = new Snake(13,"Orange","Male",true,"Jackie",true);
            snake1.LayEgg();
            IMammal cat1 = new Cat();
            cat1.Move();
           
        }
    }
}
