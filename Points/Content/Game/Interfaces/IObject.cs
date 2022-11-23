using Points.Content.scripts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.Interfaces
{
    interface IObject
    {
        public void destroy(MonoObject item);
        public MonoObject create(MonoObject item);
        public T create<T>() where T : MonoObject;
    }
}
