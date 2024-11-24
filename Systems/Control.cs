using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lab6.Systems
{
    internal class Control
    {
        public static Vector2 GetVelocity()
        {
            Vector2 vel = new Vector2(0,0);
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                vel.Y = 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                vel.Y = -5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                vel.X = -5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                vel.X = 5;
            }
            return vel;
        }
    }
}
