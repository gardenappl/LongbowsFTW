
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LongbowsFTW.Items
{
	public class ItemTweaks : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			switch(item.type)
			{
				case ItemID.CobaltRepeater:
					item.useTime = item.useAnimation = 30;
					item.damage = 42;					   
					item.shootSpeed = 12;
					item.knockBack = 2;
					break;
				case ItemID.PalladiumRepeater:			   
					item.useTime = item.useAnimation = 29;
					item.damage = 44;
					item.shootSpeed = 12.25f;
					item.knockBack = 2;
					break;
				case ItemID.MythrilRepeater:
					item.useTime = item.useAnimation = 28;
					item.damage = 46;
					item.shootSpeed = 12.5f;
					item.knockBack = 2.5f;
					break;
				case ItemID.OrichalcumRepeater:
					item.useTime = item.useAnimation = 27;
					item.damage = 48;
					item.shootSpeed = 13.25f;
					item.knockBack = 2.5f;
					break;
				case ItemID.AdamantiteRepeater:
					item.useTime = item.useAnimation = 25;
					item.damage = 51;
					item.shootSpeed = 13;
					item.knockBack = 3;
					break;
				case ItemID.TitaniumRepeater:
					item.useTime = item.useAnimation = 24;
					item.damage = 52;
					item.shootSpeed = 13.5f;
					item.knockBack = 3;
					break;
				case ItemID.HallowedRepeater:
					item.useTime = item.useAnimation = 24;
					item.damage = 54;
					item.shootSpeed = 14;
					item.knockBack = 3;
					break;
				case ItemID.ChlorophyteShotbow:
					item.useTime = item.useAnimation = 24;
					item.damage = 44;
					item.shootSpeed = 14.5f;
					item.knockBack = 3.25f;
					break;
			}
		}
	}
}
