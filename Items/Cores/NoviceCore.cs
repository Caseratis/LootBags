using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items.Cores
{
    public class NoviceCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Novice Core");
            Tooltip.SetDefault("Used in crafting tier 1 gear");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 14;
            item.rare = 0;
            item.maxStack = 99;
            item.value = 1000;
        }
    }
}