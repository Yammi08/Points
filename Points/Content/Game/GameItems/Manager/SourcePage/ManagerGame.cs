using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.Manager
{
    public static class ManagerGame
    {
        public static ManagerPages managerP { get; private set; }
        public static SpriteBatch spriteBatch { get; private set; }
        public static GameEditor editor { get; private set; }
        // ** crear clase Window
        public static int width { get; private set; }
        public static int height { get; private set; }
        public static void init(int width, int height)
        {
            ManagerGame.width = width;
            ManagerGame.height = height;
            managerP = new ManagerPages();
            editor = new GameEditor();
            editor.createZone();
        }
        public static void start(SpriteBatch spriteBatch)
        {
            ManagerGame.spriteBatch = spriteBatch;
            editor.startZone();
            
        }
    }
}
