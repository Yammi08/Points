using Microsoft.Xna.Framework;
using Points.Content.Creator.Enitities;
using Points.Content.Game.GameItems.components;
using Points.Content.Game.GameItems.Manager;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Points.Content.Creator.Scripts
{
    class ScriptPlanet : Script
    {
        IEnumerable<Meteorite> meteorites;
        public ScriptPlanet(Entity entity) : base(entity)
        {
        }
        public override void Initialization()
        {
            /*
            Sprite sprite = entity.getComponent<Sprite>();
            sprite.SetSprite(0);
            sprite.pivot = new Vector2(sprite.width / 2, sprite.height / 2);
            entity.transform.Position = new Vector2(ManagerGame.width / 2, ManagerGame.height / 2);
            */
            meteorites = page.managerE.getEntities<Meteorite>();
        }
        public override void Ready()
        {
            
        }

        public override void Update(float delta)
        {
            entity.transform.Rotation += 1*delta;
        }
    }
}
