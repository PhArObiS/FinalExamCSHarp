using System;

namespace NeilLopes_FinalExamOOP
{
    public class ThirdScene : Scene
    { 
        public override void Describe()
        {
            Console.WriteLine("\nVous voyez des chiens dans le jardin.");
        }

        public override ConsoleKey PresentChoices()
        {
            Console.WriteLine("\nAppuyez sur 'C' pour caresser les chiens dans le jardin.\nAppuyez sur 'R' pour revenir par la fenêtre et revenir dans la pièce.");
            return Console.ReadKey().Key;
        }

        public override Scene HandleChoices(ConsoleKey key, Hero hero)
        {
            switch (key)
            {
                case ConsoleKey.C:
                    hero.ReduceVitality(5);
                    Console.WriteLine("\nVous caressez les chiens dans le jardin pendant une heure.");
                    return null;

                case ConsoleKey.R:
                    hero.ReduceVitality(5);
                    return new FirstScene();

                default:
                    Console.WriteLine("\nChoix invalide. Veuillez réessayer.");
                    return this;
            }
        }
    }
}
