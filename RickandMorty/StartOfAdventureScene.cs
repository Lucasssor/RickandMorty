using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace RickandMorty
{
    internal class StartOfAdventureScene: Scene
    {
        public StartOfAdventureScene(Game game) : base(game)
        {

        }

        public override void Run()
        {
            if (!MyGame.MyRick.HasKey)
            {
                Clear();
                WriteLine("You still don't have your car keys. Go find them.");
                ConsoleShortcuts.WaitForKeyPress();
                MyGame.MyHomeNavigationScene.Run();

            }
            else
            {
                Clear();
                string prompt = @"Its beggining of your adventure
Where you wanty to go first?
After getting all 3 quest medals from riddleplanet, cave of dreams and placeholder you can get to final";

                string[] options = { "Let's go to RiddlePlanet", "b", "c", "final" };
                Menu mainMenu = new Menu(prompt, options);
                int selectedIndex = mainMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        WriteLine("(Flying to RiddlePlanet)");
                        MyGame.MyPuzzlePlanet.Run();
                        break;

                    case 1:
                        WriteLine("b");
                        break;

                    case 2:
                        WriteLine("c");
                        break;
                    case 3:
                                                
                        MyGame.MyFinal.Run();

                        break;

                }
            }
        }
    }
}
