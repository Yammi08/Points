using Microsoft.Xna.Framework;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.scripts.components
{
    class Transform : Component
    {
        Matrix2 matrix;

        Vector2 position { get; }
        Vector2 scale { get; }
        float rotation { get; }
        public Transform(Entity entity) : base(entity)
        {
            
        }
        
    }
}
