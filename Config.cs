using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace LootBags
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Tier 1 Loot Bag Drop Chance")]
        [DefaultValue(25)]
        public int LootBag1DropChance { get; set; }

        [Label("Tier 2 Loot Bag Drop Chance")]
        [DefaultValue(30)]
        public int LootBag2DropChance { get; set; }

        [Label("Tier 3 Loot Bag Drop Chance")]
        [DefaultValue(35)]
        public int LootBag3DropChance { get; set; }

        [Label("Tier 4 Loot Bag Drop Chance")]
        [DefaultValue(40)]
        public int LootBag4DropChance { get; set; }

        [Label("Tier 5 Loot Bag Drop Chance")]
        [DefaultValue(45)]
        public int LootBag5DropChance { get; set; }

        [Label("Tier 6 Loot Bag Drop Chance")]
        [DefaultValue(50)]
        public int LootBag6DropChance { get; set; }

        [Label("Dye Loot Bag Drop Chance")]
        [DefaultValue(3)]
        public int DyeBagDropChance { get; set; }

        [Label("Tier 1 Loot Bag Cost")]
        [DefaultValue(100000)]
        public int LootBag1Cost { get; set; }

        [Label("Tier 2 Loot Bag Cost")]
        [DefaultValue(200000)]
        public int LootBag2Cost { get; set; }

        [Label("Tier 3 Loot Bag Cost")]
        [DefaultValue(300000)]
        public int LootBag3Cost { get; set; }

        [Label("Tier 4 Loot Bag Cost")]
        [DefaultValue(400000)]
        public int LootBag4Cost { get; set; }

        [Label("Tier 5 Loot Bag Cost")]
        [DefaultValue(500000)]
        public int LootBag5Cost { get; set; }

        [Label("Tier 6 Loot Bag Cost")]
        [DefaultValue(2000000)]
        public int LootBag6Cost { get; set; }

        [Label("Tier 1 Core Drop Chance")]
        [DefaultValue(20)]
        public int Core1DropChance { get; set; }

        [Label("Tier 2 Core Drop Chance")]
        [DefaultValue(20)]
        public int Core2DropChance { get; set; }

        [Label("Tier 3 Core Drop Chance")]
        [DefaultValue(20)]
        public int Core3DropChance { get; set; }

        [Label("Tier 4 Core Drop Chance")]
        [DefaultValue(20)]
        public int Core4DropChance { get; set; }

        [Label("Tier 5 Core Drop Chance")]
        [DefaultValue(20)]
        public int Core5DropChance { get; set; }

        [Label("Tier 6 Core Drop Chance")]
        [DefaultValue(20)]
        public int Core6DropChance { get; set; }

        [Label("Can loot bags be bought?")]
        [Tooltip("Reload Required")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool BuyLootBags { get; set; }

        [Label("Do all loot bag tiers always drop?")]
        [Tooltip("(They are still affected by progression)")]
        [DefaultValue(false)]
        public bool AllLootBagsDrop { get; set; }

        [Label("Allow crafting previous loot bag tiers?")]
        [Tooltip("Reload Required")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool LootBagCrafting { get; set; }

        public override void OnLoaded()
        {
            LootBags.config = this;
        }
    }
}
