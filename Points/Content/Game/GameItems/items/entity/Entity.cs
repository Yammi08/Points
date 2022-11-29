using Points.Content.Game.GameItems.Manager;
using Points.Content.Game.Interfaces;
using Points.Content.scripts.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Points.Content.scripts
{
    public class Entity : MonoObject, Iiterator
    {
        public readonly ManagerEntities managerE;
        public readonly ManagerScripts managerS;
        public readonly string id;
        public Entity? parent;
        readonly Transform transform;
        readonly List<Component> components;
        readonly Dictionary<string,Entity> childs;


        public Entity(ManagerEntities manager) : base()
        {
            transform = new Transform(this);
            components = new List<Component> { transform };
            childs = new Dictionary<string, Entity>();
            managerE = manager;
            managerS = manager.page.managerS;
            id = "entity__" + GetHashCode();
        }
        #region funciones hijo
        public T getChild<T>(string id) where T : Entity => (T)childs[id];
        public void addChild(Entity entity)=>childs.Add(entity.id, entity);
        #region remover hijo
        public void removeChild(string id) => childs.Remove(id);
        public void removeChild(Entity entity) => childs.Remove(entity.id);
        #endregion
        #endregion

        #region funciones componentes
        public void removeComponent(Component component) => components.Remove(component);
        public T addComponent<T>() where T : Component
        {
            T component = (T)Activator.CreateInstance(typeof(T),this);
            components.Add(component);
            return component;
        }
        public List<T> getComponents<T>() where T : Component
        {
            List<T> items = new List<T>();
            for(int i = 0; i < components.Count;i++)
                if (components[i] is T) items.Add((T)components[i]);
            return items;
        }
        public T getComponent<T>() where T : Component
        {
            T item = (T)components.FirstOrDefault(c => c is T);
            return item;
        }
        #endregion
        public void init()
        {
            throw new NotImplementedException();
        }

        public void loadContent()
        {
            throw new NotImplementedException();
        }

        public void start()
        {
            throw new NotImplementedException();
        }

        public void enterTree()
        {
            throw new NotImplementedException();
        }

        public void update(float delta)
        {
            throw new NotImplementedException();
        }

        public void draw(float delta)
        {
            throw new NotImplementedException();
        }
    }
}
