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
using Microsoft.Xna.Framework.Input.Touch;



namespace CosmicCurling
{



    public class InputManager : Microsoft.Xna.Framework.GameComponent
    {



        public InputManager(Game game) : base(game)
        {
            // TODO: Construct any child components here
            TouchPanel.EnabledGestures = GestureType.Flick;

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

        private void HandleFlick()
        {



        }



    }
}
