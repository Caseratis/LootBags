using System;
using Terraria;
using Terraria.ModLoader;

namespace LootBags.Items
{
    public class CaseratisBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Caseratis' Bag of Mysteries");
            Tooltip.SetDefault("Right click to open" + Environment.NewLine + "Not even the mod developer knows what's inside");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 30;
            item.rare = 11;
            item.maxStack = 999;
            item.value = 1;
            item.expert = true;
            item.expertOnly = false;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            int num = new Random().Next(1, ItemLoader.ItemCount);
            player.QuickSpawnItem(num, 1);
        }
    }
}
