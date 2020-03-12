using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var tele = new Guitar("Suhr", "Classic T")
            {
                NumberOfFrets = 22,
                IsSolidBody = true
            };
            var acoustic = new Guitar("Yamaha", "Acoustic")
            {
                NumberOfFrets = 22,
                IsSolidBody = false
            };
            var attaboy = new Bar("Spicy Margarita", "Attaboy")
            {
                MilesFromHome = 22,
                IsSpeakeasy = true
            };
            var pattersonHouse = new Bar("Old Fashioned", "Patterson House")
            {
                MilesFromHome = 20,
                IsSpeakeasy = true
            };
            var smokey = new Pet("Smokey", "Cat", 10);
            var razz = new Pet("Razz", "Dog", 20);
            var nashville = new City("Nashville");
            var jacksonville = new City("Jacksonville");

            tele.Shred();
            tele.CheckOutMyAxe();
            acoustic.Shred();
            acoustic.CheckOutMyAxe();
            nashville.ComeVisit();
            nashville.Directions("36.1627° N, 86.7816° W");
            jacksonville.ComeVisit();
            jacksonville.Directions("30.3322° N, 81.6557° W");
            smokey.Yell("MEOW");
            smokey.PeaceOut();
            razz.Yell("ARFFFFF");
            razz.PeaceOut();
            attaboy.ServeDranks();
            attaboy.CallACab();
            pattersonHouse.ServeDranks();
            pattersonHouse.CallACab();

        }
    }
}
