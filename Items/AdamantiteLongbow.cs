
using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace LongbowsFTW.Items
{
	public class AdamantiteLongbow : ModItem
	{
		public override void SetDefaults()
		{
			item.value = Item.sellPrice(0, 2, 40);
			item.useStyle = 5;
			item.useAnimation = 20;
			item.useTime = 20;
			item.autoReuse = true;
			item.rare = 4;
			item.scale = 1.1f;
			item.width = 14;
			item.height = 46;
			item.UseSound = SoundID.Item5;
			item.damage = 40;
			item.knockBack = 2.5f;
			item.shoot = 1;
			item.shootSpeed = 10;
			item.noMelee = true;
			item.ranged = true;
			item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddIngredient(ItemID.AdamantiteBar, 12);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}