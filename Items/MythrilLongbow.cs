using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace LongbowsFTW.Items
{
	public class MythrilLongbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.AddTranslation(GameCulture.Russian, "Мифриловый длинный лук");
			DisplayName.AddTranslation(GameCulture.Portuguese, "Arco Longo de Mithril");
		}
		
		public override void SetDefaults()
		{
			item.value = Item.sellPrice(0, 1, 80);
			item.useStyle = 5;
			item.useAnimation = 23;
			item.useTime = 23;
			item.autoReuse = true;
			item.rare = 4;
			item.scale = 1.1f;
			item.width = 14;
			item.height = 40;
			item.UseSound = SoundID.Item5;
			item.damage = 36;
			item.knockBack = 2;
			item.shoot = 1;
			item.shootSpeed = 9.5f;
			item.noMelee = true;
			item.ranged = true;
			item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddIngredient(ItemID.MythrilBar, 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
