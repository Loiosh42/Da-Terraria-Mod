using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
//using TAPI;
//using Player;

namespace P1test.Items.Acsessories
{

	public class CelestialGauntlet : ModItem
	{
		public override void SetStaticDefaults() {
			Item.width = 26;
			Item.height = 32;
			DisplayName.SetDefault("Skyblade Gauntlet");
			Tooltip.SetDefault("With every swing, a monster falls. \n Inflicts Solar Conflagration during the day, Void Burn at night \n30% Melee speed, damage, and crit");
	
		}
		public override void SetDefaults() {

			Item.accessory = true; // Makes this item an accessory.
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 100); // Sets the item sell price to 100 gold coin.
		}

		public override void UpdateAccessory(Player p, bool hideVisual)
		{

			p.GetAttackSpeed(DamageClass.Melee) += 0.30f;
			p.GetDamage(DamageClass.Melee) += 0.30f;
			p.GetCritChance(DamageClass.Generic) += 30;
			//player.knockBackMod += 0.5f;
			//player.meleeCritMult += 0.42f;
			hideVisual = true;
			p.GetModPlayer<P1testPlayer>().CelGauntBuf = true;
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
