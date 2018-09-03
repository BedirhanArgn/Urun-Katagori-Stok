using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExamples
{
    public class DataInitialize : DropCreateDatabaseIfModelChanges<Uruncontext>
    {
                protected override void Seed(Uruncontext context)
        {
            List<katagori> katagoriler = new List<katagori>()
            {
                new katagori() {katagoriadi="araba",Id=1 },
                                new katagori() {katagoriadi="Bilgisayar",Id=2 },
                new katagori() {katagoriadi="BeyazEşya",Id=3 },
       

            };
        
            foreach (var i in katagoriler)
            {
                context.katagoriler.Add(i);

            }
            context.SaveChanges();




            List<Urun> urunler = new List<Urun>()
            {
                new Urun() {fiyat=200,Id=1,urunadi="Bmw",stokadet=2,katagoriId=2},
                new Urun() {fiyat=100,Id=2,urunadi="Mercedes",stokadet=2,katagoriId=2},
                new Urun() {fiyat=80,Id=3,urunadi="Audi",stokadet=2,katagoriId=2},
                new Urun() {fiyat=60,Id=4,urunadi="Fiat",stokadet=2,katagoriId=2},
                new Urun() {fiyat=90,Id=5,urunadi="Toyota",stokadet=2,katagoriId=2},
            };


            foreach (var item in urunler)
            {
                context.Urunler.Add(item);
                   
            }
            context.SaveChanges();
            List<tedarikci> tedarikcier = new List<tedarikci>()
            {
                new tedarikci() {Adres="izmir",Firmaadi="borusan", Id=1, telefon="0541403920"}
            };


            foreach (var a in tedarikcier)
            {
                context.Tedarikciler.Add(a);
            }
            context.SaveChanges();
            
             
       base.Seed(context);
        }
    }
        
    
    
}
