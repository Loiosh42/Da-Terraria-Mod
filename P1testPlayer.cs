using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace P1test
{
	public class P1testPlayer : ModPlayer
	{
		//public bool QuantProj = false;
		public bool Cursed = false;
		public bool Slagged = false;
		public bool QuProHit = false;
		public bool CelGauntBuf = false;
		public bool SolBurn = false;
		public bool VoiBurn = false;
		public bool MiniPort = false;
		public bool MiniPort2 = false;
		public float PlaySpeedX = 0;
		public float PlaySpeedY = 0;
		public bool Scarf = false;
		public bool Scarfe = false;
		public bool GLOOed = false;
		public bool SevLBoots = false;
		public float PlayerX2 = 0f;
		public float PlayerY2 = 0f;
		public float PlayerVX2 = 0f;
		public float PlayerVY2 = 0f;
		public float PlayerPos = 0f;
		public bool Wasped = false;

		public double ShHP = 300;
		public int ShCooldown = 3001;
		public bool SHLDon = false;

		public override void ResetEffects()
		{
			//QuantProj = false;
			Slagged = false;
			QuProHit = false;
			CelGauntBuf = false;
			SolBurn = false;
			VoiBurn = false;
			MiniPort = false;
			MiniPort2 = false;
			Cursed = false;
			PlaySpeedX = 0;
			PlaySpeedY = 0;
			Scarfe = false;
			Scarf = false;
			GLOOed = false;
			SevLBoots = false;
			PlayerX2 = 0f;
			PlayerY2 = 0f;
			PlayerVX2 = 0f;
			PlayerVY2 = 0f;
			PlayerPos = 0f;
			Wasped = false;
			SHLDon = false;

		}

	

		public override void PostHurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit, int cooldownCounter)
		{
			if (MiniPort == true)
			{
		
				Player.AddBuff(Mod.Find<ModBuff>("MiniPortBuff").Type, 300);
				
				
			}
			if (MiniPort2 == true)
			{
				Player.AddBuff(61, 300);
				Player.AddBuff(Mod.Find<ModBuff>("MiniPortBuff1").Type, 1);
				Player.AddBuff(73, 300);

			}
		}

		public override void PreUpdateMovement()
		{
			if (GLOOed == true)
			{
				Vector2 newVelocity = Player.velocity;
				newVelocity = newVelocity * 0.1f;
				Player.velocity = newVelocity;
			}
			if (SHLDon = true)
            {
				if (ShCooldown < 3002)
				{
					ShCooldown = ShCooldown + 1;

				}
				else
				{
					if (ShHP < 300)
					{
						ShHP = ShHP + 1;
					}
				}
			}
			
		}

		public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource, ref int cooldownCounter)
		{
			if (SHLDon = true)
            {
				int TshDam = damage;
				if (ShCooldown > 3000)
				{
					if (ShHP > 5)
                    {
						damage = TshDam / 2;
						ShHP = ShHP - (TshDam / 2);
					}

				}

			}
			return true;
		}

		public override void OnHitNPC(Item item, NPC target, int damage, float knockBack, bool crit)
		{


		if (CelGauntBuf == true)
			{//player.AddBuff(14, 3000000);
			 //player.AddBuff(71, 3000000);
			 //player.AddBuff(73, 3000000);
			 //player.AddBuff(74, 3000000);
			 //player.AddBuff(75, 3000000);
			 //player.AddBuff(76, 3000000);
			 //player.AddBuff(77, 3000000);
			 //player.AddBuff(79, 3000000);
			 //player.AddBuff(322, 3000000);
				if (Main.dayTime)
				{
					target.AddBuff(Mod.Find<ModBuff>("SolarConflagration").Type, 400);
					//target.AddBuff(BuffID.OnFire, 300, true);

					//target.AddBuff(BuffID.ShadowFlame, 300, false);
					//target.AddBuff(BuffID.Bleeding, 300, false);
					//target.AddBuff(BuffID.CursedInferno, 300, false);
					//target.AddBuff(BuffID.ShadowFlame, 300, false);
					target.AddBuff(BuffID.Ichor, 600);
					//target.AddBuff(BuffID.Poisoned, 300, false);
					//target.AddBuff(BuffID.Burning, 300, false);
					//target.AddBuff(20, 300);
					//target.AddBuff(24, 300);
					//target.AddBuff(30, 300);
					//target.AddBuff(39, 300);
					//target.AddBuff(69, 300);
					//target.AddBuff(70, 300);
					//target.AddBuff(153, 300);
					//target.AddBuff(323, 300);
				}
				else
				{
					target.AddBuff(Mod.Find<ModBuff>("VoidBurn").Type, 400);
					target.AddBuff(BuffID.Suffocation, 300, false);
					//target.AddBuff(BuffID.Bleeding, 300, false);
					//target.AddBuff(BuffID.Poisoned, 300, false);
					target.AddBuff(31, 600);
					target.AddBuff(32, 600);
					target.AddBuff(160, 600);
					target.AddBuff(BuffID.Frostburn, 300, false);
					//target.AddBuff(20, 300);
					//target.AddBuff(30, 300);
					//target.AddBuff(44, 300);
					//target.AddBuff(47, 300);
					//target.AddBuff(68, 300);
					//target.AddBuff(70, 300);
					//target.AddBuff(144, 300);
					//target.AddBuff(324, 300);
				}
			}
			
		}






		public override bool Shoot(Item item, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{

			if (QuProHit == true)
            {
				//if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
				//{
					//type = mod.ProjectileType("CGPro");
					type = 207;
					//type = mod.ProjectileType("Qutp"); // or ProjectileID.FireArrow;
					return true;//false
				//}
				//else { return true; }
			}
            else { return true; }
		}
		public override void UpdateBadLifeRegen()
        {
			if(SolBurn == true)
            {
				if (Player.lifeRegen > 0)
				{
					Player.lifeRegen = 0;
				}
				Player.lifeRegenTime = 0;
				// lifeRegen is measured in 1/2 life per second. Therefore, this effect causes 40 life lost per second.
				Player.lifeRegen -= 80;
			}

			if(VoiBurn == true)
            {
				if (Player.lifeRegen > 0)
				{
					Player.lifeRegen = 0;
				}
				Player.lifeRegenTime = 0;
				// lifeRegen is measured in 1/2 life per second. Therefore, this effect causes 30 life lost per second.
				Player.lifeRegen -= 60;
			}

			if (Wasped == true)
			{
				if (Player.lifeRegen > 0)
				{
					Player.lifeRegen = 0;
				}
				Player.lifeRegenTime = 0;
				// lifeRegen is measured in 1/2 life per second. Therefore, this effect causes 150 life lost per second.
				Player.lifeRegen -= 300;
			}

			if (Slagged == true)
			{
				if (Player.lifeRegen > 0)
				{
					Player.lifeRegen = 0;
				}
				Player.lifeRegenTime = 0;
				// lifeRegen is measured in 1/2 life per second. Therefore, this effect causes 15 life lost per second.
				Player.lifeRegen -= 30;
			}
			if (Cursed == true)
			{
				if (Player.lifeRegen > 0)
				{
					Player.lifeRegen = 0;
				}
				Player.lifeRegenTime = 0;
				// lifeRegen is measured in 1/2 life per second. Therefore, this effect causes 5 life lost per second.
				Player.lifeRegen -= 10;
			}

		}
		//public override void OnShoot()
		public override void PostUpdate()
        {
			Scarfe = false;
			PlaySpeedX = Player.velocity.X;
			PlaySpeedY = Player.velocity.Y;
		}
	}
}