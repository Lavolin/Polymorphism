using System;
using System.Collections.Generic;
using System.Text;

namespace E03Raiding
{
    public class Paladin : BaseHero
    {
       
        public Paladin(string name) : base(name)
        {
        }

        public override int Power => 100;

        public override string CastAbility()
          => $"{base.CastAbility()} healed for {Power}";
        
    }
}
