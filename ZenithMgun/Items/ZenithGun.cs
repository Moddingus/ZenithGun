using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using GodHatchet.Projectiles;

namespace GodHatchet.Items
{
    public class ZenithGun : ModItem
    {
        private int counter = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Predator");
            Tooltip.SetDefault("this is a gun");
        }
        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.autoReuse = true;
            item.useAnimation = 7;
            item.useTime = 2;
            item.width = 50;
            item.crit = 50;
            item.height = 18;
            item.shoot = ModContent.ProjectileType<Placeholder>();
            item.UseSound = SoundID.Item11;
            item.damage = 222;
            item.shootSpeed = 13f;
            item.noMelee = true;
            item.value = 9500000;
            item.rare = 5;
            item.knockBack = 1f;
            item.ranged = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Megashark, 1);
            recipe.AddIngredient(ItemID.OnyxBlaster, 1);
            recipe.AddIngredient(ItemID.ChainGun, 1);
            recipe.AddIngredient(ItemID.SDMG, 1);
            recipe.AddIngredient(ItemID.DartRifle, 1);
            recipe.AddIngredient(ItemID.VortexBeater, 1);
            recipe.AddIngredient(ItemID.Xenopopper, 1);
            recipe.AddIngredient(ItemID.EldMelter, 1);
            recipe.AddIngredient(ItemID.FireworksLauncher, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<ZenithBullet>(), damage, knockBack, player.whoAmI);
            int shoot = ModContent.ProjectileType<ZenithBullet>();

            if (counter == 0)
            {
                shoot = ProjectileID.BlackBolt;
                counter += 1;
            }
            else if (counter == 1)
            {
                shoot = ProjectileID.RocketFireworkBlue;
                counter += 1;
            }
            else if (counter == 2)
            {
                shoot = ProjectileID.PoisonDartBlowgun;
                counter += 1;
            }
            else if (counter == 3)
            {
                shoot = ProjectileID.VortexBeaterRocket;
                counter += 1;
            }
            else if (counter == 4)
            {
                shoot = ProjectileID.RocketIII;
                counter += 1;
            }
            else if (counter == 5)
            {
                shoot = ProjectileID.Flames;
                counter += 1;
            }
            else if (counter == 6)
            {
                shoot = ProjectileID.IchorBullet;
                counter += 1;
            }
            else if (counter == 7)
            {
                shoot = ProjectileID.ChlorophyteBullet;
                counter += 1;
            }
            else if (counter == 8)
            {
                shoot = ProjectileID.VenomBullet;
                counter += 1;
            }
            else if (counter == 9)
            {
                shoot = ProjectileID.CursedBullet;
                counter = 0;
            }
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, shoot, damage, knockBack, player.whoAmI);
            return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
        }
    }
}