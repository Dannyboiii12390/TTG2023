using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;
using System;
using TTG.Helpers;

namespace TTG.Classes
{
    public abstract class Entity
    {
        public Vector2 Position { get; private set; }
        public Vector2 Velocity { get; private set; }
        public Circle Hitbox { get; private set; }
        public float Health { get; private set; }
        public float damage { get; private set; }
        public float damageInterval { get; private set; }
        public float Interval { get; set; }
        public float Speed { get; private set; }

        //lower number = lower speed
        public float CoefficientOfSpeed { get; private set; } = 0.15f;



        public Entity(Circle pCircle, Vector2 pVelocity, float pDamage, float pDamageInterval)
        {
            Interval = 0;
            Position = pCircle._position;
            Hitbox = pCircle;
            Speed = MathF.Sqrt(pVelocity.LengthSquared()) * CoefficientOfSpeed;
            pVelocity.Normalize();
            Velocity = pVelocity;
            damage = pDamage;
            damageInterval = pDamageInterval;
        }

        public virtual void Draw(ShapeBatcher shapeBatcher)
        {
            shapeBatcher.Draw(Hitbox);
        }

        public virtual void Move()
        {
            Position = Position + (Velocity * Speed);
            Hitbox = new Circle(Position, Hitbox._radius, Hitbox._colour);

        }
        public Entity ToEntity()
        {
            return (Entity)this;
        }
        public void IncInterval()
        {
            Interval++;
        }
        public void ResetInterval()
        {
            Interval = 0;
        }
    }
}
