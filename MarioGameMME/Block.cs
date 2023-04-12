using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MalikaGameEngine.GameObjects;
using MalikaGameEngine.GameScreens;
using MarioGameMME.GameObjects;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Content;

namespace MarioGameMME
{
    public class Block : GameObject
    {
        public Block(GameScreen context) : base(context)
        {
            
        }
        public override void Init()
        {
            Texture = _content.Load<Texture2D>("");
            base.Init();
        }
    }
}