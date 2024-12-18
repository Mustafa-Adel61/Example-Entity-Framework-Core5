using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEfCore5
{
    public class Bill
    {
        public int Numebr_Of_Bill { get; set; }
        public DateTime date { get; set; }
        public float discount { get; set; }
        public string Payment_method { get; set; }
        public int PatientId { get; set; }
        public Patient patient { get; set; }

    }
}
