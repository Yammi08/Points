using Points.Content.Game.GameItems.items;
using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.Manager
{
    public class ManagerPages : MonoObject
    {
        List<Page> pages;
        public ManagerPages()
        {
            pages = new List<Page>();
        }
    }
}
