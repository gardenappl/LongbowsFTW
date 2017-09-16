
using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace LongbowsFTW.Items
{
	public class OrichalcumLongbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.AddTranslation(GameCulture.Russian, "Орихалковый длинный лук");
			DisplayName.AddTranslation(GameCulture.Portuguese, "Arco Longo de Oricalco");
		}
		
		public override void SetDefaults()
		{
			item.value = Item.sellPrice(0, 2, 20);
			item.useStyle = 5;
			item.useAnimation = 22;
			item.useTime = 22;
			item.autoReuse = true;
			item.rare = 4;
			item.scale = 1.1f;
			item.width = 14;
			item.height = 40;
			item.UseSound = SoundID.Item5;
			item.damage = 38;
			item.knockBack = 2;
			item.shoot = 1;
			item.shootSpeed = 9.75f;
			item.noMelee = true;
			item.ranged = true;
			item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddIngredient(ItemID.OrichalcumBar, 12);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}