using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //classta operasyonları metotlar şeklinde yazıyoruz.
        //naming convention - metot isimler büyük harfle başlar
        //metotların syntaxı bu şekilde

        //Encapsulation
        public void Add(Product product)//metot imzası  
        {
            Console.WriteLine("Edit to cart" +" : "+ product.name);
        }

        public void Add2(string name, int price ) //Bir classın içinde birden fazla metot olabilir.
        {
            Console.WriteLine("üstteki metot gibi kullanılıyor gerçek hayatta");
        }



    }
}
