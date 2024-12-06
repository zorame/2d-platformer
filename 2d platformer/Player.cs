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
        public Player(Texture2D texture, List<Sprite> collisionGroup, Vector2 position,int rows,int cols) : base(List < Texture2D > textures, position,rows,cols) {
            this.collisionGroup = collisionGroup;
                this.position = position;
           
        }



        public float speed = 0;
        private List<Texture2D> textures;
        private List<Sprite> sprites;
        private Vector2 vector2;
        private int v1;
        private int v2;

        public override void Update(GameTime gameTime) 
        
        {

            base.Update(gameTime);


       
            float changeX = 0;
            float ChangeY = 0;
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                ChangeY -= 0.5f ;
                walk = true;
                if (speed <= 5f)
                {
                    speed = speed + 0.1f;
                }

            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                ChangeY += 0.5f;
                walk = true;
                if (speed <= 5f)
                {
                    speed = speed + 0.1f;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                changeX -= 0.5f;
                walk = true;
                if (speed <= 5f)
                {
                    speed = speed + 0.1f;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                changeX += 0.5f;
                walk = true;
                if (speed <= 5f)
                {
                    speed = speed + 0.1f;
                }
            }
            if (changeX == 0 && ChangeY == 0)
            {
                walk = false;
                if (speed > 0) {
                    speed -= 0.5f;
                }
            }

            Debug.WriteLine(speed);
            position.Y += ChangeY * speed;
            foreach (var sprite in collisionGroup)
            {
                if (sprite.Rect.Intersects(DestinationRectangle))
                {
              
                    position.Y -= ChangeY * speed ;
                  

                }
            }
            position.X += changeX * speed;
            foreach (var sprite in collisionGroup)
            {
                if (sprite.Rect.Intersects(DestinationRectangle))
                {
                    
                    position.X -= changeX * speed;
                }
            }
        }

 
}
}
