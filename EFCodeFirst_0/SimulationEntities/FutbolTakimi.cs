using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.SimulationEntities
{
    public class FutbolTakimi:BaseEntity
    {
        public string Isim { get; set; }

        //Relational Properties
        public virtual List<Mac> Maclar { get; set; }

    }
}
