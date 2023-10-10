using NeilLopes_FinalExamOOP;
using System;
using System;

namespace NeilLopes_FinalExamOOP
{
    public class FirstScene : Scene
    {
        public override void Describe()
        {
            Console.WriteLine("\nVous êtes dans une petite pièce. Il y a une porte et une fenêtre.");
        }

        public override ConsoleKey PresentChoices()
        {
            Console.WriteLine("\nAppuyez sur 'P' pour ouvrir la porte.\nAppuyez sur 'S' pour sauter par la fenêtre.");
            return Console.ReadKey().Key;
        }

        public override Scene HandleChoices(ConsoleKey key, Hero hero)
        {
            switch (key)
            {
                case ConsoleKey.P:
                    hero.ReduceVitality(10);
                    return new SecondScene();

                case ConsoleKey.S:
                    hero.ReduceVitality(5);
                    return new ThirdScene();

                default:
                    Console.WriteLine("\nChoix invalide. Veuillez réessayer.");
                    return this;
            }
        }
    }
}
