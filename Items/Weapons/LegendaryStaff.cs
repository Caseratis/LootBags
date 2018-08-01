using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags.Items.Weapons
{
    public class LegendaryStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Legendary Staff");
            Tooltip.SetDefault("Tier 5 Staff" + Environment.NewLine + "Projectile Trail homes");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 100;
            item.magic = true;
            item.mana = 15;
            item.width = 58;
            item.height = 58;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 6;
            item.value = Item.buyPrice(gold: 20);
            item.rare = 9;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("LegendaryStaffProj");
            item.shootSpeed = 16f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "LegendaryCore", 1);
            recipe.AddIngredient(ItemID.BeetleHusk, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}