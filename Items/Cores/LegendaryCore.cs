using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items.Cores
{
    public class LegendaryCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Legendary Core");
            Tooltip.SetDefault("Used in crafting tier 5 gear");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.rare = 9;
            item.maxStack = 99;
            item.value = 10000000;
        }
    }
}