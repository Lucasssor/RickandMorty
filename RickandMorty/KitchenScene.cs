using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace RickandMorty
{
    internal class KitchenScene : Scene
    {
        public KitchenScene(Game game) : base(game)
        {
        }
        public override void Run()
        {
            string prompt = @"You entered kitchen. 
You can't see your car keys but on the countertop there are even more important items.
Alcohol.
Since you are already here you can bring some booze with you.
(choose wisely you have only one spot in your pants)
";
            string[] options = { "Pick up Beer", "Pick up Wine", "Pick up Vodka", "Go somewhere else" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    PickUpBeer();
                    break;

                case 1:
                    PickUpWine();
                    break;

                case 2:
                    PickUpVodka();
                    break;
                case 3:
                    MyGame.MyHomeNavigationScene.Run();
                    break;
            }
        }
        private void PickUpBeer()
        {
            if (!MyGame.MyRick.HasBooze)
            {
                WriteLine("\nOh yee my dear beer. You are coming with me.");
                MyGame.MyRick.PickUpBooze("Beer");
            }
            else
            {
                WriteLine("\nUnfortunately Rick's pockets are full. You can't take this beer.");
            }
            ConsoleShortcuts.WaitForKeyPress();
            Run();
        }
        private void PickUpWine()
        {
            if (!MyGame.MyRick.HasBooze)
            {
                WriteLine("\nHey player - why would you pick wine?? But ok, Rick takes it anyway.");
                MyGame.MyRick.PickUpBooze("Wine");
            }
            else
            {
                WriteLine("\nUnfortunately Rick's pockets are full. You can't take this wine.");
            }
            ConsoleShortcuts.WaitForKeyPress();
            Run();
        }

        private void PickUpVodka()
        {
            if (!MyGame.MyRick.HasBooze)
            {
                WriteLine("\nHey player - why would you pick vodka?? But ok, Rick takes it anyway.");
                MyGame.MyRick.PickUpBooze("Vodka");
            }
            else
            {
                WriteLine("\nUnfortunately Rick's pockets are full. You can't take this vodka.");
            }
            ConsoleShortcuts.WaitForKeyPress();
            Run();
        }



    }
}
