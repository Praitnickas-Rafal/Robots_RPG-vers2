using System;
using Robots_RPG.Class;
using System.Collections.Generic;

namespace Robots_RPG
{ 
    public static class PartsStorage
    {
        public static Parts head1 = new Parts("Clever Brain", "Head", 15, 7, 12, "Good");
        public static Parts head2 = new Parts("Observant Eyes", "Head", 12, 8, 13, "Rare");
        public static Parts head3 = new Parts("Steel Skull", "Head", 16, 14, 16, "Epic");
        public static Parts head4 = new Parts("Rapid Thinker", "Head", 0, 0, 42, "Legendary");

        public static Parts legs1 = new Parts("Speedy Sprinters", "Legs", 10, 15, 14, "Good");
        public static Parts legs2 = new Parts("Sturdy Stilts", "Legs", 8, 8, 25, "Rare");
        public static Parts legs3 = new Parts("Jumping Jacks", "Legs", 11, 14, 14, "Epic");
        public static Parts legs4 = new Parts("Steel Stompers", "Legs", 70, 0, 0, "Legendary");

        public static Parts tors1 = new Parts("Iron Shield", "Tors", 15, 6, 7, "Good");
        public static Parts tors2 = new Parts("Swift Armor", "Tors", 26, 15, 12, "Rare");
        public static Parts tors3 = new Parts("Sturdy Vest", "Tors", 14, 23, 6, "Epic");
        public static Parts tors4 = new Parts("Stealthy Cloak", "Tors", 40, 0, 20, "Legendary");

        public static List<Parts> hardcoredParts = new List<Parts>
        {
            head1,
            head2,
            head3,
            head4,
            legs1,
            legs2,
            legs3,
            legs4,
            tors1,
            tors2,
            tors3,
            tors4
        };
    }
}
