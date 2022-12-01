using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Points.Content.Game.GameItems.components;
using Points.Content.Game.GameItems.items;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Points.Content.Game.GameItems.Manager
{
    public class ManagerDraw
    {
        // ** por favor modificar esto para que sea un sistema de capas
        List<Sprite> sprites;
        readonly Page page;
        public ManagerDraw(Page page)
        {
            sprites = new List<Sprite>();
            this.page = page;
        }
        public void addSprite(Sprite sprite)=>sprites.Add(sprite);
        // ** por favor agregar remover y todo eso

        // ** por favor aniadir un mejor Draw para capas y que permita usar la camara
        public void Draw()
        {
            SpriteBatch spriteBatch = ManagerGame.spriteBatch;
            foreach (Sprite sprite in sprites)
            {
                SpriteEffects spriteEffects = SpriteEffects.None;
                Vector2 scale = sprite.entity.transform.GlobalScale;
                if (scale.X < 0.0 && scale.Y > 0.0)
                {
                    spriteEffects = SpriteEffects.FlipHorizontally;
                    scale = new Vector2(Math.Abs(scale.X), Math.Abs(scale.Y));
                }
                else if (scale.X > 0.0 && scale.Y < 0.0)
                {
                    spriteEffects = SpriteEffects.FlipVertically;
                    scale = new Vector2(Math.Abs(scale.X), Math.Abs(scale.Y));
                }
                spriteBatch.Begin(SpriteSortMode.BackToFront,sprite.shader.blendState, sprite.shader.sampler, sprite.shader.depthStencil, sprite.shader.rasterizer, sprite.shader.effect/*Camera.Transform*/);
                spriteBatch.Draw(sprite.GetTexture(), position: sprite.entity.transform.GlobalPosition, sprite.spriteCoords, sprite.color, sprite.entity.transform.GlobalRotation, sprite.pivot, scale, spriteEffects, sprite.layer);
                spriteBatch.End();
            }
            

        }
        
    }
}
