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



    public sealed class InputManager : Microsoft.Xna.Framework.GameComponent
    {
        public static Game myGame;
        private static readonly InputManager instance = new InputManager(myGame);

        private Vector2 deltaFlick;

        private InputManager(Game game) : base(game)
        {
            // TODO: Construct any child components here
            TouchPanel.EnabledGestures = GestureType.Flick;

        }


        public static InputManager sharedInputManager
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

            while (TouchPanel.IsGestureAvailable)
            {
                GestureSample gs = TouchPanel.ReadGesture();
                switch (gs.GestureType)
                {
                    case GestureType.Flick:
                        HandleFlick( gs.Delta);
                        break;
                }
            }
 
            base.Update(gameTime);
        }


        private void HandleFlick(Vector2 deltaF)
        {
            deltaFlick = deltaF;
        }


        public Vector2 getDeltaFlick()
        {

            Vector2 temp = deltaFlick;
            deltaFlick = new Vector2(0, 0);

            return temp;
        }


    }
}
