using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;

namespace P1test.Items.Over
{
	
	public class AmuletOfQuantumMolasses : ModItem
	{
		public override void SetStaticDefaults() {
			Item.width = 30;
			Item.height = 40;
			DisplayName.SetDefault("A.O.Q.M");
			Tooltip.SetDefault("Speed For Power.");
		}

		public override void SetDefaults() {

			Item.accessory = true; // Makes this item an accessory.
			Item.rare = ItemRarityID.Blue; 
			Item.value = Item.sellPrice(gold: 100); // Sets the item sell price to 100 gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
		
			Vector2 newVelocity = player.velocity;
			newVelocity = newVelocity * 0.7f;
			player.velocity = newVelocity;
			player.extraFall = 100;
			player.GetAttackSpeed(DamageClass.Melee) += 0.70f;
			player.GetDamage(DamageClass.Melee) += 0.70f;
			player.GetCritChance(DamageClass.Generic) += 70;
			player.manaRegen += 7;
			player.GetDamage(DamageClass.Magic) += 0.70f;
			player.GetDamage(DamageClass.Ranged) += 0.70f;
			player.GetCritChance(DamageClass.Ranged) += 70;
			player.maxFallSpeed += 20.0f;
			hideVisual = true;
		}
		public override void AddRecipes()
		{
			// because we don't call base.AddRecipes(), we erase the previously defined recipe and can now make a different one
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	
	}
}
