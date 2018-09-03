using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExamples
{
    public class katagori
    {
        public int Id { get; set; }
        public string katagoriadi { get; set; }


        public List<Urun> Urunler { get; set; }//bire çok ilişki

        
    }
}
