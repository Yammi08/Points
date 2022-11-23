using Points.Content.Game.GameItems.Manager;
using Points.Content.Game.Interfaces;
using Points.Content.scripts.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Points.Content.scripts
{
    public class Entity : ManagerId, Iiterator
    {
        public readonly ManagerEntities managerE;
        public readonly ManagerScripts managerS;
        readonly Transform transform;
        readonly List<Component> components;
        

        public Entity(ManagerEntities manager) : base()
        {
            transform = new Transform(this);
            components = new List<Component>{transform};
            managerE = manager;
            managerS = manager.page.ManagerS;
        }
        
        public void removeComponent(Component component) => components.Remove(component);
        public void addComponent<T>() where T : Component
        {
            T component = (T)Activator.CreateInstance(typeof(T),this);
            components.Add(component);
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
