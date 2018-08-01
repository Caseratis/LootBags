using System;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items
{
	public class LootBag4 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tier 4 Loot Bag");
			Tooltip.SetDefault("Right click to open" + Environment.NewLine + "'I wonder what's inside'");
		}

		public override void SetDefaults()
		{
            item.width = 24;
            item.height = 30;
            item.rare = 5;
            item.maxStack = 999;
            item.value = 0;
		}

		public override bool CanRightClick()
		{
			return true;
		}

        public override void AddRecipes()
        {
            if (Config.LootBagCrafting == true)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(null, "LootBag5", 1);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this, 2);
                recipe.AddRecipe();
            }
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
            if (result.type == 4)
            {
                player.QuickSpawnItem(result.item, result.amount);
                int RanCore = new Random().Next(0, Config.Core4DropChance);
                if (RanCore == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("EpicCore"));
                }
            }
            else
            {
                RightClick(player);
            }
            /*


            int num = new Random().Next(0, 23);
			if (num == 0)
			{
				player.QuickSpawnItem(ItemID.SoulofSight, new Random().Next(10, 31));
			}

            if (num == 1)
            {
                player.QuickSpawnItem(ItemID.SoulofMight, new Random().Next(10, 31));
            }

            if (num == 2)
            {
                player.QuickSpawnItem(ItemID.SoulofFright, new Random().Next(10, 31));
            }

            if (num == 3)
            {
                player.QuickSpawnItem(ItemID.SoulofFlight, new Random().Next(10, 31));
            }

            if (num == 4)
            {
                player.QuickSpawnItem(ItemID.HallowedBar, new Random().Next(5, 21));
            }

            if (num == 5)
            {
                player.QuickSpawnItem(ItemID.ApprenticeScarf);
            }

            if (num == 6)
            {
                player.QuickSpawnItem(ItemID.SquireShield);
            }

            if (num == 7)
            {
                player.QuickSpawnItem(ItemID.HuntressBuckler);
            }

            if (num == 8)
            {
                player.QuickSpawnItem(ItemID.MonkBelt);
            }

            if (num == 9)
            {
                player.QuickSpawnItem(3852); //Tome of Infinite Wisdom
            }

            if (num == 10)
            {
                player.QuickSpawnItem(ItemID.DD2PhoenixBow);
            }

            if (num == 11)
            {
                player.QuickSpawnItem(3823); //Brand of the Inferno
            }

            if (num == 12)
            {
                player.QuickSpawnItem(3835); //Sleepy Octopod
            }

            if (num == 13)
            {
                player.QuickSpawnItem(3836); //Ghastly Gaive
            }

            if (num == 14)
            {
                player.QuickSpawnItem(ItemID.DD2PetGhost);
            }

            if (num == 15)
            {
                player.QuickSpawnItem(ItemID.EyeSpring);
            }

            if (num == 16)
            {
                player.QuickSpawnItem(ItemID.DeathSickle);
            }

            if (num == 17)
            {
                player.QuickSpawnItem(ItemID.BrokenBatWing);
            }

            if (num == 18)
            {
                player.QuickSpawnItem(ItemID.MoonStone);
            }

            if (num == 19)
            {
                player.QuickSpawnItem(ItemID.NeptunesShell);
            }

            if (num == 20)
            {
                player.QuickSpawnItem(ItemID.BrokenHeroSword);
            }

            if (num == 21)
            {
                player.QuickSpawnItem(ItemID.MothronWings);
            }

            if (num == 22)
            {
                player.QuickSpawnItem(ItemID.LifeFruit);
            }
            */
        }
	}
}
