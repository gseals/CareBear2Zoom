using System;
using System.Collections.Generic;
using System.Text;

namespace CareBear2Zoom.Bears
{
    // if I wanted to make this class a class that cannot be constructed by itself
    // abstract says whether or not this class is contructable; this class can only be inherited from; cannot be instatiated on its own
    // without public, it is implicitly internal
    abstract class CareBearBase
    {
        // protected means I get access to the setter and also anyone who inherits from me, but no one else
        // protected means this class and the childred of this class, but no one else
        // this time, grumpybear.cs can change this because it inherits directly from here
        public string Name { get; protected set; }
        public BearColor Color { get; protected set; }
        public string BellyBadge { get; protected set; }

        // if we mark Stare as abstract, it means we are not defining what it does, only that it exists.
        // it must be used, but we do not determine how or what happens inside the method
        // abstract methods must be fleshed out to be implemented by an inheriting class
        // abstract: the inheriting class has to define it; actually, the inheriting class MUST use this method
        // you must override abstract
        public abstract void Stare();

        // this public method Care is completely shared behavior.
        // anyone who inherits from CareBearBase will have a method on it called Care that returns nothing, takes in a string, that has this exact behavior.
        // you cannot change it, this is how it works
        // Care method is a method on the base class. I get the behavior for free when I inherit from this class
        // I've already defined it, you can't touch it
        public void Care(string humanToCareFor)
        {
            Console.WriteLine($"{Name} cares deeply for {humanToCareFor}.");
        }

        // virtual means that each individual inheriting care bear can change this
        // virtual: I've defined it, but you are welcome to modify it
        // virtual means you can change it, but you do not have to
        // you can choose not to override virtual
        public virtual void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"{Name} runs over to {careBearToHug.Name} and squeezes them, pressing their {BellyBadge} and {careBearToHug.BellyBadge} together.");
        }
    }


}
