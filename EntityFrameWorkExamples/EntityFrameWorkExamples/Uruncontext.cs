using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExamples
{
   public class Uruncontext:DbContext
    {
        public Uruncontext():base("urunConnection")
        {

            Database.SetInitializer(new DataInitialize());
            
            }
        public DbSet<katagori> katagoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<tedarikci> Tedarikciler { get; set; }
    }
}
