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
using FarseerPhysics.Factories;

namespace CosmicCurling
{





    public class WallObject: GameObject
    {

        public Body rectangleBody;

        float WallWidth;
        float WallHeight;

        Vector2 TopPosition;
        Vector2 BottomPosition;
        Vector2 LeftPosition;
        Vector2 RightPosition;


        int WallType;

        public WallObject(Game game, SpriteBatch sB, World mW, int Type) : base(game, sB, mW)
        {
            //had to multiply by 2 to make it work...dont know why...
            /// meh, I'm sick, don't feel like thinking about it
            /// it works for now anyways
            /// 

            WallHeight = 2f*  game.GraphicsDevice.Viewport.Height/CosmicCurling.MeterInPixels;
            WallWidth = 2f * game.GraphicsDevice.Viewport.Width / CosmicCurling.MeterInPixels;

            TopPosition = new Vector2(0, 0);
            BottomPosition = new Vector2(0, 800 / CosmicCurling.MeterInPixels);
            LeftPosition = new Vector2(0, 0);
            RightPosition = new Vector2(480 / CosmicCurling.MeterInPixels, 0);

            WallType = Type;

        }




        protected override void LoadContent()
        {

            ///Wall types:
            ///1 is top
            ///2 is Right
            ///3 is Bottom
            ///4 is Left
            
            switch(WallType)
            {

                case 1:
                    rectangleBody = BodyFactory.CreateRectangle(myWorld, WallWidth, 0.1f, 1f,TopPosition);
                    rectangleBody.BodyType = BodyType.Static;

                    // Give it some bounce and friction
                    rectangleBody.Restitution = 0.3f;
                    rectangleBody.Friction = 0.1f;
                    break;


                case 2:
                    rectangleBody = BodyFactory.CreateRectangle(myWorld, 0.1f, WallHeight, 1f, RightPosition);
                    rectangleBody.BodyType = BodyType.Static;

                    // Give it some bounce and friction
                    rectangleBody.Restitution = 0.3f;
                    rectangleBody.Friction = 0.1f;
                    break;


                case 3:
                    rectangleBody = BodyFactory.CreateRectangle(myWorld, WallWidth, 0.1f, 1f, BottomPosition);
                    rectangleBody.BodyType = BodyType.Static;

                    // Give it some bounce and friction
                    rectangleBody.Restitution = 0.3f;
                    rectangleBody.Friction = 0.1f;
                    break;

                case 4:
                    rectangleBody = BodyFactory.CreateRectangle(myWorld, 0.1f, WallHeight, 1f, LeftPosition);
                    rectangleBody.BodyType = BodyType.Static;

                    // Give it some bounce and friction
                    rectangleBody.Restitution = 0.3f;
                    rectangleBody.Friction = 0.1f;
                    break;



                default:
                    break;





            }




        }


    }









}
