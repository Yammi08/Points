using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Points.Content;
using Points.Content.Game.GameItems.Manager;

namespace Points
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.IsFullScreen = true;
            _graphics.ApplyChanges();
            LoadSources.init();
            ManagerGame.init(_graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight);
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            LoadSources.loadContent(Content);

            ManagerGame.start(_spriteBatch);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape) || Keyboard.GetState().IsKeyDown(Keys.Q))
                Exit();

            // TODO: Add your update logic here
            ManagerGame.managerP.currentPage.Update((float)gameTime.ElapsedGameTime.TotalSeconds);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(30,30,30));

            ManagerGame.managerP.currentPage.Draw(_spriteBatch);
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
