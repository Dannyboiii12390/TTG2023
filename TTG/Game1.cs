using ImGuiNET;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.ImGui;
using TTG.Classes;

namespace TTG
{
	public class MyGame: Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;
		private ShapeBatcher _shapeBatcher;

		private Board board;


		private int screenHeight = 480;
		private int screenWidth = 800;

        ImGuiRenderer _renderer;
		public MyGame()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			// TODO: Add your initialization logic here
			_shapeBatcher = new ShapeBatcher(this);
			board = new Board(screenWidth, screenHeight);
			_renderer = new ImGuiRenderer(this).Initialize().RebuildFontAtlas();

			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO: use this.Content to load your game content here
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();


			_renderer.BeginLayout(gameTime);
			_renderer.EndLayout();

			// TODO: Add your update logic here

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			board.Draw(_shapeBatcher);


			// TODO: Add your drawing code here

			base.Draw(gameTime);
		}
	}
}