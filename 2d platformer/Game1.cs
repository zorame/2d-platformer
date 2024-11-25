using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace _2d_platformer
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        List<Sprite> sprites;
        Player player;
        AnimatedSprite ani;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Texture2D playertexture = Content.Load<Texture2D>("player");
            Texture2D enemy = Content.Load<Texture2D>("enemy");
            // TODO: use this.Content to load your game content here
            sprites = new();
            Texture2D animation = Content.Load<Texture2D>("Sprite-0001");
     /*       ani = new AnimatedSprite(animation,sprites,new Vector2 (200,200),4,4);*/
            player = new Player(animation,sprites,new Vector2(0,0),4,4);
            sprites.Add(new Sprite(enemy, new Vector2(200, 200)));
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            List<Sprite> killlist = new();
            // TODO: Add your update logic here
            //foreach (var sprite in sprites)
            //{
            //    sprite.Update(gameTime);
            //    if ( sprite.Rect.Intersects(player.source))
            //    {
            //        killlist.Add(sprite);
            //    }
            //}
            //    foreach (var sprite in killlist)
            //    {
            //    sprites.Remove(sprite);
            //    }
                player.Update(gameTime);
          
                

                
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            foreach (var sprite in sprites)
            {
                sprite.Draw(_spriteBatch);
            }
            player.Draw(_spriteBatch);
        
        _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
