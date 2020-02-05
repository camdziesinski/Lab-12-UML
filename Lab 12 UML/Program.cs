using System;

namespace Lab_12_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard gandalf = new Wizard("Gandalf", 10, 12, 14, 2);
            Wizard harry = new Wizard("Harry Potter", 5, 10, 1, 80);
            Warrior link = new Warrior("Link", 100, 10, "sword");
            Warrior kratos = new Warrior("Kratos", 500, 0, "axe");
            Warrior sora = new Warrior("Sora", 50, 50, "key blade");

            GameCharacter[] gameCharacters = {gandalf, link, harry, kratos, sora};

            foreach(var character in gameCharacters)
            {
                character.Play();
                Console.WriteLine("==========================");
            }
        }
    }
}
