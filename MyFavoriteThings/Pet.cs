using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Pet : FavoriteThing
    {
        public bool IsApexPet => true;
        public string TypeOfAnimal { get; set; }
        public int Age { get; set; }
        public string BattleCry { get; set; }

        public Pet(string name, string typeOfAnimal, int age)
        {
            Name = name;
            TypeOfAnimal = typeOfAnimal;
            Age = age;
        }

        public void Yell (string battleCry)
        {
            BattleCry = battleCry;
            Console.WriteLine($"{Name} yells out {BattleCry} as they venture into the pit of despair");
        }

        public void PeaceOut()
        {
            if (Age >= 20)
            {
                Console.WriteLine($"It was a great {Age} years. I found my peace, so peace. RIP {Name}.");
            }
            else
            {
                Console.WriteLine($"Woah woah woah...I'm not going anywhere");
            }
        }
    }
}
