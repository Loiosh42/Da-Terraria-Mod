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

namespace P1test.Projectiles
{
    public class WaspBullet : ModProjectile
    {
        public bool count = false;

        public override void SetDefaults()
        {
            Projectile.width = 8;//22
            Projectile.height = 6;//14
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.timeLeft = 600;
            Projectile.alpha = 1;
            Projectile.light = 0.3f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            AIType = 0;
            Projectile.penetrate = 20;
        }
        /*public override void PreDraw(SpriteBatch spriteBatch, Color lightColor) 
        { 
            
            int num1 = Dust.NewDust(projectile.position, projectile.width, projectile.height, 15, projectile.velocity.X, projectile.velocity.Y, 100f, default(Color), 1f);

            Main.dust[num1].noGravity = true;
            Main.dust[num1].velocity *= 0.1f;

        }*/

        public override void ModifyHitPlayer(Player target, ref int damage, ref bool crit)
        {
            //target.AddBuff(mod.BuffType("VoidBurn"), 60);
        }
        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            //target.AddBuff(mod.BuffType("VoidBurn"), 60);
        }


        public override void Kill(int timeLeft)
        {
            
            for (int i = 0; i < 25; i++)
            {
                int dustIndex = Dust.NewDust(new Vector2(Projectile.position.X, Projectile.position.Y), Projectile.width, Projectile.height, 31, 0f, 0f, 100, default(Color), 0.7f);
                Main.dust[dustIndex].velocity *= 0.2f;
            }
            // Fire Dust spawn
            /*
            for (int i = 0; i < 80; i++)
            {
                int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 6, 0f, 0f, 100, default(Color), 3f);
                Main.dust[dustIndex].noGravity = true;
                Main.dust[dustIndex].velocity *= 5f;
                dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 6, 0f, 0f, 100, default(Color), 2f);
                Main.dust[dustIndex].velocity *= 3f;
            }*/
            Player player = Main.player[Projectile.owner];
            float centerX = Projectile.Center.X; 
            float centerY = Projectile.Center.Y; 
            float velocityX = Projectile.velocity.X;
            float velocityY = Projectile.velocity.Y;
            /*float num = random.NextDouble(-2, 2);
            float num1 = random.NextDouble(-3, 2);
            float num2 = random.NextDouble(-4, 3);
            float num3 = random.NextDouble(-4, 4);*/

            int type = Mod.Find<ModProjectile>("SingWasp").Type; 
            int damage = 75; 
            float knockBack = 0f; 

            int owner = Main.myPlayer;
            owner = Projectile.owner;
            owner = player.whoAmI;

            Projectile.NewProjectile(Projectile.GetSource_FromThis(), centerX, centerY, velocityX, velocityY, type, damage, knockBack, owner);
            Projectile.NewProjectile(Projectile.GetSource_FromThis(), centerX, centerY, velocityX, velocityY, type, damage, knockBack, owner);
            Projectile.NewProjectile(Projectile.GetSource_FromThis(), centerX, centerY, velocityX, velocityY, type, damage, knockBack, owner);
            Projectile.NewProjectile(Projectile.GetSource_FromThis(), centerX, centerY, velocityX, velocityY, type, damage, knockBack, owner);
            Projectile.NewProjectile(Projectile.GetSource_FromThis(), centerX, centerY, velocityX, velocityY, type, damage, knockBack, owner);
        }


       /*public override void ModifyDamageHitbox(ref Rectangle hitbox)
        {
            if(count == true)
            {
                hitbox.Inflate(500, 500); /////////////
            }
                
        }*/
        
        
        public override void AI()
        {
            Projectile.rotation = (float)Math.Atan2((double)Projectile.velocity.Y, (double)Projectile.velocity.X) + 1.57f;


        }
       


    }
}