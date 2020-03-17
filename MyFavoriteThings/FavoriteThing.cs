using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class FavoriteThing
    {
        public bool isFavoriteThing => true;
        public string Name { get; set; }
    public void DuhItsMyFavorite()
    {
        if (isFavoriteThing)
        Console.WriteLine($"Of course {Name} is my favorite!");
    }
    }

}
