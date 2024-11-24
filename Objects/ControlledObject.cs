using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lab6.Objects
{
    internal class ControlledObject: Entity
    {
        override public void Update()
        {
            foreach (Component comp in Components)
            {
                comp.Update();
            }
        }

        public ControlledObject(String name, Vector2 pos, Texture2D texture) : base()
        {
            this.Name = name;
            this.Position = pos;
            Image image_comp = new Image(texture);
            image_comp.Added(this);
            Components.Add(image_comp);
            Controlled controlled_comp = new Controlled();
            controlled_comp.Added(this);
            Components.Add(controlled_comp);
        }
    }
}
