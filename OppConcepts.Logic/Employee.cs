using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Logic
{
    public abstract class Employee:Ipay
    {
        public int Id { get; set; } 
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public Date? Borndate { get; set; }

        public Date? Hiredate { get; set; }
        public bool IsActive { get; set; }
        
        public override string ToString()
        {
            return $"{Id}/t{Firstname}{Lastname}\n\t"+
                $"hired ........{Borndate}";
        }

        public abstract decimal GetValuatorPay();

    }
}
