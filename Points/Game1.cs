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
            LoadSources.init();
            ManagerGame.init();
            ManagerGame.managerP.currentPage.init();
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            ManagerGame.managerP.currentPage.loadContent();
            LoadSources.loadContent(Content);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            ManagerGame.managerP.currentPage.update((float)gameTime.ElapsedGameTime.Seconds);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(50,50,50));

            ManagerGame.managerP.currentPage.draw((float)gameTime.ElapsedGameTime.Seconds);
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
