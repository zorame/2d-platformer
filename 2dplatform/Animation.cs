using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
/*using System.Numerics;*/
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace _2dplatform
{
    internal class Animation : SpriteScaled
{
        Texture2D Texture;
        public int row;
        public int col;
        private int currentframe = 0;
        private int frameratio = 10;
        private int totalframe;
        int frame = 0;
        public Rectangle destinationrect;

        public Animation(Texture2D texture, Vector2 position, int row, int col) : base(texture, position) {
            this.col = col;
            this.row = row;
            this.Texture = texture;
            /*this.position = position;*/

        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);  
            frame++;
            if (frame >= frameratio)
            {
                currentframe++;
                frame = 0;
            }
            totalframe = row * col;
            if (currentframe > totalframe)
            {
                currentframe = 0;

            }
          
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            int width = Texture.Width / col;
            int height = Texture.Height / row;
            int cols = currentframe % col;
            int rows = currentframe / col;

            Rectangle source = new Rectangle(width * cols,height * rows, width, height);
            Rectangle destinationrect = new Rectangle((int)position.X, (int)position.Y, width, height);

            spriteBatch.Draw(Texture, destinationrect, source,Color.White);
        }
    }
}
