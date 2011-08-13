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

using FarseerPhysics.Dynamics;


namespace CosmicCurling
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public sealed class ScreenManager : Microsoft.Xna.Framework.GameComponent
    {

        public static Game myGame;
        public static SpriteBatch mySpriteBatch;
        public static World myWorld;
        private static readonly ScreenManager instance = new ScreenManager(myGame, mySpriteBatch, myWorld);

        public MainMenu mainMenu;
        public Level1 level1Screen;



        private ScreenManager(Game game, SpriteBatch spriteBatch, World mW): base(game)
        {
            
            // TODO: Construct any child components here

    

        }

        public static ScreenManager sharedScreenManager
        {
            get
            {
                return instance;
            }
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


        public void manualInit()
        {
            mainMenu = new MainMenu(myGame, mySpriteBatch);
            level1Screen = new Level1(myGame, mySpriteBatch, myWorld);
            //  mainMenu.LoadContent();
            myGame.Components.Add(mainMenu);
            myGame.Components.Add(level1Screen);

            //   game.Components.Remove(level1Screen);
        }



    }
}
