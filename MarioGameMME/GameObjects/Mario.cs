using MalikaGameEngine.GameObjects;
using MalikaGameEngine.GameScreens;
using MalikaGameEngine.Managers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MarioGameMME.GameObjects
{
    public class Mario : GameObject
    {
        public float Speed { get; set; }
        public MarioType Type { get; set; }    //текущий тип марио
        public enum MarioType { 
            NORMAL, 
            BIG, 
            FIREBALL,
            STAR
        }
        
        private Vector2 _velocity;
        public Mario(GameScreen context) : base(context)
        {
           
        }

        public override void Init()
        {
            base.Init();
            Texture = Context.Content.Load<Texture2D>("GameObjects/s_Mario");
            Speed = 200;
            Type = MarioType.NORMAL;
        }

        public override void Update(float elapsedTime)
        {
            Move(elapsedTime);
            base.Update(elapsedTime);
            Console.WriteLine(Position);
        }

        private void Move(float elapsedTime)
        {
            _velocity.X = (Convert.ToInt32(Keyboard.IsKeyDown(_input["Right"])) - Convert.ToInt32(Keyboard.IsKeyDown(_input["Left"]))) * Speed;
            _velocity.Y += Constants.GRAVITY;
            Position += _velocity * elapsedTime;
            if (Position.Y >= Variables.WINDOW_HEIGHT) {
                Position = new Vector2(Position.X, 0);
            }

            //if (Keyboard.IsKeyDown(_input["Jump"]) && IsGrounded == true) {
            //    Position.Y -= 5f;
            //    Velocity += Vector2.UnitY * 38;
            //    IsGrounded= false;
            //}
        }
        public void Collision()
        {
            if (Position.Y > Variables.WINDOW_HEIGHT)
                Position *= Vector2.UnitX;
        }
    }
}