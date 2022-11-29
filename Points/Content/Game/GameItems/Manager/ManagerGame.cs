using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.Manager
{
    public static class ManagerGame
    {
        public static ManagerPages managerP { get; private set; }
        public static GameEditor editor;
        public static void init()
        {
            managerP = new ManagerPages();
            editor = new GameEditor();
            editor.createZone();
        }
    }
}
