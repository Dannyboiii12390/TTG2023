using ImGuiNET;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.ImGui;
using MonoGameLib.Shapes;
using System.Collections.Generic;
using TTG.Classes;

namespace TTG
{
	public class MyGame: Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;
		private ShapeBatcher _shapeBatcher;

		private Board board;
		private List<MeleeZombie> meleeZombieList = new List<MeleeZombie>();	
		private List<RangedZombie> rangedZombieList = new List<RangedZombie>();
		private List<Bullet> bullets = new List<Bullet>();
		

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
			board = new Board();
			_renderer = new ImGuiRenderer(this).Initialize().RebuildFontAtlas();

			meleeZombieList.Add(new MeleeZombie(new Circle(new Vector2(screenWidth+40, screenHeight-40), 39, Color.Red)));
			rangedZombieList.Add(new RangedZombie(new Circle(new Vector2(screenWidth + 40, screenHeight - 120), 39, Color.Blue)));
			rangedZombieList.Add(new RangedZombie(new Circle(new Vector2(screenWidth + 40, screenHeight - 200), 39, Color.Blue)));
							


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

			//move all entities
			foreach (MeleeZombie z in meleeZombieList)
			{
				z.Move();
			}
			foreach(RangedZombie r in rangedZombieList)
			{
				r.Move();
				//bullets.Add(r.Shoot());
			}
			foreach(Bullet bullet in bullets)
			{
				bullet.Move();
			}

			//update shoot interval for all entities
			foreach (MeleeZombie z in meleeZombieList)
			{
				
				z.IncInterval();
			}
            foreach (RangedZombie z in rangedZombieList)
            {
                
                z.IncInterval();
            }
			
			//check each ranged zombie can shoot
            foreach (RangedZombie zombie in rangedZombieList)
			{
				if (zombie.Interval >= zombie.damageInterval)
				{
                    bullets.Add(zombie.Shoot());
                    zombie.ResetInterval();
				}
			}
            
			

            

			// TODO: Add your update logic here

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			board.Draw(_shapeBatcher);

			foreach (MeleeZombie z in meleeZombieList)
			{
				z.Draw(_shapeBatcher);
			}
			foreach(RangedZombie r in rangedZombieList)
			{
				r.Draw(_shapeBatcher);
			}
			foreach(Bullet bullet in bullets)
			{
				bullet.Draw(_shapeBatcher);
			}

			_renderer.BeginLayout(gameTime);
			//ImGui.Begin("Zombie");
			//ImGui.Text(rangedZombieList[0].Interval.ToString());

			_renderer.EndLayout();


			// TODO: Add your drawing code here

			base.Draw(gameTime);
		}
	}
}