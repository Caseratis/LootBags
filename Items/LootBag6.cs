using System;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items
{
	public class LootBag6 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tier 6 Loot Bag");
			Tooltip.SetDefault("Right click to open" + Environment.NewLine + "'I wonder what's inside'");
		}

		public override void SetDefaults()
		{
			item.width = 24;
            item.height = 30;
            item.rare = 11;
            item.maxStack = 999;
            item.value = 0;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
            // the tables are assembled together according to their predicates' value
            LootNode pool = new LootNode();

            pool.AddChildren((from table
                              in LootBags.lootTables
                              select table.Value.children)
                             .SelectMany(x => x)
                             .ToArray());

            // then Roll() is invoked
            Loot result = pool.Roll();
            if (result.type == 6)
            {
                player.QuickSpawnItem(result.item, result.amount);
                int RanCore = new Random().Next(0, LootBags.config.Core6DropChance);
                if (RanCore == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("GodlyCore"));
                }
            }
            else
            {
                RightClick(player);
            }
            /*


            int num = new Random().Next(0, 19);
			int num2 = new Random().Next(10, 21);
			if (num == 0)
			{
				player.QuickSpawnItem(ItemID.FragmentSolar, num2);
			}

            if (num == 1)
            {
                player.QuickSpawnItem(ItemID.FragmentVortex, num2);
            }

            if (num == 2)
            {
                player.QuickSpawnItem(ItemID.FragmentNebula, num2);
            }

            if (num == 3)
            {
                player.QuickSpawnItem(ItemID.FragmentStardust, num2);
            }

            if (num == 4)
            {
                player.QuickSpawnItem(ItemID.AnkhShield);
            }

            if (num == 5)
            {
                player.QuickSpawnItem(ItemID.SolarFlareHelmet);
            }

            if (num == 6)
            {
                player.QuickSpawnItem(ItemID.SolarFlareBreastplate);
            }

            if (num == 7)
            {
                player.QuickSpawnItem(ItemID.SolarFlareLeggings);
            }

            if (num == 8)
            {
                player.QuickSpawnItem(ItemID.VortexHelmet);
            }

            if (num == 9)
            {
                player.QuickSpawnItem(ItemID.VortexBreastplate);
            }

            if (num == 10)
            {
                player.QuickSpawnItem(ItemID.VortexLeggings);
            }

            if (num == 11)
            {
                player.QuickSpawnItem(ItemID.NebulaHelmet);
            }

            if (num == 12)
            {
                player.QuickSpawnItem(ItemID.NebulaBreastplate);
            }

            if (num == 13)
            {
                player.QuickSpawnItem(ItemID.NebulaLeggings);
            }

            if (num == 14)
            {
                player.QuickSpawnItem(ItemID.StardustHelmet);
            }

            if (num == 15)
            {
                player.QuickSpawnItem(ItemID.StardustBreastplate);
            }

            if (num == 16)
            {
                player.QuickSpawnItem(ItemID.StardustLeggings);
            }

            if (num == 17)
            {
                player.QuickSpawnItem(ItemID.LunarBar, new Random().Next(15, 31));
            }

            if (num == 18)
            {
                player.QuickSpawnItem(mod.ItemType("TrueDiscoBall"));
            }
            */
        }
	}
}
