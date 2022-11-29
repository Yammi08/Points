using Points.Content.Game.GameItems.components;
using Points.Content.Game.GameItems.items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.Manager
{
    class ManagerDraw
    {
        // ** por favor modificar esto para que sea un sistema de capas
        List<Sprite> sprites;
        readonly Page page;
        public ManagerDraw(Page page)
        {
            this.page = page;
        }
        public void addSprite(Sprite sprite)=>sprites.Add(sprite);
        // ** por favor agregar remover y todo eso
    }
}
