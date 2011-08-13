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



    public class PlayerObject:GameObject
    {

        public Body circleBody;

         float PixelsPerMeter;

        
        
        
        public PlayerObject(Game game, SpriteBatch sB, World mW):base(game,sB,mW)
        {
            position = new Vector2(10, 10);
            PixelsPerMeter = CosmicCurling.MeterInPixels;
            
        }
        


        protected override void LoadContent()
        {


            texture = TextureManager.SharedTextureManager.getTexture("stone");
            origin = new Vector2(texture.Width / 2f, texture.Height / 2f);

            position = new Vector2(200, 100);

                     // Create the circle fixture
           
            circleBody = BodyFactory.CreateCircle( myWorld , texture.Width / (2f * PixelsPerMeter),1f, position/PixelsPerMeter);


            circleBody.BodyType = BodyType.Dynamic;

            // Give it some bounce and friction
            circleBody.Restitution = 1;
            circleBody.Friction = 0.1f;




            
        //    circleBody.Position = position / PixelsPerMeter;


            //base.LoadContent();
        }


        public override void Update(GameTime gameTime)
        {
        //    position += position * 0.05f;


            MouseState ms = Mouse.GetState();
            if (ms.LeftButton == ButtonState.Pressed)
            {
                circleBody.Position = new Vector2(ms.X, ms.Y)/PixelsPerMeter;
            }


            position = circleBody.Position * PixelsPerMeter;




            base.Update(gameTime);
            
        }




        public override void Draw(GameTime gameTime)
        {

        //    spriteBatch.Draw(texture, position, Color.White);


            spriteBatch.Draw(texture, position, null, Color.White, rotation, origin, 1f, SpriteEffects.None, 0f);


            base.Draw(gameTime);
        }

    }








}
