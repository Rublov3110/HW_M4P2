using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_M4L3
{
    public class EmployeeProject
    {
        public int ID { get; set; }
        public decimal Rate { get; set; }
        public DateTime StartedDate { get; set; }
        public int EmployeeID { get; set; }
        public int ProjectID { get; set; }
        public Employee Employee { get; set; }
        public Project Project { get; set; }



    }
}
