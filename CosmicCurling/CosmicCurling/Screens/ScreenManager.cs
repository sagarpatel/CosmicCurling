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
    public class ScreenManager : Microsoft.Xna.Framework.GameComponent
    {


        MainMenu mainMenu;
        Level1 level1Screen;



        public ScreenManager(Game game, SpriteBatch spriteBatch): base(game)
        {
            
            // TODO: Construct any child components here

            mainMenu = new MainMenu(game,spriteBatch);
            level1Screen = new Level1(game, spriteBatch);
          //  mainMenu.LoadContent();
            game.Components.Add(mainMenu);
            game.Components.Add(level1Screen);

            game.Components.Remove(level1Screen);

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
