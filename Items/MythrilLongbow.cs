﻿using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace LongbowsFTW.Items
{
	public class MythrilLongbow : ModItem
	{
		public override void SetDefaults()
		{
			Item.value = Item.sellPrice(0, 1, 80);
			Item.useStyle = 5;
			Item.useAnimation = 23;
			Item.useTime = 23;
			Item.autoReuse = true;
			Item.rare = 4;
			Item.scale = 1.1f;
			Item.width = 14;
			Item.height = 40;
			Item.UseSound = SoundID.Item5;
			Item.damage = 36;
			Item.knockBack = 2;
			Item.shoot = 1;
			Item.shootSpeed = 9.5f;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Ranged;
			Item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddTile(TileID.MythrilAnvil)
				.AddIngredient(ItemID.MythrilBar, 12)
				.Register();
		}
	}
}
