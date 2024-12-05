using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace _2dplatform
{
    internal class Player : Animation 
{

   
        public Player(Texture2D texture, Vector2 position, int row, int col) : base(texture, position, row, col) {  }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            int changeY = 0;
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                changeY -= 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                changeY += 2;
            }
            if (rect.Intersects(destinationrect)) 
            { changeY = 0;
                
            }
            position.Y += changeY;

            int changeX = 0;
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                changeX -= 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                changeX += 2;
            }
            position.X += changeX;
        }
    }
}
