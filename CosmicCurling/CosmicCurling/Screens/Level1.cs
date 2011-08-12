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


    public class Level1: GamePlayScreenAbstract
    {


        Texture2D tex;
       
        public RectangleObstacleObject obs1;

        public WallObject TopWall;
        public WallObject RightWall;
        public WallObject BottomWall;
        public WallObject LeftWall;



        public Level1(Game game, SpriteBatch sB,World mW):base(game,sB,mW)
        {

            obs1 = new RectangleObstacleObject(game, sB, mW);

            TopWall = new WallObject(game, sB, mW, 1);
            RightWall = new WallObject(game, sB, mW, 2);
            BottomWall = new WallObject(game, sB, mW, 3);
            LeftWall = new WallObject(game, sB, mW, 4);


        }


        protected override void LoadContent()
        {
           // tex = Game.Content.Load<Texture2D>("Sprites/Curling_ Ball_Green_64");

            //   base.LoadContent();

            Game.Components.Add(obs1);

            Game.Components.Add(TopWall);
            Game.Components.Add(RightWall);
            Game.Components.Add(BottomWall);
            Game.Components.Add(LeftWall);

            isLoaded = true;
        }


        public override void Draw(GameTime gameTime)
        {

        //    spriteBatch.Draw(tex, new Vector2(400, 400), Color.White);

        }




    }




}
