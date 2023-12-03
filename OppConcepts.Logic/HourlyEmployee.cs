using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Logic
{
    public class HourlyEmployee:Employee
    {
        private float _workingHour;
        private decimal _hourValue;

        public float WorkingHour
        {
            get=>_workingHour; set => _workingHour =Validateworkinghour( value);
        }

        private float Validateworkinghour(float value)
        {
            if (value > 0)
            {
                return value;
            }
            throw new ArgumentException("the value error ");
        }

        public decimal HourValue 
        {
            get=> _hourValue;
            set=> _hourValue=ValidateHourValue(value); 
        }

        public override decimal GetValuatorPay()
        {
            return HourValue * (decimal)_workingHour;
        }

        public override string ToString()
        {
            return $"{base.ToString()}/n/t" +
                $"Working hours------{WorkingHour,15:N2}\n\t" +
                 $" hours value------{HourValue,15:C2}\n\t" +
                  $"Salary------{GetValuatorPay(),15:C2}\n\t";
        }


        private decimal ValidateHourValue(decimal value)
        {
            if(value > 0)
            {
                return value;
            }
            throw new ArgumentException("the value error ");
        }
    }
}
