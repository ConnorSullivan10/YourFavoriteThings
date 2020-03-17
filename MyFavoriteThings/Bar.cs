using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Bar : FavoriteThing
    {
        public int MilesFromHome { get; set; }
        public string FavoriteDrink { get; set; }
        public bool IsSpeakeasy { get; set; }

        public Bar(string theUsual, string name)
        {
            Name = name;
            FavoriteDrink = theUsual;
        }

        public void ServeDranks()
        {
            Console.WriteLine($"Here at {Name} you can have as many {FavoriteDrink}s as you'd like");
        }

        public void CallACab()
        {
            Console.WriteLine($"Of course we'll get you a ride home, even if it's {MilesFromHome} miles away");
        }
    }
}
