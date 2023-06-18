using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace RickandMorty
{
    internal class DeathScene : Scene
    {
        public DeathScene(Game game) : base(game) 
        {
        }

        public override void Run()
        {
            string prompt = @"
▄██   ▄    ▄██████▄  ███    █▄       ████████▄   ▄█     ▄████████ ████████▄  
███   ██▄ ███    ███ ███    ███      ███   ▀███ ███    ███    ███ ███   ▀███ 
███▄▄▄███ ███    ███ ███    ███      ███    ███ ███    ███    █▀  ███    ███ 
▀▀▀▀▀▀███ ███    ███ ███    ███      ███    ███ ███   ▄███▄▄▄     ███    ███ 
▄██   ███ ███    ███ ███    ███      ███    ███ ███  ▀▀███▀▀▀     ███    ███ 
███   ███ ███    ███ ███    ███      ███    ███ ███    ███    █▄  ███    ███ 
███   ███ ███    ███ ███    ███      ███   ▄███ ███    ███    ███ ███   ▄███ 
 ▀█████▀   ▀██████▀  ████████▀       ████████▀  █▀     ██████████ ████████▀                                                                              


Would you like to play again?";
            string[] options = { "YES", "NO" };
            Menu mainMenu = new Menu(prompt, options); 
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.MyRick.HasKey = false;
                    MyGame.MyRick.HasMorty = false;
                    MyGame.MyRick.HasBooze = false;
                    MyGame.MyRick.HasLighter = false;
                    MyGame.MyRick.HasRiddleMedal = false;
                    MyGame.MyTitleScene.Run();
                    return;

                case 1:
                    ConsoleShortcuts.ExitConsole();
                    break;

            }
        }
    }

}
