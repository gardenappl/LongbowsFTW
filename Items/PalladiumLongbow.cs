
using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace LongbowsFTW.Items
{
	public class PalladiumLongbow : ModItem
	{
		public override void SetDefaults()
		{
			Item.value = Item.sellPrice(0, 1, 60);
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 24;
			Item.useTime = 24;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.LightRed;
			Item.scale = 1.1f;
			Item.width = 14;
			Item.height = 40;
			Item.UseSound = SoundID.Item5;
			Item.damage = 34;
			Item.knockBack = 1.75f;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 9.25f;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Ranged;
			Item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddTile(TileID.MythrilAnvil)
				.AddIngredient(ItemID.PalladiumBar, 12)
				.Register();
		}
	}
}
