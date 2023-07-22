
using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace LongbowsFTW.Items
{
	public class AdamantiteLongbow : ModItem
	{
		public override void SetDefaults()
		{
			Item.value = Item.sellPrice(0, 2, 40);
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 20;
			Item.useTime = 20;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.LightRed;
			Item.scale = 1.1f;
			Item.width = 14;
			Item.height = 46;
			Item.UseSound = SoundID.Item5;
			Item.damage = 40;
			Item.knockBack = 2.5f;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 10;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Ranged;
			Item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddTile(TileID.Anvils)
				.AddIngredient(ItemID.AdamantiteBar, 12)
				.Register();
		}
	}
}