
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace P1test
{
    public class KaBoom : ModProjectile
    {
        public bool count = false;

        public override void SetDefaults()
        {
            Projectile.width = 50;
            Projectile.height = 50;
            Projectile.aiStyle = 6;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.timeLeft = 3;
            Projectile.penetrate = 100;
            Projectile.alpha = 1;
            Projectile.light = 1f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            AIType = 6;
        }

       


        public override void Kill(int timeLeft)
        {
            
            Projectile.damage = 120; 
            
    
            for (int i = 0; i < 40; i++)
            {
                int dustIndex = Dust.NewDust(new Vector2(Projectile.position.X, Projectile.position.Y), Projectile.width, Projectile.height, 31, 0f, 0f, 100, default(Color), 2f);
                Main.dust[dustIndex].velocity *= 2f;
            }
            // Fire Dust spawn
            for (int i = 0; i < 60; i++)
            {
                int dustIndex = Dust.NewDust(new Vector2(Projectile.position.X, Projectile.position.Y), Projectile.width, Projectile.height, 160, 0f, 0f, 200, default(Color), 1.75f);//59,1.5f
                Main.dust[dustIndex].noGravity = false;
                Main.dust[dustIndex].velocity *= 1f;
                dustIndex = Dust.NewDust(new Vector2(Projectile.position.X, Projectile.position.Y), Projectile.width, Projectile.height, 31, 0f, 0f, 100, default(Color), 1f);
                Main.dust[dustIndex].velocity *= 1.6f;
            }
        }






        



    }
}