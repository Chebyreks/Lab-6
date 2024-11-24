using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Lab6.Core;
using Lab6.Objects;

namespace Lab6
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private List<Entity> _entities;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 1080;
            _graphics.PreferredBackBufferHeight = 720;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();


        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _entities = new List<Entity>();

            Texture2D texture_larek = Content.Load<Texture2D>("larek");
            Texture2D texture1 = Content.Load<Texture2D>("shaurma1");
            Texture2D texture2 = Content.Load<Texture2D>("shaurma2");
            Texture2D texture_car = Content.Load<Texture2D>("Car");
            Texture2D texture_man = Content.Load<Texture2D>("Man");
            _entities.Add(new StaticObject("Larek1", new Vector2(0, 0), texture_larek));
            _entities.Add(new StaticObject("Shaurma1", new Vector2(0, 0), texture1));
            _entities.Add(new StaticObject("Shaurma2", new Vector2(350, -100), texture2));
            _entities.Add(new MovingObject("Car", new Vector2(-800, 150), new Vector2(5, 1), texture_car));
            _entities.Add(new ControlledObject("Man", new Vector2(-100, 200), texture_man));
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            foreach (Entity entity in _entities)
            {
                entity.Update();
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            foreach (Entity entity in _entities)
            {
                entity.Draw(ref _spriteBatch);
            }
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
