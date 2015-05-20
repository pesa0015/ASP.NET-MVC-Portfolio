namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sites",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        img_src = c.String(),
                        a_href = c.String(),
                        a_href_target = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sites");
        }
    }
}
