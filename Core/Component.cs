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
    internal class Component
    {
        public Entity Entity { get; private set; }

        public virtual void Added(Entity entity)
        {
            Entity = entity;
        }

        public virtual void Update()
        {

        }

        public virtual void Draw(ref SpriteBatch batch)
        {

        }
    }
}
