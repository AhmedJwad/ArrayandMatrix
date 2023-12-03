using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Logic
{
    public  class SalaryEmployee:Employee
    {
        private decimal _salary;
        public decimal salary { 
            get=>_salary;
            set=>_salary=ValidateSalary(value); 
        }

        public override decimal GetValuatorPay()
        {
            return salary * 0.88M;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" 
                 +$"Salary ........{salary:C2}" +
            $"value to pay ........{GetValuatorPay():C2}";
           
        }
        private decimal ValidateSalary(decimal value)
        {
           if(value>100000)
            {
                return value;
            }
            throw new ArgumentException("the salary is lower than minimuim salary");
        }
    }
}
