using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEfCore5
{
    public class Warehouse
    {
        public int tax_Register { get; set; }
        public string Location  { get; set; }
        public string stored_items { get; set; }
        public string manager_name { get; set; }
        public DateTime inspection_scheduel { get; set; }
        public List<Employee> employees { get; set; }
        public int registration_Number { get; set; }
        public Medicine medicine { get; set; }

    }
}
