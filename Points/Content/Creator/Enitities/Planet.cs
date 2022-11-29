using Points.Content.Creator.Scripts;
using Points.Content.Game.GameItems.components;
using Points.Content.Game.GameItems.Manager;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Creator
{
    class Planet : Entity
    {

        public Planet(ManagerEntities manager) : base(manager)
        {
            addComponent<Sprite>().renderer = LoadSources.rPlayer;
            getComponent<Sprite>().SetSprite(0);
            addComponent<ScriptPlanet>();
        }

    }
}
