using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Lab6.Core
{
    internal class Entity
    {
        public int Id;
        public string Name;
        public Vector2 Position;

        public List<Component> Components;

        public Entity() 
        { 
            Components = new List<Component>();
        }

        public virtual void Update()
        {
            foreach (Component comp in Components)
            {
                comp.Update(); 
            }
        }

        public virtual void Draw(ref SpriteBatch batch)
        {
            foreach (Component comp in Components)
            {
                if (comp.GetType() == typeof(Image))
                {
                    comp.Draw(ref batch);
                }
            }
        }
    }
}
