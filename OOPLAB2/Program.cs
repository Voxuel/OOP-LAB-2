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
            IMammal Icat = new Cat(1,"","",false,"",false);
            Icat.Move();
            cat.MakeSound();

            Console.WriteLine("-----------NEW ANIMAL-------------");

            var shiba = new Shiba(10, "Black", "Male", true, "Joe", false);
            shiba.MakeTrick();
            shiba.Wash();
            shiba.MakeSound();

            Console.WriteLine("-----------NEW ANIMAL-------------");

            var husky = new Husky(15, "White", "Male", false, "Darin", false, true);
            husky.PrintAnimal();
            husky.CheckSleep();

            Console.WriteLine("-----------NEW ANIMAL-------------");

            var snake = new Snake(3, "Golden", "Male", true, "Vizer", true);
            snake.SetFree();
            snake.PrintAnimal();
            snake.Pet();
            IReptile Isnake = new Snake(13,"Orange","Male",true,"Jackie",true);
            Isnake.LayEgg();

            Console.WriteLine("-----------NEW ANIMAL-------------");

            var empty = new Animals(1, "", "", false, "");
            empty.PrintAnimal();
           
        }
    }
}
