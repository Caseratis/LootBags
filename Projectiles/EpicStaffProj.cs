using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Projectiles
{

    public class EpicStaffProj : ModProjectile
    {
        int Timer;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Epic Staff Projectile");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 25;
            projectile.height = 25;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.penetrate = 4;
            projectile.timeLeft = 600;
            projectile.tileCollide = true;
            projectile.alpha = 255;
        }

        public override void AI()
        {
            Timer++;
            if (Timer == 10)
            {
                Timer = 0;
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, mod.ProjectileType("EpicTrail"), projectile.damage / 2, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            }

            Dust dust;
            // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
            Vector2 position = projectile.position + projectile.velocity;
            dust = Main.dust[Terraria.Dust.NewDust(position, projectile.width, projectile.height, 27, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
            dust.noGravity = true;
        }
    }
}
