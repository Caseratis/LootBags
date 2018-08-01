using System;
using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

public static class Config
{
	public static int LootBag1DropChance = 25;

	public static int LootBag2DropChance = 30;

	public static int LootBag3DropChance = 35;

	public static int LootBag4DropChance = 40;

	public static int LootBag5DropChance = 45;

	public static int LootBag6DropChance = 50;

	public static int DyeBagDropChance = 3;

	public static int LootBag1Cost = 100000;

	public static int LootBag2Cost = 200000;

	public static int LootBag3Cost = 300000;

	public static int LootBag4Cost = 400000;

	public static int LootBag5Cost = 500000;

	public static int LootBag6Cost = 2000000;

	public static bool BuyLootBags = true;

	public static bool AllLootBagsDrop = false;

    public static int Core1DropChance = 20;

    public static int Core2DropChance = 20;

    public static int Core3DropChance = 20;

    public static int Core4DropChance = 20;

    public static int Core5DropChance = 20;

    public static int Core6DropChance = 20;

    public static bool LootBagCrafting = true;

    private static string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "LootBagsConfig.json");

	private static Preferences Configuration = new Preferences(Config.ConfigPath, false, false);

	public static void Load()
	{
		if (!Config.ReadConfig())
		{
			ErrorLogger.Log("Failed to read Loot Bag config file! Recreating config...");
			Config.CreateConfig();
		}
	}

	private static bool ReadConfig()
	{
		bool result;
		if (Config.Configuration.Load())
		{
			Config.Configuration.Get<int>("LootBag1DropChance", ref Config.LootBag1DropChance);
			Config.Configuration.Get<int>("LootBag2DropChance", ref Config.LootBag2DropChance);
			Config.Configuration.Get<int>("LootBag3DropChance", ref Config.LootBag3DropChance);
			Config.Configuration.Get<int>("LootBag4DropChance", ref Config.LootBag4DropChance);
			Config.Configuration.Get<int>("LootBag5DropChance", ref Config.LootBag5DropChance);
			Config.Configuration.Get<int>("LootBag6DropChance", ref Config.LootBag6DropChance);
			Config.Configuration.Get<int>("DyeBagDropChance", ref Config.DyeBagDropChance);
			Config.Configuration.Get<int>("LootBag1Cost", ref Config.LootBag1Cost);
			Config.Configuration.Get<int>("LootBag2Cost", ref Config.LootBag2Cost);
			Config.Configuration.Get<int>("LootBag3Cost", ref Config.LootBag3Cost);
			Config.Configuration.Get<int>("LootBag4Cost", ref Config.LootBag4Cost);
			Config.Configuration.Get<int>("LootBag5Cost", ref Config.LootBag5Cost);
			Config.Configuration.Get<int>("LootBag6Cost", ref Config.LootBag6Cost);
			Config.Configuration.Get<bool>("BuyLootBags", ref Config.BuyLootBags);
			Config.Configuration.Get<bool>("AllLootBagsDrop", ref Config.AllLootBagsDrop);
            Config.Configuration.Get<int>("Core1DropChance", ref Config.Core1DropChance);
            Config.Configuration.Get<int>("Core2DropChance", ref Config.Core2DropChance);
            Config.Configuration.Get<int>("Core3DropChance", ref Config.Core3DropChance);
            Config.Configuration.Get<int>("Core4DropChance", ref Config.Core4DropChance);
            Config.Configuration.Get<int>("Core5DropChance", ref Config.Core5DropChance);
            Config.Configuration.Get<int>("Core6DropChance", ref Config.Core6DropChance);
            Config.Configuration.Get<bool>("LootBagCrafting", ref Config.LootBagCrafting);
            result = true;
		}
		else
		{
			result = false;
		}
		return result;
	}

	private static void CreateConfig()
	{
		Config.Configuration.Clear();
		Config.Configuration.Put("LootBag1DropChance", Config.LootBag1DropChance);
		Config.Configuration.Put("LootBag2DropChance", Config.LootBag2DropChance);
		Config.Configuration.Put("LootBag3DropChance", Config.LootBag3DropChance);
		Config.Configuration.Put("LootBag4DropChance", Config.LootBag4DropChance);
		Config.Configuration.Put("LootBag5DropChance", Config.LootBag5DropChance);
		Config.Configuration.Put("LootBag6DropChance", Config.LootBag6DropChance);
		Config.Configuration.Put("DyeBagDropChance", Config.DyeBagDropChance);
		Config.Configuration.Put("LootBag1DropChance", Config.LootBag1DropChance);
		Config.Configuration.Put("LootBag2DropChance", Config.LootBag2DropChance);
		Config.Configuration.Put("LootBag3DropChance", Config.LootBag3DropChance);
		Config.Configuration.Put("LootBag4DropChance", Config.LootBag4DropChance);
		Config.Configuration.Put("LootBag5DropChance", Config.LootBag5DropChance);
		Config.Configuration.Put("LootBag6DropChance", Config.LootBag6DropChance);
		Config.Configuration.Put("BuyLootBags", Config.BuyLootBags);
		Config.Configuration.Put("AllLootBagsDrop", Config.AllLootBagsDrop);
        Config.Configuration.Put("Core1DropChance", Config.Core1DropChance);
        Config.Configuration.Put("Core2DropChance", Config.Core2DropChance);
        Config.Configuration.Put("Core3DropChance", Config.Core3DropChance);
        Config.Configuration.Put("Core4DropChance", Config.Core4DropChance);
        Config.Configuration.Put("Core5DropChance", Config.Core5DropChance);
        Config.Configuration.Put("Core6DropChance", Config.Core6DropChance);
        Config.Configuration.Put("LootBagCrafting", Config.LootBagCrafting);
        Config.Configuration.Save(true);
	}
}
