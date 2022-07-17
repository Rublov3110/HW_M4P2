using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_M4L3
{
   public class Client
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string CountryFrom { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
