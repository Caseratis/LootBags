using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items.Weapons
{
    public class GodlyStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Godly Staff");
            Tooltip.SetDefault("Tier 6 Staff" + Environment.NewLine + "Explosions linger");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 120;
            item.magic = true;
            item.mana = 15;
            item.width = 58;
            item.height = 58;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 6;
            item.value = Item.buyPrice(gold: 25);
            item.rare = 11;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("GodlyStaffProj");
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