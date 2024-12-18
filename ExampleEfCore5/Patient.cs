using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEfCore5
{
    public class Patient
    {
        public int Id { get; set; }
        public string  First_Name { get; set; }
        public string  Middle_Name { get; set; }
        public string  Last_Name { get; set; }
        public string perscrtion { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Doctor_ID { get; set; }
        
        public List<Patient_Phone> patient_Phone { get; set; }
        public Doctor doctor { get; set; }
        public int registration { get; set; }
        public Medicine medicine { get; set; }
        public Bill bill { get; set; }


    }
}
