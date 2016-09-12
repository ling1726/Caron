namespace Caron.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addContactSubject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactSubjects",
                c => new
                    {
                        ContactSubjectId = c.Int(nullable: false, identity: true),
                        Label = c.String(maxLength: 70),
                    })
                .PrimaryKey(t => t.ContactSubjectId);
            
            AddColumn("dbo.Contacts", "ContactSubjectId", c => c.Int(nullable: false));
            CreateIndex("dbo.Contacts", "ContactSubjectId");
            AddForeignKey("dbo.Contacts", "ContactSubjectId", "dbo.ContactSubjects", "ContactSubjectId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "ContactSubjectId", "dbo.ContactSubjects");
            DropIndex("dbo.Contacts", new[] { "ContactSubjectId" });
            DropColumn("dbo.Contacts", "ContactSubjectId");
            DropTable("dbo.ContactSubjects");
        }
    }
}
