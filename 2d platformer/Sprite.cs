using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

using System;
using System.Collections.Generic;
/*using System.Drawing;*/
using System.Linq;
/*using System.Numerics;*/
using System.Text;
using System.Threading.Tasks;

namespace _2d_platformer
{
    internal class Sprite
    {
        private static readonly float SCALE = 1f;
        public Texture2D texture;
        public Vector2 position;
        
        public Rectangle Rect { get { return new Rectangle(
            (int)position.X, 
            (int)position.Y,
            texture.Width * (int)SCALE,
            texture.Height * (int)SCALE
            ); 
            } }
        public Sprite(Texture2D texture, Vector2 position ) {
        this.position = position;
            this.texture = texture;
        
        }
        public virtual void Update(GameTime gameTime) { }
        public virtual void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, Rect, Color.White);
        }
}
}
