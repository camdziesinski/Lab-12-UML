using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_UML
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public int SpellNumber
        {
            get { return spellNumber; }
            set { spellNumber = value; }
        }

        public override int MagicalEnergy { get => magicalEnergy; set => magicalEnergy = value; }
        public override string Name { get => name; set => name = value; }
        public override int Strength { get => strenght; set => strenght = value; }
        public override int Intelligence { get => intelligence; set => intelligence = value; }

        public Wizard(string _name, int _strength, int _intelligence, int _magicalEnergy, int _spellNumber)
        {
            name = _name;
            strenght = _strength;
            intelligence = _intelligence;
            magicalEnergy = _magicalEnergy;
            spellNumber = _spellNumber;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Spell Count: {SpellNumber}");
        }
    }
}
