using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.Interfaces
{
    public interface Iiterator
    {
        public abstract void init();
        public abstract void loadContent();
        public abstract void start();
        public abstract void enterTree();
        public abstract void update(float delta);
        public abstract void draw(float delta);
    }
}
