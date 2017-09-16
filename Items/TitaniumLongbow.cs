
using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace LongbowsFTW.Items
{
	public class TitaniumLongbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.AddTranslation(GameCulture.Russian, "Титановый длинный лук");
			DisplayName.AddTranslation(GameCulture.Portuguese, "Arco Longo de Titânio");
		}
		
		public override void SetDefaults()
		{
			item.value = Item.sellPrice(0, 2, 80);
			item.useStyle = 5;
			item.useAnimation = 19;
			item.useTime = 19;
			item.autoReuse = true;
			item.rare = 4;
			item.scale = 1.1f;
			item.width = 16;
			item.height = 44;
			item.UseSound = SoundID.Item5;
			item.damage = 41;
			item.knockBack = 2.5f;
			item.shoot = 1;
			item.shootSpeed = 10.5f;
			item.noMelee = true;
			item.ranged = true;
			item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddIngredient(ItemID.TitaniumBar, 13);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}