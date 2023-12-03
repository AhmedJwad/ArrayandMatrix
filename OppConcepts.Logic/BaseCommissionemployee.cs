using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Logic
{
    public class BaseCommissionemployee:CommisionEmployee
    {
        private decimal _salary;


        public decimal Salary
        {
            get => _salary;
            set => _salary = ValidateSalary(value);
        }

        public override decimal GetValuatorPay()
        {
            return base.GetValuatorPay() + Salary;
        }
        public override string ToString()
        {
            return $"{Id}\t{Firstname}\n\t" +
                $"HireDate-----------{Hiredate}" +
                $"%Commision----------{CommisionPercentage,16:P2}\n\t" +
                $"Sales------------{Sales,15:C2}\n\t" +
                $"Base--------------{Salary,15:P2}\n\t" +
                $"Salary-------------{GetValuatorPay(),15:C2}\n\t";
        }
        private decimal ValidateSalary(decimal value)
        {
           if(value> 40000) { return value; }
            throw new ArgumentException("the salary must be more than zero");
        }
    }
}
