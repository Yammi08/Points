using Points.Content.Game.GameItems.items;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.Manager
{
    public class ManagerEntities : MonoObject
    {
        List<Entity> entities;
        public readonly Page page;
        public ManagerEntities(Page page)
        {
            this.page = page;
        }

        public Entity addEntity()
        {
            Entity entity = new Entity(this);
            return entity;
        }
        
    }
}
