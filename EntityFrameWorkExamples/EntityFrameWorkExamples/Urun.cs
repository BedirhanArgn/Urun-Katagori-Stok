using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExamples
{
  public class Urun
    {


        public int Id { get; set; }
        public string urunadi { get; set; }
        public double fiyat{ get; set; }
        public int stokadet { get; set; }
        public int katagoriId { get; set; }

       // Bu kısıö sadece derleyiciler için kullanılır
       //public katagori katagorii { get; set; }//(bire) çok ilişki
       public List<tedarikci> tedarikciler { get; set; } //çoka çok ilişki

    }
}
