using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace LootBags
{
	public class MyPlayer : ModPlayer
	{
        public static bool MoonWalk = false;

       

        public override void ResetEffects()
        {
            MoonWalk = false;


    }
        public override void PreUpdateMovement()
        {
            if (MoonWalk == true)
            {
                if (player.controlRight == true)
                {
                    player.direction = 0;
                }

                if (player.controlLeft == true)
                {
                    player.direction = 1;
                }
            }
        } 

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (item.type == ItemID.CopperShortsword && target.type == NPCID.MoonLordCore)
            {
                player.QuickSpawnItem(mod.ItemType("CaseratisBag"));
            }
        }
    }
}
