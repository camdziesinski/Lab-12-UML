using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_UML
{
    abstract class GameCharacter
    {
        protected string name;
        protected int strenght, intelligence;

        public abstract string Name
        {
            get;
            set;
        }
        public abstract int Strength
        {
            get;
            set;
        }
        public abstract int Intelligence
        {
            get;
            set;
        }
        public virtual void Play()
        {
            Console.WriteLine($"Name: {Name}\nStrenght: {Strength}\nIntelligence {Intelligence}");
        }

    }
}
