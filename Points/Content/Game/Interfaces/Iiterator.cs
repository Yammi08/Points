using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.Interfaces
{
    interface IIni {public abstract void Initialization(); }
    interface ILoadContent { public abstract void LoadContent(); }
    interface IEnterTree { public abstract void EnterTree(); }
    interface IReady { public abstract void Ready(); }
    interface IUpdate { public abstract void Update(float delta); }
    interface IDraw { public abstract void Draw(SpriteBatch spriteBatch); }
}
