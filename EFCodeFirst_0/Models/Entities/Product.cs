using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.Models.Entities
{
    /*
     1 Category          n Products
    1 Product            1 Category
     
     
     */




    public class Product : BaseEntity
    {

        //Birecok ilişkilerde class'ların birbirlerini tanıyarak (cogul ve tekillik durumlarına dikkat edilip) ilişkinin ifade edilmesi mümkündür...Lakin ilişkiyi tekil olarak alan tarafta ek olarak Foreign Key tanımlaması yapılması en saglıklısıdır...

        //Yapmazsanız yine ilişkiyi kurarsınız ancak Entity Framework Foreign Key'i kendisi tanıdır...Ve bu sadece SQL tarafında tanımlanmıs olur...Yani Ram'de , yani kullandıgımız programlama dilinde asla tanımlanmadıgı icin o Foreign Key'e ulasamazsınız...Dolayısıyla direkt ilişkinin nesnesi tarafından haberlesmek zorunda kalırsınız...

        //Bu nedenle en saglıklısı Foreign Key'i elle ve uygun standartlarda tanımlamak gerekir...Uygun standart da ilişki property'sinin isminin sonuna Id takısının getirilerek yeni bir isim yaratılmaısıdır (CategoryId)

        //Bu yöntem yapıldıgı takdirde Foreign Key'iniz otomatik olarak algılanır...

        //Bir nedenden dolayı eger kendi verdigimiz ismin Foreign Key olmasını istiyorsanız bu da mümkündür ancak tavsiye edilmez...


        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryId { get; set; }


        //Relational Properties
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }




    }
}
