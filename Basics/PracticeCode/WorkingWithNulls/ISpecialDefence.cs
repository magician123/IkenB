using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithNulls
{
    interface ISpecialDefence
    {
        int CalculateDamageReduction(int totalDamage);
    }

    class IronBonesDefence : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 10;
        }
    }

    class DiamondSkinDefence : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 1;
        }
    }
}
