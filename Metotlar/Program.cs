using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.name = "apple";
            product1.price = 14;
            product1.explanation = "apple ?";

            Product product2 = new Product();
            product2.name = "orange";
            product2.price = 13;
            product2.explanation = "orange";
            

            Product[] products = new Product[] { product1, product2 }; //ürün arrayi oluşturduk.
            // product1, product2 gibi veriler aslında bir veri kaynağından gelir.Veritabanı,API,excel dosyası vb.

            //type safe - tip güvenli hangi veri tipiyle çalışacağını bilmek istiyor.
            // foreach içinde Product tipi yerine var veri tipi de yazabiliriz.(gidip products ın tipine bakar neyse getirir.)
            foreach (Product product in products)
            {
                Console.WriteLine(product.name);
                Console.WriteLine(product.explanation);

            }

            //Console.WriteLine(); cw yazıp tab tab yaparsan otomatik oluşur.
            //Instance -class çağırıyoruz,örneğini oluşturuyoruz
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add2("lemon", 15);
            

        }
    }
}
