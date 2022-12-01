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
    class ScriptMeteorite : Script
    {
        public Planet planet;
        public float randX,randY;
        private static int _cont= 3;
        public static int cont => _cont++;
        public int randDir;
        private Vector2 startPos;
        public ScriptMeteorite(Entity entity) : base(entity)
        {

        }
        public override void Ready()
        {
            planet = managerE.getEntity<Planet>("planet");
            Random random;
            random = new Random();
            randX = random.Next(0,360);
            do
            {
                randDir = ((int)random.Next(-1, 2));
            } while (randDir == 0);
            Debug.WriteLine(randDir);
            startPos = entity.transform.Position * cont * 0.8f;
        }
        public override void Update(float delta)
        {
            float x = (float)Math.Cos((planet.transform.Rotation * randDir )* 2f + randX) * 0.5f;
            float y = (float)Math.Sin((planet.transform.Rotation * randDir ) * 2f + (10 / randX)) *0.5f;
            entity.transform.Position =  planet.transform.Position - new Vector2(x * startPos.X - y * startPos.Y, y * startPos.X + x * startPos.Y) * 0.08f;
            entity.transform.Rotation = (float)Math.Atan2(y,x);
        }
    }
}
