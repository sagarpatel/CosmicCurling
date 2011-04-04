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


    public class Level1: GamePlayerScreenAbstract
    {


        Texture2D tex;

        public Level1(Game game, SpriteBatch sB):base(game,sB)
        {
            
        }


        protected override void LoadContent()
        {
            tex = Game.Content.Load<Texture2D>("Sprites/Curling_ Ball_Green_64");

            //   base.LoadContent();

            isLoaded = true;
        }


        public override void Draw(GameTime gameTime)
        {

        //    spriteBatch.Draw(tex, new Vector2(400, 400), Color.White);

        }




    }




}
