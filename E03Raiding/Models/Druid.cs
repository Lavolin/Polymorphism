using System;
using System.Collections.Generic;
using System.Text;

namespace E03Raiding
{
    public class Druid : BaseHero
    {
       
        public Druid(string name)
            : base(name)
        {

        }

        public override int Power => 80;

        public override string CastAbility()
         => $"{base.CastAbility()} healed for {Power}";

    }
}
