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



    public class MainMenu : ScreenAbstract
    {

        Texture2D testex;
        
        
        

        public MainMenu(Game game, SpriteBatch sB):base(game,sB)
        {

            int b = 8;
        }


        protected override void LoadContent()
        {
            testex = Game.Content.Load<Texture2D>("Sprites/Curling_ Ball_Green_64");
            
         //   base.LoadContent();

            isLoaded = true;
        }


        public override void Draw(GameTime gameTime)
        {
            if (isLoaded)
            {//testing new olor
                //int x = spriteBatch.GraphicsDevice.Viewport.Height;
                //x = testex.Height;
                
             //   spriteBatch.Draw(testex, new Vector2(100, 100), Color.White);

                base.Draw(gameTime);
            }
        }



    }




}
