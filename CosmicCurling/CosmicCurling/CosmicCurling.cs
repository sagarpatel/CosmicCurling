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

namespace CosmicCurling
{



    public class CosmicCurling : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        

        ScreenManager screenManager;
  
        PlayerObject player1;

        public const float MeterInPixels = 100f;

        public World myWorld;


        public CosmicCurling()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Frame rate is 30 fps by default for Windows Phone.
            TargetElapsedTime = TimeSpan.FromTicks(333333);

            graphics.PreferredBackBufferWidth = 480;
            graphics.PreferredBackBufferHeight = 800;

            myWorld = new World(new Vector2(0, 10));

            

        }




        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            spriteBatch = new SpriteBatch(GraphicsDevice);

            TextureManager.SharedTextureManager.addTexture("stone", Content.Load<Texture2D>("Sprites/Curling_ Ball_Green_64"));
            TextureManager.SharedTextureManager.addTexture("rectObs",Content.Load<Texture2D>("Sprites/Brick_200x50_Side"));

            screenManager = new ScreenManager(this, spriteBatch,myWorld);


            player1 = new PlayerObject(this, spriteBatch, myWorld);

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
            {

             //   Components.Remove(screenManager.level1Screen);
                screenManager.level1Screen.obs1.rectangleBody.Rotation += 10;
            
                

               // this.Exit();

            }




            myWorld.Step((float)gameTime.ElapsedGameTime.TotalMilliseconds * 0.001f);

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
