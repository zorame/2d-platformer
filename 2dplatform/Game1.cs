using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _2dplatform
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
/*        Animation ani;*/
        Player player;
        List<SpriteScaled> _sprites;
      /*  private Texture2D mainplayer;*/

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
            _sprites = new();
            Texture2D mainplayer = Content.Load<Texture2D>("SmileyWalk");
            Texture2D enemy = Content.Load<Texture2D>("Sprite-0002");
            //sprite = new SpriteScaled(mainplayer, new Vector2(0,0) );
            // TODO: use this.Content to load your game content here
    /*        _sprites.Add(new Player(mainplayer,new Vector2(100,200)));*/
            player = new Player(mainplayer,new Vector2(0,0),4,4);
            _sprites.Add(new SpriteScaled(enemy, new Vector2(200, 300)));
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            foreach (var sprite in _sprites) {
                sprite.Update(gameTime);
            }
            // TODO: Add your update logic here
            
            player.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            /*            _spriteBatch.Draw(mainplayer ,new Vector2(0,0), Color.White);*/
            foreach (var sprite in _sprites)
            {
                sprite.Draw(_spriteBatch);
            }
            player.Draw(_spriteBatch);

            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
