using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;


namespace RickandMorty
{
    static class ConsoleShortcuts
    {
        public static void WaitForKeyPress()
        {
            WriteLine("(Press any key to continue.)");
            ReadKey(true);

        }

        public static void ExitConsole()
        {
            WriteLine("(Press any key to exit.)");
            ReadKey(true);
            Environment.Exit(0);
        }

        public static int RandomNumber()
        {
            Random random = new Random();
            int test = random.Next(0, 2);
            return test;
        }

        public static int RiddleRandomNumber()
        {
            Random random = new Random();
            int testtest = random.Next(0, 10);
            return testtest;
        }



    }
}
