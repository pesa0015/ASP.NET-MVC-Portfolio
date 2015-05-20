namespace Portfolio.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Portfolio.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Portfolio.Models.SitesDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Portfolio.Models.SitesDBContext context)
        {
            context.Sites.AddOrUpdate(i => i.title,
                new Sites
                {
                    title = "Site 1",
                    img_src = "site-1.png",
                    a_href = "http://www.site-1.se/",
                    a_href_target = "site-1.se"
                },

                 new Sites
                 {
                     title = "Site 2",
                     img_src = "site-2.png",
                     a_href = "http://www.site-2.se/",
                     a_href_target = "site-2.se"
                 },

                 new Sites
                 {
                     title = "Site 3",
                     img_src = "site-3.png",
                     a_href = "http://www.site-3.se/",
                     a_href_target = "site-3.se"
                 },

               new Sites
               {
                   title = "Site 4",
                   img_src = "site-4.png",
                   a_href = "http://www.site-4.se/",
                   a_href_target = "site-4.se"
               }
           );
        }
    }
}
