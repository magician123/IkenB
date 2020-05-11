using System;
using System.Collections.Generic;
using System.Text;

namespace ClassConcepts
{
    public class Monster
    {
        private string name;
        private int lifePoints;

        public Monster(string name, int lifePoints)
        {
            this.name = name;
            this.lifePoints = lifePoints;
        }

        public virtual string Speak()
        {
            return $"My name is {name} and I have {lifePoints} lifepoints";
        }
    }
}
