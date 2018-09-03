using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExamples
{
   public class tedarikci
    {
        public int Id { get; set; }
        public string Firmaadi { get; set; }
        public string Adres { get; set; }
        public string telefon { get; set; }
        public List<Urun> Urunler { get; set; }
    }
}
