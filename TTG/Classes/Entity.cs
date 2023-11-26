using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;
using System;
using TTG.Helpers;

namespace TTG.Classes
{
    public abstract class Entity
    {
        
        public Vector2 Position { get { return Hitbox._position; } }
        public Vector2 Velocity { get { return Hitbox._velocity; } }
        public Circle Hitbox { get; private set; }
        public float Health { get; private set; } = 100f;
        public float damage { get; private set; }
        public float damageInterval { get; private set; }
        public float Interval { get; set; }
        public float Speed { get; private set; }

        //lower number = lower speed
        public float CoefficientOfSpeed { get; private set; } = 0.15f;



        public Entity(Circle pCircle, Vector2 pVelocity, float pDamage, float pDamageInterval)
        {
            Interval = 0;
            Hitbox = pCircle;
            Speed = MathF.Sqrt(pVelocity.LengthSquared()) * CoefficientOfSpeed;
            pVelocity.Normalize();
            damage = pDamage;
            damageInterval = pDamageInterval;
        }

        public virtual void Draw(ShapeBatcher shapeBatcher)
        {
            shapeBatcher.Draw(Hitbox);
        }

        public virtual void Move()
        {
            Vector2 position = Position + (Velocity * Speed);
            Hitbox = new Circle(position, Hitbox._radius, Hitbox._colour);

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
        public void ChangeVelocity(Vector2 vel)
        {
            Hitbox.changeVelocity(vel);
        }
    }
}
