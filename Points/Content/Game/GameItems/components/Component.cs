using Points.Content.Game.GameItems.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.scripts
{
    public class Component : MonoObject
    {
        
        public Entity entity { get; private set; }
        public Component(Entity entity)
        {
            this.entity = entity;
        }
    }
}
