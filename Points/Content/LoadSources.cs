using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Points.Content.Game.GameItems.draw;
using Points.Content.Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content
{
    public static class LoadSources 
    {
        public static Renderer rPlayer;
        public static void init()
        {
            rPlayer = new Renderer();
        }
        public static void loadContent(ContentManager content)
        {
            rPlayer.texture2D = content.Load<Texture2D>("Images/MaybeEarth");
            rPlayer.Division(1,1);

        }
    }
}
