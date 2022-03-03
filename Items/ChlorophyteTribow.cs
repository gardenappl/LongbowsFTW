
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;

namespace LongbowsFTW.Items
{
	public class ChlorophyteTribow : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			Item.value = Item.sellPrice(0, 4, 80);
			Item.useStyle = 5;
			Item.useAnimation = 19;
			Item.useTime = 19;
			Item.autoReuse = true;
			Item.rare = 7;
			Item.scale = 1.1f;
			Item.width = 14;
			Item.height = 42;
			Item.UseSound = SoundID.Item5;
			Item.damage = 34;
			Item.knockBack = 2.75f;
			Item.shoot = 1;
			Item.shootSpeed = 11.5f;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Ranged;
			Item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddTile(TileID.MythrilAnvil)
				.AddIngredient(ItemID.ChlorophyteBar, 12)
				.Register();
		}
		
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source,  Vector2 position, Vector2 velocity, int type, int damage, float knockBack)
		{
			int amount = Main.rand.Next(2, 5);
			for(int i = 0; i < amount; i++)
			{
				var shootPos = position + Main.rand.NextVector2Square(2f, 2f);
				var shootVel = velocity + Main.rand.NextVector2Square(-1.5f, 1.5f);
				int proj = Projectile.NewProjectile(source, shootPos, shootVel, type, damage, knockBack, player.whoAmI);
				Main.projectile[proj].noDropItem = true;
			}
			return false;
		}
	}
}