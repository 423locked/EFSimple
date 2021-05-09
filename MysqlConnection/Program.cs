using System;
using System.Collections.Generic;

namespace EFSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContext db = new AppContext();

            List<Cat> cats = new List<Cat>()
            {
                new Cat("Barsik", "Persian"),
                new Cat("Timmy", "Scottish"),
                new Cat("Marcus", "British")
            };

            foreach (Cat cat in cats)
                db.Cats.Add(cat);

            db.SaveChanges();

            foreach (Cat cat in db.Cats)
                Console.WriteLine($"{cat.CatID} {cat.Name} {cat.Breed}");
        }
    }
}
