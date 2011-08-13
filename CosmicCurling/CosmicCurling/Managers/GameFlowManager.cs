using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;



namespace CosmicCurling
{
    public sealed class GameFlowManager : Microsoft.Xna.Framework.GameComponent
    {
        public static Game myGame;
        private static readonly GameFlowManager instance = new GameFlowManager(myGame);


        private GameFlowManager(Game game):base(game)
        {

        }


        public static GameFlowManager sharedGameFlowManager
        {
            get
            {
                return instance;
            }
        }




    }





}
