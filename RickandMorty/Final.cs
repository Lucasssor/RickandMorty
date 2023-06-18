using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace RickandMorty
{
    internal class Final : Scene
    {
        public Final(Game game) : base(game)
        {
        }

        public override void Run()
        {
            if (MyGame.MyRick.HasRiddleMedal == false)
            {
                Clear();
                WriteLine("You need all three medals to get to the final.");
                ConsoleShortcuts.WaitForKeyPress();
                MyGame.MyStartOfAdventureScene.Run();

            }
            else
            {
                
                string prompt = @$"final";

                string[] options = { "option1", "option2"};
                Menu mainMenu = new Menu(prompt, options);
                int selectedIndex = mainMenu.Run();



                switch (selectedIndex)
                {
                    case 0:

                        WriteLine("opcja1");
                        break;
                    case 1:

                        WriteLine("opcja2");
                        break;
                 

                }
            }
        }
    }
}
