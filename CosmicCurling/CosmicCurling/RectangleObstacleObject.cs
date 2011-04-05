using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;

using FarseerPhysics.Dynamics;
using FarseerPhysics.Factories;




namespace CosmicCurling
{



    public class RectangleObstacleObject : GameObject
    {

        public Body rectangleBody;

        float PixelsPerMeter;


        public RectangleObstacleObject(Game game, SpriteBatch sB, World mW):base(game,sB,mW)
        {
            position = new Vector2(10, 10);
            PixelsPerMeter = CosmicCurling.MeterInPixels;


        }


        protected override void LoadContent()
        {

            texture = Game.Content.Load<Texture2D>("Sprites/Brick_200x50_Side");
            origin = new Vector2(texture.Width / 2f, texture.Height / 2f);

            position = new Vector2(200, 600);

            // Create the circle fixture

            rectangleBody = BodyFactory.CreateRectangle(myWorld, texture.Width /PixelsPerMeter, texture.Height/PixelsPerMeter, 1f, position/PixelsPerMeter);
            rectangleBody.BodyType = BodyType.Static;

            // Give it some bounce and friction
            rectangleBody.Restitution = 0.3f;
            rectangleBody.Friction = 0.1f;

            //base.LoadContent();
        }


        public override void Update(GameTime gameTime)
        {

            position = rectangleBody.Position * PixelsPerMeter;

            base.Update(gameTime);

        }




        public override void Draw(GameTime gameTime)
        {

            spriteBatch.Draw(texture, position, null, Color.White, rotation, origin, 1f, SpriteEffects.None, 0f);


            base.Draw(gameTime);
        }









    }





}
