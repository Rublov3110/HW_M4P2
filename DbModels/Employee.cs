using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_M4L3
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int OfficeID { get; set; }
        public int TitleID { get; set; }
        public Title Title { get; set; }
        public Office Office { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; }

    }
}
