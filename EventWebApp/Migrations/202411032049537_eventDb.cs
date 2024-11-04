namespace EventWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Eventoes", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Eventoes", new[] { "CategoriaId" });
            CreateTable(
                "dbo.EventoCategorias",
                c => new
                    {
                        Evento_EventoId = c.Int(nullable: false),
                        Categoria_CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Evento_EventoId, t.Categoria_CategoriaId })
                .ForeignKey("dbo.Eventoes", t => t.Evento_EventoId, cascadeDelete: true)
                .ForeignKey("dbo.Categorias", t => t.Categoria_CategoriaId, cascadeDelete: true)
                .Index(t => t.Evento_EventoId)
                .Index(t => t.Categoria_CategoriaId);
            
            DropColumn("dbo.Eventoes", "CategoriaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Eventoes", "CategoriaId", c => c.Int(nullable: false));
            DropForeignKey("dbo.EventoCategorias", "Categoria_CategoriaId", "dbo.Categorias");
            DropForeignKey("dbo.EventoCategorias", "Evento_EventoId", "dbo.Eventoes");
            DropIndex("dbo.EventoCategorias", new[] { "Categoria_CategoriaId" });
            DropIndex("dbo.EventoCategorias", new[] { "Evento_EventoId" });
            DropTable("dbo.EventoCategorias");
            CreateIndex("dbo.Eventoes", "CategoriaId");
            AddForeignKey("dbo.Eventoes", "CategoriaId", "dbo.Categorias", "CategoriaId", cascadeDelete: true);
        }
    }
}
