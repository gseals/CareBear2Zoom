using System;
using System.Collections;
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
            // IEnumerable are the lowest common denominator for all of our connections
            // as long as it is an ienumerable, you can use linq on it
            var careBearNames = careBears.Select(bear => bear.Name);

            // be aware of the order in which you do things because it effects your outcome
            // this order takes the original list and filters it down to a smaller subset before filtering the smaller group down more
            var careBearNamesThatStartWithT = careBears.Where(bear =>bear.Name.StartsWith('T')).Select(bear => bear.Name);

            // lambda expressions (delegates): the fat arrow occuring inside of parentheses on linq methods; it is a function reference
            // the is operator allows us to name something specifically and it returns a boolean expression representing the result
            // Any returns true if any one of the thing in the list matches
            // Any: one thing must match; as soon as it finds the first of the thing, it stops looking through the list
            var anyTinderHearts = careBears.Any(bear => bear is TinderHeart);

            // All returns true if every bear in our list if a TinderHeart
            // All: looks until it finds something that doesn't match and then exits out - short circuiting
            var allTinderHearts = careBears.All(bear => bear is TinderHeart);

            // when you put in your dot operator, anything with a disc and a down arrow are the linq things
            // aggragate is the same concept as JS reduce

            // first says find me the first thing in the list and return it
            var firstBear = careBears.First();

            // entering a parameter gives the method something look for;
            // if you ask for something that doesn't exist, it blows up - throws an exception
            var firstBearStartingWithT = careBears.First(bear => bear.Name.StartsWith("Te"));

            // if you create a list with nothing in it
            var otherList = new List<CareBearBase>();
            // if you ask for the first thing in a list that doesn't have anything in it, it blows up - throw an exception
            var blowsUp = otherList.First();

            // FirstOrDefault says find the first thing that matches, or give me the default of carebearbase
            // a reference type, like a class, default to null
            var works = careBears.FirstOrDefault(bear => bear.Name.StartsWith('W'));

            // skip one item and then take 2 items; throws an exception if used on a list of not three things
            var skippedGrumpy= careBears.Skip(1).Take(2);



        }
    }
}
