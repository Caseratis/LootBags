using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items.Cores
{
    public class GodlyCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Godly Core");
            Tooltip.SetDefault("Used in crafting tier 6 gear");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.rare = 9;
            item.maxStack = 99;
            item.value = 100000000;
        }
    }
}