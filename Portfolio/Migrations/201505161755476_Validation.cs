namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sites", "title", c => c.String(nullable: false));
            AlterColumn("dbo.Sites", "img_src", c => c.String(nullable: false));
            AlterColumn("dbo.Sites", "a_href", c => c.String(nullable: false));
            AlterColumn("dbo.Sites", "a_href_target", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sites", "a_href_target", c => c.String());
            AlterColumn("dbo.Sites", "a_href", c => c.String());
            AlterColumn("dbo.Sites", "img_src", c => c.String());
            AlterColumn("dbo.Sites", "title", c => c.String());
        }
    }
}
