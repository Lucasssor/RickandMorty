using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;


namespace RickandMorty
{
    internal class BunkerScene : Scene
    {
        public BunkerScene(Game game) : base(game)
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
            else if (MyGame.MyRick.HasKey == true)
            {
                Clear();
                WriteLine("You have your key. There is nothing interesting there.");
                ConsoleShortcuts.WaitForKeyPress();
                MyGame.MyHomeNavigationScene.Run();
            }
            else
            {
                Clear();
                string prompt = @"You entered bunker thanks to Interdimensional Igniter.
You can see Zogar the Interstellar Invader - your alien prisoner who escaped from his cage.
He has your car keys and offers a deal.
Coinflip game.
If Rick wins he gets his keys and Zogar the Interstellar Invader will obediently come back to his cage.
If Zogar the Interstellar Invader winns - Rick Dies.
He is kind and offers you 2 tries.
You don't have many options so you accept the deal.
Game 1:
Do you pick tails or heads?";

                string[] options = { "Tails", "Heads", "Go back to garage"};
                Menu mainMenu = new Menu(prompt, options);
                int selectedIndex = mainMenu.Run();


                int test = ConsoleShortcuts.RandomNumber();

                string answer = "";
                if (test == 0)
                {
                    answer = "HEADS";
                }
                else if (test == 1)
                {
                    answer = "TAILS";
                }
                switch (selectedIndex)
                {
                    case 0:
                        
                        if (test == 0)
                        {
                            WriteLine($"\n\nThe correct answer is: {answer}.");

                            WriteLine("\n\nYOU LOST\n\n");
                            ConsoleShortcuts.WaitForKeyPress();
                            MyGame.MyBunkerSceneGameTwo.Run();
                        }
                            
                        else if (test == 1)
                        {
                            WriteLine($"\n\nThe correct answer is: {answer}.");

                            WriteLine("\n\nYOU WON\n\n");
                            
                            WriteLine("(Press any key to get your keys and lock Zogar the Interstellar Invader in his cage.)");
                            ReadKey(true);
                            GettingKey();
                        }
                            
                        break;

                    case 1:
                      
                        if (test == 1)
                        {
                            WriteLine($"\n\nThe correct answer is: {answer}.");

                            WriteLine("\n\nYOU LOST\n\n");
                            ConsoleShortcuts.WaitForKeyPress();
                            MyGame.MyBunkerSceneGameTwo.Run();
                        }

                        else if (test == 0)
                        {
                            WriteLine($"\n\nThe correct answer is: {answer}.");

                            WriteLine("\n\nYOU WON\n\n");

                            WriteLine("(Press any key to get your keys and lock Zogar the Interstellar Invader in his cage.)");
                            ReadKey(true);
                            GettingKey();
                        }

                        break;

                    case 2:
                        Clear();
                        MyGame.MyHomeNavigationScene.Run();
                        break;
                }
                ConsoleShortcuts.WaitForKeyPress();

            }
            
        }
        private void GettingKey()
        {
            if (!MyGame.MyRick.HasKey)
            {
                
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
