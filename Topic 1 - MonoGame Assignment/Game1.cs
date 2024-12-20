﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_1___MonoGame_Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D carTexture;
        Texture2D planeTexture;
        Texture2D boatTexture;
        Texture2D submarineTexture;

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

            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            carTexture = Content.Load<Texture2D>("car");
            planeTexture = Content.Load<Texture2D>("plane (1)");
            boatTexture = Content.Load<Texture2D>("red-boat");
            submarineTexture = Content.Load<Texture2D>("submarine");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(carTexture, new Vector2(2, 5), Color.White);
            _spriteBatch.Draw(planeTexture, new Vector2(30, 250), Color.White);
            _spriteBatch.Draw(boatTexture, new Vector2(4, 300), Color.White);
            _spriteBatch.Draw(submarineTexture, new Vector2(200, 108), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
