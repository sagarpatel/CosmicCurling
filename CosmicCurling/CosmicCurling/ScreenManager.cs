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
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class ScreenManager : Microsoft.Xna.Framework.DrawableGameComponent
    {


        MainMenu mainMenu;



        public ScreenManager(Game game, SpriteBatch spriteBatch): base(game)
        {
            
            // TODO: Construct any child components here

            mainMenu = new MainMenu(game,spriteBatch);
            mainMenu.LoadContent();
            game.Components.Add(mainMenu);

        }


        protected override void LoadContent()
        {

            base.LoadContent();

        }



        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

 



        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);
        }






    }
}
