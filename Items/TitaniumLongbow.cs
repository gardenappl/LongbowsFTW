
using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace LongbowsFTW.Items
{
	public class TitaniumLongbow : ModItem
	{
		public override void SetDefaults()
		{
			Item.value = Item.sellPrice(0, 2, 80);
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 19;
			Item.useTime = 19;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.LightRed;
			Item.scale = 1.1f;
			Item.width = 16;
			Item.height = 44;
			Item.UseSound = SoundID.Item5;
			Item.damage = 41;
			Item.knockBack = 2.5f;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 10.5f;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Ranged;
			Item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddTile(TileID.MythrilAnvil)
				.AddIngredient(ItemID.TitaniumBar, 13)
				.Register();
		}
	}
}