﻿
using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace LongbowsFTW.Items
{
	public class CobaltLongbow : ModItem
	{
		public override void SetDefaults()
		{
			Item.value = Item.sellPrice(0, 1, 20);
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 25;
			Item.useTime = 25;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.LightRed;
			Item.width = 12;
			Item.height = 44;
			Item.UseSound = SoundID.Item5;
			Item.damage = 32;
			Item.knockBack = 1.5f;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 9;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Ranged;
			Item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddTile(TileID.Anvils)
				.AddIngredient(ItemID.CobaltBar, 10)
				.Register();
		}
	}
}
