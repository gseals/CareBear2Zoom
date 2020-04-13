using System;
using System.Collections.Generic;
using System.Text;

namespace CareBear2Zoom.Bears
{
    class GrumpyBear : CareBearBase
    {
        // there are some thing I know about grumpy bear that when a grumpy bear is created should change about the care bear
        // constructor is good for default values and states; the place to start from
        public GrumpyBear()
        {
            BellyBadge = "Rain Cloud";
            Color = BearColor.Blue;
            Name = "Grumpy Bear";
        }

        // override keyword is like the sibling of abstract/virtual keyword
        // when I want to implement abstract stuff, I use the keyword override
        // when I want to override virtual stuff, I use override, also
        public override void Stare()
        {
            Console.WriteLine("Stares aggressively into the distance while shooting a beam from his belly.");
        }

        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"Grumpy Bear hates hugs and instead shuns {careBearToHug.Name}.");
        }

    }
}
