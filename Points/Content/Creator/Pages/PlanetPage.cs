using Points.Content.Creator.Scripts;
using Points.Content.Game.GameItems.items;
using Points.Content.Game.GameItems.Manager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Points.Content.Creator
{
    sealed public class PlanetPage : Page
    {

        public PlanetPage(ManagerPages managerP) : base(managerP)
        {
           managerE.addEntity<Planet>();

        }
        public override void init()
        {
            
            base.init();
            
        }
        public override void update(float delta)
        {
            base.update(delta);
        }

    }
}
