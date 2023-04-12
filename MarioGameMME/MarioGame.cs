using MalikaGameEngine.GameObjects;
using MarioGameMME.GameScreens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Screens;

namespace MarioGameMME
{
    public class MarioGame : MalikaGameEngine.Core.Game
    {
        public MarioGame()
        {

        }

        protected override void Initialize()
        {
            base.Initialize();
            ScreenManager.LoadScreen(new Level_1(this));
        }  

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}