using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //Basit bir mesaj olduğu için sürekli new'lememek adına "static" ekledik.
    //Dipnot: publicler PASCAl KEY gereği değişkenleri büyük harf ile başlar.
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductListed = "Ürünler listelendi.";
    }
}
