using Points.Content.Game.GameItems.items;
using Points.Content.Game.GameItems.Manager;
using Points.Content.Game.Interfaces;
using Points.Content.scripts.components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Points.Content.scripts
{
    public class Entity : MonoObject, IIni
    {
        // ** crear un sistema de nombres
        public readonly ManagerEntities managerE;
        public readonly ManagerScripts managerS;
        public readonly string id;
        public readonly Page entityPage;
        public Entity? parent;
        public string name;
        public readonly Transform transform;
        readonly List<Component> components;
        readonly Dictionary<string,Entity> childs;


        public Entity(ManagerEntities manager) : base()
        {
            transform = new Transform(this);
            components = new List<Component> { transform };
            childs = new Dictionary<string, Entity>();
            managerE = manager;
            managerS = manager.page.managerS;
            entityPage = manager.page;
            
            id = this.GetType() +"__" + GetHashCode();
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
        public virtual void Initialization() { }
    }
}
