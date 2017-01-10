
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace LongbowsFTW.Items
{
	public class ChlorophyteTribow : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Chlorophyte Tribow";
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			for(int i = 0; i < Main.rand.Next(2, 5); i++)
			{
				int proj = Projectile.NewProjectile(position.X + (Main.rand.NextFloat() - 0.5f) * 0.5f, position.Y + (Main.rand.NextFloat() - 0.5f) * 0.5f,
				                         speedX + (Main.rand.NextFloat() - 0.5f) * 3, speedY + (Main.rand.NextFloat() - 0.5f) * 3, type, damage, knockBack, item.owner);
				Main.projectile[proj].noDropItem = true;
			}
			return false;
		}
	}
}