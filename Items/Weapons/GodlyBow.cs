using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items.Weapons
{
    public class GodlyBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Godly Bow");
            Tooltip.SetDefault("Tier 6 Bow" + Environment.NewLine + "Explosions linger");  //The (English) text shown below your weapon's name
        }

        public override void SetDefaults()
        {
            item.damage = 120;
            item.ranged = true;
            item.width = 36;
            item.height = 70;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 6;
            item.value = Item.buyPrice(gold: 25);
            item.rare = 11;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("GodlyArrow");
            item.shootSpeed = 16f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GodlyCore", 1);
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}