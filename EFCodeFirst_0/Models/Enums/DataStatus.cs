using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.Models.Enums
{
    public enum DataStatus
    {
        Inserted = 1,//Veri girişi yapılmıs ve veri üzerinde oynanmamıstır (Aktif)
        Updated = 2,  //Veri hala aktiftir ancak veri güncellenmiştir
        Deleted = 3 //Veri Pasiftir
    }
}
