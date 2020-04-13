using System;
using System.Collections.Generic;
using System.Text;

namespace CareBear2Zoom.Bears
{
    class TinderHeart : CareBearBase
    {
        public TinderHeart()
        {
            Name = "Tinder Heart";
            BellyBadge = "Cell Phone";
            Color = BearColor.Gold;
        }

        public override void Stare()
        {
            Console.WriteLine("Swipe Left");
        }

        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"Swipes right on {careBearToHug.Name}");
        }
    }
}
