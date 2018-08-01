using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items
{
	public class MagicClock : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Clock");
			Tooltip.SetDefault("Changes the time");
		}

		public override void SetDefaults()
		{
            item.noMelee = true;
            item.width = 66;
            item.height = 66;
            item.useTime = 39;
            item.useAnimation = 39;
            item.useStyle = 1;
            item.knockBack = 6f;
            item.value = 100;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.mana = 20;
            item.scale = 0.5f;
		}

		public override bool UseItem(Player player)
		{
			Main.dayTime = !Main.dayTime;
			return true;
		}
	}
}
