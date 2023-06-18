using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace RickandMorty

{
    
    internal class PuzzlePlanet : Scene
    {
        public PuzzlePlanet(Game game) : base(game)
        {
        }

        public override void Run()
        {
            if (MyGame.MyRick.HasRiddleMedal)
            {
                Clear();
                WriteLine("You already have this medal Go to other planet.");
                ConsoleShortcuts.WaitForKeyPress();
                MyGame.MyHomeNavigationScene.Run();

            }
            else
            {
                int i = ConsoleShortcuts.RiddleRandomNumber();
                int p = Riddle.Answer()[i];
                int index = i + 1;
                string prompt = @$"Welcome to riddle planet you can you will be asked to tell me the correct value of prime number
Twoje zadato to podac liczbe o indeksie {index}";//dodać fabułe

                string[] options = { "23", "5", "17", "3", "29", "11", "7", "2", "19", "13" };
                Menu mainMenu = new Menu(prompt, options);
                int selectedIndex = mainMenu.Run();



                switch (selectedIndex)
                {
                    case 0:
                        if (p == 23)
                        {
                            WriteLine("you won");
                            GetRiddleMedal();

                        }
                        else
                        {
                            WriteLine("wrong answer, try again!");
                            ConsoleShortcuts.WaitForKeyPress();
                            MyGame.MyPuzzlePlanet.Run();
                        }

                        break;

                    case 1:
                        if (p == 5)
                        {
                            WriteLine("you won");
                            GetRiddleMedal();

                        }
                        else
                        {
                            WriteLine("wrong answer, try again!");
                            ConsoleShortcuts.WaitForKeyPress();
                            MyGame.MyPuzzlePlanet.Run();
                        }
                        break;

                    case 2:
                        if (p == 17)
                        {
                            WriteLine("you won");
                            GetRiddleMedal();

                        }
                        else
                        {
                            WriteLine("wrong answer, try again!");
                            ConsoleShortcuts.WaitForKeyPress();
                            MyGame.MyPuzzlePlanet.Run();
                        }
                        break;
                    case 3:
                        if (p == 3)
                        {
                            WriteLine("you won");
                            GetRiddleMedal();

                        }
                        else
                        {
                            WriteLine("wrong answer, try again!");
                            ConsoleShortcuts.WaitForKeyPress();
                            MyGame.MyPuzzlePlanet.Run();
                        }
                        break;
                    case 4:
                        if (p == 29)
                        {
                            WriteLine("you won");
                            GetRiddleMedal();

                        }
                        else
                        {
                            WriteLine("wrong answer, try again!");
                            ConsoleShortcuts.WaitForKeyPress();
                            MyGame.MyPuzzlePlanet.Run();
                        }
                        break;

                    case 5:
                        if (p == 11)
                        {
                            WriteLine("you won");
                            GetRiddleMedal();

                        }
                        else
                        {
                            WriteLine("wrong answer, try again!");
                            ConsoleShortcuts.WaitForKeyPress();
                            MyGame.MyPuzzlePlanet.Run();
                        }
                        break;
                    case 6:
                        if (p == 7)
                        {
                            WriteLine("you won");
                            GetRiddleMedal();

                        }
                        else
                        {
                            WriteLine("wrong answer, try again!");
                            ConsoleShortcuts.WaitForKeyPress();
                            MyGame.MyPuzzlePlanet.Run();
                        }
                        break;
                    case 7:
                        if (p == 2)
                        {
                            WriteLine("you won");
                            GetRiddleMedal();

                        }
                        else
                        {
                            WriteLine("wrong answer, try again!");
                            ConsoleShortcuts.WaitForKeyPress();
                            MyGame.MyPuzzlePlanet.Run();
                        }
                        break;

                    case 8:
                        if (p == 19)
                        {
                            WriteLine("you won");
                            GetRiddleMedal();

                        }
                        else
                        {
                            WriteLine("wrong answer, try again!");
                            ConsoleShortcuts.WaitForKeyPress();
                            MyGame.MyPuzzlePlanet.Run();
                        }
                        break;

                    case 9:
                        if (p == 13)
                        {
                            WriteLine("you won");
                            GetRiddleMedal();

                        }
                        else
                        {
                            WriteLine("wrong answer, try again!");
                            ConsoleShortcuts.WaitForKeyPress();
                            MyGame.MyPuzzlePlanet.Run();
                        }
                        break;
                }
            }
                                   
        }
        private void GetRiddleMedal()
        {
            if (!MyGame.MyRick.HasRiddleMedal)
            {
                WriteLine("\nYou received medal- good job Rick");
                MyGame.MyRick.HasRiddleMedal = true;
                ConsoleShortcuts.WaitForKeyPress();
                MyGame.MyStartOfAdventureScene.Run();
            }
            else
            {
                WriteLine("\nYou received this medal already");
            }
            ConsoleShortcuts.WaitForKeyPress();
            Run();
        }
    }
}
