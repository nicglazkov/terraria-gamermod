using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Gamermod.Items
{

	public class Aaaaa : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("TestSword");
			Tooltip.SetDefault("Haha gun go brrrrr");
		}

		public override void SetDefaults()
		{
			item.damage = 1;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = (int)0.5;
			item.useAnimation = (int)0.5;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 10;
			item.value = 10000;
			item.rare = ItemRarityID.Expert;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;


		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= 0.9f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
			recipe.AddIngredient(ItemID.Megashark, 1);
			recipe.AddIngredient(ItemID.StarCannon, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}


	}
}
