using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace P1test.Buffs
{
	// Ethereal Flames is an example of a buff that causes constant loss of life.
	// See ExamplePlayer.UpdateBadLifeRegen and ExampleGlobalNPC.UpdateLifeRegen for more information.
	public class MiniPortBuff : ModBuff
	{
		public bool petProjectileNotSpawned = false;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Finally Usefull");
			Description.SetDefault("Only works on melee weapons");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = false;

			//debuff = true;
		}


		public override void Update(Player player, ref int buffIndex)
		{
			player.itemTime = 2;
            player.itemAnimation = 2;


		}
    }
}


