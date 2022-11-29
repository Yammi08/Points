using Points.Content.Game.GameItems.components;
using Points.Content.Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.Manager
{
    public class ManagerScripts : Iiterator
    {
        List<Script> scripts = new List<Script>();

        
        public void AddSript(Script script)
        {
            scripts.Add(script);
        }
        // ** configurar mejor Remove scripts
        public void RemoveSript(Script script)
        {
            scripts.Remove(script);
        }
        public void init()
        {
            foreach (var script in scripts)
                script.init();
        }
        public void loadContent()
        {
            foreach (var script in scripts)
                script.loadContent();
        }
        public void enterTree()
        {
            foreach (var script in scripts)
                script.enterTree();
        }
        public void start()
        {
            foreach (var script in scripts)
                script.start();
        }
        public void update(float delta)
        {
            foreach (var script in scripts)
                script.update(delta);
        }
        public void draw(float delta)
        {
            foreach (var script in scripts)
                script.draw(delta);
        }

        

        

        
        

        
    }
}
