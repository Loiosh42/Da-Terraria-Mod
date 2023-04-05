

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;

using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;


namespace P1test.Items.Weapons
{
	public class WaspCan : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wasp Cells");
			Tooltip.SetDefault("Miniature Cryo Chambers!");
		}

		public override void SetDefaults() {
			Item.damage = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 14;
			Item.height = 24;
			Item.maxStack = 999;
			Item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			Item.knockBack = 4f;
			Item.value = 10;
			Item.rare = ItemRarityID.Green;
			Item.shoot = ModContent.ProjectileType<Projectiles.WaspBullet>();   //The projectile shoot when your weapon using this ammo
			Item.shootSpeed = 2f;                  //The speed of the projectile
			Item.ammo = Item.type;             //The ammo class this ammo belongs to.
		}

		

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe(50);
			recipe.AddIngredient(ItemID.MusketBall, 50);
			recipe.AddIngredient(ItemID.GraniteBlock, 1);
			recipe.Register();
		}
	}
}
