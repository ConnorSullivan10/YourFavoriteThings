using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Guitar
    {
        public int NumberOfFrets { get; set; }
        public string Brand { get; set; }
        public string ModelName { get; set; }
        public bool IsSolidBody { get; set; }

        public Guitar(string brand, string model)
            {
            Brand = brand;
            ModelName = model;
            }

        public void Shred()
        {
            Console.WriteLine($"Watch me play some sick licks up all {NumberOfFrets} of these frets.");
        }
        

        public void CheckOutMyAxe()
        {
            Console.WriteLine($"Bruh, did you see my new {Brand} {ModelName}? It rips!");
        }
    }
}
