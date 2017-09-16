
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace LongbowsFTW.Items
{
	public class ChlorophyteTribow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.AddTranslation(GameCulture.Russian, "Хлорофитовый трелук");
			DisplayName.AddTranslation(GameCulture.Portuguese, "Triarco de Clorofita");
		}
		
		public override void SetDefaults()
		{
			item.value = Item.sellPrice(0, 4, 80);
			item.useStyle = 5;
			item.useAnimation = 19;
			item.useTime = 19;
			item.autoReuse = true;
			item.rare = 7;
			item.scale = 1.1f;
			item.width = 14;
			item.height = 42;
			item.UseSound = SoundID.Item5;
			item.damage = 34;
			item.knockBack = 2.75f;
			item.shoot = 1;
			item.shootSpeed = 11.5f;
			item.noMelee = true;
			item.ranged = true;
			item.useAmmo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int amount = Main.rand.Next(2, 5);
			for(int i = 0; i < amount; i++)
			{
				var shootPos = position + Main.rand.NextVector2Square(2f, 2f);
				var shootVel = new Vector2(speedX, speedY) + Main.rand.NextVector2Square(-1.5f, 1.5f);
				int proj = Projectile.NewProjectile(shootPos, shootVel, type, damage, knockBack, item.owner);
				Main.projectile[proj].noDropItem = true;
			}
			return false;
		}
	}
}