using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickandMorty
{
    internal class Scene
    {

        protected Game MyGame;
        public Scene(Game game)       
        {
            MyGame = game;        
        }

        virtual public void Run()
        {
        }


    }
}
