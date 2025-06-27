using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirage_BOT.app.Utilities.Enums
{
    public static class Skills
    {
        public enum KnightSkills
        {
            Devestate = 4,
            Throwing_Axe = 6,
            Challenging_Throw = 6,
            Execute = 15,
            Whirlwind = 30
        }
        public enum MageSkills
        {
            Elemental_Strike = 4,
            Mind_Games = 15,
            Explosion = 30,
            Conjure_Missle = 60,
            Conjure_Death_Missle = 600
        }
        public enum ShamanSkills
        {
            Healing_Hands = 7,
            Divine_Intervention = 15,
            Mind_Games = 15,
            Conjure_Missle = 60,
            Conjure_Heal = 300
        }
        public enum RangerSkills
        {
            Volley = 6,
            Concussive_Shot = 15,
            Headshot = 15,
            Scatter_Shot = 30,
            Conjure_Arrows = 60,
            Conjure_Chaos_Arrow = 600
        }
    }
}
