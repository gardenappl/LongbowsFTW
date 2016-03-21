
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace LongbowsFTW.Items
{
	public class CobaltLongbow : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Cobalt Longbow";
			item.value = Item.sellPrice(0, 1, 20);
			item.useStyle = 5;
			item.useAnimation = 25;
			item.useTime = 25;
			item.autoReuse = true;
			item.rare = 4;
			item.width = 12;
			item.height = 44;
			item.useSound = 5;
			item.damage = 32;
			item.knockBack = 1.5f;
			item.shoot = 1;
			item.shootSpeed = 9;
			item.noMelee = true;
			item.ranged = true;
			item.useAmmo = 1;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.Anvils);
			recipe.AddIngredient(ItemID.CobaltBar, 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
