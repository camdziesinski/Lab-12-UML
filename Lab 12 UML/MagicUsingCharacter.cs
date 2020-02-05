using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_UML
{
    abstract class MagicUsingCharacter : GameCharacter
    {
        protected int magicalEnergy;

        public abstract int MagicalEnergy
        {
            get; 
            set;
        }
        
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
        }
    }
}
