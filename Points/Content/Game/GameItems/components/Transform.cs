using Microsoft.Xna.Framework;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.scripts.components
{
    class Transform : Component
    {
        Matrix2 matrixLocal;
        Matrix2 matrixGlogal;
        
        public Vector2 localPosition { get=> matrixLocal.Translation;}
        public Vector2 localScale { get=> matrixLocal.Scale; }
        public float   localRotation { get=> matrixLocal.Rotation; }
        public Vector2 globalPosition { get => matrixGlogal.Translation; }
        public Vector2 globalScale { get=> matrixGlogal.Scale; }
        public float globalRotation { get => matrixGlogal.Rotation; }
        
        public Transform(Entity entity) : base(entity)
        {
            
        }
        private void updateTransform()
        {
            //sif(entity)
        }
    }
}
