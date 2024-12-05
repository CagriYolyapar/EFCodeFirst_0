using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.Models.Entities
{
    //Junction Table'imizi temsil eden sınıfımız
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        //Relational Properties
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
