using System;
using NeilLopes_FinalExamOOP;

namespace NeilLopes_FinalExamOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero(25);
            Scene currentScene = new FirstScene();

            while (currentScene != null && hero.IsAlive())
            {
                currentScene.Describe();
                ConsoleKey keyPressed = currentScene.PresentChoices();
                currentScene = currentScene.HandleChoices(keyPressed, hero);
            }

            if (hero.IsAlive())
            {
                Console.WriteLine("\nJeu terminé. Merci d'avoir joué à mon jeu !");
            }
            else
            {
                Console.WriteLine("\nJeu terminé. Votre héros a manqué de vitalité et est mort.");
            }
        }
    }
}
