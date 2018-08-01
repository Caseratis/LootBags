using System;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items
{
	public class LootBag5 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tier 5 Loot Bag");
			Tooltip.SetDefault("Right click to open" + Environment.NewLine + "'I wonder what's inside'");
		}

		public override void SetDefaults()
		{
            item.width = 24;
            item.height = 30;
            item.rare = 9;
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
                recipe.AddIngredient(null, "LootBag6", 1);
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
            if (result.type == 5)
            {
                player.QuickSpawnItem(result.item, result.amount);
                int RanCore = new Random().Next(0, Config.Core5DropChance);
                if (RanCore == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("LegendaryCore"));
                }
            }
            else
            {
                RightClick(player);
            }
            /*


            int num = new Random().Next(0, 40);
			if (num == 0)
			{
				player.QuickSpawnItem(ItemID.BrainScrambler);
			}

            if (num == 1)
            {
                player.QuickSpawnItem(ItemID.LaserMachinegun);
            }

            if (num == 2)
            {
                player.QuickSpawnItem(ItemID.Xenopopper);
            }

            if (num == 3)
            {
                player.QuickSpawnItem(ItemID.XenoStaff);
            }

            if (num == 4)
            {
                player.QuickSpawnItem(ItemID.CosmicCarKey);
            }

            if (num == 5)
            {
                player.QuickSpawnItem(ItemID.LaserDrill);
            }

            if (num == 6)
            {
                player.QuickSpawnItem(ItemID.ElectrosphereLauncher);
            }

            if (num == 7)
            {
                player.QuickSpawnItem(ItemID.ChargedBlasterCannon);
            }

            if (num == 8)
            {
                player.QuickSpawnItem(ItemID.InfluxWaver);
            }

            if (num == 9)
            {
                player.QuickSpawnItem(ItemID.AntiGravityHook);
            }

            if (num == 10)
            {
                player.QuickSpawnItem(ItemID.Keybrand);
            }

            if (num == 11)
            {
                player.QuickSpawnItem(ItemID.WispinaBottle);
            }

            if (num == 12)
            {
                player.QuickSpawnItem(ItemID.MagnetSphere);
            }

            if (num == 13)
            {
                player.QuickSpawnItem(ItemID.PaladinsShield);
            }

            if (num == 14)
            {
                player.QuickSpawnItem(ItemID.PaladinsHammer);
            }

            if (num == 15)
            {
                player.QuickSpawnItem(ItemID.ShadowbeamStaff);
            }

            if (num == 16)
            {
                player.QuickSpawnItem(ItemID.SpectreStaff);
            }

            if (num == 17)
            {
                player.QuickSpawnItem(ItemID.InfernoFork);
            }

            if (num == 18)
            {
                player.QuickSpawnItem(ItemID.RocketLauncher);
            }

            if (num == 19)
            {
                player.QuickSpawnItem(ItemID.RifleScope);
            }

            if (num == 20)
            {
                player.QuickSpawnItem(ItemID.SniperRifle);
            }

            if (num == 21)
            {
                player.QuickSpawnItem(ItemID.TacticalShotgun);
            }

            if (num == 22)
            {
                player.QuickSpawnItem(ItemID.BlackBelt);
            }

            if (num == 23)
            {
                player.QuickSpawnItem(ItemID.Tabi);
            }

            if (num == 24)
            {
                player.QuickSpawnItem(ItemID.BeetleHusk, new Random().Next(10, 26));
            }

            if (num == 25)
            {
                player.QuickSpawnItem(ItemID.Ectoplasm, new Random().Next(10, 26));
            }

            if (num == 26)
            {
                player.QuickSpawnItem(ItemID.ShroomiteBar, new Random().Next(10, 26));
            }

            if (num == 27)
            {
                player.QuickSpawnItem(ItemID.SpectreBar, new Random().Next(10, 26));
            }

            if (num == 28)
            {
                player.QuickSpawnItem(ItemID.DD2SquireBetsySword);
            }

            if (num == 29)
            {
                player.QuickSpawnItem(3858); //Sky Dragons Fury
            }

            if (num == 30)
            {
                player.QuickSpawnItem(ItemID.DD2BetsyBow);
            }

            if (num == 31)
            {
                player.QuickSpawnItem(3870);
            }

            if (num == 32)
            {
                player.QuickSpawnItem(ItemID.BetsyWings);
            }

            if (num == 33)
            {
                player.QuickSpawnItem(ItemID.DeadlySphereStaff);
            }

            if (num == 34)
            {
                player.QuickSpawnItem(ItemID.ToxicFlask);
            }

            if (num == 35)
            {
                player.QuickSpawnItem(ItemID.MothronWings);
            }

            if (num == 36)
            {
                player.QuickSpawnItem(ItemID.TheEyeOfCthulhu);
            }

            if (num == 37)
            {
                player.QuickSpawnItem(ItemID.NailGun);
            }

            if (num == 38)
            {
                player.QuickSpawnItem(ItemID.PsychoKnife);
            }

            if (num == 39)
            {
                player.QuickSpawnItem(ItemID.SolarTablet);
            }
            */
        }
    }
}
