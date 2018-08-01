using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items.Cores
{
    public class EpicCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Epic Core");
            Tooltip.SetDefault("Used in crafting tier 4 gear");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.rare = 5;
            item.maxStack = 99;
            item.value = 1000000;
        }
    }
}