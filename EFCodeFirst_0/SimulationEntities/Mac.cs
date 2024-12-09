using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.SimulationEntities
{
    //Recursive Many To Many
    public class Mac : BaseEntity
    {
        public int EvSahibiTakimId { get; set; }
        public int DeplasmanTakimId { get; set; }

        //Relational Properties
        public virtual FutbolTakimi EvSahibiTakim { get; set; }
        public virtual FutbolTakimi DeplasmanTakim { get; set; }
    }
}
