using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items.Cores
{
    public class AdeptCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Adept Core");
            Tooltip.SetDefault("Used in crafting tier 3 gear");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.rare = 4;
            item.maxStack = 99;
            item.value = 100000;
        }
    }
}