using Microsoft.Xna.Framework.Graphics;
using Points.Content.Game.Interfaces;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.components
{
    public class Script : Component, IIni, IEnterTree, IReady, IUpdate, IDraw
    {
        public Script(Entity entity) : base(entity)
        {
            entity.managerE.page.managerS.AddSript(this);
        }

        public virtual void Draw(SpriteBatch spriteBatch){}

        public virtual void EnterTree(){}

        public virtual void Initialization(){}

        public virtual void Ready(){}

        public virtual void Update(float delta){}
    }
}
