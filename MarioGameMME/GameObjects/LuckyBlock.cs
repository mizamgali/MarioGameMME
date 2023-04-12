using MalikaGameEngine.GameObjects;
using MalikaGameEngine.GameScreens;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioGameMME.GameObjects
{
    public class LuckyBlock : GameObject
    {
        public bool IsMushroom { get; set; }  
        public LuckyBlock(GameScreen context) : base(context)
        {

        }
    }
}
