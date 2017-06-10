
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace LongbowsFTW.Items
{
	public class Brahmastra : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Artemis' Bow");
			DisplayName.AddTranslation(GameCulture.Russian, "Лук Артемиды");
		}
		
		public override void SetDefaults()
		{
			item.value = Item.sellPrice(0, 4);
			item.useStyle = 5;
			item.useAnimation = 19;
			item.useTime = 19;
			item.autoReuse = true;
			item.rare = 4;
			item.scale = 1.1f;
			item.width = 14;
			item.height = 44;
			item.UseSound = SoundID.Item5;
			item.damage = 43;
			item.knockBack = 2.5f;
			item.shoot = 1;
			item.shootSpeed = 11;
			item.noMelee = true;
			item.ranged = true;
			item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddIngredient(ItemID.HallowedBar, 12);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}