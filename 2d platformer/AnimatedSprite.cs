using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace _2d_platformer
{
    internal class AnimatedSprite
    {

        public List<Texture2D> texture;
        public Vector2 position;
        public int rows { get; set; }
        public int cols { get; set; }
        private int currentFrame;
        private int totalFrames;
        private int interval;
        private int actualframe;
        public bool walk = false;
        public Rectangle DestinationRectangle

        {
            get
            {
                return new Rectangle(
                    (int)position.X,
                    (int)position.Y,
                    texture[0].Width * 2 / cols,
                    texture[0].Width * 2 / rows
                    );
            }
        } 


        /*        float SCALE = 1.0f;*/
        /*        public Rectangle Rect
                {
                    get
                    {
                        return new Rectangle(
                        (int)position.X,
                        (int)position.Y,
             texture.Width * (int)SCALE,
             texture.Height * (int)SCALE
             );
                    }
                }*/

        public AnimatedSprite(List<Texture2D> textures, Vector2 position , int rows,int cols)
        {
            this.texture = texture;
            this.position = position;
            this.rows = rows;
            this.cols = cols;
            currentFrame = 0;
            interval = 10;
            totalFrames = rows * cols;
        }
        public virtual void Update(GameTime gametime)
        {
            
            if (walk == true)
            {
                currentFrame++;
                if (currentFrame >= interval)
                {
                    actualframe++;
                    currentFrame = 0;

                }
                if (actualframe >= totalFrames)
                {
                    actualframe = 0;

                }

            }
        }

        public void Draw(SpriteBatch spritebatch)
        {
            int width = texture[0].Width  / cols;
            int height = texture[0].Height  / rows;
            int colums = actualframe / cols;
            int row = actualframe % cols;

            Rectangle source = new Rectangle(width * colums, height  * row, width , height );



            spritebatch.Draw(texture[0], DestinationRectangle, source, Color.White);
            
        }
}
}
