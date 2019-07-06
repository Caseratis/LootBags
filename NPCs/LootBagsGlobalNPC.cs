using System;
using Terraria;
using Terraria.ModLoader;

namespace LootBags.NPCs
{
	public class LootBagsGlobalNPC : GlobalNPC
	{


        

        public override void NPCLoot(NPC npc)
		{

			if (!LootBags.config.AllLootBagsDrop)
			{
				if (npc.lifeMax > 5 && npc.value > 0f && NPC.downedMoonlord)
				{
					Random random = new Random();
					int num = Main.rand.Next(0, LootBags.config.LootBag6DropChance);
					if (num == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LootBag6"), 1, false, 0, false, false);
					}
				}
				else if (npc.lifeMax > 5 && npc.value > 0f && NPC.downedGolemBoss)
				{
					Random random = new Random();
					int num2 = Main.rand.Next(0, LootBags.config.LootBag5DropChance);
					if (num2 == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LootBag5"), 1, false, 0, false, false);
					}
				}
				else if (npc.lifeMax > 5 && npc.value > 0f && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
				{
					Random random = new Random();
					int num3 = Main.rand.Next(0, LootBags.config.LootBag4DropChance);
					if (num3 == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LootBag4"), 1, false, 0, false, false);
					}
				}
				else if (npc.lifeMax > 5 && npc.value > 0f && Main.hardMode)
				{
					Random random = new Random();
					int num4 = Main.rand.Next(0, LootBags.config.LootBag3DropChance);
					if (num4 == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LootBag3"), 1, false, 0, false, false);
					}
				}
				else if (npc.lifeMax > 5 && npc.value > 0f && NPC.downedBoss3)
				{
					Random random = new Random();
					int num5 = Main.rand.Next(0, LootBags.config.LootBag2DropChance);
					if (num5 == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LootBag2"), 1, false, 0, false, false);
					}
				}
				else if (npc.lifeMax > 5 && npc.value > 0f)
				{
					Random random = new Random();
					int num6 = Main.rand.Next(0, LootBags.config.LootBag1DropChance);
					if (num6 == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LootBag1"), 1, false, 0, false, false);
					}
				}
			}
			else if (LootBags.config.AllLootBagsDrop)
			{
				if (npc.lifeMax > 5 && npc.value > 0f && NPC.downedMoonlord)
				{
					Random random = new Random();
					int num = Main.rand.Next(0, LootBags.config.LootBag6DropChance);
					if (num == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LootBag6"), 1, false, 0, false, false);
					}
				}
				if (npc.lifeMax > 5 && npc.value > 0f && NPC.downedGolemBoss)
				{
					Random random = new Random();
					int num2 = Main.rand.Next(0, LootBags.config.LootBag5DropChance);
					if (num2 == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LootBag5"), 1, false, 0, false, false);
					}
				}
				if (npc.lifeMax > 5 && npc.value > 0f && NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
				{
					Random random = new Random();
					int num3 = Main.rand.Next(0, LootBags.config.LootBag4DropChance);
					if (num3 == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LootBag4"), 1, false, 0, false, false);
					}
				}
				if (npc.lifeMax > 5 && npc.value > 0f && Main.hardMode)
				{
					Random random = new Random();
					int num4 = Main.rand.Next(0, LootBags.config.LootBag3DropChance);
					if (num4 == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LootBag3"), 1, false, 0, false, false);
					}
				}
				if (npc.lifeMax > 5 && npc.value > 0f && NPC.downedBoss3)
				{
					Random random = new Random();
					int num5 = Main.rand.Next(0, LootBags.config.LootBag2DropChance);
					if (num5 == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LootBag2"), 1, false, 0, false, false);
					}
				}
				if (npc.lifeMax > 5 && npc.value > 0f)
				{
					Random random = new Random();
					int num6 = Main.rand.Next(0, LootBags.config.LootBag1DropChance);
					if (num6 == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LootBag1"), 1, false, 0, false, false);
					}
				}
			}
			if (npc.type == 217)
			{
				Random random = new Random();
				int num7 = Main.rand.Next(0, LootBags.config.DyeBagDropChance);
				if (num7 == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DyeLootBag"), 1, false, 0, false, false);
				}
			}
			if (npc.type == 218)
			{
				Random random = new Random();
				int num7 = Main.rand.Next(0, LootBags.config.DyeBagDropChance);
				if (num7 == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DyeLootBag"), 1, false, 0, false, false);
				}
			}
			if (npc.type == 219)
			{
				Random random = new Random();
				int num7 = Main.rand.Next(0, LootBags.config.DyeBagDropChance);
				if (num7 == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DyeLootBag"), 1, false, 0, false, false);
				}
			}
			if (npc.type == 220)
			{
				Random random = new Random();
				int num7 = Main.rand.Next(0, LootBags.config.DyeBagDropChance);
				if (num7 == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DyeLootBag"), 1, false, 0, false, false);
				}
			}
			if (npc.type == 221)
			{
				Random random = new Random();
				int num7 = Main.rand.Next(0, LootBags.config.DyeBagDropChance);
				if (num7 == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DyeLootBag"), 1, false, 0, false, false);
				}
			}
		}
	}
}
