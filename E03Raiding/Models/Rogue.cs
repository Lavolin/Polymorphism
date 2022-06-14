using System;
using System.Collections.Generic;
using System.Text;

namespace E03Raiding
{
    public class Rogue : BaseHero
    {
        
        public Rogue(string name) : base(name)
        {
        }

        public override int Power => 80;
        

        public override string CastAbility()
        => $"{base.CastAbility()} hit for {Power} damage";
    }
}
