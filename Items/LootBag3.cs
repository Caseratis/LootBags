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
	public class LootBag3 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tier 3 Loot Bag");
			Tooltip.SetDefault("Right click to open" + Environment.NewLine + "'I wonder what's inside'");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 30;
			item.rare = 4;
			item.maxStack = 999;
			item.value = 0;
		}

		public override bool CanRightClick()
		{
			return true;
		}

        public override void AddRecipes()
        {
            if (LootBags.config.LootBagCrafting == true)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(null, "LootBag4", 1);
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
            if (result.type == 3)
            {
                player.QuickSpawnItem(result.item, result.amount);
                int RanCore = new Random().Next(0, LootBags.config.Core3DropChance);
                if (RanCore == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("AdeptCore"));
                }
            }
            else
            {
                RightClick(player);
            }
            /*


            int num = new Random().Next(0, 67);
            if (num == 0)
            {
                player.QuickSpawnItem(ItemID.CobaltBar, new Random().Next(5, 21));
            }

            if (num == 1)
            {
                player.QuickSpawnItem(ItemID.PalladiumBar, new Random().Next(5, 21));
            }

            if (num == 2)
            {
                player.QuickSpawnItem(ItemID.MythrilBar, new Random().Next(5, 21));
            }

            if (num == 3)
            {
                player.QuickSpawnItem(ItemID.OrichalcumBar, new Random().Next(5, 21));
            }

            if (num == 4)
            {
                player.QuickSpawnItem(ItemID.AdamantiteBar, new Random().Next(5, 21));
            }

            if (num == 5)
            {
                player.QuickSpawnItem(ItemID.TitaniumBar, new Random().Next(5, 21));
            }

            if (num == 6)
            {
                player.QuickSpawnItem(ItemID.BeamSword);
            }

            if (num == 7)
            {
                player.QuickSpawnItem(ItemID.MagicQuiver);
            }

            if (num == 8)
            {
                player.QuickSpawnItem(ItemID.Marrow);
            }

            if (num == 9)
            {
                player.QuickSpawnItem(ItemID.RuneHat);
                player.QuickSpawnItem(ItemID.RuneRobe);
            }

            if (num == 10)
            {
                player.QuickSpawnItem(ItemID.ScalyTruffle);
            }

            if (num == 11)
            {
                player.QuickSpawnItem(ItemID.FrozenTurtleShell);
            }

            if (num == 12)
            {
                player.QuickSpawnItem(ItemID.FrostStaff);
            }

            if (num == 13)
            {
                player.QuickSpawnItem(ItemID.Bacon);
            }

            if (num == 14)
            {
                player.QuickSpawnItem(ItemID.Frostbrand);
            }

            if (num == 15)
            {
                player.QuickSpawnItem(ItemID.IceBow);
            }

            if (num == 16)
            {
                player.QuickSpawnItem(ItemID.FlowerofFrost);
            }

            if (num == 17)
            {
                player.QuickSpawnItem(ItemID.ToySled);
            }

            if (num == 18)
            {
                player.QuickSpawnItem(ItemID.RodofDiscord);
            }

            if (num == 19)
            {
                player.QuickSpawnItem(ItemID.SoulofLight, new Random().Next(4, 11));
            }

            if (num == 20)
            {
                player.QuickSpawnItem(ItemID.BlessedApple);
            }

            if (num == 21)
            {
                player.QuickSpawnItem(ItemID.CrystalShard, new Random().Next(4, 11));
            }

            if (num == 22)
            {
                player.QuickSpawnItem(ItemID.PixieDust, new Random().Next(4, 11));
            }

            if (num == 23)
            {
                player.QuickSpawnItem(ItemID.UnicornHorn);
            }

            if (num == 24)
            {
                player.QuickSpawnItem(ItemID.UnicornonaStick);
            }

            if (num == 25)
            {
                player.QuickSpawnItem(ItemID.LightShard);
            }

            if (num == 26)
            {
                player.QuickSpawnItem(ItemID.Megaphone);
            }

            if (num == 27)
            {
                player.QuickSpawnItem(ItemID.FastClock);
            }

            if (num == 28)
            {
                player.QuickSpawnItem(ItemID.Blindfold);
            }

            if (num == 29)
            {
                player.QuickSpawnItem(ItemID.CursedFlame, new Random().Next(4, 11));
            }

            if (num == 30)
            {
                player.QuickSpawnItem(ItemID.DarkShard);
            }

            if (num == 31)
            {
                player.QuickSpawnItem(ItemID.MeatGrinder);
            }

            if (num ==32)
            {
                player.QuickSpawnItem(ItemID.Ichor, new Random().Next(4, 11));
            }

            if (num == 33)
            {
                player.QuickSpawnItem(ItemID.Vitamins);
            }

            if (num == 34)
            {
                player.QuickSpawnItem(ItemID.SoulofNight, new Random().Next(4, 11));
            }

            if (num == 35)
            {
                player.QuickSpawnItem(ItemID.DualHook);
            }

            if (num == 36)
            {
                player.QuickSpawnItem(ItemID.MagicDagger);
            }

            if (num == 37)
            {
                player.QuickSpawnItem(ItemID.TitanGlove);
            }

            if (num == 38)
            {
                player.QuickSpawnItem(ItemID.PhilosophersStone);
            }

            if (num == 39)
            {
                player.QuickSpawnItem(ItemID.CrossNecklace);
            }

            if (num == 40)
            {
                player.QuickSpawnItem(ItemID.StarCloak);
            }

            if (num == 41)
            {
                player.QuickSpawnItem(ItemID.DartRifle);
            }

            if (num == 42)
            {
                player.QuickSpawnItem(ItemID.WormHook);
            }

            if (num == 43)
            {
                player.QuickSpawnItem(ItemID.ChainGuillotines);
            }

            if (num == 44)
            {
                player.QuickSpawnItem(ItemID.ClingerStaff);
            }

            if (num == 45)
            {
                player.QuickSpawnItem(ItemID.PutridScent);
            }

            if (num == 46)
            {
                player.QuickSpawnItem(ItemID.SoulDrain);
            }

            if (num == 47)
            {
                player.QuickSpawnItem(ItemID.DartPistol);
            }

            if (num == 48)
            {
                player.QuickSpawnItem(ItemID.FetidBaghnakhs);
            }

            if (num == 49)
            {
                player.QuickSpawnItem(ItemID.FleshKnuckles);
            }

            if (num == 50)
            {
                player.QuickSpawnItem(ItemID.TendonHook);
            }

            if (num == 51)
            {
                player.QuickSpawnItem(ItemID.DaedalusStormbow);
            }

            if (num == 52)
            {
                player.QuickSpawnItem(ItemID.FlyingKnife);
            }

            if (num == 53)
            {
                player.QuickSpawnItem(ItemID.CrystalVileShard);
            }

            if (num == 54)
            {
                player.QuickSpawnItem(ItemID.IlluminantHook);
            }

            if (num == 55)
            {
                player.QuickSpawnItem(ItemID.FrostCore);
            }

            if (num == 56)
            {
                player.QuickSpawnItem(3783); //forbidden fragment
            }

            if (num == 57)
            {
                player.QuickSpawnItem(ItemID.CoinGun);
            }

            if (num == 58)
            {
                player.QuickSpawnItem(ItemID.Cutlass);
            }

            if (num == 59)
            {
                player.QuickSpawnItem(ItemID.DiscountCard);
            }

            if (num == 60)
            {
                player.QuickSpawnItem(ItemID.GoldRing);
            }

            if (num == 61)
            {
                player.QuickSpawnItem(ItemID.LuckyCoin);
            }

            if (num == 62)
            {
                player.QuickSpawnItem(ItemID.PirateStaff);
            }

            if (num == 63)
            {
                player.QuickSpawnItem(ItemID.MechanicalEye);
            }

            if (num == 64)
            {
                player.QuickSpawnItem(ItemID.MechanicalWorm);
            }

            if (num == 65)
            {
                player.QuickSpawnItem(ItemID.MechanicalSkull);
            }

            if (num == 66)
            {
                player.QuickSpawnItem(mod.ItemType("MagicClock"));
            }
            */
        }
        
    }
}
