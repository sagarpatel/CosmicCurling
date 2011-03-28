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
    public abstract class ScreenAbstract : Microsoft.Xna.Framework.DrawableGameComponent
    {

        protected bool isActive;
        protected bool isLoaded;

        protected SpriteBatch spriteBatch;

        public ScreenAbstract(Game game, SpriteBatch spriteB):base(game)
        {
            spriteBatch = spriteB;
            isActive = false;
            isLoaded = false;

        }



        public override void Initialize()
        {
            base.Initialize();
        }

        public virtual void LoadContent()
        {
            base.LoadContent();
        }

        public virtual void UnloadContent()
        {
            base.UnloadContent();
        }







        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }


        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            

        }




    }





}
