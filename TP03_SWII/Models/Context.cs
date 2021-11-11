using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TP03_SWII.Models
{
    public class Context : DbContext
    {
        public DbSet<BL> Bls { get; set; }
        public DbSet<Container> Containers { get; set; }
    }
}