using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_0.SimulationEntities
{
    //Recursive One To Many
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ReportedEmployeeId { get; set; }
        //Relational Properties
        public virtual List<Employee> Employees { get; set; }
        public virtual Employee ReportedEmployee { get; set; }


    }
}
