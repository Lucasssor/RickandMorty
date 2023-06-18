using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RickandMorty
{
    internal class Game
    {
        public Rick MyRick;
        public TitleScene MyTitleScene;
        public DeathScene MyDeathScene;
        public HomeNavigationScene MyHomeNavigationScene;
        public KitchenScene MyKitchenScene;
        public MortyRoomScene MyMortyRoomScene;
        public BunkerScene MyBunkerScene;
        public BunkerSceneGameTwo MyBunkerSceneGameTwo;
        public StartOfAdventureScene MyStartOfAdventureScene;
        public PuzzlePlanet MyPuzzlePlanet;
        public Final MyFinal;



        public Game() 
        {
            MyTitleScene = new TitleScene(this);
            MyDeathScene = new DeathScene(this);
            MyHomeNavigationScene = new HomeNavigationScene(this);
            MyRick = new Rick();
            MyKitchenScene = new KitchenScene(this);
            MyBunkerScene = new BunkerScene(this);
            MyMortyRoomScene = new MortyRoomScene(this);
            MyStartOfAdventureScene = new StartOfAdventureScene(this);
            MyBunkerSceneGameTwo = new BunkerSceneGameTwo(this);
            MyPuzzlePlanet = new PuzzlePlanet(this);
            MyFinal = new Final(this);



        }

        public void Start()
        {
            MyTitleScene.Run();
            //MyBunkerScene.Run();
            //MyPuzzlePlanet.Run();


        }



    }




}
