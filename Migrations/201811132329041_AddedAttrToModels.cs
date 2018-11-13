namespace PokemonCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAttrToModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pokemons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hp = c.Int(nullable: false),
                        Cp = c.Int(nullable: false),
                        name = c.String(nullable: false),
                        picture = c.String(nullable: false),
                        color = c.String(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PokemonTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        Pokemon_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pokemons", t => t.Pokemon_Id)
                .Index(t => t.Pokemon_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PokemonTypes", "Pokemon_Id", "dbo.Pokemons");
            DropIndex("dbo.PokemonTypes", new[] { "Pokemon_Id" });
            DropTable("dbo.PokemonTypes");
            DropTable("dbo.Pokemons");
        }
    }
}
