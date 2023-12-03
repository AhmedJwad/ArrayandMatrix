using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Logic
{
    public class CommisionEmployee:Employee
    {
        private float _commecionpercentage;
        private decimal _sales;

        public float CommisionPercentage
        {
            get => _commecionpercentage;
            set => _commecionpercentage = ValidateCommisionpercentage(value);

        }

        public decimal Sales
        {
            get => _sales;
            set => _sales = ValidateSale(value);
        }

        private decimal ValidateSale(decimal value)
        {
            if (value > 0)
            {
                return value;
            }
            throw new NotImplementedException("the value of Sale must be more than zero");
        }

        private float ValidateCommisionpercentage(float value)
        {
            if(value> 0)
            {
                return value;
            }
            throw new NotImplementedException("the value of commision percentage must be more than zero");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"commision....{CommisionPercentage,16:P2}/n/t" +
                  $"Sale....{Sales,16:C2}/n/t" +
                    $"Salary....{GetValuatorPay(),15:C2}/n/t";
        }
        public override decimal GetValuatorPay()
        {
            return Sales * (decimal)CommisionPercentage;
        }
    }
}
