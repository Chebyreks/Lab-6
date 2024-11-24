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
    internal class Image: Component
    {
        public Texture2D Texture;

        public Image(Texture2D texture) 
        {
            Texture = texture;
        }

        override public void Draw(ref SpriteBatch batch) 
        {
            batch.Draw(Texture, Entity.Position, Color.White);
        }
    }
}
