using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace RickandMorty
{
    internal class TitleScene : Scene
    {
        string TitleArt =  @" 
   ▄████████  ▄█   ▄████████    ▄█   ▄█▄         ▄████████ ███▄▄▄▄   ████████▄         ▄▄▄▄███▄▄▄▄    ▄██████▄     ▄████████     ███     ▄██   ▄   
  ███    ███ ███  ███    ███   ███ ▄███▀        ███    ███ ███▀▀▀██▄ ███   ▀███      ▄██▀▀▀███▀▀▀██▄ ███    ███   ███    ███ ▀█████████▄ ███   ██▄ 
  ███    ███ ███  ███    █▀    ███ ██▀          ███    ███ ███   ███ ███    ███      ███   ███   ███ ███    ███   ███    ███    ▀███▀▀██ ███▄▄▄███ 
 ▄███▄▄▄▄██▀ ███  ███         ▄█████▀           ███    ███ ███   ███ ███    ███      ███   ███   ███ ███    ███  ▄███▄▄▄▄██▀     ███   ▀ ▀▀▀▀▀▀███ 
▀▀███▀▀▀▀▀   ███  ███        ▀▀█████▄         ▀███████████ ███   ███ ███    ███      ███   ███   ███ ███    ███ ▀▀███▀▀▀▀▀       ███     ▄██   ███ 
▀███████████ ███  ███    █▄    ███ ██▄          ███    ███ ███   ███ ███    ███      ███   ███   ███ ███    ███ ▀███████████     ███     ███   ███ 
  ███    ███ ███  ███    ███   ███ ▀███▄        ███    ███ ███   ███ ███   ▄███      ███   ███   ███ ███    ███   ███    ███     ███     ███   ███ 
  ███    ███ █▀   ████████▀    ███   ▀█▀        ███    █▀   ▀█   █▀  ████████▀        ▀█   ███   █▀   ▀██████▀    ███    ███    ▄████▀    ▀█████▀  
  ███    ███                   ▀                                                                                  ███    ███                       
";
        public TitleScene(Game game) : base(game)
        {
        
        }

        public override void Run()
        {

            string prompt = $@"{TitleArt}
Welcome to Rick and Morty - The Game
Use arrows and enter to navigate :)";

            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.MyHomeNavigationScene.Run();
                    ConsoleShortcuts.WaitForKeyPress();
                    break;

                case 1:
                    DisplayAboutInfo();
                    break;

                case 2:
                    ConsoleShortcuts.ExitConsole();
                    break;
            }
        }


        private void ExitGame()
        {
            WriteLine("A kliknij jeszcze raz");
            ReadKey();
            Environment.Exit(0);
        }
        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("Game by: Łukasz Kiecka");
            WriteLine("Press any key to return to the main menu");
            ReadKey();
            Run();

        }

    }
}
