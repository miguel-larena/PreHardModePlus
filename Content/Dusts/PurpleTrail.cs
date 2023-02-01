﻿using Terraria;
using Terraria.ModLoader;

namespace PreHardmodePlus.Content.Dusts
{
	public class PurpleTrail : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.velocity *= 1f; // Multiply the dust's start velocity by 0.4, slowing it down.
			dust.noGravity = true; // Makes the dust have no gravity.
			dust.noLight = true; //  Makes the dust emit no light.
			dust.scale *= 1f; // Multiplies the dust's initial scale by 1.
		}

		public override bool Update(Dust dust) // Calls every frame the dust is active
		{
            dust.position += dust.velocity / 2;
            dust.scale *= 0.99f;

			float light = 0.35f * dust.scale;


			Lighting.AddLight(dust.position, light, light, light);

			if (dust.scale < 0.5f)
			{
				dust.active = false;
			}
			return false; // Return false to prevent vanilla behavior
		}
	}
}

