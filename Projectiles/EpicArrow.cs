using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Projectiles
{
    public class EpicArrow : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Epic Arrow");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 26;
            projectile.height = 38;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.tileCollide = true;
        }

        public override void AI()
        {

            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;

            Dust dust;
            // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
            Vector2 position = projectile.position + projectile.velocity;
            dust = Main.dust[Terraria.Dust.NewDust(position, projectile.width, projectile.height, 27, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
            dust.noGravity = true;

        }

        public override bool PreKill(int timeLeft)
        {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, mod.ProjectileType("EpicExplosion"), projectile.damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Main.PlaySound(SoundID.Item14.WithVolume(0.5f), (int)projectile.Center.X, (int)projectile.Center.Y);
            return true;

        }


    }
}
