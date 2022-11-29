using Points.Content.Game.GameItems.Manager;
using Points.Content.Game.Interfaces;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Points.Content.Game.GameItems.items
{
    public class Page : MonoObject, Iiterator
    {
        public readonly string id;
        public readonly ManagerEntities managerE;
        public readonly ManagerScripts managerS;
        readonly ManagerPages managerP;


        public Page(ManagerPages managerP)
        {
            managerE = new ManagerEntities(this);
            managerS = new ManagerScripts();
            this.managerP = managerP;
            id = "page__" + GetHashCode();
        }
        public virtual void init()
        {
            managerS.init();
            
        }
        public virtual void draw(float delta)
        {
            managerS.draw(delta);
        }

        public virtual void enterTree()
        {
            managerS.enterTree();

        }

        

        public virtual void loadContent()
        {
            managerS.loadContent();
        }

        public virtual void start()
        {
            managerS.start();
        }

        public virtual void update(float delta)
        {
            managerS.update(delta);
        }
    }
}
