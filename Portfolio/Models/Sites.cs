using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Sites
    {
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string img_src { get; set; }
        [Required]
        public string a_href { get; set; }                  // a_href = fullständig url, t.ex. http://www.example.com/
        [Required]
        public string a_href_target { get; set; }           // a_href_target = användarvänlig url, t.ex. example.com
    }

    public class SitesDBContext : DbContext
    {
        public DbSet<Sites> Sites { get; set; }
    }
}