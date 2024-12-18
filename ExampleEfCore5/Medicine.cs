using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEfCore5
{
    public class Medicine
    {
        //it is the prime Key in on creating
        public int registration_Number { get; set; }
        public string Manufacturer { get; set;}
        public int remaining_shelf_life { get; set;}
        public int amount { get; set;}
        public int Supplier_ID { get; set;}

        public string frequency { get; set;}
        public List<Doctor> doctors { get; set; }
        public List<Patient>  patient { get; set; }
        public Supplier supplier { get; set; }
        public Warehouse warehouse { get; set; }

    }
}
