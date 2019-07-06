using System;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items
{
    public class LootBag1 : ModItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tier 1 Loot Bag");
            Tooltip.SetDefault("Right click to open" + Environment.NewLine + "'I wonder what's inside'");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 30;
            item.rare = 0;
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
                recipe.AddIngredient(null, "LootBag2", 1);
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
            if (result.type == 1)
            {
                player.QuickSpawnItem(result.item, result.amount);
                int RanCore = new Random().Next(0, LootBags.config.Core1DropChance);
                if (RanCore == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("NoviceCore"));
                }
            }
            else
            {
                RightClick(player);
            }





        }

        

    /*
        int num = new Random().Next(0, 88);
        if (num == 0)
        {
            int ranWood = new Random().Next(25, 101);
            player.QuickSpawnItem(ItemID.Wood, ranWood);
        }

        if (num == 1)
        {
            int ranTorch = new Random().Next(10, 51);
            player.QuickSpawnItem(ItemID.Torch, ranTorch);
        }

        if (num == 2)
        {
            int ranGel = new Random().Next(15, 51);
            player.QuickSpawnItem(ItemID.Gel, ranGel);
        }

        if (num == 3)
        {
            int ranBar = new Random().Next(5, 21);
            player.QuickSpawnItem(ItemID.CopperBar, ranBar);
        }

        if (num == 4)
        {
            int ranBar = new Random().Next(5, 21);
            player.QuickSpawnItem(ItemID.TinBar, ranBar);
        }

        if (num == 5)
        {
            int ranBar = new Random().Next(5, 21);
            player.QuickSpawnItem(ItemID.IronBar, ranBar);
        }

        if (num == 6)
        {
            int ranBar = new Random().Next(5, 21);
            player.QuickSpawnItem(ItemID.LeadBar, ranBar);
        }

        if (num == 7)
        {
            int ranBar = new Random().Next(5, 21);
            player.QuickSpawnItem(ItemID.SilverBar, ranBar);
        }

        if (num == 8)
        {
            int ranBar = new Random().Next(5, 21);
            player.QuickSpawnItem(ItemID.TungstenBar, ranBar);
        }

        if (num == 9)
        {
            int ranBar = new Random().Next(5, 21);
            player.QuickSpawnItem(ItemID.GoldBar, ranBar);
        }

        if (num == 10)
        {
            int ranBar = new Random().Next(5, 21);
            player.QuickSpawnItem(ItemID.PlatinumBar, ranBar);
        }

        if (num == 11)
        {
            int ranGem = new Random().Next(3, 6);
            player.QuickSpawnItem(ItemID.Amber, ranGem);
        }

        if (num == 12)
        {
            int ranGem = new Random().Next(3, 6);
            player.QuickSpawnItem(ItemID.Diamond, ranGem);
        }

        if (num == 13)
        {
            int ranGem = new Random().Next(3, 6);
            player.QuickSpawnItem(ItemID.Ruby, ranGem);
        }

        if (num == 14)
        {
            int ranGem = new Random().Next(3, 6);
            player.QuickSpawnItem(ItemID.Emerald, ranGem);
        }

        if (num == 15)
        {
            int ranGem = new Random().Next(3, 6);
            player.QuickSpawnItem(ItemID.Sapphire, ranGem);
        }

        if (num == 16)
        {
            int ranGem = new Random().Next(3, 6);
            player.QuickSpawnItem(ItemID.Topaz, ranGem);
        }

        if (num == 17)
        {
            int ranGem = new Random().Next(3, 6);
            player.QuickSpawnItem(ItemID.Amethyst, ranGem);
        }

        if (num == 18)
        {
            int ranGrenade = new Random().Next(15, 31);
            player.QuickSpawnItem(ItemID.Grenade, ranGrenade);
        }

        if (num == 19)
        {
            int ranBomb = new Random().Next(10, 26);
            player.QuickSpawnItem(ItemID.Bomb, ranBomb);
        }

        if (num == 20)
        {
            int ranDynamite = new Random().Next(5, 21);
            player.QuickSpawnItem(ItemID.Dynamite, ranDynamite);
        }

        if (num == 21)
        {
            int ranMushroom = new Random().Next(5, 11);
            player.QuickSpawnItem(ItemID.Mushroom, ranMushroom);
        }

        if (num == 22)
        {
            player.QuickSpawnItem(ItemID.Spear, 1);
        }

        if (num == 23)
        {
            player.QuickSpawnItem(ItemID.WoodenBoomerang, 1);
        }

        if (num == 24)
        {
            player.QuickSpawnItem(ItemID.Blowpipe, 1);
        }

        if (num == 25)
        {
            player.QuickSpawnItem(ItemID.Aglet, 1);
        }

        if (num == 26)
        {
            player.QuickSpawnItem(ItemID.ClimbingClaws, 1);
        }

        if (num == 27)
        {
            player.QuickSpawnItem(ItemID.Umbrella, 1);
        }

        if (num == 28)
        {
            player.QuickSpawnItem(ItemID.Radar, 1);
        }

        if (num == 29)
        {
            player.QuickSpawnItem(ItemID.CordageGuide, 1);
        }

        if (num == 30)
        {
            player.QuickSpawnItem(ItemID.WandofSparking, 1);
        }

        if (num == 31)
        {
            player.QuickSpawnItem(ItemID.BandofRegeneration, 1);
        }

        if (num == 32)
        {
            player.QuickSpawnItem(ItemID.MagicMirror, 1);
        }

        if (num == 33)
        {
            player.QuickSpawnItem(ItemID.CloudinaBottle, 1);
        }

        if (num == 34)
        {
            player.QuickSpawnItem(ItemID.HermesBoots, 1);
        }

        if (num == 35)
        {
            player.QuickSpawnItem(ItemID.EnchantedBoomerang, 1);
        }

        if (num == 36)
        {
            player.QuickSpawnItem(ItemID.ShoeSpikes, 1);
        }

        if (num == 37)
        {
            int ranFlare = new Random().Next(25, 51);
            player.QuickSpawnItem(ItemID.FlareGun, 1);
            player.QuickSpawnItem(ItemID.Flare, ranFlare);
        }

        if (num == 38)
        {
            player.QuickSpawnItem(ItemID.Extractinator, 1);
        }

        if (num == 39)
        {
            player.QuickSpawnItem(ItemID.LavaCharm, 1);
        }

        if (num == 40)
        {
            player.QuickSpawnItem(ItemID.IceSkates, 1);
        }

        if (num == 41)
        {
            player.QuickSpawnItem(ItemID.IceBlade, 1);
        }

        if (num == 42)
        {
            player.QuickSpawnItem(ItemID.SnowballCannon, 1);
        }

        if (num == 43)
        {
            player.QuickSpawnItem(ItemID.LifeCrystal, 1);
        }

        if (num == 44)
        {
            player.QuickSpawnItem(ItemID.ManaCrystal, 1);
        }

        if (num == 45)
        {
            player.QuickSpawnItem(ItemID.BallOHurt, 1);
        }

        if (num == 46)
        {
            player.QuickSpawnItem(ItemID.BandofStarpower, 1);
        }

        if (num == 47)
        {
            player.QuickSpawnItem(ItemID.Musket, 1);
        }

        if (num == 48)
        {
            player.QuickSpawnItem(ItemID.ShadowOrb, 1);
        }

        if (num == 49)
        {
            player.QuickSpawnItem(ItemID.Vilethorn, 1);
        }

        if (num == 50)
        {
            player.QuickSpawnItem(ItemID.TheUndertaker, 1);
        }

        if (num == 51)
        {
            player.QuickSpawnItem(ItemID.TheRottedFork, 1);
        }

        if (num == 52)
        {
            player.QuickSpawnItem(ItemID.CrimsonRod, 1);
        }

        if (num == 53)
        {
            player.QuickSpawnItem(ItemID.PanicNecklace, 1);
        }

        if (num == 54)
        {
            player.QuickSpawnItem(ItemID.CrimsonHeart, 1);
        }

        if (num == 55)
        {
            player.QuickSpawnItem(ItemID.Trident, 1);
        }

        if (num == 56)
        {
            player.QuickSpawnItem(ItemID.Flipper, 1);
        }

        if (num == 57)
        {
            player.QuickSpawnItem(ItemID.BreathingReed, 1);
        }

        if (num == 58)
        {
            player.QuickSpawnItem(ItemID.BeachBall, 1);
        }

        if (num == 59)
        {
            player.QuickSpawnItem(ItemID.WaterWalkingBoots, 1);
        }

        if (num == 60)
        {
            int ranFin = new Random().Next(1, 4);
            player.QuickSpawnItem(ItemID.SharkFin, ranFin);
        }

        if (num == 61)
        {
            int ranOcean = new Random().Next(3, 6);
            player.QuickSpawnItem(ItemID.Coral, ranOcean);
        }

        if (num == 62)
        {
            int ranOcean = new Random().Next(3, 6);
            player.QuickSpawnItem(ItemID.Starfish, ranOcean);
        }

        if (num == 63)
        {
            int ranOcean = new Random().Next(3, 6);
            player.QuickSpawnItem(ItemID.Seashell, ranOcean);
        }

        if (num == 64)
        {
            player.QuickSpawnItem(ItemID.DivingHelmet, 1);
        }

        if (num == 65)
        {
            player.QuickSpawnItem(ItemID.JellyfishNecklace, 1);
        }

        if (num == 66)
        {
            player.QuickSpawnItem(ItemID.Hook, 1);
        }

        if (num == 67)
        {
            player.QuickSpawnItem(ItemID.WhoopieCushion, 1);
        }

        if (num == 68)
        {
            player.QuickSpawnItem(ItemID.ChainKnife, 1);
        }

        if (num == 69)
        {
            player.QuickSpawnItem(ItemID.DepthMeter, 1);
        }

        if (num == 70)
        {
            player.QuickSpawnItem(ItemID.MiningShirt, 1);
            player.QuickSpawnItem(ItemID.MiningPants, 1);
        }

        if (num == 71)
        {
            player.QuickSpawnItem(ItemID.BonePickaxe, 1);
        }

        if (num == 72)
        {
            player.QuickSpawnItem(ItemID.WizardHat, 1);
        }

        if (num == 73)
        {
            player.QuickSpawnItem(ItemID.MetalDetector, 1);
        }

        if (num == 74)
        {
            player.QuickSpawnItem(ItemID.BoneSword, 1);
        }

        if (num == 75)
        {
            player.QuickSpawnItem(ItemID.Skull, 1);
        }

        if (num == 76)
        {
            player.QuickSpawnItem(ItemID.EnchantedSword, 1);
        }

        if (num == 77)
        {
            player.QuickSpawnItem(ItemID.Arkhalis, 1);
        }

        if (num == 78)
        {
            player.QuickSpawnItem(ItemID.Fish, 1);
        }

        if (num == 79)
        {
            player.QuickSpawnItem(ItemID.IceMachine, 1);
        }

        if (num == 80)
        {
            player.QuickSpawnItem(ItemID.SnowballLauncher, 1);
        }

        if (num == 81)
        {
            player.QuickSpawnItem(ItemID.VikingHelmet, 1);
        }

        if (num == 82)
        {
            player.QuickSpawnItem(ItemID.Arkhalis, 1);
        }

        if (num == 83)
        {
            player.QuickSpawnItem(ItemID.LivingWoodWand, 1);
            player.QuickSpawnItem(ItemID.LeafWand, 1);
        }

        if (num == 84)
        {
            player.QuickSpawnItem(ItemID.LivingLoom, 1);
        }

        if (num == 85)
        {
            player.QuickSpawnItem(ItemID.SuspiciousLookingEye);
        }

        if (num == 86)
        {
            player.QuickSpawnItem(ItemID.WormFood);
        }

        if (num == 87)
        {
            player.QuickSpawnItem(ItemID.BloodySpine);
        }
        */


    }
}
