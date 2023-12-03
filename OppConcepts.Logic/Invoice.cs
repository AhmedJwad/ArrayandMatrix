using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Logic
{
   public class Invoice:Ipay
    {
        public int Id { get; set; }

        public string Description { get; set; } 

        public float Quantity { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{Description}\n\t"+ $"Quantity------:{Quantity,20:N2}\n\t"
               + $"Price --------:{Price,20:C2}\n\t" + $"Salary --------:{GetValuatorPay(),20:C2}\n\t";
        }
        public decimal GetValuatorPay()
        {
            return Price * (decimal) Quantity;
        }
    }
}
