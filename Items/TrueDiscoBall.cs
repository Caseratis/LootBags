using LootBags;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items
{
    public class TrueDiscoBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Disco Ball");
            Tooltip.SetDefault("Makes you moon walk" + Environment.NewLine + "Hiding the accessory disables the effect");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
            item.value = 1;
            item.rare = 11;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (hideVisual == false)
            {
                MyPlayer.MoonWalk = true;
            }
        }
    }
}
