using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MalikaGameEngine.GameScreens;
using Microsoft.Xna.Framework;
using MarioGameMME.GameObjects;

namespace MarioGameMME.GameScreens
{
    public class TestScreen : GameScreen
    {
        public TestScreen(MalikaGameEngine.Core.Game game) : base(game)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
            GameObjects.Add("marioObj", new Mario(this));
        }
    }
}
