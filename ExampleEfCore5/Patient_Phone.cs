using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEfCore5
{
    public class Patient_Phone
    {
        //coposite primary key
        public int Patient_Id { get; set; }
        public string Phone_Number { get; set; }
        public Patient patient { get; set; }
    }
}
