using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEfCore5
{

    public class Supplier
    {
        public int Id { get; set; }
        public string phone_Number { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public int delivery_efficiency { get; set; }
        public List<Medicine> medicines{ get;}
    }
}
