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

using FarseerPhysics.Common;
using FarseerPhysics.Collision;
using FarseerPhysics.Controllers;
using FarseerPhysics.Dynamics;
using FarseerPhysics.Factories;



namespace CosmicCurling
{


    public abstract class GamePlayScreenAbstract: ScreenAbstract
    {


        protected World myWorld;
       


        public GamePlayScreenAbstract(Game game, SpriteBatch sB, World mW):base(game,sB)
        {

            myWorld = mW;

        }










    }






}
