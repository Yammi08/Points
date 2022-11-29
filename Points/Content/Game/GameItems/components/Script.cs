using Points.Content.Game.Interfaces;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.components
{
    public class Script : Component,Iiterator
    {
        public Script(Entity entity) : base(entity)
        {
            entity.managerE.page.managerS.AddSript(this);
        }

        public virtual void draw(float delta)
        {
            
        }

        public virtual void enterTree()
        {

        }

        public virtual void init()
        {

        }

        public virtual void loadContent()
        {

        }

        public virtual void start()
        {

        }

        public virtual void update(float delta)
        {

        }
    }
}
