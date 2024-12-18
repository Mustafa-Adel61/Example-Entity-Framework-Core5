using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEfCore5
{
    public class Doctor_Location
    {
        //coposite primary key

        public int DoctorId { get; set; }
        public string Location { get; set; }
        public Doctor doctor { get; set; }
    }
}
