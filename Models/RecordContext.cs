using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkMain.Models
{
    public class RecordContext : DbContext
    {
         public RecordContext() : base("RecordContext")
        {

        }
        public DbSet<Student> Students { get; set; }    
    }
}