using System;
using System.Collections.Generic;
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
        }
    }
}
