using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Demo.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmpId { get; set; }       //forignKey
        public Employee Manager { get; set; }//Navigation property

        public List<Employee> Employees { get; set; }//Navigation property
    }
}
