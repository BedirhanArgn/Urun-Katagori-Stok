using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*katagori k = new katagori();
            k.Id = 2;
            k.katagoriadi = "beyaz eşya";


            Uruncontext db = new Uruncontext();
            db.katagoriler.Add(k);
            db.SaveChanges();

            Console.WriteLine("tamam");
            Console.ReadLine();*/


            Uruncontext db = new Uruncontext();
            var urunler = db.Urunler.ToList();
            Console.WriteLine("veritabani olustu");

            foreach (var item in urunler)
            {
                Console.WriteLine("urun adi {0}",item.urunadi);
            }

            Console.ReadLine();
        }
    }
}
