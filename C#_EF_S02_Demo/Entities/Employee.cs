using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Demo.Entities
{
    public  class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} :: Name : {Name} :: Age : {Age} :: Salary : {Salary} : Address : {Address}";
        }
    }
}
