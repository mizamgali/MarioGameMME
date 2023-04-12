using MalikaGameEngine;
using MalikaGameEngine.GameObjects;
using MalikaGameEngine.GameScreens;
using MarioGameMME.GameObjects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MarioGameMME.GameScreens
{
    public class Level_1: GameScreen
    {
        public Level_1(MalikaGameEngine.Core.Game game): base(game)
        {
            GameObjects["Mario"] = new Mario(this) { Position = Vector2.One * 100 };
        }
        public override void Initialize()
        {
            _level = "Level_1";
            base.Initialize();
            InitializeGameObjects();
        }
        public void InitializeGameObjects() {
            foreach (Entity entity in _entities)
            {
                switch(entity.Type)
                {
                    case "LuckyBlock" : GameObjects.Add(entity.Type + "_" + Guid.NewGuid(), new LuckyBlock(this)
                    {
                        Position = new Vector2(entity.X, entity.Y),

                        IsMushroom = ((JsonElement)entity.Properties["isMushroom"]).ValueKind == JsonValueKind.True ? true : false
                    });
                        break;
                    case "Coin":
                        GameObjects.Add(entity.Type + "_" + Guid.NewGuid(), new Coin(this)
                        {
                            Position = new Vector2(entity.X, entity.Y)
                        });
                        break;
                    case "Finish":
                        GameObjects.Add(entity.Type + "_" + Guid.NewGuid(), new Finish(this)
                        {
                            Position = new Vector2(entity.X, entity.Y)
                        });
                        break;
                    case "Brick":
                        GameObjects.Add(entity.Type + "_" + Guid.NewGuid(), new Brick(this)
                        {
                            Position = new Vector2(entity.X, entity.Y)
                        });
                        break;
                    case "Pipe":
                        GameObjects.Add(entity.Type + "_" + Guid.NewGuid(), new Pipe(this)
                        {
                            Position = new Vector2(entity.X, entity.Y)
                        });
                        break;
                }
            }
        }
    }
}
