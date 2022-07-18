using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_M4L3
{
    public class Project
    {
        public int ID { get; set; }  
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartedDate { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }

    }
}
