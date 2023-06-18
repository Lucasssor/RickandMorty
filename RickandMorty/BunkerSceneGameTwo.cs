using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;


namespace RickandMorty
{
    internal class BunkerSceneGameTwo : Scene
    {
        public BunkerSceneGameTwo(Game game) : base(game)
        {

        }

        public override void Run()
        {
            if (!MyGame.MyRick.HasLighter)
            {
                Clear();
                WriteLine("You can't see anything.\nRick Sanchez: Where is my Interdimensional Igniter??????\nRick Sanchez: Morty must have stolen it from me again. I have to find it and come back here.");
                ConsoleShortcuts.WaitForKeyPress();
                MyGame.MyHomeNavigationScene.Run();
            }
            else
            {
                Clear();
                string prompt = @"
YOUR LAST CHANCE
Game 2:
Do you pick tails or heads?";

                string[] options = { "Tails", "Heads"};
                Menu mainMenu = new Menu(prompt, options);
                int selectedIndex = mainMenu.Run();

                
                int test2 = ConsoleShortcuts.RandomNumber();
                string answer2 = "";
                if (test2 == 0)
                {
                    answer2 = "HEADS";

                }
                else if (test2 == 1)
                {
                    answer2 = "TAILS";
                }

                switch (selectedIndex)
                {
                    case 0:

                        if (test2 == 0)
                        {
                            WriteLine($"\n\nThe correct answer is: {answer2}.");

                            WriteLine("\n\nYOU LOST\n\n");
                            MyGame.MyDeathScene.Run();  
                        }

                        else if (test2 == 1)
                        {
                            WriteLine($"\n\nThe correct answer is: {answer2}.");

                            WriteLine("\n\nYOU WON\n\n");

                            WriteLine("(Press any key to get your keys and lock Zogar the Interstellar Invader in his cage.)");
                            ReadKey(true);
                            GettingKey();
                        }
                        break;

                    case 1:

                        if (test2 == 1)
                        {
                            WriteLine($"\n\nThe correct answer is: {answer2}.");
                            WriteLine("\n\nYOU LOST\n\n");

                            MyGame.MyDeathScene.Run();
                        }

                        else if (test2 == 0)
                        {
                            WriteLine($"\n\nThe correct answer is: {answer2}.");
                            WriteLine("\n\nYOU WON\n\n");

                            WriteLine("(Press any key to get your keys and lock Zogar the Interstellar Invader in his cage.)");
                            ReadKey(true);
                            GettingKey();
                        }

                        break;
                }
                ConsoleShortcuts.WaitForKeyPress();
            }

        }
        private void GettingKey()
        {
            if (!MyGame.MyRick.HasKey)
            {
                WriteLine("You won.");
                WriteLine("\nRick Sanchez: Thanks for the keys you loser");
                MyGame.MyRick.HasKey = true;
                ConsoleShortcuts.WaitForKeyPress();
                MyGame.MyHomeNavigationScene.Run();

            }

            else
            {
                WriteLine("The key is already in your possesion");
                ConsoleShortcuts.WaitForKeyPress();
                MyGame.MyHomeNavigationScene.Run();
            }

        }

    }
}