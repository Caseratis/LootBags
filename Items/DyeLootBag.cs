using System;
using Terraria;
using Terraria.ModLoader;

namespace LootBags.Items
{
	public class DyeLootBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dye Loot Bag");
			Tooltip.SetDefault("Right click to open" + Environment.NewLine + "'I wonder what's inside'");
		}

		public override void SetDefaults()
		{
            item.width = 20;
            item.height = 28;
            item.rare = 0;
            item.maxStack = 999;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			if (NPC.downedMoonlord)
			{
				int num = new Random().Next(0, 33);
				if (num == 0)
				{
					player.QuickSpawnItem(3040, 3);
				}
				if (num == 1)
				{
					player.QuickSpawnItem(3560, 3);
				}
				if (num == 2)
				{
					player.QuickSpawnItem(3028, 3);
				}
				if (num == 3)
				{
					player.QuickSpawnItem(3561, 3);
				}
				if (num == 4)
				{
					player.QuickSpawnItem(3041, 3);
				}
				if (num == 5)
				{
					player.QuickSpawnItem(3025, 3);
				}
				if (num == 6)
				{
					player.QuickSpawnItem(3190, 3);
				}
				if (num == 7)
				{
					player.QuickSpawnItem(3027, 3);
				}
				if (num == 8)
				{
					player.QuickSpawnItem(3026, 3);
				}
				if (num == 9)
				{
					player.QuickSpawnItem(3554, 3);
				}
				if (num == 10)
				{
					player.QuickSpawnItem(3553, 3);
				}
				if (num == 11)
				{
					player.QuickSpawnItem(3555, 3);
				}
				if (num == 12)
				{
					player.QuickSpawnItem(2872, 3);
				}
				if (num == 13)
				{
					player.QuickSpawnItem(2871, 3);
				}
				if (num == 14)
				{
					player.QuickSpawnItem(3534, 3);
				}
				if (num == 15)
				{
					player.QuickSpawnItem(3039, 3);
				}
				if (num == 16)
				{
					player.QuickSpawnItem(3038, 3);
				}
				if (num == 17)
				{
					player.QuickSpawnItem(3597, 3);
				}
				if (num == 18)
				{
					player.QuickSpawnItem(3600, 3);
				}
				if (num == 19)
				{
					player.QuickSpawnItem(3598, 3);
				}
				if (num == 20)
				{
					player.QuickSpawnItem(3042, 3);
				}
				if (num == 21)
				{
					player.QuickSpawnItem(3533, 3);
				}
				if (num == 22)
				{
					player.QuickSpawnItem(2883, 3);
				}
				if (num == 23)
				{
					player.QuickSpawnItem(2869, 3);
				}
				if (num == 24)
				{
					player.QuickSpawnItem(2870, 3);
				}
				if (num == 25)
				{
					player.QuickSpawnItem(2873, 3);
				}
				if (num == 26)
				{
					player.QuickSpawnItem(2878, 3);
				}
				if (num == 27)
				{
					player.QuickSpawnItem(2879, 3);
				}
				if (num == 28)
				{
					player.QuickSpawnItem(2884, 3);
				}
				if (num == 29)
				{
					player.QuickSpawnItem(2885, 3);
				}
				if (num == 30)
				{
					player.QuickSpawnItem(2864, 3);
				}
				if (num == 31)
				{
					player.QuickSpawnItem(3556, 3);
				}
				if (num == 32)
				{
					player.QuickSpawnItem(3024, 3);
				}
			}
			else if (NPC.downedMartians)
			{
				int num = new Random().Next(0, 32);
				if (num == 0)
				{
					player.QuickSpawnItem(3040, 3);
				}
				if (num == 1)
				{
					player.QuickSpawnItem(3560, 3);
				}
				if (num == 2)
				{
					player.QuickSpawnItem(3028, 3);
				}
				if (num == 3)
				{
					player.QuickSpawnItem(3561, 3);
				}
				if (num == 4)
				{
					player.QuickSpawnItem(3041, 3);
				}
				if (num == 5)
				{
					player.QuickSpawnItem(3025, 3);
				}
				if (num == 6)
				{
					player.QuickSpawnItem(3190, 3);
				}
				if (num == 7)
				{
					player.QuickSpawnItem(3027, 3);
				}
				if (num == 8)
				{
					player.QuickSpawnItem(3026, 3);
				}
				if (num == 9)
				{
					player.QuickSpawnItem(3554, 3);
				}
				if (num == 10)
				{
					player.QuickSpawnItem(3553, 3);
				}
				if (num == 11)
				{
					player.QuickSpawnItem(3555, 3);
				}
				if (num == 12)
				{
					player.QuickSpawnItem(2872, 3);
				}
				if (num == 13)
				{
					player.QuickSpawnItem(2871, 3);
				}
				if (num == 14)
				{
					player.QuickSpawnItem(3534, 3);
				}
				if (num == 15)
				{
					player.QuickSpawnItem(3039, 3);
				}
				if (num == 16)
				{
					player.QuickSpawnItem(3038, 3);
				}
				if (num == 17)
				{
					player.QuickSpawnItem(3597, 3);
				}
				if (num == 18)
				{
					player.QuickSpawnItem(3600, 3);
				}
				if (num == 19)
				{
					player.QuickSpawnItem(3598, 3);
				}
				if (num == 20)
				{
					player.QuickSpawnItem(3042, 3);
				}
				if (num == 21)
				{
					player.QuickSpawnItem(3533, 3);
				}
				if (num == 22)
				{
					player.QuickSpawnItem(2883, 3);
				}
				if (num == 23)
				{
					player.QuickSpawnItem(2869, 3);
				}
				if (num == 24)
				{
					player.QuickSpawnItem(2870, 3);
				}
				if (num == 25)
				{
					player.QuickSpawnItem(2873, 3);
				}
				if (num == 26)
				{
					player.QuickSpawnItem(2878, 3);
				}
				if (num == 27)
				{
					player.QuickSpawnItem(2879, 3);
				}
				if (num == 28)
				{
					player.QuickSpawnItem(2884, 3);
				}
				if (num == 29)
				{
					player.QuickSpawnItem(2885, 3);
				}
				if (num == 30)
				{
					player.QuickSpawnItem(2864, 3);
				}
				if (num == 31)
				{
					player.QuickSpawnItem(3556, 3);
				}
			}
			else if (NPC.downedPlantBoss)
			{
				int num = new Random().Next(0, 30);
				if (num == 0)
				{
					player.QuickSpawnItem(3040, 3);
				}
				if (num == 1)
				{
					player.QuickSpawnItem(3560, 3);
				}
				if (num == 2)
				{
					player.QuickSpawnItem(3028, 3);
				}
				if (num == 3)
				{
					player.QuickSpawnItem(3561, 3);
				}
				if (num == 4)
				{
					player.QuickSpawnItem(3041, 3);
				}
				if (num == 5)
				{
					player.QuickSpawnItem(3025, 3);
				}
				if (num == 6)
				{
					player.QuickSpawnItem(3190, 3);
				}
				if (num == 7)
				{
					player.QuickSpawnItem(3027, 3);
				}
				if (num == 8)
				{
					player.QuickSpawnItem(3026, 3);
				}
				if (num == 9)
				{
					player.QuickSpawnItem(3554, 3);
				}
				if (num == 10)
				{
					player.QuickSpawnItem(3553, 3);
				}
				if (num == 11)
				{
					player.QuickSpawnItem(3555, 3);
				}
				if (num == 12)
				{
					player.QuickSpawnItem(2872, 3);
				}
				if (num == 13)
				{
					player.QuickSpawnItem(2871, 3);
				}
				if (num == 14)
				{
					player.QuickSpawnItem(3534, 3);
				}
				if (num == 15)
				{
					player.QuickSpawnItem(3039, 3);
				}
				if (num == 16)
				{
					player.QuickSpawnItem(3038, 3);
				}
				if (num == 17)
				{
					player.QuickSpawnItem(3597, 3);
				}
				if (num == 18)
				{
					player.QuickSpawnItem(3600, 3);
				}
				if (num == 19)
				{
					player.QuickSpawnItem(3598, 3);
				}
				if (num == 20)
				{
					player.QuickSpawnItem(3042, 3);
				}
				if (num == 21)
				{
					player.QuickSpawnItem(3533, 3);
				}
				if (num == 22)
				{
					player.QuickSpawnItem(2883, 3);
				}
				if (num == 23)
				{
					player.QuickSpawnItem(2869, 3);
				}
				if (num == 24)
				{
					player.QuickSpawnItem(2870, 3);
				}
				if (num == 25)
				{
					player.QuickSpawnItem(2873, 3);
				}
				if (num == 26)
				{
					player.QuickSpawnItem(2878, 3);
				}
				if (num == 27)
				{
					player.QuickSpawnItem(2879, 3);
				}
				if (num == 28)
				{
					player.QuickSpawnItem(2884, 3);
				}
				if (num == 29)
				{
					player.QuickSpawnItem(2885, 3);
				}
			}
			else if (NPC.downedMechBossAny)
			{
				int num = new Random().Next(0, 26);
				if (num == 0)
				{
					player.QuickSpawnItem(3040, 3);
				}
				if (num == 1)
				{
					player.QuickSpawnItem(3560, 3);
				}
				if (num == 2)
				{
					player.QuickSpawnItem(3028, 3);
				}
				if (num == 3)
				{
					player.QuickSpawnItem(3561, 3);
				}
				if (num == 4)
				{
					player.QuickSpawnItem(3041, 3);
				}
				if (num == 5)
				{
					player.QuickSpawnItem(3025, 3);
				}
				if (num == 6)
				{
					player.QuickSpawnItem(3190, 3);
				}
				if (num == 7)
				{
					player.QuickSpawnItem(3027, 3);
				}
				if (num == 8)
				{
					player.QuickSpawnItem(3026, 3);
				}
				if (num == 9)
				{
					player.QuickSpawnItem(3554, 3);
				}
				if (num == 10)
				{
					player.QuickSpawnItem(3553, 3);
				}
				if (num == 11)
				{
					player.QuickSpawnItem(3555, 3);
				}
				if (num == 12)
				{
					player.QuickSpawnItem(2872, 3);
				}
				if (num == 13)
				{
					player.QuickSpawnItem(2871, 3);
				}
				if (num == 14)
				{
					player.QuickSpawnItem(3534, 3);
				}
				if (num == 15)
				{
					player.QuickSpawnItem(3039, 3);
				}
				if (num == 16)
				{
					player.QuickSpawnItem(3038, 3);
				}
				if (num == 17)
				{
					player.QuickSpawnItem(3597, 3);
				}
				if (num == 18)
				{
					player.QuickSpawnItem(3600, 3);
				}
				if (num == 19)
				{
					player.QuickSpawnItem(3598, 3);
				}
				if (num == 20)
				{
					player.QuickSpawnItem(3042, 3);
				}
				if (num == 21)
				{
					player.QuickSpawnItem(3533, 3);
				}
				if (num == 22)
				{
					player.QuickSpawnItem(2883, 3);
				}
				if (num == 23)
				{
					player.QuickSpawnItem(2869, 3);
				}
				if (num == 24)
				{
					player.QuickSpawnItem(2870, 3);
				}
				if (num == 25)
				{
					player.QuickSpawnItem(2873, 3);
				}
			}
			else if (Main.hardMode)
			{
				int num = new Random().Next(0, 22);
				if (num == 0)
				{
					player.QuickSpawnItem(3040, 3);
				}
				if (num == 1)
				{
					player.QuickSpawnItem(3560, 3);
				}
				if (num == 2)
				{
					player.QuickSpawnItem(3028, 3);
				}
				if (num == 3)
				{
					player.QuickSpawnItem(3561, 3);
				}
				if (num == 4)
				{
					player.QuickSpawnItem(3041, 3);
				}
				if (num == 5)
				{
					player.QuickSpawnItem(3025, 3);
				}
				if (num == 6)
				{
					player.QuickSpawnItem(3190, 3);
				}
				if (num == 7)
				{
					player.QuickSpawnItem(3027, 3);
				}
				if (num == 8)
				{
					player.QuickSpawnItem(3026, 3);
				}
				if (num == 9)
				{
					player.QuickSpawnItem(3554, 3);
				}
				if (num == 10)
				{
					player.QuickSpawnItem(3553, 3);
				}
				if (num == 11)
				{
					player.QuickSpawnItem(3555, 3);
				}
				if (num == 12)
				{
					player.QuickSpawnItem(2872, 3);
				}
				if (num == 13)
				{
					player.QuickSpawnItem(2871, 3);
				}
				if (num == 14)
				{
					player.QuickSpawnItem(3534, 3);
				}
				if (num == 15)
				{
					player.QuickSpawnItem(3039, 3);
				}
				if (num == 16)
				{
					player.QuickSpawnItem(3038, 3);
				}
				if (num == 17)
				{
					player.QuickSpawnItem(3597, 3);
				}
				if (num == 18)
				{
					player.QuickSpawnItem(3600, 3);
				}
				if (num == 19)
				{
					player.QuickSpawnItem(3598, 3);
				}
				if (num == 20)
				{
					player.QuickSpawnItem(3042, 3);
				}
				if (num == 21)
				{
					player.QuickSpawnItem(3533, 3);
				}
			}
			else
			{
				int num = new Random().Next(0, 15);
				if (num == 0)
				{
					player.QuickSpawnItem(3040, 3);
				}
				if (num == 1)
				{
					player.QuickSpawnItem(3560, 3);
				}
				if (num == 2)
				{
					player.QuickSpawnItem(3028, 3);
				}
				if (num == 3)
				{
					player.QuickSpawnItem(3561, 3);
				}
				if (num == 4)
				{
					player.QuickSpawnItem(3041, 3);
				}
				if (num == 5)
				{
					player.QuickSpawnItem(3025, 3);
				}
				if (num == 6)
				{
					player.QuickSpawnItem(3190, 3);
				}
				if (num == 7)
				{
					player.QuickSpawnItem(3027, 3);
				}
				if (num == 8)
				{
					player.QuickSpawnItem(3026, 3);
				}
				if (num == 9)
				{
					player.QuickSpawnItem(3554, 3);
				}
				if (num == 10)
				{
					player.QuickSpawnItem(3553, 3);
				}
				if (num == 11)
				{
					player.QuickSpawnItem(3555, 3);
				}
				if (num == 12)
				{
					player.QuickSpawnItem(2872, 3);
				}
				if (num == 13)
				{
					player.QuickSpawnItem(2871, 3);
				}
				if (num == 14)
				{
					player.QuickSpawnItem(3534, 3);
				}
			}
		}
	}
}
