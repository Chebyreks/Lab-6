using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Lab6.Systems;

namespace Lab6.Core
{
    internal class Controlled: Component
    {
        public Vector2 velocity;
        public Vector2 acceleration;

        override public void Update()
        {
            velocity = Control.GetVelocity();
            Entity.Position -= velocity;
            velocity -= acceleration;
        }
    }
}
