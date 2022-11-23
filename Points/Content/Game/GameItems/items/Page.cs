using Points.Content.Game.GameItems.Manager;
using Points.Content.Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.items
{
    public class Page : Iiterator
    {
        public readonly ManagerEntities managerE;
        public  readonly ManagerScripts ManagerS;
        ManagerPages managerP;

        public Page(ManagerPages managerP)
        {
            managerE = new ManagerEntities(this);
            this.managerP = managerP;
        }

        public void draw(float delta)
        {
            throw new NotImplementedException();
        }

        public void enterTree()
        {
            throw new NotImplementedException();
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

        public void update(float delta)
        {
            throw new NotImplementedException();
        }
    }
}
