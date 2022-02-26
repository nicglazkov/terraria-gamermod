using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Gamermod.Items
{

    public class BetterMinigun : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("TestSword");
			Tooltip.SetDefault("A better minigun");
		}

		public override void SetDefaults()
		{
			item.damage = 20000;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;


		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= 0.4f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SDMG, 1);
			recipe.AddIngredient(ItemID.ChainGun, 1);
			recipe.AddIngredient(ItemID.Minishark, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}


	}
}
