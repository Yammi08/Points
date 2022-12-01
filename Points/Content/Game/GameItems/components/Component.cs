using Points.Content.Game.GameItems.items;
using Points.Content.Game.GameItems.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.scripts
{
    public class Component : MonoObject
    {
        
        public Entity entity { get; private set; }
        public Page page { get => entity.entityPage; }
        public ManagerEntities managerE => page.managerE;
        public ManagerScripts managerS => page.managerS;
        
        public Component(Entity entity)
        {
            this.entity = entity;
        }
    }
}
