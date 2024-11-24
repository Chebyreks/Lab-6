using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lab6.Core
{
    internal class Movable: Component
    {
        public Vector2 velocity;
        public Vector2 acceleration;

        public Movable(Vector2 velocity, Vector2 acceleration)
        {
            this.velocity = velocity;
            this.acceleration = acceleration;
        }

        override public void Update()
        {
            Entity.Position += velocity;
            velocity += acceleration;
        }
    }
}
