using System;

namespace NeilLopes_FinalExamOOP
{
    public class Hero
    {
        public int Vitality { get; private set; }

        public Hero(int initialVitality)
        {
            Vitality = initialVitality;
        }

        public void ReduceVitality(int amount)
        {
            Vitality -= amount;
            if (Vitality < 0)
            {
                Vitality = 0;
            }
        }

        public bool IsAlive()
        {
            return Vitality > 0;
        }
    }
}
