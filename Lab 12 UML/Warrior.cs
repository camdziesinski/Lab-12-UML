using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_UML
{
    class Warrior : GameCharacter
    {
        private string weaponType;
        public string WeaponType
        {
            get { return weaponType; }
            set { weaponType = value; }
        }

        public override string Name { get => name; set => name = value; }
        public override int Strength { get => strenght; set => strenght = value; }
        public override int Intelligence { get => intelligence; set => intelligence = value; }

        public Warrior(string _name, int _strength, int _intelligence, string _weaponType)
        {
            name = _name;
            strenght = _strength;
            intelligence = _intelligence;
            weaponType = _weaponType;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon Type: {WeaponType}");
        }
    }
}
