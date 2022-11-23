using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.Manager
{
    public class ManagerId : MonoObject
    {
        public int id;
        private static int nextID = 0;
        private static int assingID { get => nextID++; }
        protected ManagerId()
        {
            id = assingID;
        }

        
    }
}
