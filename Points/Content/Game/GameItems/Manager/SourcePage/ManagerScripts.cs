using Microsoft.Xna.Framework.Graphics;
using Points.Content.Game.GameItems.components;
using Points.Content.Game.GameItems.items;
using Points.Content.Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.Manager
{
    public class ManagerScripts : IIni, IEnterTree, IReady, IUpdate, IDraw
    {
        List<Script> scripts = new List<Script>();
        Page page;
        public ManagerScripts(Page page)
        {
            this.page = page;
        }
        
        public void AddSript(Script script)
        {
            scripts.Add(script);
        }
        // ** configurar mejor Remove scripts
        public void RemoveSript(Script script)
        {
            scripts.Remove(script);
        }
        public void Initialization()
        {
            foreach (var script in scripts)
                script.Initialization();
        }

        public void EnterTree()
        {
            foreach (var script in scripts)
                script.EnterTree();
        }
        public void Ready()
        {
            foreach (var script in scripts)
                script.Ready();
        }
        public void Update(float delta)
        {
            foreach (var script in scripts)
                script.Update(delta);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var script in scripts)
                script.Draw(spriteBatch);
        }       
    }
}
