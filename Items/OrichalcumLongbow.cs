
using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace LongbowsFTW.Items
{
	public class OrichalcumLongbow : ModItem
	{
		public override void SetDefaults()
		{
			Item.value = Item.sellPrice(0, 2, 20);
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 22;
			Item.useTime = 22;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.LightRed;
			Item.scale = 1.1f;
			Item.width = 14;
			Item.height = 40;
			Item.UseSound = SoundID.Item5;
			Item.damage = 38;
			Item.knockBack = 2;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 9.75f;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Ranged;
			Item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddTile(TileID.MythrilAnvil)
				.AddIngredient(ItemID.OrichalcumBar, 12)
				.Register();
		}
	}
}