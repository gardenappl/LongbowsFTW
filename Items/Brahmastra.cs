
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
		public override void SetDefaults()
		{
			Item.value = Item.sellPrice(0, 4);
			Item.useStyle = 5;
			Item.useAnimation = 19;
			Item.useTime = 19;
			Item.autoReuse = true;
			Item.rare = 4;
			Item.scale = 1.1f;
			Item.width = 14;
			Item.height = 44;
			Item.UseSound = SoundID.Item5;
			Item.damage = 43;
			Item.knockBack = 2.5f;
			Item.shoot = 1;
			Item.shootSpeed = 11;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Ranged;
			Item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddTile(TileID.MythrilAnvil)
				.AddIngredient(ItemID.HallowedBar, 12)
				.Register();
		}
	}
}