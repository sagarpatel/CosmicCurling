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

namespace CosmicCurling
{



    public class CosmicCurling : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;


        ScreenManager screenManager;


        PlayerObject player1;




        public CosmicCurling()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Frame rate is 30 fps by default for Windows Phone.
            TargetElapsedTime = TimeSpan.FromTicks(333333);

            
            

        }




        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            spriteBatch = new SpriteBatch(GraphicsDevice);

            screenManager = new ScreenManager(this, spriteBatch);
            player1 = new PlayerObject(this, spriteBatch);

            Components.Add(screenManager);
            Components.Add(player1);

            base.Initialize();
        }



        protected override void LoadContent()
        {
                

            base.LoadContent();

        }

 


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

    



        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

           



            base.Update(gameTime);
        }

     



        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);


            /// base.Draw should draw anythin tahts in the draw method of DrawableGameCompnent 
            base.Draw(gameTime);


            spriteBatch.End();

        }




    }
}
