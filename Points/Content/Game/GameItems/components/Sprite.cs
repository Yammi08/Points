using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Points.Content.Game.GameItems.draw;
using Points.Content.scripts;
using System;
using System.Collections.Generic;

using System.Text;

namespace Points.Content.Game.GameItems.components
{
    public class Sprite : Component
    {
        private int _layer;
        internal Rectangle spriteCoords;
        public Renderer renderer;
        public Color color;
        public Vector2 pivot;
        public Shader shader;
        public int layer
        {
            get => _layer;
            set
            {
                _layer = value;
            }
        }

        
        
        public Sprite(Entity entity) : base(entity)
        {
            spriteCoords = new Rectangle(0, 0, 0, 0);
            renderer = null;
            color = Color.White;
            pivot = new Vector2(0);
            shader = new Shader();
            color = Color.White;
            layer = 0;
        }
        /// <summary>
        /// Method <c>GetTexture</c> watch the Texture
        /// </summary>
        /// <returns><c>Texture2D</c></returns>
        public Texture2D GetTexture()
        {
            return renderer.texture2D;
        }
        /// <summary>
        /// Method <c>SetSprite</c> change the sprite from <see cref="Sprite"/>
        /// </summary>
        /// <param name="i">id to <see cref="Sprite"/></param>
        public void SetSprite(int i) => spriteCoords = renderer.GetTexture(i);
    }
}
