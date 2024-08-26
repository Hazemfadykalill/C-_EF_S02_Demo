using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S02_Demo.Entities
{
    public class Cousre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Student> students { get; set; }
    }
}
