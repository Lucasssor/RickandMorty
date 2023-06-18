using RickandMorty;
using System;
using static System.Console;

namespace KeyboardMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = " Rick and Morty - The Game";
            CursorVisible = false;
            try
            {
                WindowWidth = 148;
                WindowHeight = 30;
            }
            catch 
            {
                WriteLine("Please adjust console menu manualy");
            }



            Game myGame = new Game();
            myGame.Start();
        }

    }
}