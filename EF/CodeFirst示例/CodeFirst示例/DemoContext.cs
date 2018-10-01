using System;
using System.Data.Entity;
using System.Linq;


namespace CodeFirst示例
{

    public class DemoContext : DbContext
    {

        public DemoContext() : base("name=DemoContext") { }

        public DbSet<Info> Info { get; set; }

        public DbSet<Grade> Grade { get; set; }

    }


}