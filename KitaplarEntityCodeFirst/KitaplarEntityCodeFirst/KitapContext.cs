using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaplarEntityCodeFirst
{
    public class KitapContext : DbContext
    {
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Kitap> Kitaps { get; set; }
        public DbSet<KitapTur> KitapTurs { get; set; }
        public KitapContext() : base("KitapCon") { }


    }
}
