using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEfCore5
{
    public class Doctor
    {

        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string specialization { get; set; }
        public int Age { get; set; }
        public int years_to_retirement { get; set; }
        public List<Doctor_Location> doctor_Locations { get; set; }
        public List<Patient> patients { get; set; }
        public List<Medicine> medicines { get; set; }





    }
}
