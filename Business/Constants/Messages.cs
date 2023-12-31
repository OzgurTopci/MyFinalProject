using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenceTime="Sistem bakımda";
        public static string ProductListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabirilir";
        public static string ProductNameAlreadyExists="Bu isim zaten mevcut";
        internal static string CategoryLimitExceded="Kategori limi aşıldığı için yeni ürün eklenemiyor";
    }
}
