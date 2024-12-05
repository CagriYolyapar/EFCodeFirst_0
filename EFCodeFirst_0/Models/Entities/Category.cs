using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.Models.Entities
{
    //Bire cok ilişkilerde ilişkiyi cogul olarak alan tarafa sadece Relational Property yazılır... Bire cok ilişkiyi kurmak icin ilgili class'ları birbirine tanıtmak ve Foreign Key'i saglıklı bir şekilde belirlemek gereklidir...Bunları yaptıktan sonra ilişkiniz kurulmus olacaktır...
    public class Category : BaseEntity
    {
        public string  CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual List<Product> Products { get; set; }


    }
}
