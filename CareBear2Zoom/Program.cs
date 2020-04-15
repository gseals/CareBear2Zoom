using System;
using System.Collections.Generic;
using System.Linq;
using CareBear2Zoom.Bears;

namespace CareBear2Zoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var grumpyBear = new GrumpyBear();
            var tenderHeart = new TenderHeart();
            var tinderHeart = new TinderHeart();

            // to access lists, you must have using System.Collections.Generic;
            // we have to be explicit with the kind of things we put into Lists
            // the three items above have an "is a" relationship with the CareBearBase;
            // the curly brackets at the end of the careBears variable is called an object initializer
            var careBears = new List<CareBearBase> {grumpyBear, tenderHeart, tinderHeart};

            foreach (var bear in careBears)
            {
                bear.Care("Nathan");
                bear.Stare();
            }

            // LINQ - Language integrated queries: transforming and filtering collections of things
            // LINQ allows us to use similar JS methods like map, filter, reduce

            // LINQ where() is similar to JS filter()
            // this method does not modify the original list; the variable below will have bears whose names begin with T
            var namesThatStartWithT = careBears.Where(bear => bear.Name.StartsWith('T')).ToList();
            var i = 0;
            foreach (var bear in namesThatStartWithT)
            {
                Console.WriteLine(namesThatStartWithT[i].Name);
                i++;
            }
            Console.ReadLine();

            // transforming the List. similar to map in JS. not removing things, but changing what the collection is made of
            // bear.Name tells Select that we will be returning an IEnumerable of strings
            var careBearNames = careBears.Select(bear => bear.Name);

        }
    }
}
