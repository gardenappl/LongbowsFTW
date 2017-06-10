
using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace LongbowsFTW.Items
{
	public class PalladiumLongbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.AddTranslation(GameCulture.Russian, "Палладиевый длинный лук");
		}
		
		public override void SetDefaults()
		{
			item.value = Item.sellPrice(0, 1, 60);
			item.useStyle = 5;
			item.useAnimation = 24;
			item.useTime = 24;
			item.autoReuse = true;
			item.rare = 4;
			item.scale = 1.1f;
			item.width = 14;
			item.height = 40;
			item.UseSound = SoundID.Item5;
			item.damage = 34;
			item.knockBack = 1.75f;
			item.shoot = 1;
			item.shootSpeed = 9.25f;
			item.noMelee = true;
			item.ranged = true;
			item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.Anvils);
			recipe.AddIngredient(ItemID.PalladiumBar, 12);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
