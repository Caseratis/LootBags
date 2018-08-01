﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Projectiles
{
    public class ApprenticeStaffProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Apprentice Staff Projectile");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 15;
            projectile.height = 15;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.penetrate = 2;
            projectile.timeLeft = 600;
            projectile.tileCollide = true;
            projectile.alpha = 255;
        }

        public override void AI()
        {

            Dust dust;
            // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
            Vector2 position = projectile.position + projectile.velocity;
            dust = Main.dust[Terraria.Dust.NewDust(position, projectile.width, projectile.height, 88, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
            dust.noGravity = true;
        }
    }
}
