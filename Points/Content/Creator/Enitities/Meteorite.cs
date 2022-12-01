using Microsoft.Xna.Framework;
using Points.Content.Creator.Scripts;
using Points.Content.Game.GameItems.components;
using Points.Content.Game.GameItems.Manager;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Points.Content.Creator.Enitities
{
    class Meteorite : Entity
    {
        
        public Meteorite(ManagerEntities manager) : base(manager)
        {
            addComponent<Sprite>().renderer = LoadSources.rMeteorite;
            addComponent<ScriptMeteorite>();
            this.name = "meteorite";
        }
        public override void Initialization()
        {
            Sprite sprite = getComponent<Sprite>();
            sprite.pivot = new Vector2(sprite.width, sprite.height)*0.5f;
            transform.Position = new Vector2(ManagerGame.width / 1.5f, ManagerGame.height / 1.5f);
            transform.Scale = new Vector2(2);
            sprite.SetSprite(0);
        }
    }
}
