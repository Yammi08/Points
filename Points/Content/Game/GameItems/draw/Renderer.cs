using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Points.Content.Game.GameItems.draw
{
    public class Renderer
    {

        private List<Rectangle> textures = new List<Rectangle>();

        public Texture2D texture2D;

        public Renderer()
        {
        }
        public void Division(int rows, int columns)
        {
            Point tileSize = new Point(texture2D.Width / rows, texture2D.Height / columns);
            for (int y = 0; y <= columns; y++)
            {
                for (int x = 0; x <= rows; x++)
                    Cut(new Rectangle(
                        new Point(tileSize.X * x, tileSize.Y * y),
                        new Point(tileSize.X, tileSize.Y)
                        ));

            }
        }
        public void Manually(Rectangle rectangleFloat)
        {
            Cut(rectangleFloat);
            var s = new Rectangle(0, 0, 0, 0);
        }
        public Rectangle GetTexture(int i)
        {
            if (i == -1)
            {
                return new Rectangle(0, 0, 0, 0);
            }
            return textures[i];
        }
        private void Cut(Rectangle rectangleFloat)
        {
            textures.Add(rectangleFloat);
        }
    }
}
