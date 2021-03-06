using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LootBags
{
    class LootBags : Mod
    {
        public static Dictionary<string, LootNode> lootTables = new Dictionary<string, LootNode>();
        internal static Config config;

        public LootBags()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };

            LootBags.AddBuiltinTables();
        }

        public static void AddTable(string name, int type, LootNode[] entries)
        {
            LootBags.lootTables[name] = new LootNode(type).AddChildren(entries);
        }

        public static void AddTable(string name, LootNode[] entries)
        {
            LootBags.AddTable(name, new LootNode[] { });
        }

        public static void AddTable(string name)
        {
            LootBags.AddTable(name, new LootNode[] { });
        }

        private static void AddBuiltinTables()
        {
            LootBags.AddTable("LootBagTable", 1, BuiltinTables.BuildLootBagTable());
        }
        
        public override object Call(params object[] args)
        {
            LootNode table;
            Loot loot;

                    table = LootBags.lootTables["LootBagTable"];
                    loot = new Loot((double) args[0], (int) args[1], (int) args[2], (int) args[3], (int) args[4]);
                    table.AddChildren(loot);
            

            return this;
        }
        

        public override void Unload()
        {
            config = null;
        }

        public override void PostSetupContent()
        {
            Mod censusMod = ModLoader.GetMod("Census");
            if (censusMod != null)
            {
                censusMod.Call("TownNPCCondition", NPCType("Loot Bag Dealer"), "Eye of Cthulhu is defeated");
            }
        }
    }
}

