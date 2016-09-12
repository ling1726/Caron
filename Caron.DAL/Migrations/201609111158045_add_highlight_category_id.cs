namespace Caron.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_highlight_category_id : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HighLightCategories",
                c => new
                    {
                        HighLightCategoryId = c.Int(nullable: false, identity: true),
                        Label = c.String(maxLength: 70),
                    })
                .PrimaryKey(t => t.HighLightCategoryId);
            
            CreateTable(
                "dbo.Highlights",
                c => new
                    {
                        HighLightId = c.Int(nullable: false, identity: true),
                        Label = c.String(maxLength: 70),
                        HighLightCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HighLightId)
                .ForeignKey("dbo.HighLightCategories", t => t.HighLightCategoryId, cascadeDelete: true)
                .Index(t => t.HighLightCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Highlights", "HighLightCategoryId", "dbo.HighLightCategories");
            DropIndex("dbo.Highlights", new[] { "HighLightCategoryId" });
            DropTable("dbo.Highlights");
            DropTable("dbo.HighLightCategories");
        }
    }
}
