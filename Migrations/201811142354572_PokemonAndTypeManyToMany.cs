namespace PokemonCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PokemonAndTypeManyToMany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PokemonTypes", "Pokemon_Id", "dbo.Pokemons");
            DropIndex("dbo.PokemonTypes", new[] { "Pokemon_Id" });
            CreateTable(
                "dbo.PokemonTypePokemons",
                c => new
                    {
                        PokemonType_Id = c.Int(nullable: false),
                        Pokemon_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PokemonType_Id, t.Pokemon_Id })
                .ForeignKey("dbo.PokemonTypes", t => t.PokemonType_Id, cascadeDelete: true)
                .ForeignKey("dbo.Pokemons", t => t.Pokemon_Id, cascadeDelete: true)
                .Index(t => t.PokemonType_Id)
                .Index(t => t.Pokemon_Id);
            
            DropColumn("dbo.PokemonTypes", "Pokemon_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PokemonTypes", "Pokemon_Id", c => c.Int());
            DropForeignKey("dbo.PokemonTypePokemons", "Pokemon_Id", "dbo.Pokemons");
            DropForeignKey("dbo.PokemonTypePokemons", "PokemonType_Id", "dbo.PokemonTypes");
            DropIndex("dbo.PokemonTypePokemons", new[] { "Pokemon_Id" });
            DropIndex("dbo.PokemonTypePokemons", new[] { "PokemonType_Id" });
            DropTable("dbo.PokemonTypePokemons");
            CreateIndex("dbo.PokemonTypes", "Pokemon_Id");
            AddForeignKey("dbo.PokemonTypes", "Pokemon_Id", "dbo.Pokemons", "Id");
        }
    }
}
