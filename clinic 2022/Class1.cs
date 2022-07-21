using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace clinic_2022
{
    internal class Class1
    {
        int ID { get; set; }
        DateTime Date { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        string Sex { get; set; }
        string Diagnosis { get; set; }
        string Treatment { get; set; }
        decimal Charges { get; set; }
    }
    
}
