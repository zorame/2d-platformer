using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

/*using System.Numerics;*/
using System.Text;
using System.Threading.Tasks;

namespace _2d_platformer
{
    internal class Player : AnimatedSprite

{   
        public Vector2 Position;
        public List<Sprite> collisionGroup;
        public Player(Texture2D texture, List<Sprite> collisionGroup, Vector2 position,int rows,int cols) : base(texture, position,rows,cols) { this.collisionGroup = collisionGroup; }

        public override void Update(GameTime gameTime) 
        
        {
            base.Update(gameTime);
           
            float ChangeY = 0;
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                ChangeY -= 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                ChangeY += 2;
            }
            position.Y += ChangeY;
            foreach (var sprite in collisionGroup)
            {
                if (sprite.Rect.Intersects(destinationRectangle))
                {
                    position.Y -= ChangeY;

                }
            }

            float changeX = 0f;
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                changeX -= +2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                changeX += 2;
            }
            position.X += changeX;
            foreach (var sprite in collisionGroup)
            {
                if (sprite.Rect.Intersects(destinationRectangle))
                {
                    position.X -= changeX;
                }
            }
        }

}
}
