
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace LongbowsFTW.Items
{
	public class TitaniumLongbow : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Titanium Longbow";
			item.value = Item.sellPrice(0, 2, 80);
			item.useStyle = 5;
			item.useAnimation = 19;
			item.useTime = 19;
			item.autoReuse = true;
			item.rare = 4;
			item.scale = 1.1f;
			item.width = 16;
			item.height = 44;
			item.useSound = 5;
			item.damage = 41;
			item.knockBack = 2.5f;
			item.shoot = 1;
			item.shootSpeed = 10.5f;
			item.noMelee = true;
			item.ranged = true;
			item.useAmmo = 1;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddIngredient(ItemID.TitaniumBar, 13);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}