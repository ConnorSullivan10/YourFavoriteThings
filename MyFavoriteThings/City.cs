using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class City : FavoriteThing
    {
        public string Coordinates { get; set; }
        public bool IsCool => true;

        public City(string name)
        {
            Name = name;
        }

        public void ComeVisit()
        {
            if (IsCool)
            Console.WriteLine($"Come on down to {Name}. It's awesome here!");
        }

        public void Directions(string coordinates)
        {
            Coordinates = coordinates;
            Console.WriteLine($"The trip to {Name} is easy. Just go to {Coordinates}");
        }

    }
}
