using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace LootBags.NPCs
{
    [AutoloadHead]
    public class EAMerchant : ModNPC
    {
        public static bool Plants = false;

        public override bool Autoload(ref string name)
        {
            name = "Loot Bag Dealer";
            return mod.Properties.Autoload;
        }

        public override string Texture
        {
            get
            {
                return "LootBags/NPCs/EAMerchant";
            }
        }


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Loot Bag Dealer");
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 150;
            NPCID.Sets.AttackType[npc.type] = 3;
            NPCID.Sets.AttackTime[npc.type] = 17;
            NPCID.Sets.AttackAverageChance[npc.type] = 10;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 500;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.TaxCollector;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            if (NPC.downedBoss3 || Main.hardMode == true && Config.BuyLootBags)
            {
                return true;
            }
            return false;
        }

        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(4))
            {
                case 0:
                    return "Trip";
                case 1:
                    return "Larry";
                case 2:
                    return "Greene";
                default:
                    return "John";
            }
        }

        public override string GetChat()
        {
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "The loot bags are expensive to provide players with a sense of pride and accomplishment.";
                case 1:
                    return "They aren't loot boxes, they're loot bags.";
                case 2:
                    return "Money first, customer second.";
                default:
                    return "Sorry, but you need to pay $1.99 to talk to me.";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = "Give Me Your Money";
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
            }

        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.GoldCoin);
            shop.item[nextSlot].shopCustomPrice = 50000;
            nextSlot++;

            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("LootBag1"));
                shop.item[nextSlot].shopCustomPrice = Config.LootBag1Cost;
                nextSlot++;
            }
            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("LootBag2"));
                shop.item[nextSlot].shopCustomPrice = Config.LootBag2Cost;
                nextSlot++;
            }
            if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("LootBag3"));
                shop.item[nextSlot].shopCustomPrice = Config.LootBag3Cost;
                nextSlot++;
            }
            if (NPC.downedGolemBoss)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("LootBag4"));
                shop.item[nextSlot].shopCustomPrice = Config.LootBag4Cost;
                nextSlot++;
            }
            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("LootBag5"));
                shop.item[nextSlot].shopCustomPrice = Config.LootBag5Cost;
                nextSlot++;
            }
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 10;
            knockback = 3f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 20;
            randExtraCooldown = 20;
        }

        public override void DrawTownAttackSwing(ref Texture2D item, ref int itemSize, ref float scale, ref Vector2 offset)//Allows you to customize how this town NPC's weapon is drawn when this NPC is swinging it (this NPC must have an attack type of 3). Item is the Texture2D instance of the item to be drawn (use Main.itemTexture[id of item]), itemSize is the width and height of the item's hitbox
        {
            scale = 1f;
            item = Main.itemTexture[ItemID.GoldenToilet]; ; //this defines the item that this npc will use
            itemSize = 50;
        }

        public override void TownNPCAttackSwing(ref int itemWidth, ref int itemHeight) //  Allows you to determine the width and height of the item this town NPC swings when it attacks, which controls the range of this NPC's swung weapon.
        {
            itemWidth = 16;
            itemHeight = 26;
        }
    }
}