using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mime;

namespace _2dplatform
{
    public class SpriteScaled
    {
        public Texture2D texutre;
        public Vector2 position;
        private float Scale = 1f;
        public Rectangle rect => new Rectangle((int)position.X, (int)position.Y, texutre.Width * (int)Scale, texutre.Height * (int)Scale);
        public SpriteScaled(Texture2D texture, Vector2 position)
        {
            this.texutre = texture;
            this.position = position;
        }
        public virtual void Update(GameTime gameTime)
        {

        }
        public virtual void Draw(SpriteBatch spritebatch)
        {

            spritebatch.Draw(texutre, rect, Color.White);
        }
    }


}
