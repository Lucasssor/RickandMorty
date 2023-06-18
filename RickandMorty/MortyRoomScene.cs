using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace RickandMorty
{
    internal class MortyRoomScene : Scene
    {
        public MortyRoomScene(Game game) : base(game)
        {

        }

        public override void Run()
        {
            string prompt = "You entered Morty's room. \nYou see Morty lying on his bed and his drawer on gis left.\nWhat you want to do here?\n";

            string[] options = { "Invite Morty to the epic adventure (he may or not be helpful)", "Open drawer", "Go somewhere else" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    InviteMorty();
                    break;

                case 1:
                    InteractWithDrawer();
                    break;

                case 2:
                    MyGame.MyHomeNavigationScene.Run();
                    break;
            }
        }


        private void InviteMorty()
        {
            if (!MyGame.MyRick.HasMorty)
            {
                WriteLine("\nRick Sanchez: Hey Morty, stop sleeping and come with me.");
                WriteLine("Morty Smith: Yeeey Rickkk I am right behind you from now on.");

                MyGame.MyRick.HasMorty = true;

            }
            else
            {
                WriteLine("\nMorty is already following you.");
            }
            ConsoleShortcuts.WaitForKeyPress();
            Run();

        }

        private void InteractWithDrawer()
        {
            if (!MyGame.MyRick.HasLighter)
            {
                WriteLine(" \nOh my God. Morty again stole my Interdimensional Igniter. I will take it with me.");
                MyGame.MyRick.HasLighter = true;
            }
            else
            {
                WriteLine("\nThis drawer is empty.");
            }
            ConsoleShortcuts.WaitForKeyPress();
            Run();

        }

    }
}
