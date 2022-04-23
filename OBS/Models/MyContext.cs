using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OBS.Models
{
    public class MyContext : DbContext
    {

        public MyContext()
            : base("name=Mycon")
        {
        }

        public virtual DbSet<Ogrenci> MyEntities { get; set; }
    }



}