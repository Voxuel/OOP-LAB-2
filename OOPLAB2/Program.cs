using System;

namespace OOPLAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat(10,"Grey","Female",false,"Nath",false);
            cat.PrintAnimal();
            var shiba = new Shiba(10, "Black", "Male", true, "Joe", false);
            shiba.MakeTrick();
            shiba.Wash();
        }
    }
}
