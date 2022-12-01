using Microsoft.Xna.Framework;
using Points.Content.Creator.Enitities;
using Points.Content.Creator.Scripts;
using Points.Content.Game.GameItems.components;
using Points.Content.Game.GameItems.items;
using Points.Content.Game.GameItems.Manager;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Points.Content.Creator
{
    sealed public class PlanetPage : Page
    {
        private Planet planet;
        private Meteorite meteorite;
        public PlanetPage(ManagerPages managerP) : base(managerP)
        {
            planet = managerE.addEntity<Planet>();
            meteorite = managerE.addEntity<Meteorite>();
            managerE.addEntity<Meteorite>();
            managerE.addEntity<Meteorite>();
            managerE.addEntity<Meteorite>();
            managerE.addEntity<Meteorite>();
            managerE.addEntity<Meteorite>();
            managerE.addEntity<Meteorite>();
            managerE.addEntity<Meteorite>();
            managerE.addEntity<Meteorite>();
        }
        public override void Initialization()
        {

            
            planet.transform.Position = new Vector2(ManagerGame.width / 2, ManagerGame.height / 2);
 
            base.Initialization();
        }
    }
}
