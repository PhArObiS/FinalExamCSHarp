using System;

namespace NeilLopes_FinalExamOOP
{
    public class SecondScene : Scene
    {
        public override void Describe()
        {
            Console.WriteLine("\nVous êtes dans un couloir. La porte se referme derrière vous.");
        }

        public override ConsoleKey PresentChoices()
        {
            Console.WriteLine("\nAppuyez sur 'C' pour courir dans le couloir.\nAppuyez sur 'R' pour retourner dans la salle.");
            return Console.ReadKey().Key;
        }

        public override Scene HandleChoices(ConsoleKey key, Hero hero)
        {
            switch (key)
            {
                case ConsoleKey.C:
                    hero.ReduceVitality(15);
                    Console.WriteLine("\nVous explorez le couloir et trouvez une porte cachée!");
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
