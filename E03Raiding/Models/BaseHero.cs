using System;
using System.Collections.Generic;
using System.Text;

namespace E03Raiding
{
    public abstract class BaseHero
    {
        protected BaseHero(string name)
        {
            Name = name;
        }

        public string Name { get;}

        public abstract int Power { get;}

        public virtual string CastAbility()
         => $"{this.GetType().Name} - {Name}";
    }
}
