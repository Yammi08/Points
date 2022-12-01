using Microsoft.Xna.Framework;
using Points.Content.Creator.Scripts;
using Points.Content.Game.GameItems.components;
using Points.Content.Game.GameItems.Manager;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Creator.Enitities
{
    class Planet : Entity
    {

        public Planet(ManagerEntities manager) : base(manager)
        {
            addComponent<Sprite>().renderer = LoadSources.rPlayer;
            addComponent<ScriptPlanet>();
            name = "planet";
        }
        public override void Initialization()
        {
            Sprite sprite = getComponent<Sprite>();
            sprite.pivot = new Vector2(sprite.width / 2, sprite.height / 2);
            transform.Scale = Vector2.One* 0.5f;
            sprite.SetSprite(0);
        }
    }
}
