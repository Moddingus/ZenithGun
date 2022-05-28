using System;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace GodHatchet.Projectiles
{
	public class ZenithBullet : ModProjectile
	{
        public override void SetDefaults()
        {
            projectile.width = 4;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.light = 0.5f;
            projectile.extraUpdates = 2;
            projectile.scale = 1.2f;
            projectile.timeLeft = 600;
            projectile.ranged = true;
            projectile.alpha = 0;
            aiType = ProjectileID.ChlorophyteBullet;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 480);
        }
        public override void Kill(int timeLeft)
        {
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, ProjectileID.Xenopopper, 250, 0, projectile.whoAmI);
        }
    }
}

