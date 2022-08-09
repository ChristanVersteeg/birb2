using System;
using System.Collections.Generic;
using System.Text;
using BaseProject.Engine;
using BaseProject.GameObjects.SpriteGameObjects;
using BaseProject.GameStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BaseProject
{
    /// <summary>
    /// The Debug class is used for making new instances of TextGameObjects and responsible for the Debug.Print() function.
    /// </summary>
    class Debug : GameObjectList //Debug class, shortened to p to just make the referal easy when you want to print a line. So that it is just p.print instead of Debug.print.
    {

        //Here is an method overload of the System.Diagnostics.Debug.WriteLine(). It needs to be overloaded in order to have all of the datatypes we need. This is solely made so that we can shorten System.Diagnostics.Debug.WriteLine() to Debug.Print.
        static public void Print(string println)
        {
            System.Diagnostics.Debug.WriteLine(println);
        }

        static public void Print(float println)
        {
            System.Diagnostics.Debug.WriteLine(println);
        }

        static public void Print(Vector2 println)
        {
            System.Diagnostics.Debug.WriteLine(println);
        }

        static public void Print(bool println)
        {
            System.Diagnostics.Debug.WriteLine(println);
        }

        public int Right, Up;
        /// <summary>
        /// Helps you move objects around so you can put them in a specific location by telling you the offset. 
        /// Put 'debug.Mover(inputHelper);' in the 'public override void HandleInput(InputHelper inputHelper)' in order to use it. 
        /// You will use The int Up and Right to determine the offset. They can be called by 'debug.Up' and 'debug.Right'. Just add/subtract Up and Right. Match the polarity to the X and Y position.
        /// </summary>
        /// <param name="inputHelper"></param>
        public void Mover(InputHelper inputHelper)
        {
            if (inputHelper.KeyPressed(Keys.Up)) Up++;
            if (inputHelper.KeyPressed(Keys.Left)) Right++;
            if (inputHelper.KeyPressed(Keys.Down)) Up--;
            if (inputHelper.KeyPressed(Keys.Right)) Right--;
            Vector2 RightUp = new Vector2(Right, Up);
            Print(RightUp);
        }

        //For drawing bounding boxes.
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
            DrawingHelper.DrawRectangle(BoundingBox, spriteBatch, Color.Green);
        }
    }
}