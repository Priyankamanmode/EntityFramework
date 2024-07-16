namespace EntityFrameworkMain.Migrations
{
    using EntityFrameworkMain.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkMain.Models.RecordContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EntityFrameworkMain.Models.RecordContext context)
        {
            var student = new List<Student>
           {new Student {Id = 1,    Name="Priyanka" },
           new Student {Id = 2, Name="SONA" },

           };
            student.ForEach(s=> context.Students.Add(s));
            context.SaveChanges();
        }
    }
}
