using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Product
    {
        //Classların iki farklı kullanımı vardır.
        //1.property(özellik)leri tutmak[id,name,price vb.]
        //2.operasyonları tutar(sepete ürün ekleme gibi)
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string explanation { get; set; }
    }
}
