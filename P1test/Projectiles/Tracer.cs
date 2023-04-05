
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace P1test.Projectiles
{
	public class Tracer : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Tracer Bullets");
			Tooltip.SetDefault("1 in 4");
		}

		public override void SetDefaults() {
			Item.damage = 10;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 10;
			Item.height = 18;
			Item.maxStack = 999;
			Item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			Item.knockBack = 4f;
			Item.value = 10;
			Item.rare = ItemRarityID.Green;
			Item.shoot = ModContent.ProjectileType<Projectiles.TracerP>();   //The projectile shoot when your weapon using this ammo
			Item.shootSpeed = 2f;                  //The speed of the projectile
			Item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe(50);
			recipe.AddIngredient(ItemID.MusketBall, 50);
			recipe.AddIngredient(1351, 10);
			recipe.Register();
		}
	}
}
