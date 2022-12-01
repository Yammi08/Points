using Points.Content.Extented;
using Points.Content.Game.GameItems.items;
using Points.Content.Game.Interfaces;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Points.Content.Game.GameItems.Manager
{
    public class ManagerEntities : MonoObject,IIni
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
        public T getEntity<T>(string name) where T : Entity => (T)entities.Values.FirstOrDefault(c => c.name == name && c is T);
        public IEnumerable<T> getEntities<T>() where T : Entity
        {
           return entities.Values.Where<Entity, T>(e => e is T);
        }

        public virtual void Initialization()
        {
            foreach (Entity entity in entities.Values)
                entity.Initialization();
        }
    }
}
