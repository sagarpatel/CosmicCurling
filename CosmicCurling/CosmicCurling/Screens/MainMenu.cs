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


        public MainMenu(Game game, SpriteBatch sB):base(game,sB)
        {


        }


        protected override void LoadContent()
        {

            base.LoadContent();

            isLoaded = true;
        }


        public override void Draw(GameTime gameTime)
        {
            if (isLoaded)
            {
                base.Draw(gameTime);
            }
        }



    }




}
