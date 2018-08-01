using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items.Cores
{
    public class ApprenticeCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Apprentice Core");
            Tooltip.SetDefault("Used in crafting tier 2 gear");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 18;
            item.rare = 3;
            item.maxStack = 99;
            item.value = 10000;
        }
    }
}