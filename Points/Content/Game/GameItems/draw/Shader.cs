using Microsoft.Xna.Framework.Graphics;

namespace Points.Content.Game.GameItems.components
{
    public class Shader
    {
        public BlendState blendState = null;
        public SamplerState sampler = new SamplerState();
        public DepthStencilState depthStencil = null;
        public RasterizerState rasterizer = null;
        public Effect effect;
        public Shader()
        {
            sampler.Filter = TextureFilter.Point;
            sampler.AddressV = TextureAddressMode.Clamp;
        }
    }
}