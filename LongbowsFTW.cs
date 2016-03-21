
using System;
using Terraria;
using Terraria.ModLoader;

namespace LongbowsFTW
{
	public class LongbowsFTW : Mod
	{
		public override void SetModInfo(out string name, ref ModProperties properties)
		{
			name = "LongbowsFTW";
			properties.Autoload = true;
			properties.AutoloadGores = true;
			properties.AutoloadSounds = true;
		}
	}
}
