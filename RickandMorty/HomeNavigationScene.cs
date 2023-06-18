using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace RickandMorty
{
    internal class HomeNavigationScene : Scene
    {
        public HomeNavigationScene(Game game): base(game)
        {
        }

        public override void Run()
        {
            string prompt = "You (Rick Sanchez) are in dire need to go to epic adventure (like everyday). \nYou have searched all garage for your flying car keys with no luck. You problably left them somewhere in the house. \nWhere would you like to go?\n";

            string[] options = { "Go to kitchen", "Go to Morty's room", "Go to bunker", "Get started with your adventure" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Clear();
                    MyGame.MyKitchenScene.Run();
                    break;

                case 1:
                    Clear();
                    MyGame.MyMortyRoomScene.Run();
                    break;

                case 2:
                    Clear();
                    MyGame.MyBunkerScene.Run();
                    break;
                case 3: 
                    Clear();
                    MyGame.MyStartOfAdventureScene.Run();
                    break;
                    


            }
        }
    }
}
