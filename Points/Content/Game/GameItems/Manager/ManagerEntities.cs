using Points.Content.Game.GameItems.items;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.Manager
{
    public class ManagerEntities : MonoObject
    {
        Dictionary<string,Entity> entities;
        public readonly Page page;
        public ManagerEntities(Page page)
        {
            this.page = page;
            entities = new Dictionary<string, Entity>();
        }

        public T addEntity<T>() where T : Entity
        {
            T entity = (T)Activator.CreateInstance(typeof(T), this);
            entities.Add(entity.id,entity);
            return entity;
        }
        
    }
}
