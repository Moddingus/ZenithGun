using System;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace GodHatchet.Projectiles
{
    public class Placeholder : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.timeLeft = 0;
        }
    }
}

