/*
if (num == )
            {
                player.QuickSpawnItem(ItemID.);
            }
*/
using System;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items
{
	public class LootBag2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tier 2 Loot Bag");
			Tooltip.SetDefault("Right click to open" + Environment.NewLine + "'I wonder what's inside'");
		}

		public override void SetDefaults()
		{
            item.width = 24;
            item.height = 30;
            item.rare = 3;
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
                recipe.AddIngredient(null, "LootBag3", 1);
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
            if (result.type == 2)
            {
                player.QuickSpawnItem(result.item, result.amount);
                int RanCore = new Random().Next(0, Config.Core2DropChance);
                if (RanCore == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("ApprenticeCore"));
                }
            }
            else
            {
                RightClick(player);
            }
            /*


            int num = new Random().Next(0, 54);
			if (num == 0)
			{
				player.QuickSpawnItem(ItemID.DarkLance);
			}

            if (num == 1)
            {
                player.QuickSpawnItem(ItemID.Sunfury);
            }

            if (num == 2)
            {
                player.QuickSpawnItem(ItemID.Flamelash);
            }

            if (num == 3)
            {
                player.QuickSpawnItem(ItemID.FlowerofFire);
            }

            if (num == 4)
            {
                player.QuickSpawnItem(ItemID.HellwingBow);
            }

            if (num == 5)
            {
                player.QuickSpawnItem(ItemID.PlumbersHat);
            }

            if (num == 6)
            {
                player.QuickSpawnItem(ItemID.ObsidianRose);
            }

            if (num == 7)
            {
                player.QuickSpawnItem(ItemID.DarkLance);
            }

            if (num == 8)
            {
                player.QuickSpawnItem(ItemID.DemonScythe);
            }

            if (num == 9)
            {
                player.QuickSpawnItem(ItemID.MagmaStone);
            }

            if (num == 10)
            {
                player.QuickSpawnItem(ItemID.GuideVoodooDoll);
            }

            if (num == 11)
            {
                player.QuickSpawnItem(ItemID.Cascade);
            }

            if (num == 12)
            {
                player.QuickSpawnItem(ItemID.HellstoneBar, new Random().Next(5, 21));
            }

            if (num == 13)
            {
                player.QuickSpawnItem(ItemID.Obsidian, new Random().Next(15, 31));
            }

            if (num == 14)
            {
                player.QuickSpawnItem(ItemID.Handgun);
            }

            if (num == 15)
            {
                player.QuickSpawnItem(ItemID.AquaScepter);
            }

            if (num == 16)
            {
                player.QuickSpawnItem(ItemID.MagicMissile);
            }

            if (num == 17)
            {
                player.QuickSpawnItem(ItemID.BlueMoon);
            }

            if (num == 18)
            {
                player.QuickSpawnItem(ItemID.CobaltShield);
            }

            if (num == 19)
            {
                player.QuickSpawnItem(ItemID.Muramasa);
            }

            if (num == 20)
            {
                player.QuickSpawnItem(ItemID.ShadowKey);
            }

            if (num == 21)
            {
                player.QuickSpawnItem(ItemID.Valor);
            }

            if (num == 22)
            {
                player.QuickSpawnItem(ItemID.BoneWelder);
            }

            if (num == 23)
            {
                player.QuickSpawnItem(ItemID.GoldenKey);
            }

            if (num == 24)
            {
                player.QuickSpawnItem(ItemID.Bone, new Random().Next(10, 26));
            }

            if (num == 25)
            {
                player.QuickSpawnItem(ItemID.ClothierVoodooDoll);
            }

            if (num == 26)
            {
                player.QuickSpawnItem(ItemID.Nazar);
            }

            if (num == 27)
            {
                player.QuickSpawnItem(ItemID.TallyCounter);
            }

            if (num == 28)
            {
                player.QuickSpawnItem(ItemID.AnkletoftheWind);
            }

            if (num == 29)
            {
                player.QuickSpawnItem(ItemID.FeralClaws);
            }

            if (num == 30)
            {
                player.QuickSpawnItem(ItemID.StaffofRegrowth);
            }

            if (num == 31)
            {
                player.QuickSpawnItem(ItemID.FiberglassFishingPole);
            }

            if (num == 32)
            {
                player.QuickSpawnItem(ItemID.Boomstick);
            }

            if (num == 33)
            {
                player.QuickSpawnItem(ItemID.HoneyDispenser);
            }

            if (num == 34)
            {
                player.QuickSpawnItem(ItemID.FlowerBoots);
            }

            if (num == 35)
            {
                player.QuickSpawnItem(ItemID.Seaweed);
            }

            if (num == 36)
            {
                player.QuickSpawnItem(ItemID.Bezoar);
            }

            if (num == 37)
            {
                player.QuickSpawnItem(ItemID.Stinger, new Random().Next(3, 6));
            }

            if (num == 38)
            {
                player.QuickSpawnItem(ItemID.Vine, new Random().Next(1, 6));
            }

            if (num == 39)
            {
                player.QuickSpawnItem(ItemID.ArchaeologistsHat);
            }

            if (num == 40)
            {
                player.QuickSpawnItem(ItemID.JungleSpores, new Random().Next(3, 6));
            }

            if (num == 41)
            {
                player.QuickSpawnItem(ItemID.NaturesGift);
            }

            if (num == 42)
            {
                player.QuickSpawnItem(ItemID.Feather, new Random().Next(3, 6));
            }

            if (num == 43)
            {
                player.QuickSpawnItem(ItemID.LuckyHorseshoe);
            }

            if (num == 44)
            {
                player.QuickSpawnItem(ItemID.Starfury);
            }

            if (num == 45)
            {
                player.QuickSpawnItem(ItemID.ShinyRedBalloon);
            }

            if (num == 46)
            {
                player.QuickSpawnItem(ItemID.SkyMill);
            }

            if (num == 47)
            {
                player.QuickSpawnItem(ItemID.BewitchingTable);
            }

            if (num == 48)
            {
                player.QuickSpawnItem(ItemID.AlchemyTable);
            }

            if (num == 49)
            {
                player.QuickSpawnItem(ItemID.WarTable);
            }

            if (num == 50)
            {
                player.QuickSpawnItem(ItemID.WarTableBanner);
            }

            if (num == 51)
            {
                player.QuickSpawnItem(ItemID.DD2PetDragon);
            }

            if (num == 52)
            {
                player.QuickSpawnItem(ItemID.DD2PetGato);
            }

            if (num == 53)
            {
                player.QuickSpawnItem(ItemID.Abeemination);
            }
            */
        }


    }
}
