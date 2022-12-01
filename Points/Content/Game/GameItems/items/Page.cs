using Microsoft.Xna.Framework.Graphics;
using Points.Content.Game.GameItems.Manager;
using Points.Content.Game.Interfaces;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Points.Content.Game.GameItems.items
{
    public class Page : MonoObject, IIni, IEnterTree, IReady, IUpdate, IDraw
    {
        public readonly string id;
        public readonly ManagerEntities managerE;
        public readonly ManagerScripts managerS;
        public readonly ManagerDraw managerD;
        readonly ManagerPages managerP;


        public Page(ManagerPages managerP)
        {
            managerE = new ManagerEntities(this);
            managerS = new ManagerScripts(this);
            managerD = new ManagerDraw(this);
            this.managerP = managerP;
            id = "page__" + GetHashCode();
        }
        public virtual void Initialization()
        {
            managerE.Initialization();
            managerS.Initialization();
            
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            managerD.Draw();
            managerS.Draw(spriteBatch);
        }

        public virtual void EnterTree()
        {
            managerS.EnterTree();

        }

        public virtual void Ready()
        {
            managerS.Ready();
        }

        public virtual void Update(float delta)
        {
            managerS.Update(delta);
        }
    }
}
