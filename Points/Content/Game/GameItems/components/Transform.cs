using Microsoft.Xna.Framework;
using MonoGame.Extended;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.scripts.components
{
    public class Transform : Component
    {
        public Matrix2 matrix
        {
            get
            {
                return IfRecalculateGlobal();
            }
        }
        public Matrix2 localMatrix;

        private Vector2 _position;
        private float _rotation;
        private Vector2 _scale;

        public Transform(Entity entity) : base(entity)
        {
            Position = Vector2.Zero;
            Scale = Vector2.One;
            Rotation = 0;
        }

        protected Matrix2 IfRecalculateGlobal()
        {
            IfRecalculate();
            if (entity.parent == null)
                return localMatrix;
            return Matrix2.Multiply(localMatrix, entity.parent.transform.matrix);

        }
        protected internal void IfRecalculate() => RecalculateLocalMatrix(out localMatrix);
        protected internal void RecalculateLocalMatrix(out Matrix2 matrix)
        {

            matrix = Matrix2.CreateScale(_scale) *
                     Matrix2.CreateRotationZ(_rotation) *
                     Matrix2.CreateTranslation(_position);
        }
        /// <summary>
        /// variable of type <see cref="Vector2"/>
        /// <para><see cref="Vector2"/> (x , y)</para>
        /// </summary>
        public Vector2 Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
                IfRecalculate();
            }
        }
        public Vector2 Scale
        {
            get
            {
                return _scale;

            }
            set
            {
                _scale = value;
                IfRecalculate();
            }
            //=> localPosition = new Vector2(value.X - entitie.transform.GlobalPosition.X, value.Y - entitie.transform.GlobalPosition.Y);
        }

        public float Rotation
        {
            get
            {
                return _rotation;
            }
            set
            {
                _rotation = value;
                IfRecalculate();
            }
        }


        public Vector2 GlobalPosition { get => matrix.Translation; }
        public Vector2 GlobalScale { get => matrix.Scale; }
        public float GlobalRotation { get => matrix.Rotation; }
    }
}
