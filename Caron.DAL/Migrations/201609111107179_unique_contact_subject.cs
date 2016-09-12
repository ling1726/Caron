namespace Caron.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unique_contact_subject : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ContactSubjects", "Label", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.ContactSubjects", new[] { "Label" });
        }
    }
}
